public interface IAggregate
{
    IIterator CreateIterator();
}

public interface IIterator
{
    bool HasNext();
    object Next();
}

public class BurgerMenu : IAggregate
{
    private List<string> _items = new List<string>();

    public void AddItem(string item)
    {
        _items.Add(item);
    }

    public IIterator CreateIterator()
    {
        return new BurgerMenuIterator(_items);
    }
}

public class BurgerMenuIterator : IIterator
{
    private List<string> _items;
    private int _position = 0;

    public BurgerMenuIterator(List<string> items)
    {
        _items = items;
    }

    public bool HasNext()
    {
        return _position < _items.Count;
    }

    public object Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("No more items.");
        }

        return _items[_position++];
    }
}
