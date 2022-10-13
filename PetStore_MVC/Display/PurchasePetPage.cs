namespace PetStore_MVC.Display;

public class PurchasePetPage : ConsolePage
{
    public override ConsolePage display()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("On the Purchase Pet Page");
        return this;
    }
    
}