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
            Console.WriteLine("type quit to exit the application\n");
            Console.Write("\nSelect an option > ");

            string userSelection = Console.ReadLine();

            switch (userSelection.ToLower())
            {
                case "1":
                    Console.Clear();
                    return new AddAnimalPage();
                case "2":
                    Console.Clear();
                    return new SearchPetsPage();
                case "3":
                    Console.Clear();
                    return new PurchasePetPage();
                case "quit":
                    return this;
                default:
                    Console.WriteLine("Please Select a valid option!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    display();
                    break;
            }

            return this;
    }
}