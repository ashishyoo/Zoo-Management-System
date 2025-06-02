namespace App.Lion;

using App.Animal;

public class Lion : Animal
{
    public Lion(string name, string species, int age) : base(name, species, age, "meat") { }

    public override void MakeSound()
    {
        Console.WriteLine($"The {this.GetName()} roars with thunderous might.");
    }

    public override void Eat(string foodType)
    {
        Console.WriteLine($"The {this.GetName()} devours the {foodType} with primal intensity.");
    }

    public override void Move()
    {
        Console.WriteLine($"The {this.GetName()} prowls through the grass with stealth and power.");
    }
}