namespace App.Animal;

public abstract class Animal
{
    private string name;
    private string species;
    private int age;

    protected Animal(string name, string species, int age)
    {
        this.name = name;
        this.species = species;
        this.age = age;
    }

    public string GetName()
    {
        return name;
    }

    public string GetSpecies()
    {
        return species;
    }

    public int GetAge()
    {
        return age;
    }

    public abstract void MakeSound();
    public abstract void Eat(string foodType);
    public abstract void Move();
}