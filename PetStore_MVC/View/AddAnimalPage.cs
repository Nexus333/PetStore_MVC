namespace PetStore_MVC.View;

public class AddAnimalPage : ConsolePage
{
    public override ConsolePage display()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("On the Add animal Page");
        Thread.Sleep(3000);
        return this;
    }
}