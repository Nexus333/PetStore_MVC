namespace PetStore_MVC.View;

public class ViewCartPage : ConsolePage
{
    public override ConsolePage display()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("On the View Cart Page");
        return this;
    }
}