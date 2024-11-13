public interface ICharacterPrototype
{
    ICharacterPrototype Clone();
}

public class GameCharacter : ICharacterPrototype
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public List<string> Inventory { get; set; }

    public GameCharacter(string name, int health, int mana, List<string> inventory)
    {
        Name = name;
        Health = health;
        Mana = mana;
        Inventory = new List<string>(inventory);
    }

    public ICharacterPrototype Clone()
    {
        // Create a deep copy of the GameCharacter
        return new GameCharacter(Name, Health, Mana, new List<string>(Inventory));
    }

    public override string ToString()
    {
        return $"{Name} - Health: {Health}, Mana: {Mana}, Inventory: [{string.Join(", ", Inventory)}]";
    }
}
