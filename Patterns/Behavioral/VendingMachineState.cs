public interface IVendingMachineState
{
    void InsertCoin(VendingMachine machine);
    void SelectProduct(VendingMachine machine);
    void DispenseProduct(VendingMachine machine);
}

public class NoCoinInsertedState : IVendingMachineState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("Coin inserted.");
        machine.State = new HasCoinState();
    }

    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("No coin inserted. Insert a coin first.");
    }

    public void DispenseProduct(VendingMachine machine)
    {
        Console.WriteLine("No coin inserted. Insert a coin first.");
    }
}

public class HasCoinState : IVendingMachineState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("Coin already inserted.");
    }

    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("Product selected.");
        machine.State = new DispensingState();
    }

    public void DispenseProduct(VendingMachine machine)
    {
        Console.WriteLine("Select a product first.");
    }
}

public class DispensingState : IVendingMachineState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("Please wait, dispensing product.");
    }

    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("Please wait, dispensing product.");
    }

    public void DispenseProduct(VendingMachine machine)
    {
        Console.WriteLine("Dispensing product.");
        machine.State = new NoCoinInsertedState();
    }
}

public class OutOfStockState : IVendingMachineState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("Out of stock.");
    }

    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("Out of stock.");
    }

    public void DispenseProduct(VendingMachine machine)
    {
        Console.WriteLine("Out of stock.");
    }
}

public class VendingMachine
{
    private IVendingMachineState? _state;

    public VendingMachine(IVendingMachineState state)
    {
        this.State = state;
    }

    public IVendingMachineState State
    {
        get => _state;
        set
        {
            _state = value;
            Console.WriteLine($"Vending Machine state changed to: {_state.GetType().Name}");
        }
    }

    public void InsertCoin()
    {
        _state?.InsertCoin(this);
    }

    public void SelectProduct()
    {
        _state?.SelectProduct(this);
    }

    public void DispenseProduct()
    {
        _state?.DispenseProduct(this);
    }
}
