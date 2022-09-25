namespace PetStore_MVC.View;

public class homePage : ConsolePage
{
    public static string[] options = new[] { "Add a new pet to inventory", "Search pets", "Buy pet"};
    
    public override ConsolePage display()
    {
        Console.WriteLine(petHeader);
        int optionNum = 1;
            foreach (string option in options)
            { 
                Console.Write(optionNum+") ");
                Console.WriteLine(option);
                optionNum += 1;
            }
            standardPages();
            promptForInput();
            getUserInput();

            switch (userInput.ToLower())
            {
                case "1":
                    Console.Clear();
                    return new AddAnimalPage();
                case "2":
                    Console.Clear();
                    return new SearchPetsPage();
                case "quit":
                    onQuitApp();
                    break;
                case "h":
                    Console.Clear();
                    display();
                    break;
                default:
                    invalidSelection();
                    break;
            }

            return this;
    }

}