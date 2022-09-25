namespace PetStore_MVC.Controller;
using PetStore_MVC.Model;
using PetStore_MVC.View;

public class PetStoreController
{
  private ConsolePage currentPage;
  private bool runApp = true;
  private CartController cartCtrl;
  
  public void setCurrentPage(ConsolePage newPage)
  {
    this.currentPage = newPage;
  }

  public void setupControllers()
  {
    //initialize all controllers for use. 
    cartCtrl = new CartController();

  }

  public void start()
  {
    setupControllers();
    homePage hp = new homePage();
    setCurrentPage(hp);
    while (runApp)
    {
      currentPage.quitApp += OnQuitApp;
      currentPage = currentPage.display();
    }
  }

  public void OnQuitApp(object pageRef, EventArgs args)
  {
    this.runApp = false;
  }
}