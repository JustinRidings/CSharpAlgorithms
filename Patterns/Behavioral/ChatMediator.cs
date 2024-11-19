public interface IChatMediator
{
    void SendMessage(string message, User user);
    void AddUser(User user);
}

public class ChatMediator : IChatMediator
{
    private List<User> _users;

    public ChatMediator()
    {
        _users = new List<User>();
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, User user)
    {
        foreach (var u in _users)
        {
            if (u != user)
            {
                u.Receive(message);
            }
        }
    }
}

public abstract class User
{
    protected IChatMediator _mediator;
    protected string _name;

    public User(IChatMediator mediator, string name)
    {
        _mediator = mediator;
        _name = name;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}

public class ConcreteUser : User
{
    public ConcreteUser(IChatMediator mediator, string name) : base(mediator, name)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{_name} sends: {message}");
        _mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{_name} receives: {message}");
    }
}
