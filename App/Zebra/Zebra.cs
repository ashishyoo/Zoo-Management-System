namespace App.Zebra;

using App.Animal;

public class Zebra : Animal
{
    public Zebra(string name, string species, int age) : base(name, species, age, "grass") { }

    public override void MakeSound()
    {
        Console.WriteLine($"The {this.GetName()} whinnies softly.");
    }

    public override void Eat(string foodType)
    {
        Console.WriteLine($"The {this.GetName()} grazes calmly on the {foodType}.");
    }

    public override void Move()
    {
        Console.WriteLine($"The {this.GetName()} gallops gracefully across the plain.");
    }
}