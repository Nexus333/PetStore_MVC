namespace PetStore_MVC.Display;

public class CheckoutPage : ConsolePage
{
    public override ConsolePage display()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("On the Checkout Page");
        return this;
    }
}