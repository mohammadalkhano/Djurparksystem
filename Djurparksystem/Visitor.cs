namespace Djurparksystem
{
    /// <summary>
    /// Class represents a visitor.
    /// </summary>
    public class Visitor
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public bool HasTicket { get; set; } = false;
        public decimal TicketPrice { get; set; }
        public Visitor(string name, int age, bool hasTicket, decimal ticketPrice)
        {
            Name = name;
            Age = age;
            HasTicket = hasTicket;
            TicketPrice = ticketPrice;
        }
        public override string ToString()
        {
            string hasTicket = HasTicket ? "Active" : "No";
            return $"Name: {Name}, Age: {Age}, Has {hasTicket} ticket.";

        }
    }
}