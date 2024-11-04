public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public Car()
    {
        Make = string.Empty;
        Model = string.Empty;
        Color = string.Empty;
    }

    public Car(string make, string model, string color)
    {
        Make = make;
        Model = model;
        Color = color;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Color} {Make} {Model}");
    }
}