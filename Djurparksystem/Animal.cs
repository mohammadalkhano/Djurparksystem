namespace Djurparksystem;
public abstract class Animal
{
    protected int Age;
    protected string Name;
    protected bool _Hungry { get; set; } = false;
    protected string Favourite_food;
    protected string FavouriteColor;
    protected Animal(int _Age, string _Name)
    {
        Age = _Age;
        Name = _Name;
        _Hungry = false;
        Favourite_food = "Hamburgare";
    }
    /// <summary>
    /// Allows the animal to eat the specified food, updating its hunger status.
    /// </summary>
    /// <param name="food">The food to eat.</param>
    public virtual void Eat(string food)
    {
        if (_Hungry)
        {
            if (Favourite_food == food)
            {
                Console.WriteLine($"Djuret är mätt och belåten!..Tack för maten");
                _Hungry = false;
                return;
            }
            else
            {
                Console.WriteLine($"Djuret gillar inte denna mat.):");
                _Hungry = true;
                return;
            }
        }
        Console.WriteLine("Djuret är mätt");
        return;
    }
    /// <summary>
    /// Sets the animal to hungry.
    /// </summary>
    /// <returns></returns>
    public virtual bool Hungry()
    {
        _Hungry = true;
        return _Hungry;
    }
    /// <summary>
    /// Allows the animal to interact in a generic way, e.g., wagging its tail.
    /// </summary>
    public virtual void Interact()
    {
        Console.WriteLine("Djuret viftar glatt på svansen");
        _Hungry = true;
    }
    public override string ToString()
    {
        string hungry = _Hungry ? "Yes" : "No";
        return $"{GetType().Name}: {Name}, Age: {Age},Hungrig: {hungry} ,Favorite Food: {Favourite_food}";

    }

}
