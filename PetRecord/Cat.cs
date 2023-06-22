
class Cat : Pet
{

    public override string GetPetType()
    {
        return "Cat";
    }

    public override string SetBreed(string breed)
    {
        return petBreed = breed;
    }

} 
