using System;
using System.Linq;

namespace PetRecord
{
    class ShowPetList
    {
        public void GetPetList()
        {
            
            Console.Write("Pet List\n");
            MainApp.NewLines();

            DisplayPetList();

            MainApp.NewLines();
            Console.Write("Press any key to continue...");
        }

        public int GetPetListCount()
        {
            return MainApp.petList.Count();
        }

        public void DisplayPetList()
        {
            int count = -1;
            foreach (Pet pet in MainApp.petList)
            {
                count++;
                Console.Write(count + ".");
                Console.WriteLine(Space() + "Name: " + pet.PetName);
                Console.WriteLine(Space() + "  Description: " + pet.PetDescription);
                Console.WriteLine(Space() + "  Gender: " + pet.PetGender);
                Console.WriteLine(Space() + "  Breed: " + pet.GetBreed());

                Console.WriteLine();
            }
        }

        public string Space()
        {
            return "     ";
        }
    }
}
