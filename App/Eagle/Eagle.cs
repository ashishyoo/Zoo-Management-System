namespace App.Eagle;

using App.Animal;

public class Eagle : Animal
{
    public Eagle(string name, string species, int age) : base(name, species, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("The eagle screeches sharply across the sky.");
    }

    public override void Eat(string foodType)
    {
        Console.WriteLine($"The eagle tears into {foodType} with its sharp beak.");
    }

    public override void Move()
    {
        Console.WriteLine("The eagle soars high above, gliding effortlessly on the wind.");
    }
}