using System;


namespace PetRecord
{
    class InputHandler
    {
        ShowPetList showPetList;
        AddNewPet addNewPet;
        UpdatePetRecord updatePetRecord;
        DeletePetRecord deletePetRecord;

        public void Initialized()
        {
            showPetList = new ShowPetList();
            addNewPet = new AddNewPet();
            updatePetRecord = new UpdatePetRecord();
            deletePetRecord = new DeletePetRecord();
        }

        public void GetMainInput(string inputNumber)
        {
            try
            {

                bool isInputValid = ValidateInput(inputNumber, 1, 4);

                if(isInputValid == false)
                {
                    Console.WriteLine("Press any key to continue...");
                    return;
                }

                Console.Clear();
                Console.WriteLine("\n");

                switch (int.Parse(inputNumber))
                {
                    case 1:
                        showPetList.GetPetList();
                        break;
                    case 2:
                        addNewPet.SetNewPet();
                        break;
                    case 3:
                        updatePetRecord.Initialize();
                        break;
                    case 4:
                        deletePetRecord.Initialize();
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int GetSideInput(string inputNumber, int min, int max)
        {
            bool isInputValid = InputHandler.ValidateInput(inputNumber, min, max);

            if (isInputValid == false)
            {
                Console.WriteLine("Press any key to continue...");
                return -1;
            }

            return int.Parse(inputNumber);
        }

        public static bool ValidateInput(string input, int min, int max)
        {
            int inputNumber;

            bool isSuccess = int.TryParse(input, out inputNumber);

            if (isSuccess != true)
            {
                ErrorList.InvalidInputTypeError();
                return false;
            }

            while (inputNumber < min || inputNumber > max)
            {
                ErrorList.InvalidInputError();
                return false;
            }
            return true;
        }

        
    }
}
