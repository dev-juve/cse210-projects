using System;

// I add a feature to prevent the HideRandomWords method from hidding words
// that are already hidden.

class Program
{
    static void Main(string[] args)
    {
        string book = "Philippians";
        int chapter = 4;
        int startVerse = 6;
        int endVerse = 7;
        Reference myReference = new Reference(book, chapter, startVerse, endVerse);
        string scripture = "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God. And the peace of God, which transcends all understanding, will guard your hearts and your minds in Christ Jesus.";
        Scripture myScripture = new Scripture(myReference, scripture);
        Word newWord = new Word(scripture);

        string input ;
        
        do
        {
          
            Console.WriteLine(myReference.GetDisplayText());
            Console.WriteLine(myScripture.GetDisplayText());
            Console.WriteLine("");
            Console.Write("Press enter or type 'quit': ");
            
            input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            Console.Clear();
            myScripture.HideRandomWords(3); 

        } 
        while (!myScripture.IsCompletelyHidden() && input.ToLower() != "quit");
        Console.WriteLine(myReference.GetDisplayText());
        Console.WriteLine(myScripture.GetDisplayText());
        Console.WriteLine("");
        Console.WriteLine("Congrats! You've memorized it.");
        Console.WriteLine("");

    }
}