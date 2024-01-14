using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter;
        if (grade >= 90)
        {
            // Console.WriteLine("Your letter is A.");
            // Console.WriteLine("Congratulations! You've passed the course.");
            letter = "A";
        }
        else if (grade >= 80)
        {
            // Console.WriteLine("Your letter is B.");
            // Console.WriteLine("Congratulations! You've passed the course.");
            letter = "B";
        }
        else if (grade >= 70)
        {
            // Console.WriteLine("Your letter is C.");
            // Console.WriteLine("Congratulations! You've passed the course.");
            letter = "C";
        }
        else if (grade >= 60)
        {
            // Console.WriteLine("Your letter is D.");
            // Console.WriteLine("You haven't passed the test. Study more to succeed the next time.");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("Your letter is F.");
            // Console.WriteLine("You haven't passed the test. Study more to succeed the next time.");
            letter = "F";
        }

        Console.WriteLine($"Your letter is {letter}.");



    }
}