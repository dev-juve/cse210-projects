class Program
{
    static void Main()
    {
        List<Activity> _activities = new List<Activity>
        {
            new Running(new DateTime(2022, 04, 7), 30, 3.0),
            new Cycling(new DateTime(2020, 11, 3), 30, 6.0),
            new Swimming(new DateTime(2024, 08, 12), 30, 10),
        };

        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}