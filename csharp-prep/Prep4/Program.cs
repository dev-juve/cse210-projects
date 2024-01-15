using System;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        Console.Write("Add a list of numbers (Enter 0 when you're done): ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Add a list of numbers (Enter 0 when you're done): ");
            input = Console.ReadLine();
            number = int.Parse(input);
        }
        
        int sum = 0;
        int avr = 0;
        foreach (int element in numbers)
        {
            sum += element;
        }

        int nElement = numbers.Count;
        avr = sum / nElement;
        int max = numbers.Max();
        Console.WriteLine($"");
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avr}");
        Console.WriteLine($"The largest number is: {max}");
        
    }
}