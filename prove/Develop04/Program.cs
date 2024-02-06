using System;
// I add a feature to prevent the GetRandomQuestion method from choosing a question twice before
// all the questions in the list have been shown to the user.
class Program
{
    static void Main(string[] args)
    {
        string name1 = "Breathing Activity";
        string description1 = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
        string name2 = "Reflecting Activity";
        string description2 = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        string name3 = "Listing Activity";
        string description3 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        ReflectingActivity reflect = new ReflectingActivity(name2, description2);
        BreathingActivity newBreathe = new BreathingActivity(name1, description1);
        ListingActivity listing = new ListingActivity(name3, description3);
        
        int option = 0;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            option = int.Parse(input);
            if (option == 1)
            {
                newBreathe.Run();
            }
            else if (option == 2)
            {
                reflect.run();
            }
            else if (option == 3)
            {
                listing.run();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Incorrect option. Try again.");
                Console.WriteLine("");
            }
            

        }while (option != 4);

        



        
        
        
        

        

    }
}