namespace App.Enclosure;

using App.Animal;

public class Enclosure<T> where T : Animal
{
    private List<T> animalsInEnclosure = new List<T>();

    public void AddAnimal(T animal)
    {
        animalsInEnclosure.Add(animal);
    }

    public void RemoveAnimal(T animal)
    {
        animalsInEnclosure.Remove(animal);
    }

    public void DisplayAnimalsDetails()
    {
        Console.WriteLine();
        foreach (T animal in animalsInEnclosure)
        {
            Console.WriteLine($"Name: {animal.GetName()}");
            Console.WriteLine($"Species: {animal.GetSpecies()}");
            Console.WriteLine($"Age: {animal.GetAge()}");
            animal.MakeSound();
            animal.Eat(animal.GetFood());
            animal.Move();
            Console.WriteLine();
        }
    }

    public string GetAnimalCount()
    {
        Console.WriteLine();
        return $"Total animals in enclosure: {animalsInEnclosure.Count}";
    }

    public void PerformRoutineCheckup()
    {
        Console.WriteLine();
        foreach (T animal in animalsInEnclosure)
        {
            Console.WriteLine($"Performing checkup on {animal.GetName()} the {animal.GetSpecies()}");
        }
    }

    public List<T> GetAnimals()
    {
        Console.WriteLine();
        return animalsInEnclosure;
    }
}