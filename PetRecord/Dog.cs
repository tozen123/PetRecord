
class Dog : Pet
{
    
    public override string GetPetType()
    {
        return "Dog";
    }
    public override string SetBreed(string breed)
    {
        return petBreed = breed;
    }
}