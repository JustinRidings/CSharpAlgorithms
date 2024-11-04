using System;

// target
public class Book
{
    public void Read()
    {
        Console.WriteLine("Reading a fascinating book!");
    }
}

// Adaptee
public class Magazine
{
    public void FlipThrough()
    {
        Console.WriteLine("Flipping through the magazine.");
    }

    public void Read()
    {
        Console.WriteLine("Reading an interesting magazine!");
    }
}

// Adapter
public class MagazineAdapter : Book
{
    private readonly Magazine _magazine;

    public MagazineAdapter(Magazine magazine)
    {
        _magazine = magazine;
    }

    public new void Read()
    {
        _magazine.FlipThrough();
        _magazine.Read();
    }
}
