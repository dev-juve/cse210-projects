using System.Diagnostics;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void run()
    {
        DisplayStartingMessage();

        int duration = GetDurationFromUser();
        _duration = duration;

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        DisplayPrompt();
        
        Console.WriteLine("When you have something in mind, press enter to contnue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        /* int part = 0;
        if (_duration < 20)
        {
            part = _duration;
        }
        else if (_duration >= 20)
        {
            part = _duration / 2;
        }
        else if (_duration >= 30)
        {
            part = _duration / 3;
        }
        else if (_duration >= 40)
        {
            part = _duration / 2;
        }
        else if (_duration >= 50)
        {
            part = _duration / 3;
        }
        else if (_duration >= 60)
        {
            part = _duration / 3;
        }
        else
        {
            part = _duration / 4;
        }*/

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
            Console.ReadLine();
        }

        DisplayEndingMessage();

    }
    private List<string> _usedQuestions = new List<string>();
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }

        string randomQuestion;
        do
        {
            randomQuestion = GetRandomQuestionFromList();
        } while (_usedQuestions.Contains(randomQuestion));

        _usedQuestions.Add(randomQuestion);

        return randomQuestion;
    }

    private string GetRandomQuestionFromList()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    

}

