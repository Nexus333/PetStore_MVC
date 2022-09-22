namespace PetStore_MVC.View;

public class SearchPetsPage : ConsolePage
{
    public override ConsolePage display()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("On search Pet Page");
        return this;
    }
}