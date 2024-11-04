public interface ICookingStrategy
{
    void Cook();
}

public class GrillStrategy : ICookingStrategy
{
    public void Cook()
    {
        Console.WriteLine("Grilling the burger to perfection!");
    }
}

public class FryStrategy : ICookingStrategy
{
    public void Cook()
    {
        Console.WriteLine("Frying the burger to a golden crisp!");
    }
}

public class BakeStrategy : ICookingStrategy
{
    public void Cook()
    {
        Console.WriteLine("Baking the burger for a healthier option!");
    }
}

public class Burger
{
    private ICookingStrategy? _cookingStrategy;

    public void SetCookingStrategy(ICookingStrategy cookingStrategy)
    {
        _cookingStrategy = cookingStrategy;
    }

    public void Cook()
    {
        _cookingStrategy?.Cook();
    }
}
