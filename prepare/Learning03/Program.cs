using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction1 = new Fraction();
        Fraction myFraction2 = new Fraction(6);
        Fraction myFraction3 = new Fraction(6, 7);

        Console.WriteLine(myFraction3.GetDecimalValue());
    }

    
}