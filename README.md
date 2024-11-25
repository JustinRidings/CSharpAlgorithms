# C# Algorithms
A collection of Design Patterns and Algorithms, implemented in C#.

### Prereqs

You will need .NET 8 Runtime/SDK in order to code / build. Additionally, it helps to use an IDE. I recommend Visual Studio.

- [Install .NET 8 SDK/Runtime Interactively](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Install Visual Studio Preview](https://visualstudio.microsoft.com/vs/preview/)

OR use [WinGet](https://learn.microsoft.com/en-us/windows/package-manager/winget/)

```
winget install dotnet-runtime-8
winget install dotnet-sdk-8
winget install Microsoft.VisualStudio.2022.Community.Preview
```

### Project Layout

The [Patterns](https://github.com/JustinRidings/CSharpAlgorithms/tree/main/Patterns) directory contains sub-directories for the different types of design patterns that exist, align with implementations. The [WhiteboardSolutions.cs](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/WhiteboardSolutions.cs) file contains static implementations for various whiteboarding questions. You can Demo each pattern or whiteboard solution by running the [Program](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Program.cs) to see the output.

### Behavioral Patterns

- [Iterator](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/BurgerMenuIterator.cs)
  - **Summary**: Provides a way to access elements of a collection sequentially without exposing its underlying representation.
  - **When to use**: When you need to traverse a collection without exposing its internal structure.

```mermaid
graph TD
A[Collection] -->|createIterator| B[Iterator]
B -->|first| C[Element1]
B -->|next| D[Element2]
B -->|hasNext| E[Element3]
B -->|currentItem| F[Element4]
```
- [Observer](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/BurgerObserver.cs)
  - **Summary**: Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
  - **When to use**: When changes to one object need to be propagated to multiple dependent objects automatically.

 ```mermaid
graph TD
A[Subject] -->|registerObserver| B[Observer1]
A -->|removeObserver| C[Observer2]
A -->|notifyObservers| D[Observer3]
B -->|update| E[Observer1State]
C -->|update| F[Observer2State]
D -->|update| G[Observer3State]
```

- [Strategy](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/CookingStrategy.cs)
  - **Summary**: Defines a family of algorithms, encapsulates each one, and makes them interchangeable. The strategy pattern lets the algorithm vary independently from the clients that use it.
  - **When to use**: When you have multiple algorithms for a specific task and want to switch between them dynamically.
 
```mermaid
graph TD
A[Context] -->|setStrategy| B[StrategyInterface]
B -->|executeStrategy| C[ConcreteStrategyA]
B -->|executeStrategy| D[ConcreteStrategyB]
A -->|performTask| E[Result]
```

- [Command](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/LightCommand.cs)
  - **Summary**: Encapsulates a request as an object, thereby allowing for parameterization of clients with queues, requests, and operations.
  - **When to use**: When you need to parameterize objects with operations, delay execution, or support undoable operations.
 
```mermaid
graph TD
A[Invoker] -->|executeCommand| B[Command]
B -->|execute| C[ConcreteCommand]
C -->|execute| D[Receiver]
D -->|action| E[Result]
```

- [State](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/VendingMachineState.cs)
  - **Summary**: Allows an object to alter its behavior when its internal state changes. The object will appear to change its class.
  - **When to use**: When an object's behavior depends on its state, and it needs to change behavior at runtime depending on its current state.
 
```mermaid
graph TD
A[Context] -->|setState| B[State]
B -->|handleRequest| C[ConcreteStateA]
B -->|handleRequest| D[ConcreteStateB]
A -->|request| E[Result]
```

- [Mediator](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/ChatMediator.cs)
  - **Summary**: Defines an object that encapsulates how a set of objects interact. This pattern promotes loose coupling by keeping objects from referring to each other explicitly and allows their interaction to be varied independently.
  - **When to use**: When you need to reduce the complexity of communication between multiple objects and centralize the interaction logic.
 
```mermaid
graph TD
A[Mediator] -->|notify| B[Colleague1]
A -->|notify| C[Colleague2]
B -->|send| A
C -->|send| A
```

- [Chain of Responsibility](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Behavioral/SupportChainOfResponsibility.cs)
  - **Summary**: Allows a request to pass through a chain of handlers. Each handler either processes the request or passes it to the next handler in the chain.
  - **When to use**: When multiple objects can handle a request, and you want to avoid coupling the sender to a specific receiver.

```mermaid
graph TD
A[Client] -->|sendRequest| B[Handler1]
B -->|handleRequest| C[Handler2]
C -->|handleRequest| D[Handler3]
D -->|handleRequest| E[Result]
```

### Creational Patterns

- [Builder](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Creational/CarBuilder.cs)
  - **Summary**: Separates the construction of a complex object from its representation so that the same construction process can create different representations.
  - **When to use**: When you need to construct complex objects step by step and allow for different representations.
- [Factory](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Creational/CarFactory.cs)
  - **Summary**: Defines an interface for creating an object, but lets subclasses alter the type of objects that will be created.
  - **When to use**: When you need to delegate the instantiation logic to subclasses or to centralize the creation logic for a specific type of object.
- [Singleton](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Creational/CarSingleton.cs)
  - **Summary**: Ensures a class has only one instance and provides a global point of access to it.
  - **When to use**: When you need exactly one instance of a class to control access to shared resources.
- [LazyLoading](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Creational/OrderLazy.cs)
  - **Summary**: Delays the initialization of an object until it is actually needed, which can improve performance and reduce memory usage.
  - **When to use**: When you want to defer the initialization of an object until it's really needed to save resources.
- [Prototype](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Creational/GameCharacterPrototype.cs)
  - **Summary**: Allows you to copy existing objects without making your code dependent on their classes.
  - **When to use**: When creating new instances of a class is expensive or complicated, or when you want to replicate an object configuration with minor changes.

### Structural Patterns

- [Facade](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Structural/BookstoreFacade.cs)
  - **Summary**: Provides a unified interface to a set of interfaces in a subsystem, making the subsystem easier to use.
  - **When to use**: When you need to simplify interactions with a complex system by providing a unified interface.
- [Adapter](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Structural/MagazineAdapter.cs)
  - **Summary**: Converts the interface of a class into another interface the clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
  - **When to use**: When you need to integrate a new class that doesn't fit the existing interface or legacy system.
- [Decorator](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Structural/BeverageDecorator.cs)
  - **Summary**: Attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
  - **When to use**: When you need to add behaviors or responsibilities to objects dynamically without modifying their code.
- [Composite](https://github.com/JustinRidings/CSharpAlgorithms/blob/main/Patterns/Structural/ComponentComposite.cs)
  - **Summary**: Composes objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
  - **When to use**: When you need to work with tree structures and treat individual objects and compositions uniformly.
