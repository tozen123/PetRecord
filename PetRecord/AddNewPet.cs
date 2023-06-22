using System;


namespace PetRecord
{
    class AddNewPet
    {
        public void SetNewPet()
        {
            SelectType();
        }

        public void SelectType()
        {
            Console.WriteLine("Select Pet Type");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");

            Console.Write("\nAction: ");
            switch (InputHandler.GetSideInput(Console.ReadLine(), 1, 2))
            {
                case 0:
                    return;
                case 1:
                    RecordForm(new Dog());
                    break;
                case 2:
                    RecordForm(new Cat());
                    break;
            }
        }

        public void RecordForm(Pet newPet)
        {
            MainApp.NewLines();
            Console.WriteLine("Add New " + newPet.GetPetType());

            Console.Write("Name: ");
            newPet.PetName = Console.ReadLine();

            Console.Write("Description: ");
            newPet.PetDescription = Console.ReadLine();

            Console.Write("Gender: ");
            newPet.PetGender = Console.ReadLine();

            Console.Write("Breed: ");
            newPet.SetBreed(Console.ReadLine());

            Success();
            MainApp.petList.Add(newPet);
        }

       
        public void Success()
        {
            Console.WriteLine("\nSuccessfully added new pet!\n");
        }
    }
}
