namespace Djurparksystem;

public class Wolf : Animal
{
    public Wolf(int age, string name) : base(age, name)
    {
    }
    public override bool Hungry()
    {
        return base.Hungry();
    }
    public override void Eat(string food)
    {
        Console.WriteLine(Name + " eats " + food + ".");
    }

    public override void Interact()
    {
        Console.WriteLine(Name + " howls.");
    }

    public override string ToString()
    {
        return Name + " (Wolf)";
    }
}
