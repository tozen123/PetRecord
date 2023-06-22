
class Pet
{
    string petName;
    string petDescription;
    public string petBreed;
    string petGender;

    public string PetName { get => petName; set => petName = value; }
    public string PetDescription { get => petDescription; set => petDescription = value; }
    public string PetGender { get => petGender; set => petGender = value; }

    public virtual string SetBreed(string breed)
    {
        return "Unknown";
    }

    public virtual string GetPetType()
    {
        return "Unknown";
    }

    public string GetBreed()
    {
        if(petBreed == null)
        {
            return "Unknown";
        }

        return petBreed;
    }
}