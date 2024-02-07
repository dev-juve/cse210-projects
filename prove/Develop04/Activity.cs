public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        Console.WriteLine("");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.WriteLine("");
    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int second)
    {
        List<string> symbols = new List<string>
        {"\\", "|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(second);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string symbol = symbols[i];
            Console.Write(symbol);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i == symbols.Count)
            {
                i = 0;
            }

        }
    }

    public int GetDurationFromUser()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        Console.Clear();
        int duration = int.Parse(input);
        return duration;
    }

}





