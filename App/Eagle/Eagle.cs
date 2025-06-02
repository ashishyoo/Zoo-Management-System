namespace App.Eagle;

using App.Animal;

public class Eagle : Animal
{
    public Eagle(string name, string species, int age) : base(name, species, age, "fish") { }

    public override void MakeSound()
    {
        Console.WriteLine($"The {this.GetName()} screeches sharply across the sky.");
    }

    public override void Eat(string foodType)
    {
        Console.WriteLine($"The {this.GetName()} tears into {foodType} with its sharp beak.");
    }

    public override void Move()
    {
        Console.WriteLine($"The {this.GetName()} soars high above, gliding effortlessly on the wind.");
    }
}