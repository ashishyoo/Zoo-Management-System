using App.Anaconda;
using App.Animal;
using App.Eagle;
using App.Enclosure;
using App.Lion;
using App.Zebra;
using App.ZooKeeper;

class Program
{
    static void Main(String[] args)
    {
        Lion lion1 = new Lion("Aaron", "Lion", 22);
        Lion lion2 = new Lion("Baron", "Lion", 32);
        Lion lion3 = new Lion("Caron", "Lion", 42);

        Enclosure<Lion> lionLand = new Enclosure<Lion>();

        lionLand.AddAnimal(lion1);
        lionLand.AddAnimal(lion2);
        lionLand.AddAnimal(lion3);
        lionLand.DisplayAnimalsDetails();
        lionLand.PerformRoutineCheckup();
        Console.WriteLine(lionLand.GetAnimalCount());

        ZooKeeper admin1 = new ZooKeeper();
        admin1.FeedAnimalInEnclosure(lionLand, "mutton");
        admin1.TriggerSoundsInEnclosure(lionLand);
        admin1.ObserveMotionsInEnclosure(lionLand);

        Lion lion = new Lion("Leo", "Lion", 30);
        Zebra zebra = new Zebra("Zerren", "Zebra", 32);
        Eagle eagle = new Eagle("Erry", "Eagle", 42);
        Anaconda anaconda = new Anaconda("Arr", "Anaconda", 42);

        Enclosure<Animal> mixedHabitat = new Enclosure<Animal>();

        mixedHabitat.AddAnimal(lion);
        mixedHabitat.AddAnimal(zebra);
        mixedHabitat.AddAnimal(eagle);
        mixedHabitat.AddAnimal(anaconda);

        mixedHabitat.DisplayAnimalsDetails();
        mixedHabitat.PerformRoutineCheckup();
        Console.WriteLine(mixedHabitat.GetAnimalCount());

        ZooKeeper admin2 = new ZooKeeper();
        admin2.FeedAnimalInEnclosure(mixedHabitat, "water");
        admin2.TriggerSoundsInEnclosure(mixedHabitat);
        admin2.ObserveMotionsInEnclosure(mixedHabitat);
    }
}