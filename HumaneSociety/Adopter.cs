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
        int x;
        Console.WriteLine("What is your age?");
        string inputAge = Console.ReadLine();
        while (true)
        {
            if (Int32.TryParse(inputAge, out x))
            {
                age = x;
                break;
            }
            else
            {
                Console.WriteLine("Write your name in integer format.");
                inputAge = Console.ReadLine();
            }
        }
    }
    public void GetDogInformation()
    {
        Console.WriteLine("Do you have dogs in your household?");
        string yesOrNo = Console.ReadLine();
        yesOrNo = CheckYesOrNo(yesOrNo);
        if (yesOrNo == "yes")
        {
            hasDogs = true;
        }
        else
        {
            hasDogs = false;
        }
    }
    public void GetCatInformation()
    {
        Console.WriteLine("Do you have any cats in your household?");
        string yesOrNo = Console.ReadLine();
        yesOrNo = CheckYesOrNo(yesOrNo);
        if (yesOrNo == "yes")
        {
            hasCats = true;
        }
        else
        {
            hasCats = false;
        }
    }
    public void GetChildrenInformation()
    {
        Console.WriteLine("Do you have children in your household?");
        string yesOrNo = Console.ReadLine();
        yesOrNo = CheckYesOrNo(yesOrNo);
        if (hasKids == "yes")
        {
            hasKids = true;
        }
        else
        {
            hasKids = false;
        }
    }

    public void CheckOtherAnimalInformation()
    {
        Console.WriteLine("Is there any animals you own in your household?");
        string yesOrNo = Console.ReadLine();
        yesOrNo = CheckYesOrNo(yesOrNo);
        if (hasOtherAnimals == "yes")
        {
            hasOtherAnimals = true;

        }
        else
        {
            hasOtherAnimals = false;
        }
    }

    public void CheckFirstTimeOwnerStatus()
    {
        Console.WriteLine("Is this your first time owning a pet?");
        string yesOrNo = Console.ReadLine();
        yesOrNo = CheckYesOrNo(yesOrNo);
        if (firstTimeOwner == "yes")
        {
            firstTimeOwner = true;
        }
        else
        {
            firstTimeOwner = false;
        }
    }
    private string CheckYesOrNo(string yesOrNo)
    {

    }







}
