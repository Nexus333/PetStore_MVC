namespace PetStore_MVC.Data;

/*Data Model
 { string name, string age, string price, string breed, string breed/type, string markings  }
 
 */

public class AnimalFactory
{
    public Animal? makeAnimal(string animalType, List<string> animalAttributes)
    {
        Animal animalResult;

        switch (animalType.ToLower())
        {
            case "cat":
                animalResult = new Cat(animalAttributes);
                onAnimalBirth(animalResult, "cat");
                break;
            case "dog":
                animalResult = new Dog(animalAttributes);
                onAnimalBirth(animalResult, "dog");
                break;
            case "rodent":
                animalResult = new Rodent(animalAttributes);
                onAnimalBirth(animalResult, "rodent");
                break;
            default:
                Console.WriteLine($"Unable to create animal of type: {animalType}");
                return null;
        }
        
        return animalResult;
    }
    
    public delegate void makeAnimalEventHandler(object animalFactory, DataEventArgs dataReturned);

    public event makeAnimalEventHandler animalBirth;

    protected virtual void onAnimalBirth(Animal brandNewAnimal, string animalType)
    {
        DataEventArgs d = new DataEventArgs();
        d._animalMade = brandNewAnimal;
        d._animalType = animalType;
        if (animalBirth != null)
        {
            animalBirth(this,d);   
        }
    }
}