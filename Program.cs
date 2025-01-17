﻿using System;
using System.Runtime.CompilerServices;

namespace CSharp.Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creational
            DemoCarFactory();                   // Factory Pattern
            DemoCarBuilder();                   // Builder Pattern
            DemoCarSingleton();                 // Singleton Pattern
            DemoLazyLoading();                  // Lazy Loading Pattern
            DemoCharacterPrototype();           // Prototype Pattern
            DemoAbstractFactory();              // Abstract Factory Pattern

            // Behavioral
            DemoBurgerObserver();               // Observer Pattern
            DemoBurgerMenuIterator();           // Iterator Pattern
            DemoBurgerCookingStrategy();        // Strategy Pattern
            DemoLightControlCommand();          // Command Pattern
            DemoVendingMachineState();          // State Pattern
            DemoChatMediator();                 // Mediator Pattern
            DemoSupportChainOfResponsibility(); // Chain of Responsibility Pattern
            DemoShoppingVisitor();              // Visitor Pattern
            DemoDocumentTemplateMethod();       // Template Method Pattern
            DemoTextMemento();                  // Memento Pattern

            // Structural
            DemoMagazineAdapter();              // Adapter Pattern
            DemoComposite();                    // Composite Pattern
            DemoBookstoreFacade();              // Facade Pattern
            DemoBeverageDecorator();            // Decorator Pattern
            DemoTreeFlyweight();                // Flyweight Pattern
            DemoBankProxy();                    // Proxy Pattern
            DemoShapeBridge();                  // Bridge Pattern

            // Whiteboard Solutions
            DemoIsPalindrome();                 // Palindrome Whiteboard Question
            DemoFizzBuzz();                     // FizzBuzz Whiteboard Question
            DemoReverseString();                // Reverse String Whiteboard Question
            DemoCountDuplicateChars();          // Duplicate Character Counting Whiteboard Question
            DemoReverseLinkedList();            // Reverses Linked List Whiteboard Question
            DemoCombineLists();                 // Combine Linked Lists Whiteboard Question
            DemoTwoSum();                       // Two Sum Whiteboard Question
            DemoLengthOfSubstring();            // Length of Longest Substring Whiteboard Question
            DemoLargestRectangle();             // Largest Rectangle Area Whiteboard Question
            DemoFactorial();                    // Factorial Whiteboard Question
        }

        #region Creational Patterns
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
        /// Demonstrates the implementation of NotificationService to demonstrate the creational pattern, Abstract Factory.
        /// </summary>
        private static void DemoAbstractFactory()
        {
            INotificationFactory basicFactory = new BasicNotificationFactory();
            NotificationService basicService = new NotificationService(basicFactory);
            basicService.SendNotifications("Hello! This is a basic notification.");

            INotificationFactory premiumFactory = new PremiumNotificationFactory();
            NotificationService premiumService = new NotificationService(premiumFactory);
            premiumService.SendNotifications("Hello! This is a premium notification.");
        }
        #endregion
        #region Behavioral Patterns
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
        /// Demonstrates the implementation of ChatMediator to demonstrate the behavioral pattern, Mediator.
        /// </summary>
        private static void DemoChatMediator()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoChatMediator));

            IChatMediator chatMediator = new ChatMediator();

            User user1 = new ConcreteUser(chatMediator, "Alice");
            User user2 = new ConcreteUser(chatMediator, "Bob");
            User user3 = new ConcreteUser(chatMediator, "Charlie");

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.Send("Hi everyone!");
            user2.Send("Hello Alice!");

            Console.WriteLine("{0} Complete", nameof(DemoChatMediator));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of SupportChainOfResponsibility to demonstrate the behavioral pattern, Chain of Responsibility.
        /// </summary>
        private static void DemoSupportChainOfResponsibility()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoSupportChainOfResponsibility));

            SupportHandler generalSupport = new GeneralSupportHandler();
            SupportHandler technicalSupport = new TechnicalSupportHandler();
            SupportHandler managerialSupport = new ManagerialSupportHandler();

            generalSupport.SetSuccessor(technicalSupport);
            technicalSupport.SetSuccessor(managerialSupport);

            var tickets = new List<SupportTicket>
            {
                new SupportTicket("Password reset issue", "General"),
                new SupportTicket("System crash", "Technical"),
                new SupportTicket("Customer complaint", "Managerial"),
                new SupportTicket("Unknown issue", "Unknown")
            };

            foreach (var ticket in tickets)
            {
                generalSupport.HandleRequest(ticket);
            }

            Console.WriteLine("{0} Complete", nameof(DemoSupportChainOfResponsibility));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of ShoppingVisitor to demonstrate the behavioral pattern, Visitor.
        /// </summary>
        private static void DemoShoppingVisitor()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoShoppingVisitor));

            var items = new List<IElement>
            {
                new Candy("Chocolate Bar", 2.99m),
                new Candy("Gummy Bears", 3.50m),
                new Fruit("Banana", 1.99m, 2.5),
                new Fruit("Apple", 2.99m, 1.2)
            };

            var shoppingCartVisitor = new ShoppingCartVisitor();
            var reportVisitor = new ReportVisitor();

            foreach (var item in items)
            {
                item.Accept(shoppingCartVisitor);
                item.Accept(reportVisitor);
            }

            Console.WriteLine($"Total Price: {shoppingCartVisitor.TotalPrice:C}");

            Console.WriteLine("{0} Complete", nameof(DemoShoppingVisitor));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of DocumentTemplateMethod to demonstrate the behavioral pattern, Template Method.
        /// </summary>
        private static void DemoDocumentTemplateMethod()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoDocumentTemplateMethod));

            DocumentProcessor wordProcessor = new WordDocumentProcessor();
            DocumentProcessor pdfProcessor = new PdfDocumentProcessor();

            Console.WriteLine("Processing Word Document:");
            wordProcessor.ProcessDocument();

            Console.WriteLine("\nProcessing PDF Document:");
            pdfProcessor.ProcessDocument();

            Console.WriteLine("{0} Complete", nameof(DemoDocumentTemplateMethod));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of TextMemento to demonstrate the behavioral pattern, Memento.
        /// </summary>
        public static void DemoTextMemento()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoTextMemento));

            TextEditor editor = new TextEditor();
            TextHistory history = new TextHistory();

            editor.SetText("Hello, world!");
            history.Save(editor.SaveTextToMemento());

            editor.SetText("Hello, C#!");
            history.Save(editor.SaveTextToMemento());

            editor.SetText("Hello, Design Patterns!");

            editor.RestoreTextFromMemento(history.Undo());
            editor.RestoreTextFromMemento(history.Undo());

            Console.WriteLine("{0} Complete", nameof(DemoTextMemento));
            Console.WriteLine("----------");
        }
        #endregion
        #region Structural Patterns
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
        /// Demonstrates the implementation of ComponentComposite to demonstrate the structural pattern, Composite.
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
        /// Demonstrates the implementation of TreeFlyweight to demonstrate the structural pattern, Flyweight.
        /// </summary>
        private static void DemoTreeFlyweight()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoTreeFlyweight));

            TreeFactory factory = new TreeFactory();

            var trees = new List<Tree>
            {
                new Tree(1, 1, factory.GetTreeType("Oak", "Green", "Rough")),
                new Tree(2, 2, factory.GetTreeType("Pine", "Green", "Smooth")),
                new Tree(1, 1, factory.GetTreeType("Oak", "Green", "Rough")), // Reuses existing Flyweight object
                new Tree(3, 3, factory.GetTreeType("Birch", "Yellow", "Rough"))
            };

            foreach (var tree in trees)
            {
                tree.Draw();
            }

            Console.WriteLine("{0} Complete", nameof(DemoTreeFlyweight));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of BankProxy to demonstrate the structural pattern, Proxy.
        /// </summary>
        private static void DemoBankProxy()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoBankProxy));

            IBankAccount bankAccount = new BankAccount();
            IBankAccount proxy = new BankAccountProxy(bankAccount, "user", "password");

            proxy.Deposit(100);
            proxy.Withdraw(50);
            Console.WriteLine($"Balance: {proxy.GetBalance():C}");

            Console.WriteLine("{0} Complete", nameof(DemoBankProxy));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of ShapeBridge to demonstrate the structural pattern, Bridge.
        /// </summary>
        public static void DemoShapeBridge()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoShapeBridge));

            Shape circle = new Circle(new RedColor());
            circle.Draw();

            Shape rectangle = new Rectangle(new BlueColor());
            rectangle.Draw();

            Console.WriteLine("{0} Complete", nameof(DemoShapeBridge));
            Console.WriteLine("----------");
        }
        #endregion
        #region Whiteboard Solutions
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
        /// Demonstrates the implementation of TwoSum, which finds the indices of two numbers that add up to a target.
        /// </summary>
        private static void DemoTwoSum()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoTwoSum));

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = WhiteboardSolutions.TwoSum(nums, target);
            Console.WriteLine($"The numbers that add up to {target} are: [{result[0]}, {result[1]}]");

            Console.WriteLine("{0} Complete", nameof(DemoTwoSum));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of LengthOfLongestSubstring, which finds the length of the longest substring without repeating characters.
        /// </summary>
        public static void DemoLengthOfSubstring()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Now Running Demo: {0}", nameof(DemoLengthOfSubstring));

            string input = "abcabcbb";
            int length = WhiteboardSolutions.LengthOfLongestSubstring(input);
            Console.WriteLine($"The length of the longest substring without repeating characters in \"{input}\" is: {length}");

            Console.WriteLine("{0} Complete", nameof(DemoLengthOfSubstring));
            Console.WriteLine("----------");
        }

        /// <summary>
        /// Demonstrates the implementation of LargestRectangleArea, which finds the area of the largest rectangle in a histogram.
        /// </summary>
        public static void DemoLargestRectangle()
        {
            int[] heights = { 2, 1, 5, 6, 2, 3 };
            int maxArea = WhiteboardSolutions.LargestRectangleArea(heights);
            Console.WriteLine("The maximum area of the rectangle in the histogram is: " + maxArea);
        }

        /// <summary>
        /// Demonstrates the CalculateFactorial method, which finds the factorial of a non-negative integer.
        /// </summary>
        public static void DemoFactorial()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 10 };

            foreach (int number in numbers)
            {
                long factorial = WhiteboardSolutions.CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is {factorial}");
            }
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
        #endregion
    }
}
