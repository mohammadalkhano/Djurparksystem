namespace Djurparksystem
{
    // Class to represent a zoo staff member.
    public class ZooStaff
    {
        public string Name { get; set; }
        public string PersonalNumber { get; set; }
        public string Password { get; set; }
        public ZooStaff(string name, string personalNumber, string password)
        {
            Name = name;
            PersonalNumber = personalNumber;
            Password = password;
        }
    }
}