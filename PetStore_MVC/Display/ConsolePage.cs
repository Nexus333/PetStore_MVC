namespace PetStore_MVC.Display;

public abstract class ConsolePage
{
    public string petHeader = "***************************\n\tPet Console\n***************************";
    public abstract ConsolePage display();
    protected string userInput="";

    protected void invalidSelection()
    {
        Console.WriteLine("Please Select a valid option!");
        Thread.Sleep(3000);
        Console.Clear();
        display();
    }

    protected void standardPages()
    {
        Console.WriteLine("H) Return to the Home page");
        Console.WriteLine("V) View Cart");
        Console.WriteLine("QUIT) Exit the Application");
    }

    protected void promptForInput()
    {
        Console.WriteLine("\nSelect an Option > ");
    }

    protected void getUserInput()
    {
        userInput = Console.ReadLine();
    }

    public delegate void exitEventHandler(object pageRef, EventArgs dataReturned);

    public event exitEventHandler quitApp;

    protected virtual void onQuitApp()
    {
        if (quitApp != null)
        {
            quitApp(this, EventArgs.Empty);   
        }
    }
}