using NUnit.Framework;

namespace PetStore_MVC.Data.Tests;

/*Data Model
 { string name, string age, string price, string breed, string breed/type, string markings  }
 
 */
public class AnimalFactoryTests
{
    private AnimalFactory af;
    private MockAnimalListener animalListener;

    private List<string> animalProperties;
    private string animalType;

    [SetUp]
    public void setupTests()
    {
        af = new AnimalFactory();
        animalListener = new MockAnimalListener();
        af.animalBirth += animalListener.onAnimalCreation;
    }

    [Test]
    public void dataReceivableOnDogCreation()
    {
        //Arrange
        animalProperties = new List<string>(){"Fluffy", "10", "2.00", "Cocker Spaniel", "brown and white."};
        animalType = "dog";
        
        //Act
        af.makeAnimal(animalType, animalProperties);
        
        //Assert
        Assert.AreEqual("dog", animalListener.getAnimalType());
        Assert.NotNull(animalListener.getAnimalDetails());
        Assert.AreEqual("Fluffy", animalListener.getAnimalDetails().getName());
    }
}