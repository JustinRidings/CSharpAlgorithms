public interface ICommand
{
    void Execute();
}

public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("The light is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("The light is off");
    }
}

public class TurnOnLightCommand : ICommand
{
    private readonly Light _light;

    public TurnOnLightCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}

public class TurnOffLightCommand : ICommand
{
    private readonly Light _light;

    public TurnOffLightCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}

public class RemoteControl
{
    private ICommand _command = default!;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}

