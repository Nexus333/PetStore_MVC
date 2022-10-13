using PetStore_MVC.Display;

namespace PetStore_MVC.Controller;

public class PetStoreController
{
  private ConsolePage currentPage;
  private bool runApp = true;
  private CartController cartCtrl;
  private AnimalController animalCtrl;
  
  public void setCurrentPage(ConsolePage newPage)
  {
    this.currentPage = newPage;
  }

  public void setupControllers()
  {
    //initialize all controllers for use. 
    cartCtrl = new CartController();
    animalCtrl = new AnimalController();

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