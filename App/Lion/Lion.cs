namespace App.Lion;

using App.Animal;

public class Lion : Animal
{
    public Lion(string name, string species, int age) : base(name, species, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("The lion roars with thunderous might.");
    }

    public override void Eat(string foodType)
    {
        Console.WriteLine($"The lion devours the {foodType} with primal intensity.");
    }

    public override void Move()
    {
        Console.WriteLine("The lion prowls through the grass with stealth and power.");
    }
}