namespace PetStore_MVC.Model;


//TODO: Animal factory
//TODO: Constructors for type
//TODO: repository pattern
//TODO: data builder / data mother
public abstract class Animal
{
    private int age;
    private string name;
    private double price;

    public int getAge()
    {
        return this.age;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public string getName()
    {
        return this.name;
    }

    public void setName(string newName)
    {
        this.name = newName;
    }

    public void setPrice(double newPrice)
    {
        this.price = newPrice;
    }

    public double getPrice()
    {
        return this.price;
    }

}