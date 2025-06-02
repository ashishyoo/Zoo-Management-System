namespace App.Anaconda;

using App.Animal;

public class Anaconda : Animal
{
    public Anaconda(string name, string species, int age) : base(name, species, age, "egg") { }

    public override void MakeSound()
    {
        Console.WriteLine($"The {this.GetName()} hisses quietly.");
    }

    public override void Eat(string foodType)
    {
        Console.WriteLine($"The {this.GetName()} constricts {foodType} and swallows it whole.");
    }

    public override void Move()
    {
        Console.WriteLine($"The {this.GetName()} slithers slowly and silently through the underbrush.");
    }
}