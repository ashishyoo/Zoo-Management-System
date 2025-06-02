namespace App.ZooKeeper;

using App.Animal;
using App.Enclosure;


public class ZooKeeper
{
    public void FeedAnimalInEnclosure<T>(Enclosure<T> enclosure, string food) where T : Animal
    {
        foreach (T animal in enclosure.GetAnimals())
        {
            animal.Eat(food);
        }
    }

    public void TriggerSoundsInEnclosure<T>(Enclosure<T> enclosure) where T : Animal
    {
        foreach (T animal in enclosure.GetAnimals())
        {
            animal.MakeSound();
        }
    }

    public void ObserveMotionsInEnclosure<T>(Enclosure<T> enclosure) where T : Animal
    {
        foreach (T animal in enclosure.GetAnimals())
        {
            animal.Move();
        }
    }
}