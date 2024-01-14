using System;

class Program
{
    static void Main(string[] args)
    {
        
        int magicNumber = 8;
        Console.Write("What is your guess? ");
        string number = Console.ReadLine();
        int guess = int.Parse(number);
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 20);
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
        }    
      /*  else 
        {
            Console.WriteLine("Correct. You've guessed it.");
        } */
    }
}