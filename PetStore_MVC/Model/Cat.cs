namespace PetStore_MVC.Model;

public class Cat : Animal
{
    public Cat(List<string> catAttributes)
    {
        
        setName(catAttributes[0]);
        setAge(Int32.Parse(catAttributes[1]));
        setPrice(Double.Parse(catAttributes[2]));
        setBreed(catAttributes[3]);
        setMarkings(catAttributes[4]);
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