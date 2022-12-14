namespace PetStore_MVC.Data;

public class AnimalRepository
{
    private Dictionary<string, Animal> animalListByName;
    private List<Animal> animalList;
    
    public AnimalRepository()
    {
        animalListByName = new Dictionary<string, Animal>();
        animalList= new List<Animal>();
    }

    public int getAnimalCount()
    {
        return animalList.Count;
    }
    
    
    public Dictionary<string, Animal> getAnimalList()
    {
        return this.animalListByName;
    }

    public Animal getAnimalByName(string animalName)
    {
        return animalListByName[animalName];
    }

    public void removeAnimalByName(string animalName)
    {
        Animal animalReference = getAnimalByName(animalName);
        animalList.Remove(animalReference);
        animalListByName.Remove(animalName);
    }

    public void AddAnimal(Animal animalToAdd, string animalName)
    {
        animalList.Add(animalToAdd);
        animalListByName.Add(animalName, animalToAdd);
    }

    public void onAnimalCreated(object animalRepo, DataEventArgs dataReceived)
    {
        AddAnimal(dataReceived._animalMade, dataReceived._animalType);
    }

    public void updateAnimal()
    {
        ;
    }

    
}