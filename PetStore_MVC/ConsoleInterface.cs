using PetStore_MVC.Controller;

public class ConsoleInterface
{
    //Things I can do: 
    //Add pet to inventory
    //schedule pet for service
    //remove pet / purchase
    //filter pets / services? 
    //update pricing
    //keep running total of expenses
    //cancel service
    /*Emit events when option is selected, clear screen*/
    //TODO: Create page class. 


    public static void Main(string[] args)
    {
        PetStoreController psc = new PetStoreController();
        psc.start();
    }
}