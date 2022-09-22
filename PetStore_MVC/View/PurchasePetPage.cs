namespace PetStore_MVC.View;

public class PurchasePetPage : ConsolePage
{
    public override ConsolePage display()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("On the Purchase Pet Page");
        return this;
    }
    
}