public interface IVisitor
{
    void Visit(Candy candy);
    void Visit(Fruit fruit);
}

public interface IElement
{
    void Accept(IVisitor visitor);
}

public class Candy : IElement
{
    public string Name { get; }
    public decimal Price { get; }

    public Candy(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Fruit : IElement
{
    public string Name { get; }
    public decimal PricePerKg { get; }
    public double Weight { get; }

    public Fruit(string name, decimal pricePerKg, double weight)
    {
        Name = name;
        PricePerKg = pricePerKg;
        Weight = weight;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class ShoppingCartVisitor : IVisitor
{
    public decimal TotalPrice { get; private set; }

    public void Visit(Candy candy)
    {
        TotalPrice += candy.Price;
        Console.WriteLine($"Candy: {candy.Name}, Price: {candy.Price:C}");
    }

    public void Visit(Fruit fruit)
    {
        decimal fruitPrice = fruit.PricePerKg * (decimal)fruit.Weight;
        TotalPrice += fruitPrice;
        Console.WriteLine($"Fruit: {fruit.Name}, Price: {fruitPrice:C}");
    }
}

public class ReportVisitor : IVisitor
{
    public void Visit(Candy candy)
    {
        Console.WriteLine($"Candy Report - Name: {candy.Name}, Price: {candy.Price:C}");
    }

    public void Visit(Fruit fruit)
    {
        Console.WriteLine($"Fruit Report - Name: {fruit.Name}, Price per Kg: {fruit.PricePerKg:C}, Weight: {fruit.Weight} Kg");
    }
}
