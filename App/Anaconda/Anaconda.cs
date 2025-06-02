namespace App.Anaconda;

using App.Animal;

public class Anaconda : Animal
{
    public Anaconda(string name, string species, int age) : base(name, species, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("The anaconda hisses quietly.");
    }

    public override void Eat(string foodType)
    {
        Console.WriteLine($"The anaconda constricts {foodType} and swallows it whole.");
    }

    public override void Move()
    {
        Console.WriteLine("The anaconda slithers slowly and silently through the underbrush.");
    }
}