namespace PetStore_MVC.Controller;
using PetStore_MVC.Model;
using PetStore_MVC.View;

public class PetStoreController
{
  private ConsolePage currentPage;
  private bool runApp = true;
  
  public void setCurrentPage(ConsolePage newPage)
  {
    this.currentPage = newPage;
  }

  public void setupControllers()
  {
    //initialize all controllers for use. 
  }

  public void start()
  {
    homePage hp = new homePage();
    setCurrentPage(hp);
    while (runApp)
    {
      currentPage = currentPage.display();
    }
  }

  public void shutdown()
  {
    this.runApp = false;
  }
}