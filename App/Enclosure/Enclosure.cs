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
            if (animal.GetSpecies().ToLower() == "lion")
            {
                Console.WriteLine(@"
                             ,%%%%%%%%,
                           ,%%/\%%%%/\%%
                          ,%%%\c "" J/%%%
                 %.       %%%%/ o  o \%%%
                 `%%.     %%%%    _  |%%%
                  `%%     `%%%%(__Y__)%%'
                  //       ;%%%%`\-/%%%'
                 ((       /  `%%%%%%%'
                  \\    .'          |
                   \\  /       \  | |
                    \\/         ) | |
                     \         /_ | |__
                     (___________)))))))
                ");
            }
            else if (animal.GetSpecies().ToLower() == "zebra")
            {
                Console.WriteLine(@"
                    \\/),
                   ,'.' /,
                  (_)- / /,
                     /\_/ |__..--,  *
                    (\___/\ \ \ / ).'
                     \____/ / (_ //
                      \\_ ,'--'\_(
                      )_)_/ )_/ )_)
                     (_(_.'(_.'(_.'
                ");
            }
            else if (animal.GetSpecies().ToLower() == "eagle")
            {
                Console.WriteLine(@"
                        .~~~~-.
                       /    ,__`)
                      |      \o/|'-.
                      |         /  ,\
                      |        ('--./
                      /         \
                     /  ,  ,  ,  \
                     `--'--'--'--'                
                ");
            }
            else if (animal.GetSpecies().ToLower() == "anaconda")
            {
                Console.WriteLine(@"
                                    __    
                       /  \  /  \  /  \  /  \
                 _____/  __\/  __\/  __\/  __\__________
                 ____/  /__/  /__/  /__/  /_____________
                     | / \   / \   / \   / \  \____
                     |/   \_/   \_/   \_/   \    o \
                                             \_____/--<
                    ");
            }
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