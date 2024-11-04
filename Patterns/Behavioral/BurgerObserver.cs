public class BurgerObserver
{
    private List<IBurgerObserver> _observers = new List<IBurgerObserver>();
    private BurgerStatus _status;

    public BurgerStatus Status
    {
        get { return _status; }
        set
        {
            _status = value;
            NotifyObservers();
        }
    }

    public void Attach(IBurgerObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IBurgerObserver observer)
    {
        _observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
}

public interface IBurgerObserver
{
    void Update(BurgerObserver burger);
}

public class Customer : IBurgerObserver
{
    private string _name;

    public Customer(string name)
    {
        _name = name;
    }

    public void Update(BurgerObserver burger)
    {
        Console.WriteLine($"{_name} has been notified. Burger status changed to: {burger.Status}");
    }
}

public class Chef : IBurgerObserver
{
    private string _name;

    public Chef(string name)
    {
        _name = name;
    }

    public void Update(BurgerObserver burger)
    {
        Console.WriteLine($"{_name} has been notified. Burger status changed to: {burger.Status}");
    }
}

public enum BurgerStatus
{
    Cooking,
    Ready,
    Delivered
}