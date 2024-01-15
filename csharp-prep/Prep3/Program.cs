using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.Write("What is your guess? ");
            string number = Console.ReadLine();
            int guess = int.Parse(number);
        while (guess != magicNumber)
        {   
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            Console.Write("What is your guess? ");
            number = Console.ReadLine();
            guess = int.Parse(number);
        }   
        
        Console.WriteLine("Correct. You've guessed it.");
    }
}