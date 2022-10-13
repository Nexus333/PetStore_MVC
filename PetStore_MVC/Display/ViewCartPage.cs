namespace PetStore_MVC.Display;

public class ViewCartPage : ConsolePage
{
    public override ConsolePage display()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("On the View Cart Page");
        return this;
    }
}