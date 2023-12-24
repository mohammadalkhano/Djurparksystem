
namespace Djurparksystem;
public class Ball
{
    // Gets or sets the color of the ball.
    public string Color { get; set; }
    // Gets or sets the quality of the ball.
    private int Quality { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Ball"/> class with the specified color and quality.
    /// </summary>
    /// <param name="color">The color of the ball.</param>
    /// <param name="quality">The initial quality of the ball.</param>
    public Ball(string color, int quality)
    {
        Color = color;
        Quality = quality;
    }
    /// <summary>
    /// Reduces the quality of the ball based on the specified damage.
    /// </summary>
    /// <param name="damage">The amount of damage to apply to the ball's quality.</param>
    public void LowerQuality(int damage)
    {
        // Check if the ball's quality is already at or below zero.
        if (Quality <= 0)
        {
            Console.WriteLine($"Bollen har skadats, det går inte att leka med den!");
        }
        // Decrease the quality of the ball by the specified damage.
        Quality -= damage;
        Console.WriteLine($"Bollen har skadats och kvaliteten har sänkts till {Quality}.");
    }
}
