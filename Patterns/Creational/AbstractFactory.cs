public interface INotificationFactory
{
    IEmailNotification CreateEmailNotification();
    ISmsNotification CreateSmsNotification();
}

public class BasicNotificationFactory : INotificationFactory
{
    public IEmailNotification CreateEmailNotification()
    {
        return new BasicEmailNotification();
    }

    public ISmsNotification CreateSmsNotification()
    {
        return new BasicSmsNotification();
    }
}

public class PremiumNotificationFactory : INotificationFactory
{
    public IEmailNotification CreateEmailNotification()
    {
        return new PremiumEmailNotification();
    }

    public ISmsNotification CreateSmsNotification()
    {
        return new PremiumSmsNotification();
    }
}

public interface IEmailNotification
{
    void SendEmail(string message);
}

public interface ISmsNotification
{
    void SendSms(string message);
}

public class BasicEmailNotification : IEmailNotification
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending basic email: " + message);
    }
}

public class BasicSmsNotification : ISmsNotification
{
    public void SendSms(string message)
    {
        Console.WriteLine("Sending basic SMS: " + message);
    }
}

public class PremiumEmailNotification : IEmailNotification
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending premium email with extra features: " + message);
    }
}

public class PremiumSmsNotification : ISmsNotification
{
    public void SendSms(string message)
    {
        Console.WriteLine("Sending premium SMS with extra features: " + message);
    }
}

public class NotificationService
{
    private readonly IEmailNotification _emailNotification;
    private readonly ISmsNotification _smsNotification;

    public NotificationService(INotificationFactory factory)
    {
        _emailNotification = factory.CreateEmailNotification();
        _smsNotification = factory.CreateSmsNotification();
    }

    public void SendNotifications(string message)
    {
        _emailNotification.SendEmail(message);
        _smsNotification.SendSms(message);
    }
}
