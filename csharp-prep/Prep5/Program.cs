using System;

class Program
{
    static void DisplayWelcome()
        {
            Console.WriteLine("Hello World!");
        }
        
        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;

        }
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;

        }
        static int SquareNumber(int interger)
        {
            int squaredNumber = interger * interger;
            return squaredNumber;

        }
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the squared of your number is {squaredNumber}.");
            Console.WriteLine("Thank you!");
        }
    static void Main(string[] args)
    {
        Console.WriteLine("");
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favNumber);
        DisplayResult(userName, squaredNumber);
        Console.WriteLine("");

    }
}