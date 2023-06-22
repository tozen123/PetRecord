using System;
using System.Collections.Generic;



// PetRecord is a Desktop Application written in C# featuring CRUD functionality.

namespace PetRecord
{
    // ShowPetList.cs - handles the retrieving and viewing of pet list.
    // AddNewPet.cs - handles creating new pet.
    // UpdatePetRecord.cs - handles editing information of the pet.
    // DeletePetRecord.cs - handles deleting record of specific pet.

    // Dog.cs and Cat.cs inherits Pet.cs

    // InputHandler.cs - handles user inputs 
    // ErrorList.cs - handles list of error prompts

    class MainApp
    {
        public static List<Pet> petList = new List<Pet>(); // List that contains all the pet object
        static void Main(string[] args)
        {
            //Debugging Method: Uncomment this method to add handfull of entries
            AddEntries();

            InputHandler inputHandler = new InputHandler();
            inputHandler.Initialized();

            while (true)
            {
                Console.Clear();

                DisplayMenu();
                Console.Write("Action: ");
                inputHandler.GetMainInput(Console.ReadLine());

                Console.ReadKey();
            }
            
        }

        public static void DisplayMenu()
        {
            NewLines();
            Console.WriteLine("PetRecord App");
            NewLines();

            Console.WriteLine("1. Show Pet List");
            Console.WriteLine("2. Add New Pet");
            Console.WriteLine("3. Update Pet Record");
            Console.WriteLine("4. Delete Pet Record");
            NewLines();
        }

        public static void NewLines()
        {
            Console.WriteLine("\n--------------------\n");
        }

        // Debug: method for adding entries

        public static void AddEntries()
        {
            Dog dog1 = new Dog();
            dog1.PetName = "Labby";
            dog1.PetDescription = "Brown, Big";
            dog1.PetGender = "Male";
            dog1.SetBreed("Labrador");

            Dog dog2 = new Dog();
            dog2.PetName = "Brownie";
            dog2.PetDescription = "Brown, Small";
            dog2.PetGender = "Male";
            dog2.SetBreed("Askal");

            Dog dog3 = new Dog();
            dog3.PetName = "Blackie";
            dog3.PetDescription = "Black with White spots";
            dog3.PetGender = "Female";
            dog3.SetBreed("Askal");

            Cat cat1 = new Cat();
            cat1.PetName = "MingMing";
            cat1.PetDescription = "Brown";
            cat1.PetGender = "Female";
            cat1.SetBreed("Persian");

            petList.Add(dog1);
            petList.Add(dog2);
            petList.Add(dog3);
            petList.Add(cat1);
        }
    }
}
