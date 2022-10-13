namespace PetStore_MVC.Data;

public class DataEventArgs : EventArgs
{
    public Animal _animalMade { get; set; }
    public string _animalType { get; set; }
}