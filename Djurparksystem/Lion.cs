namespace Djurparksystem;
public class Lion : Animal
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Lion"/> class with the specified age and name.
    /// </summary>
    /// <param name="_Age">The age of the lion.</param>
    /// <param name="_Name">The name of the lion.</param>
    public Lion(int _Age, string _Name) : base(_Age, _Name)
    {
        // Setting properties in the constructor
        Name = _Name;
        Age = _Age;
        _Hungry = false;
        Favourite_food = "meat";
        FavouriteColor = "Green";
    }

    /// <summary>
    /// Overrides the hungry method from the base class Animal.
    /// </summary>
    /// <param name="food">The food to eat.</param>
    public override bool Hungry()
    {
        return base.Hungry();
    }
}

