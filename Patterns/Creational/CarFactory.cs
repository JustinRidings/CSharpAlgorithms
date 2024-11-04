public interface ICarFactory
{
    Car CreateCar(string make, string model, string color);
}

public class CarFactory : ICarFactory
{
    public Car CreateCar(string make, string model, string color)
    {
        return new Car(make, model, color);
    }
}
