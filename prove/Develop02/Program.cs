
/* I implemented in a feature in the PromptGenerator class
   so it doesn't display a prompt twice during a trial 
   from the list of prompts until all the prompts 
   have been shown to the user.
*/ 
internal class Program
{
    private static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        

        Journal myJournal = new Journal();
        Entry myEntry = new Entry();
        PromptGenerator myPrompt = new PromptGenerator();

        int choice = 0;
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");


        while (choice != 5)
        {
            DisplayMenu();
            int option = GetChoice();

            if (option == 1)
            {
                string prompt = myPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);  
                string response = Console.ReadLine();
                myEntry._date = dateText;
                myEntry._promptText = prompt;
                myEntry._entryText = response;
                myJournal.AddEntry(myEntry);
            }

            else if (option == 2)
            {
                myJournal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.WriteLine("");
                Console.Write("Enter a name for your file: ");
                string fileToSaveTo = FileName;
                myJournal.SaveToFile(fileToSaveTo);
                Console.Write("File saved successfully.");
                
            }
            else if (option == 4)
            {
                Console.WriteLine("");
                Console.Write("Enter the name of the file you want to load from: ");
                string fileToLoadFrom = FileName;
                myJournal.LoadFromFile(fileToLoadFrom);
            }
            else if (option == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Good bye!");
                Console.WriteLine("");
                break;
            }
            else 
            {
                Console.WriteLine("");
                Console.WriteLine("You've chosen a wrong option.");
                Console.WriteLine("Try again, please.");
                Console.WriteLine("");
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
    }

    private static int GetChoice()
    {
        Console.Write("Enter the number of your choice: ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        return choice;
    }

    private static string FileName
    {
        get
        {
            string fileName = Console.ReadLine();
            return fileName;
        }
    }

}