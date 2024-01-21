public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I realized today that I'm proud of?",
        "Who or what made me smile today?"
    };

    private List<string> _usedPrompts = new List<string>();
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string randomPrompt;
        do
        {
            randomPrompt = GetRandomPromptFromList();
        } while (_usedPrompts.Contains(randomPrompt));

        _usedPrompts.Add(randomPrompt);

        return randomPrompt;
    }

    private string GetRandomPromptFromList()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
