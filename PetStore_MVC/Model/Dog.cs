namespace PetStore_MVC.Model;


//{ string name, string age, string price, string breed, string breed/type, string markings  }
public class Dog : Animal
{

    public Dog(List<string> dogAttributes)
    {
        
        setName(dogAttributes[0]);
        setAge(Int32.Parse(dogAttributes[1]));
        setPrice(Double.Parse(dogAttributes[2]));
        setBreed(dogAttributes[3]);
        setMarkings(dogAttributes[4]);
        
        
    }
    private string breed;
    private string markings;

    public string getBreed()
    {
        return this.breed;
    }

    public void setBreed(string newBreed)
    {
        this.breed = newBreed;
    }

    public string getMarkings()
    {
        return this.markings;
    }

    public void setMarkings(string newMarkings)
    {
        this.markings = newMarkings;
    }
}