namespace PetStore_MVC.View;

public abstract class ConsolePage
{
    public string petHeader = "***************************\n\tPet Console\n***************************";
    public abstract ConsolePage display();

    public void quitApp()
    {
        
    }
}