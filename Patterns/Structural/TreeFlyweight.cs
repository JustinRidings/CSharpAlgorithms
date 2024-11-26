public class TreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing {Name} tree at ({x}, {y}) with color {Color} and texture {Texture}");
    }
}

public class TreeFactory
{
    private Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

    public TreeType GetTreeType(string name, string color, string texture)
    {
        string key = $"{name}_{color}_{texture}";

        if (!treeTypes.ContainsKey(key))
        {
            treeTypes[key] = new TreeType(name, color, texture);
        }

        return treeTypes[key];
    }
}

public class Tree
{
    public int X { get; }
    public int Y { get; }
    private TreeType treeType;

    public Tree(int x, int y, TreeType treeType)
    {
        X = x;
        Y = y;
        this.treeType = treeType;
    }

    public void Draw()
    {
        treeType.Draw(X, Y);
    }
}
