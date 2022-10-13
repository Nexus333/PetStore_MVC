namespace PetStore_MVC.Data;

public class Rodent : Animal
{
    public Rodent(List<string> rodentAttributes)
    {
        
        setName(rodentAttributes[0]);
        setAge(Int32.Parse(rodentAttributes[1]));
        setPrice(Double.Parse(rodentAttributes[2]));
        setType(rodentAttributes[3]);
        setMarkings(rodentAttributes[4]);
    }
    
    private string rodentType;
    private string markings;
    public string getType()
    {
        return this.rodentType;
    }

    public void setType(string newType)
    {
        this.rodentType = newType;
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