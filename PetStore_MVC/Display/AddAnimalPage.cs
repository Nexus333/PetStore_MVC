namespace PetStore_MVC.Display;

public class AddAnimalPage : ConsolePage
{
    private string[] options = new[] { "Add a new Dog", "Add A new Cat", "Add a New Rodent" };
    private string name;
    private string age;
    private string price;
    private string breed_type;
    private string markings;
    public override ConsolePage display()
    {
        int index = 1;
        Console.WriteLine(petHeader);
        foreach (string option in options)
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
                newAnimalForm("dog");
                break;
            case "2":
                Console.Clear();
                newAnimalForm("cat");
                break;
            case "3":
                Console.Clear();
                newAnimalForm("rodent");
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

    private void animalFormDisplay(string animalType)
    {
        Console.WriteLine(petHeader);
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Price: ${price}");
        if (animalType.ToLower() == "rodent")
        {
            Console.WriteLine($"Type: {breed_type}");
        }
        else
        {
            Console.WriteLine($"Breed: {breed_type}");
        }
        Console.WriteLine($"Markings: {markings}");
        Console.WriteLine("\n\nC) Cancel ");
        Console.WriteLine("S) Start Over");
    }
    public void newAnimalForm(string animalType)
    {
        int promptIndex = 0;
        string[] prompts = {"Enter a Name > ", "Enter an Age > ", "Enter a Price > ", "Enter breed / Type > ", "Enter any Descriptive markings > " };
        while (promptIndex < prompts.Length)
        {
            animalFormDisplay(animalType);
            Console.WriteLine(prompts[promptIndex]);
            getUserInput();
            switch (userInput.ToLower())
            {
                case "c":
                    Console.Clear();
                    return;
                case "s":
                    clearData();
                    promptIndex = 0;
                    Console.Clear();
                    break;
                default:
                    switch (promptIndex)
                    {
                        case 0:
                            this.name = userInput;
                            break;
                        case 1:
                            this.age = userInput;
                            break;
                        case 2:
                            this.price = userInput;
                            break;
                        case 3:
                            this.breed_type = userInput;
                            break;
                        case 4:
                            this.markings = userInput;
                            break;
                        default:
                            Console.WriteLine("Something went horribly wrong when filling out the form");
                            break;
                    }
                    promptIndex += 1;
                    Console.Clear();
                    break;
            }
        }

        List<string> animalData = new List<string>();
        animalData.Add(this.name);
        animalData.Add(this.age);
        animalData.Add(this.price);
        animalData.Add(this.breed_type);
        animalData.Add(this.markings);

    }

    private void clearData()
    {
        this.name = "";
        this.age = "";
        this.breed_type = "";
        this.price = "";
        this.markings = "";
    }
}