public interface IComponent
{
    void Display(int depth);
}

public class Leaf : IComponent
{
    private string _name;

    public Leaf(string name)
    {
        _name = name;
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
    }
}

public class Composite : IComponent
{
    private string _name;
    private List<IComponent> _children = new List<IComponent>();

    public Composite(string name)
    {
        _name = name;
    }

    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IComponent component)
    {
        _children.Remove(component);
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);

        // Recursively display child nodes
        foreach (var component in _children)
        {
            component.Display(depth + 2);
        }
    }
}

