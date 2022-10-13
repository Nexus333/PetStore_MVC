using PetStore_MVC.Data;

namespace PetStore_MVC.Controller;

public class CartController: psController
{
    private List<Animal> animalsInCart;
    private double cartTotal;

    public CartController()
    {
        animalsInCart = new List<Animal>();
        cartTotal = 0.00;
    }

    public void addAnimalToCart(Animal animalToAdd)
    {
        animalsInCart.Add(animalToAdd);
        cartTotal += animalToAdd.getPrice();
    }

    public List<Animal> getCartContents()
    {
        return animalsInCart;
    }

    public double getCartTotal()
    {
        return cartTotal;
    }

    public void removeAnimalFromCart(Animal animalToRemove)
    {
        Animal animalRef = animalToRemove;
        animalsInCart.Remove(animalToRemove);
        cartTotal -= animalRef.getPrice();

    }

    public Animal getAnimalReferencebyIndex(int index)
    {
        return animalsInCart[index];
    }

    public Animal? getAnimalReferenceByName(string name) => animalsInCart.Find(animal => animal.getName() == name);

    public void clearCart()
    {
        cartTotal = 0.00;
        animalsInCart.Clear();
    }   
}