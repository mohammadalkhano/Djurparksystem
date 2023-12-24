namespace Djurparksystem;

class Lioncub : Lion
{
    private int months;

    public Lioncub(string _Name, int _Months, int _Age = 0) : base(_Age, _Name)
    {
        Name = _Name;
        months = _Months;
        Favourite_food = "puppy_food";
    }
    /// <summary>
    /// Overrides the Eat method from the base class Animal.
    /// </summary>
    /// <param name="food">The food to eat.</param>
    public override bool Hungry()
    {
        return base.Hungry();
    }
    public override string ToString()
    {
        string hungry = _Hungry ? "Yes" : "No";
        return $"{GetType().Name}: {Name}, Age: {months} months ,Hungrig: {hungry} ,Favorite Food: {Favourite_food}";

    }
}
