# CSharp Whiteboard
A collection of Design Patterns and Algorithms, implemented in C#.

### Prereqs

You will need .NET 8 Runtime/SDK in order to code / build / use as a dotnet tool.

- [Install .NET 8 SDK/Runtime Interactively](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

OR use CommandLine

- `winget install dotnet-runtime-8`
- `winget install dotnet-sdk-8`

### Project Layout

The [Patterns](https://github.com/JustinRidings/CSharpAlgorithms/tree/main/Patterns) directory contains sub-directories for the different types of design patterns that exist, alogn with implementations. The [WhiteboardSolutions.cs](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/WhiteboardSolutions.cs) file contains static implementations for various whiteboarding questions. You can Demo each pattern or whiteboard solution by running the [Program](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Program.cs) to see the output.

### Behavioral Patterns

1. [Iterator](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/BurgerMenuIterator.cs)
2. [Observer](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/BurgerObserver.cs)
3. [Strategy](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/CookingStrategy.cs)
4. [Command](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/LightCommand.cs)

### Creational Patterns

1. [Builder](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Creational/CarBuilder.cs)
2. [Factory](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Creational/CarFactory.cs)
3. [Singleton](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Creational/CarSingleton.cs)
4. [LazyLoading](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Creational/OrderLazy.cs)

### Structural Patterns

1. [Facade](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Structural/BookstoreFacade.cs)
2. [Adapter](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Structural/MagazineAdapter.cs)
