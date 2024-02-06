public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDurationFromUser();
        _duration = duration;

        Console.WriteLine("");
        Console.WriteLine($"Get ready...");
        ShowSpinner(5);

        int part = 0;
        if (_duration < 20)
        {
            part = _duration / 2;
        }
        else if (_duration >= 20)
        {
            part = _duration / 4;
        }
        else
        {
            part = _duration / 6;
        }
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("");
            Console.Write("Breathe in...");
            ShowCountDown(part);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            ShowCountDown(part);
            Console.WriteLine("");
        }

        DisplayEndingMessage();

    }
}