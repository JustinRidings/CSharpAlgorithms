public interface IBeverage
{
    string GetDescription();
    double GetCost();
}

public class Espresso : IBeverage
{
    const double cost = 1.99;
    public string GetDescription()
    {
        return "Espresso";
    }

    public double GetCost()
    {
        return cost;
    }
}

public class HouseBlend : IBeverage
{
    const double cost = 0.89;
    public string GetDescription()
    {
        return "House Blend Coffee";
    }

    public double GetCost()
    {
        return cost;
    }
}

public abstract class BeverageDecorator : IBeverage
{
    protected IBeverage _beverage;

    public BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public abstract string GetDescription();
    public abstract double GetCost();
}

public class Milk : BeverageDecorator
{
    public Milk(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return _beverage.GetCost() + 0.50;
    }
}

public class Mocha : BeverageDecorator
{
    public Mocha(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Mocha";
    }

    public override double GetCost()
    {
        return _beverage.GetCost() + 0.75;
    }
}

