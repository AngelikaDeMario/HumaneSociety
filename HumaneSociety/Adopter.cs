using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Adopter
    {
        string name;
        int age;
        bool hasDogs;
        bool hasCats;
        bool hasOtherAnimals;
        bool hasKids;
        bool firstTimeOwner;
        public Adopter adopter;
        List<Animal> searchedAnimals;

    }

    public Adopter()
    {
        wallet = 4000.00;
        searchedAnimals = new List<Animal>();

    }
    public void AskForName()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
    }
    
    public void AskForAge()
    {
        Console.WriteLine("What is your age?");
        string inputAge = Console.ReadLine();
    }
}
