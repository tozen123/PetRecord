using System;


namespace PetRecord
{
    class DeletePetRecord
    {
        ShowPetList showPetList;

        public int selectedPet;
        public void Initialize()
        {
            showPetList = new ShowPetList();


            if (isListPopulated() == false)
            {
                Console.WriteLine("There is no pet to be deleted. Please add one first.");
                Console.WriteLine("Press any key to continue...");
                return;
            }


            Console.WriteLine("Select the number to delete.\n");
            DisplayPetListRecords();

            Console.Write("Action: ");
            selectedPet = InputHandler.GetSideInput(Console.ReadLine(), 0, showPetList.GetPetListCount());

            if (selectedPet == -1)
            {
                return;
            }

            RecordDeleter(MainApp.petList[selectedPet]);

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

        public void RecordDeleter(Pet pet)
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to delete the record of " + selectedPet + ". " + pet.PetName + "?");
            MainApp.NewLines();

            Console.Write(selectedPet + ".");
            Console.WriteLine(Space() + "Name: " + pet.PetName);
            Console.WriteLine(Space() + "  Description: " + pet.PetDescription);
            Console.WriteLine(Space() + "  Gender: " + pet.PetGender);
            Console.WriteLine(Space() + "  Breed: " + pet.GetBreed());

            Console.WriteLine();

            MainApp.NewLines();

            Console.WriteLine("Type 'Y' if yes and 'N' if no.");
            Console.Write("Action [Y|N]: ");
            try
            {
                string input = Console.ReadLine();

                if ((input.ToLower().Equals("y") || input.ToLower().Equals("n")) == false)
                {
                    ErrorList.InvalidInputTypeError();
                    return;
                }

                switch (input.ToLower())
                {
                    case "y":
                        Success();
                        MainApp.petList.Remove(pet);
                        break;
                    case "n":
                        Console.WriteLine("\nNo deletion occured.\n");
                        return;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void Success()
        {
            Console.WriteLine("\nSuccessfully deleted!\n");
        }

        public string Space()
        {
            return "     ";
        }
    }
}
