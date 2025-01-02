public interface IColor
{
    void ApplyColor();
}

public class RedColor : IColor
{
    public void ApplyColor()
    {
        Console.WriteLine("Red Color applied.");
    }
}

public class BlueColor : IColor
{
    public void ApplyColor()
    {
        Console.WriteLine("Blue Color applied.");
    }
}

public abstract class Shape
{
    protected IColor color;

    protected Shape(IColor color)
    {
        this.color = color;
    }

    public abstract void Draw();
}

public class Circle : Shape
{
    public Circle(IColor color) : base(color) { }

    public override void Draw()
    {
        Console.Write("Circle drawn with ");
        color.ApplyColor();
    }
}

public class Rectangle : Shape
{
    public Rectangle(IColor color) : base(color) { }

    public override void Draw()
    {
        Console.Write("Rectangle drawn with ");
        color.ApplyColor();
    }
}
