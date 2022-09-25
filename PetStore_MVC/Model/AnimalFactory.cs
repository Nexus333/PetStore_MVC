namespace PetStore_MVC.Model;

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
                break;
            case "dog":
                animalResult = new Dog(animalAttributes);
                break;
            case "rodent":
                animalResult = new Rodent(animalAttributes);
                break;
            default:
                Console.WriteLine($"Unable to create animal of type: {animalType}");
                return null;
        }

        return animalResult;
    }
}