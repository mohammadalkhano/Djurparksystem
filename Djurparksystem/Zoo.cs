
namespace Djurparksystem;

public class Zoo
{
    protected int OpeningHour { get; set; } = 10;
    protected int Price { get; set; }
    private List<Animal> animals;
    private List<Visitor> visitors;
    private List<ZooStaff> staff;

    public Zoo(int openingHour, int price)
    {
        OpeningHour = openingHour;
        Price = price;
        animals = new List<Animal>();
        visitors = new List<Visitor>();
        staff = new List<ZooStaff>();
        //  Creating 4 object of animals and put them in list.
        animals.Add(new Lion(5, "Liofido"));
    }
    /// <summary>
    /// Adds new animal. 
    /// </summary>
    /// <param name="animal"></param>
    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }
    /// <summary>
    /// Display visitors list.
    /// </summary>
    public void DisplayVisitors()
    {
        if (visitors.Any())
        {
            Console.WriteLine("Visitors list: ");
            foreach (var visitor in visitors)
            {
                Console.WriteLine(visitor.ToString());
            }
            return;
        }
        Console.WriteLine("There is no visitor in the zoo right now!.\n");
    }
    /// <summary>
    /// Adds new visitor.
    /// </summary>
    /// <param name="visitor"></param>
    public void AddVisitor(Visitor visitor)
    {
        visitors.Add(visitor);
    }
    /// <summary>
    /// Adds new staff member.
    /// </summary>
    /// <param name="staffMember"></param>
    public void AddStaff(ZooStaff staffMember)
    {
        staff.Add(staffMember);
    }
    /// <summary>
    /// Displays animals info list.
    /// </summary>
    public void DisplayAnimalInformation()
    {
        Console.WriteLine("Animals in the zoo:");
        if (animals.Any())
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
            return;
        }
        Console.WriteLine("There is no animal in the zoo to see.\n");
    }
    internal IEnumerable<Animal> GetAnimals()
    {
        return animals;
    }
    /// <summary>
    /// Sells new ticket.
    /// </summary>
    /// <param name="visitor"></param>
    public void SellTicket(Visitor visitor)
    {
        visitor.HasTicket = true;
        Console.WriteLine($"Ticket sold to {visitor.Name} for {visitor.TicketPrice} Kr");
    }
    /// <summary>
    /// Overrides To String method.
    /// </summary>
    /// <returns>Zoo info ()</returns>
    public override string ToString()
    {
        string zooInfo = "Zoo:\n";
        zooInfo += "Opening hours: ";
        zooInfo += "Friday - Sunday " + OpeningHour + "\n";
        zooInfo += "Location: Bergspromenaden, 413 11 Göteborg\n";
        zooInfo += "Price: " + Price + " Kr" + "\n";
        return zooInfo;
    }

}
