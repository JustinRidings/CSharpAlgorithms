public class Order
{
    private Lazy<OrderDetails> _orderDetails;

    public Order()
    {
        _orderDetails = new Lazy<OrderDetails>(() => LoadOrderDetails());
    }

    public OrderDetails OrderDetails
    {
        get
        {
            return _orderDetails.Value;
        }
    }

    private OrderDetails LoadOrderDetails()
    {
        Console.WriteLine("Loading order details...");
        return new OrderDetails { Detail = "Details of the order" };
    }
}

public class OrderDetails
{
    public required string Detail { get; set; }
}