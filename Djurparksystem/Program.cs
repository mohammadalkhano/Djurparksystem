
namespace Djurparksystem;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Uppdrag 5: Redovisa, dokumentera och utvärdera";
        var zoo = new StartUpZoo();
        zoo.Run();

        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
public class StartUpZoo
{
    //private Animal[] djur = new Animal[4];
    //private Ball[] balls = new Ball[3];
    private Zoo _zoo;
    /// <summary>
    /// Initializes a new instance of the <see cref="Petowner"/> class with default animals and balls.
    /// </summary>
    public StartUpZoo()
    {
        _zoo = new Zoo(11, 149);
        // Creating 3 object of ball and put them in list.
        //balls = new Ball[]
        //{
        //    new Ball("Red", 20),
        //    new Ball("Blue", 20),
        //    new Ball("Green", 20),
        //};
    }
    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Welcome to Djurify Zoo!\n");
            Console.WriteLine("1. Enter 1 to navigate to staff menu");
            Console.WriteLine("2. Enter 2 to navigate to visitor menu");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option (1-3): ");
            // Prompt the user to select an option
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    //navigate as staff member.
                    StaffMemberMenu();
                    break;
                case "2":
                    RunUserMenu();
                    break;
                case "3":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    break;
            }
        }
    }
    /// <summary>
    /// Display staff menu.
    /// </summary>
    public void StaffMemberMenu()
    {
        while (true)
        {
            Console.WriteLine("Welcome to Djurify Staff Menu!\n");
            Console.WriteLine("1. Sell Ticket");
            Console.WriteLine("2. Navigate as visitor");
            Console.WriteLine("3. Add new animal");
            Console.WriteLine("4. Add new staff member");
            Console.WriteLine("5. See visitors list in the zoo");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option (1-6): ");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    SellTicket();
                    break;
                case "2":
                    RunUserMenu();
                    break;
                case "3":
                    AddAnimal();
                    Console.WriteLine($"The animal was added successfuly.\n");
                    break;
                case "4":
                    AddStaffMember();
                    Console.WriteLine($"The member was added successfuly.\n");
                    break;
                case "5":
                    PrintVisitorsList();
                    break;
                case "6":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
    /// <summary>
    /// Display user(visitor) menu.
    /// </summary>
    public void RunUserMenu()
    {
        while (true)
        {
            // Display the menu options
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. See Opening Hour");
            Console.WriteLine("2. See animals and its info");
            Console.WriteLine("3. Feed animal");
            Console.WriteLine("4. Play with Animals");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");
            // Prompt the user to select an option
            string userChoice = Console.ReadLine();
            // Handle the user's choice
            switch (userChoice)
            {
                case "1":
                    PrintOpeningHours();
                    break;
                case "2":
                    PrintAnimals();
                    break;
                case "3":
                    Feed();
                    break;
                case "4":
                    Play();
                    break;
                case "5":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
    /// <summary>
    /// Adds new animal to the zoo.
    /// </summary>
    private void AddAnimal()
    {
        //Puppy, Lion and Wolf.
        Console.WriteLine("1. Puppy");
        Console.WriteLine("2. Lion");
        Console.WriteLine("3. Wolf");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option (1-4): ");
        // Prompt the user to select an option
        string userChoice = Console.ReadLine();

        Console.Write("Add animal name: ");
        var name = Console.ReadLine();
        Console.Write("Add animal age: ");
        var age = int.Parse(Console.ReadLine());
        if (!string.IsNullOrEmpty(name) && age > 0)
        {
            while (true)
            {
                switch (userChoice)
                {
                    case "1":
                        var puppy = new Lioncub(name, age);
                        _zoo.AddAnimal(puppy);
                        return;
                    case "2":
                        var animal = new Lion(age, name);
                        _zoo.AddAnimal(animal);
                        return;
                    case "3":
                        var wolf = new Wolf(age, name);
                        _zoo.AddAnimal(wolf);
                        return;
                    case "4":
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;

                }
            }
        }
        Console.WriteLine("Invalid input! Please make sure that you enter animal name and age correct.");
    }
    /// <summary>
    /// Adds new staff member.
    /// </summary>
    private void AddStaffMember()
    {
        // Prompt the user input
        Console.Write("Enter personal name: ");
        string memberName = Console.ReadLine();
        Console.Write("Enter personal ID: ");
        string memberId = Console.ReadLine();
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();
        if (!string.IsNullOrEmpty(memberName) && !string.IsNullOrEmpty(password))
        {
            var staffMember = new ZooStaff(memberName, memberId, password);
            _zoo.AddStaff(staffMember);
            return;
        }
        Console.WriteLine("Invalid input. Please enter your name and password.");
    }
    /// <summary>
    /// Prints visitors list.
    /// </summary>
    private void PrintVisitorsList()
    {
        _zoo.DisplayVisitors();
    }
    /// <summary>
    /// Sell ticket.
    /// </summary>
    private void SellTicket()
    {
        // Prompt the user input
        Console.Write("Enter visitor name: ");
        string visitorName = Console.ReadLine();
        Console.Write("Enter visitor age: ");
        int visitorAge = int.Parse(Console.ReadLine());
        var visitor = new Visitor(visitorName, visitorAge, true, 149);
        if (!string.IsNullOrEmpty(visitorName))
        {
            _zoo.AddVisitor(visitor);
            _zoo.SellTicket(visitor);
            return;
        }
        Console.WriteLine("Invalid input.");
    }
    /// <summary>
    /// Prints Zoo info.
    /// </summary>
    private void PrintOpeningHours()
    {
        Console.WriteLine(_zoo.ToString());
    }
    /// <summary>
    /// Prints information about all existing animals.
    /// </summary>
    private void PrintAnimals()
    {
        Console.WriteLine("\nList of Animals:");
        // Call Display animal info.
        _zoo.DisplayAnimalInformation();

    }
    /// <summary>
    /// Feeds all existing animals with the specified food.
    /// </summary>
    private void Feed()
    {
        Console.Write("\nEnter the food to feed: ");
        string food = Console.ReadLine();
        // Iterate through the list of animals

        foreach (var animal in _zoo.GetAnimals())
        {
            // Check if the animal exists and the food is not empty or null
            if (animal != null && !string.IsNullOrEmpty(food))
            {
                // Feed the animal with the specified food
                animal.Eat(food);
            }
            else
            {
                // Inform the user that there is no food or animal
                Console.WriteLine($"Du har ingen mat eller djur");
            }
        }
    }
    /// <summary>
    /// Plays with all existing animals using a ball of a specified color.
    /// </summary>
    private void Play()
    {
        Console.Write($"\nEnter a ball color for an animal to interact with: ");
        string color = Console.ReadLine();
        // Iterate through the list of animals.
        foreach (var animal in _zoo.GetAnimals())
        {
            // Check if the animal exists and the color is not empty or null
            if (animal != null && !string.IsNullOrEmpty(color))
            {
                // Let the animal interact with the ball.
                animal.Interact();
            }
        }
    }

}
