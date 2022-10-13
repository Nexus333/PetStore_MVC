namespace PetStore_MVC.Display;

public class SearchPetsPage : ConsolePage
{
    private string[] options = new[] { "Search by Name", "Show All", "Show all Animals of type" };
    public override ConsolePage display()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("On search Pet Page");
        int index = 1;
        foreach (var option in options)
        {
            Console.Write(index+") ");
            Console.WriteLine(option);
            index += 1;
        }

        standardPages();
        promptForInput();
        getUserInput();

        switch (userInput.ToLower())
        {
            case "1":
                Console.Clear();
                displayListByName();
                break;
            case "2":
                Console.Clear();
                showAll();
                break;
            case "3":
                Console.Clear();
                typeSelection();
                break;
            case "h":
                Console.Clear();
                return new homePage();
            case "quit":
                onQuitApp();
                break;
            default:
                invalidSelection();
                break;
        }

        return this;
    }

    public void displayListByName()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("\n\nC) Cancel");
        Console.WriteLine("QUIT) Exit the application");
        Console.WriteLine("\nEnter Pet's Name: > ");
        getUserInput();
            ;
    }

    public void showMatchingByName(string name)
    {
        ;
    }

    private void showAll()
    {
        Console.WriteLine(petHeader);
        //get pets
        //for pet in pets
            //display
        Console.WriteLine("\n\nC) Cancel");
        Console.WriteLine("QUIT) Exit the application");
        promptForInput();
        getUserInput();
        switch (userInput.ToLower())
        {
            case "c":
                Console.Clear();
                return;
            case "quit":
                onQuitApp();
                break;
            default:
                invalidSelection();
                break;
        }
    }

    public void displayByType(string animalType)
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("\n\n c) Cancel");
        Console.WriteLine("QUIT) Exit the application");
        promptForInput();
        getUserInput();
        switch (userInput.ToLower())
        {
            case "h":
                Console.Clear();
                return;
            case "quit":
                onQuitApp();
                break;
            default:
                invalidSelection();
                break;
        }
    }

    public void typeSelection()
    {
        Console.WriteLine(petHeader);
        Console.WriteLine("1) Dog");
        Console.WriteLine("2) Cat");
        Console.WriteLine("3) Rodent");
        Console.WriteLine("\n\nC) Cancel");
        Console.WriteLine("QUIT) Exit the application");
        promptForInput();
        getUserInput();
        switch (userInput.ToLower())
        {
            case "1":
                Console.Clear();
                displayByType("dog");
                break;
            case "2":
                Console.Clear();
                displayByType("cat");
                break;
            case "3":
                Console.Clear();
                displayByType("rodent");
                break;
            case "c":
                Console.Clear();
                return;
            case "quit":
                onQuitApp();
                break;
            default:
                invalidSelection();
                break;
        }
    }
}