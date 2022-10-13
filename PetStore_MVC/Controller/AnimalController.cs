using PetStore_MVC.Data;

namespace PetStore_MVC.Controller;


//Acts as an interface between the display and the model. 
public class AnimalController : psController
{
    private AnimalFactory animalFarm;
    private AnimalRepository animalRepo;

    public AnimalController()
    {
        animalFarm = new AnimalFactory();
        animalRepo = new AnimalRepository();
        animalFarm.animalBirth += animalRepo.onAnimalCreated;
    }
    
    //create a new Animal of Type X
    // fetch the current inventory of Animals 
    // get All animals of type x 
    
    public delegate void createAnimalEventHandler(object animalCtrl, EventArgs dataReturned);

    public event createAnimalEventHandler animalProcessing;

    protected virtual void onAnimalProcessing()
    {
        if (animalProcessing != null)
        {
            animalProcessing(this, EventArgs.Empty);   
        }
    }
}