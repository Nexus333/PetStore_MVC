namespace PetStore_MVC.View;

public class AddAnimalPage : ConsolePage
{
    public override void display()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("On the Add animal Page");
        Thread.Sleep(3000);
    }
}