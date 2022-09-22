namespace PetStore_MVC.Model;

public class Services
{
    public static Services CreateInstance()
    {
        return new Services();
    }

    private string serviceName;
    private double servicePrice;

    public string getServiceName()
    {
        return this.serviceName;
    }

    public double getServicePrice()
    {
        return this.servicePrice;
    }

    public void setServiceName(string newServiceName)
    {
        this.serviceName = newServiceName;
    }

    public void setServicePrice(double newServicePrice)
    {
        this.servicePrice = newServicePrice;
    }
}