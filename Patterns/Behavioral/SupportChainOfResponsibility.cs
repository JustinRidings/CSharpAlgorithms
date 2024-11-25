public abstract class SupportHandler
{
    protected SupportHandler? successor;

    public void SetSuccessor(SupportHandler successor)
    {
        this.successor = successor;
    }

    public abstract void HandleRequest(SupportTicket ticket);
}

public class SupportTicket
{
    public string Issue { get; set; }
    public string Level { get; set; }

    public SupportTicket(string issue, string level)
    {
        Issue = issue;
        Level = level;
    }
}

public class GeneralSupportHandler : SupportHandler
{
    public override void HandleRequest(SupportTicket ticket)
    {
        if (ticket.Level == "General")
        {
            Console.WriteLine("GeneralSupportHandler handled ticket: " + ticket.Issue);
        }
        else if (successor != null)
        {
            successor.HandleRequest(ticket);
        }
    }
}

public class TechnicalSupportHandler : SupportHandler
{
    public override void HandleRequest(SupportTicket ticket)
    {
        if (ticket.Level == "Technical")
        {
            Console.WriteLine("TechnicalSupportHandler handled ticket: " + ticket.Issue);
        }
        else if (successor != null)
        {
            successor.HandleRequest(ticket);
        }
    }
}

public class ManagerialSupportHandler : SupportHandler
{
    public override void HandleRequest(SupportTicket ticket)
    {
        if (ticket.Level == "Managerial")
        {
            Console.WriteLine("ManagerialSupportHandler handled ticket: " + ticket.Issue);
        }
        else if (successor != null)
        {
            Console.WriteLine("No handler found for ticket: " + ticket.Issue);
        }
    }
}
