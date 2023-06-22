using System;


namespace PetRecord
{
    class UpdatePetRecord
    {
        ShowPetList showPetList;

        public int selectedPet;
        public void Initialize()
        {
            showPetList = new ShowPetList();


            if (isListPopulated() == false)
            {
                Console.WriteLine("There is no pet to be updated. Please add one first.");
                Console.WriteLine("Press any key to continue...");
                return;
            }


            Console.WriteLine("Select the number to update its record.\n");

            DisplayPetListRecords();

            Console.Write("Action: ");

            selectedPet = InputHandler.GetSideInput(Console.ReadLine(), 0, showPetList.GetPetListCount());
            if(selectedPet == -1)
            { 
                return;
            }
            RecordEditor(MainApp.petList[selectedPet]);
        }

        public void DisplayPetListRecords()
        {
            Console.Write("Pet List\n");
            MainApp.NewLines();
            showPetList.DisplayPetList();
            MainApp.NewLines(); 
        }

        public bool isListPopulated()
        {
            if (showPetList.GetPetListCount() >= 1)
            {
                return true;
            }
            return false;
        }

        public void RecordEditor(Pet pet)
        {
            Console.Clear();
            Console.WriteLine("You're now currently editing the record of " + selectedPet + ". " +pet.PetName);
            MainApp.NewLines();

            Console.Write("Name: ");
            pet.PetName = Console.ReadLine();

            Console.Write("Description: ");
            pet.PetDescription = Console.ReadLine();

            Console.Write("Gender: ");
            pet.PetGender = Console.ReadLine();

            Console.Write("Breed: ");
            pet.SetBreed(Console.ReadLine());

            
            MainApp.NewLines();
            Success();
        }

        public void Success()
        {
            Console.WriteLine("\nSuccessfully edited!\n");
        }
    }
}
