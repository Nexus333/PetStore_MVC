namespace PetStore_MVC.Data.Tests;

public class MockAnimalListener
{
    private Animal animalDetails;
    private string animalType;

    public void onAnimalCreation(object animalListener, DataEventArgs dataReceived)
    {
        animalDetails = dataReceived._animalMade;
        animalType = dataReceived._animalType;
    }

    public Animal getAnimalDetails()
    {
        return animalDetails;
    }

    public string getAnimalType()
    {
        return animalType;
    }
}