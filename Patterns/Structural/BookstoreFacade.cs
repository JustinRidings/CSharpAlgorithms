public class BookInventory
{
    public void CheckStock()
    {
        Console.WriteLine("Checking book inventory...");
    }
}

public class OrderProcessing
{
    public void ProcessOrder()
    {
        Console.WriteLine("Processing book order...");
    }
}

public class ShippingService
{
    public void ArrangeShipping()
    {
        Console.WriteLine("Arranging shipping for the book...");
    }
}

public class BookstoreFacade
{
    private BookInventory _inventory;
    private OrderProcessing _orderProcessing;
    private ShippingService _shipping;

    public BookstoreFacade()
    {
        _inventory = new BookInventory();
        _orderProcessing = new OrderProcessing();
        _shipping = new ShippingService();
    }

    public void OrderBook()
    {
        _inventory.CheckStock();
        _orderProcessing.ProcessOrder();
        _shipping.ArrangeShipping();
        Console.WriteLine("Book order completed successfully.");
    }
}
