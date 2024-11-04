public sealed class CarSingleton
{
    private static readonly CarSingleton _instance = new CarSingleton();

    private CarSingleton() { }

    public static CarSingleton Instance
    {

        get { return _instance; }
    }

    public Car CreateCar(string make, string model, string color)
    {
        return new Car(make, model, color);
    }
}