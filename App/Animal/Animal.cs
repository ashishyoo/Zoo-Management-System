namespace App.Animal;

public abstract class Animal
{
    private string name;
    private string species;
    private int age;

    private string defaultFood;

    protected Animal(string name, string species, int age, string defaultFood)
    {
        this.name = name;
        this.species = species;
        this.age = age;
        this.defaultFood = defaultFood;
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

    public string GetFood()
    {
        return defaultFood;
    }

    public abstract void MakeSound();
    public abstract void Eat(string foodType);
    public abstract void Move();
}