public interface IBankAccount
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
    decimal GetBalance();
}

public class BankAccount : IBankAccount
{
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited: {amount:C}. New Balance: {_balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrew: {amount:C}. New Balance: {_balance:C}");
        }
        else
        {
            Console.WriteLine($"Insufficient funds to withdraw {amount:C}. Balance: {_balance:C}");
        }
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}

public class BankAccountProxy : IBankAccount
{
    private readonly IBankAccount _bankAccount;
    private readonly string _user;
    private readonly string _password;

    public BankAccountProxy(IBankAccount bankAccount, string user, string password)
    {
        _bankAccount = bankAccount;
        _user = user;
        _password = password;
    }

    private bool Authenticate()
    {
        // Simple authentication logic for demonstration purposes
        return _user == "user" && _password == "password";
    }

    public void Deposit(decimal amount)
    {
        if (Authenticate())
        {
            Console.WriteLine("Authentication successful. Processing deposit...");
            _bankAccount.Deposit(amount);
        }
        else
        {
            Console.WriteLine("Authentication failed. Deposit not processed.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (Authenticate())
        {
            Console.WriteLine("Authentication successful. Processing withdrawal...");
            _bankAccount.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Authentication failed. Withdrawal not processed.");
        }
    }

    public decimal GetBalance()
    {
        if (Authenticate())
        {
            Console.WriteLine("Authentication successful. Retrieving balance...");
            return _bankAccount.GetBalance();
        }
        else
        {
            Console.WriteLine("Authentication failed. Cannot retrieve balance.");
            return 0;
        }
    }
}
