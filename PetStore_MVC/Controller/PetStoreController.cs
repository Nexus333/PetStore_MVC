namespace PetStore_MVC.Controller;
using PetStore_MVC.Model;
using PetStore_MVC.View;

public class PetStoreController
{
  private ConsolePage currentPage;
  private string userInput;
  
  public void setCurrentPage(ConsolePage newPage)
  {
    this.currentPage = newPage;
  }
  
  public void start()
  {
    homePage hp = new homePage();
    setCurrentPage(hp);
    hp.display();
    getUserInput();
  }

  public void getUserInput()
  {
    Console.WriteLine("\nPlease enter a selection: > ");
    this.userInput = Console.ReadLine();
  }
  
}