using System;
using System.Runtime.CompilerServices;

namespace CSharp.Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoCarFactory();               // Factory Pattern
            DemoCarBuilder();               // Builder Pattern
            DemoCarSingleton();             // Singleton Pattern
            DemoBurgerObserver();           // Observer Pattern
            DemoBurgerMenuIterator();       // Iterator Pattern
            DemoBurgerCookingStrategy();    // Strategy Pattern
            DemoLightControlCommand();      // Command Pattern
            DemoVendingMachineState();      // State Pattern
            DemoMagazineAdapter();          // Adapter Pattern
            DemoComposite();                // Composite Pattern
            DemoBookstoreFacade();          // Facade Pattern
            DemoBeverageDecorator();        // Decorator Pattern
            DemoLazyLoading();              // Lazy Loading Pattern
            DemoCharacterPrototype();       // Prototype Pattern
            DemoIsPalindrome();             // Palindrome Whiteboard Question
            DemoFizzBuzz();                 // FizzBuzz Whiteboard Question
            DemoReverseString();            // Reverse String Whiteboard Question
            DemoCountDuplicateChars();      // Duplicate Character Counting Whiteboard Question
            DemoReverseLinkedList();        // Reverses Linked List Whiteboard Question
            DemoCombineLists();             // Combine Linked Lists Whiteboard Question
        }

        /// <summary>
        /// Demonstrates the implementation of CarFactory to demonstrate the creational pattern, Factory.
        /// </summary>
        private static void DemoCarFactory()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoCarFactory));
            ICarFactory factory = new CarFactory();
            Car car1 = factory.CreateCar("Toyota", "Corolla", "Red");
            Car car2 = factory.CreateCar("Ford", "Mustang", "Blue");

            DisplayCarInfo(car1, car2);
            Console.WriteLine("{0} Complete", nameof(DemoCarFactory));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of CarBuilder to demonstrate the creational pattern, Builder.
        /// </summary>
        private static void DemoCarBuilder()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoCarBuilder));
            CarBuilder builder = new CarBuilder();
            Car car1 = builder.SetMake("Toyota").SetModel("Corolla").SetColor("Blue").Build();
            Car car2 = builder.SetMake("Ford").SetModel("Mustang").SetColor("Red").Build();

            DisplayCarInfo(car1, car2);
            Console.WriteLine("{0} Complete", nameof(DemoCarBuilder));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of CarSingleton to demonstrate the creational pattern, Singleton.
        /// </summary>
        private static void DemoCarSingleton()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoCarSingleton));

            CarSingleton singleton = CarSingleton.Instance;
            Car car1 = singleton.CreateCar("Toyota", "Corolla", "Black");
            Car car2 = singleton.CreateCar("Ford", "Mustang", "Orange");

            DisplayCarInfo(car1, car2);

            Console.WriteLine("{0} Complete", nameof(DemoCarSingleton));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of CharacterPrototype to demonstrate the creational pattern, Prototype.
        /// </summary>
        private static void DemoCharacterPrototype()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoCharacterPrototype));

            GameCharacter originalCharacter = new GameCharacter("Hero", 100, 50, new List<string> { "Sword", "Shield" });
            Console.WriteLine("Original Character: " + originalCharacter);

            GameCharacter clonedCharacter = (GameCharacter)originalCharacter.Clone();
            Console.WriteLine("Cloned Character: " + clonedCharacter);

            clonedCharacter.Name = "Villain";
            clonedCharacter.Health = 80;
            clonedCharacter.Inventory.Add("Potion");

            Console.WriteLine("{0} Complete", nameof(DemoCharacterPrototype));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of BurgerObserver to demonstrate the behavioral pattern, Observer.
        /// </summary>
        private static void DemoBurgerObserver()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoBurgerObserver));

            BurgerObserver burger = new();

            Customer customer = new Customer("Alice");
            Chef chef = new Chef("Bob");

            burger.Attach(customer);
            burger.Attach(chef);

            burger.Status = BurgerStatus.Cooking;
            burger.Status = BurgerStatus.Ready;
            burger.Status = BurgerStatus.Delivered;

            Console.WriteLine("{0} Complete", nameof(DemoBurgerObserver));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of BurgerMenuIterator to demonstrate the behavioral pattern, Iterator.
        /// </summary>
        private static void DemoBurgerMenuIterator()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoBurgerMenuIterator));

            BurgerMenu menu = new BurgerMenu();
            menu.AddItem("Cheeseburger");
            menu.AddItem("Veggie Burger");
            menu.AddItem("Chicken Burger");

            IIterator iterator = menu.CreateIterator();
            while (iterator.HasNext())
            {
                string item = (string)iterator.Next();
                Console.WriteLine("Menu Item: " + item);
            }

            Console.WriteLine("{0} Complete", nameof(DemoBurgerMenuIterator));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of CookingStrategy to demonstrate the behavioral pattern, Strategy.
        /// </summary>
        private static void DemoBurgerCookingStrategy()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoBurgerCookingStrategy));

            Burger burger = new Burger();

            burger.SetCookingStrategy(new GrillStrategy());
            burger.Cook();

            burger.SetCookingStrategy(new FryStrategy());
            burger.Cook();

            burger.SetCookingStrategy(new BakeStrategy());
            burger.Cook();

            Console.WriteLine("{0} Complete", nameof(DemoBurgerCookingStrategy));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of LightCommand to demonstrate the behavioral pattern, Command.
        /// </summary>
        private static void DemoLightControlCommand()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoLightControlCommand));

            Light livingRoomLight = new Light();

            ICommand turnOn = new TurnOnLightCommand(livingRoomLight);
            ICommand turnOff = new TurnOffLightCommand(livingRoomLight);

            RemoteControl remote = new RemoteControl();

            // Turn on the light
            remote.SetCommand(turnOn);
            remote.PressButton();

            // Turn off the light
            remote.SetCommand(turnOff);
            remote.PressButton();

            Console.WriteLine("{0} Complete", nameof(DemoLightControlCommand));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of VendingMachineState to demonstrate the behavioral pattern, State.
        /// </summary>
        private static void DemoVendingMachineState()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoVendingMachineState));

            VendingMachine machine = new VendingMachine(new NoCoinInsertedState());

            machine.InsertCoin();
            machine.SelectProduct();
            machine.DispenseProduct();

            machine.InsertCoin();
            machine.SelectProduct();

            Console.WriteLine("{0} Complete", nameof(DemoVendingMachineState));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of MagazineAdapter to demonstrate the structural pattern, Adapter.
        /// </summary>
        private static void DemoMagazineAdapter()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoMagazineAdapter));

            Book book = new Book();
            book.Read();

            Magazine magazine = new Magazine();
            Book magazineAdapter = new MagazineAdapter(magazine);
            magazineAdapter.Read();

            Console.WriteLine("{0} Complete", nameof(DemoMagazineAdapter));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of ComponentComposite to demonstrate the Structural Pattern, Composite.
        /// </summary>
        private static void DemoComposite()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoComposite));

            Composite root = new Composite("Root");
            root.Add(new Leaf("Leaf A"));
            Composite composite = new Composite("Composite X");
            composite.Add(new Leaf("Leaf XA"));
            composite.Add(new Leaf("Leaf XB"));
            root.Add(composite);
            root.Add(new Leaf("Leaf B"));
            root.Display(1);

            Console.WriteLine("{0} Complete", nameof(DemoMagazineAdapter));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of BookstoreFacade to demonstrate the structural pattern, Facade.
        /// </summary>
        private static void DemoBookstoreFacade()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoBookstoreFacade));

            BookstoreFacade bookstoreFacade = new BookstoreFacade();
            bookstoreFacade.OrderBook();

            Console.WriteLine("{0} Complete", nameof(DemoBookstoreFacade));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of BeverageDecorator to demonstrate the structural pattern, Decorator.
        /// </summary>
        private static void DemoBeverageDecorator()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoBeverageDecorator));

            IBeverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.GetCost()}");

            beverage = new Milk(beverage);
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.GetCost()}");

            beverage = new Mocha(beverage);
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.GetCost()}");

            Console.WriteLine("{0} Complete", nameof(DemoBeverageDecorator));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of WhiteboardSolutions.IsPalindrome function, which demonstrates
        /// determining if a string is a Palindrome.
        /// </summary>
        private static void DemoIsPalindrome()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoIsPalindrome));

            string testString1 = "Racecar";
            string testString2 = "Hello";

            Console.WriteLine($"{testString1} is a palindrome: {WhiteboardSolutions.IsPalindrome(testString1)}");
            Console.WriteLine($"{testString2} is a palindrome: {WhiteboardSolutions.IsPalindrome(testString2)}");

            Console.WriteLine("{0} Complete", nameof(DemoIsPalindrome));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of WhiteboardSolutions.FizzBuzz function, which counts to N, printing the words
        /// "Fizz", "Buzz" and "FizzBuzz" for numbers divisible by 3,5, or both.
        /// </summary>
        private static void DemoFizzBuzz()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoFizzBuzz));

            WhiteboardSolutions.FizzBuzz(20);

            Console.WriteLine("{0} Complete", nameof(DemoFizzBuzz));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of WhiteboardSolutions.ReverseString, which reverses a string.
        /// </summary>
        private static void DemoReverseString()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoReverseString));

            string original = "Hello, World!";
            string reversed = WhiteboardSolutions.ReverseString(original);
            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Reversed: {reversed}");

            Console.WriteLine("{0} Complete", nameof(DemoReverseString));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of WhiteboardSolutions.CountDuplicateCharacters, which counts the maximum 
        /// amount of any duplicate characters within a string.
        /// </summary>
        private static void DemoCountDuplicateChars()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoCountDuplicateChars));

            string testString = "Hello, World!";
            int duplicateCount = WhiteboardSolutions.CountDuplicateCharacters(testString);
            Console.WriteLine($"Number of duplicate characters: {duplicateCount}");

            string testString2 = "OoOoOoOoOoOoOoOo";
            int duplicateCount2 = WhiteboardSolutions.CountDuplicateCharacters(testString2);
            Console.WriteLine($"Number of duplicate characters: {duplicateCount2}");

            Console.WriteLine("{0} Complete", nameof(DemoCountDuplicateChars));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of WhiteboardSolutions.ReverseLinkedList, which accepts a LinkedList as 
        /// a parameter, and then reverses it.
        /// </summary>
        private static void DemoReverseLinkedList()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoReverseLinkedList));

            LinkedList<int> originalList = new LinkedList<int>();
            originalList.AddLast(1);
            originalList.AddLast(2);
            originalList.AddLast(3);
            originalList.AddLast(4);

            LinkedList<int> reversedList = WhiteboardSolutions.ReverseLinkedList(originalList);

            Console.WriteLine("Original List:");
            foreach (var item in originalList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nReversed List:");
            foreach (var item in reversedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("{0} Complete", nameof(DemoReverseLinkedList));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of WhiteboardSolutions.CombineLists, which demonstrates combining two Linked Lists
        /// </summary>
        private static void DemoCombineLists()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoCombineLists));

            LinkedList<int> list1 = new LinkedList<int>(new[] { 1, 3, 5 });
            LinkedList<int> list2 = new LinkedList<int>(new[] { 2, 4, 6 });

            LinkedList<int> combinedList = WhiteboardSolutions.CombineLists(list1, list2);

            Console.WriteLine("Combined List:");
            foreach (var item in combinedList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("{0} Complete", nameof(DemoCombineLists));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the creation of OrderLazy to demonstrate the creational pattern, Lazy Loading.
        /// </summary>
        private static void DemoLazyLoading()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoLazyLoading));

            var order = new Order();
            Console.WriteLine("Order created.");
            Console.WriteLine("Order details: " + order.OrderDetails.Detail);

            Console.WriteLine("{0} Complete", nameof(DemoLazyLoading));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Internal method for simplifying redundant statements
        /// </summary>
        /// <param name="car1">A Car object</param>
        /// <param name="car2">A Car object</param>
        internal static void DisplayCarInfo(Car car1, Car car2)
        {
            car1.DisplayInfo();
            car2.DisplayInfo();
        }
    }

}
