public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
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

        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(prompt);
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            GetListFromUser();
        }

        _count = _userInputs.Count;
        Console.WriteLine($"You listed {_count} items!");
        
        DisplayEndingMessage();
        
    }

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    
    private List<string> _userInputs = new List<string>();
    public List<string> GetListFromUser()
    {
        Console.Write("> ");
        string _userInput = Console.ReadLine();
        _userInputs.Add(_userInput);
        return _userInputs;
    }
}
 