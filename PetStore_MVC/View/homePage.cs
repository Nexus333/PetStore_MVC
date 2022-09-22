namespace PetStore_MVC.View;

public class homePage : ConsolePage
{
    public static string[] options = new[] { "Add a new pet to inventory", "Search pets", "Sell pet"};
    
    public override void display()
    {
        Console.WriteLine(petHeader);
        int optionNum = 1;
        foreach (string option in options)
        {
            Console.Write(optionNum + ") ");
            Console.WriteLine(option);
            optionNum += 1;
        }

        switch (userSelection)
            {
                case "1":
                    AddAnimalPage addAnimal = new AddAnimalPage();
                    Console.Clear();
                    addAnimal.display();
                    break;
                default:
                    Console.WriteLine("Please Select a valid option!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    display();
                    break;
            }
    }
}