public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Exit");

            int choice = GetUserChoice(1, 6);

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("The goals are:");
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    exitProgram = true;
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("");
        Console.WriteLine("1. SimpleGoal");
        Console.WriteLine("2. EternalGoal");
        Console.Write("3. ChecklistGoal");
        Console.WriteLine("");
        Console.Write("Enter the goal type you want to create: ");
        string input = Console.ReadLine();
        int goalType = int.Parse(input);

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for completing the goal: ");
        input = Console.ReadLine();
        int points = int.Parse(input); 

        switch (goalType)
        {
            case 1:
                Console.Write("Do you want to set an expiration date? (Y/N): ");
                bool setExpiration = Console.ReadLine().ToUpper() == "Y";

                DateTime? expirationDate = null;

                if (setExpiration)
                {
                    Console.Write("Enter goal expiration date (MM/dd/yyyy): ");
                    DateTime dateOnly = DateTime.ParseExact(Console.ReadLine() + " 23:59:59", "MM/dd/yyyy HH:mm:ss", null);
                    expirationDate = dateOnly;
                }

                _goals.Add(new SimpleGoal(name, description, points, expirationDate));
                //_goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter the amount of time that this goal need to be accomplished for a bonus: ");
                input = Console.ReadLine();
                int target = int.Parse(input);

                Console.Write("Enter the bonus for accomplishing this goal: ");
                input = Console.ReadLine();
                int bonus = int.Parse(input);

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        int goalIndex = GetUserChoice(1, _goals.Count) - 1;
        _goals[goalIndex].RecordEvent();
        _score += _goals[goalIndex].GetPoints();

        Console.WriteLine($"Event recorded for {_goals[goalIndex].GetShortName()}. You earned {_goals[goalIndex].GetPoints()} points.");
    }

    public void SaveGoals()
    {
        Console.Write("Enter the name of the file to save goals: ");
        string fileName = Console.ReadLine();
    
        try
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
            {
                // Save total points on the first line
                file.WriteLine($"Total Points: {_score}");
    
                // Save each goal's details on separate lines
                foreach (Goal goal in _goals)
                {
                    file.WriteLine($"{goal.GetType().ToString()}:{goal.GetStringRepresentation()}");
                }
    
                Console.WriteLine($"Goals saved to {fileName} successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }


    public void LoadGoals()
    {
        Console.Write("Enter the name of the file to load goals from: ");
        string fileName = Console.ReadLine();
    
        try
        {
            _goals.Clear(); // Clear existing goals before loading new ones
    
            using (System.IO.StreamReader file = new System.IO.StreamReader(fileName))
            {
                // Read total points from the first line
                string totalPointsLine = file.ReadLine();
                if (totalPointsLine != null && totalPointsLine.StartsWith("Total Points:"))
                {
                    int.TryParse(totalPointsLine.Substring("Total Points:".Length).Trim(), out _score);
                }
    
                // Read each line and create goals accordingly
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] goalData = line.Split(':');
    
                    if (goalData.Length >= 3)
                    {
                        string goalType = goalData[0];
                        string name = goalData[1];
                        string description = goalData[2];
                        bool isComplete;
                        int points;
                        DateTime expirationDate;
    
                        if (int.TryParse(goalData[3], out points))
                        {
                            Goal goal;
    
                            switch (goalType)
                            {
                                case "SimpleGoal":
                                    bool.TryParse(goalData[4], out isComplete);
                                    goal = new SimpleGoal(name, description, points);
                                    ((SimpleGoal)goal).SetIsComplete(isComplete);
                                    if(goalData.Length == 6)
                                    {
                                        DateTime.TryParse(goalData[5], out expirationDate);
                                        ((SimpleGoal)goal).SetExpirationDate(expirationDate);
                                    }
                                    break;
                                case "EternalGoal":
                                    goal = new EternalGoal(name, description, points);
                                    break;
                                case "ChecklistGoal":
                                    int amountCompleted, target, bonus;
    
                                    if (goalData.Length >= 6 &&
                                        int.TryParse(goalData[4], out amountCompleted) &&
                                        int.TryParse(goalData[5], out target) &&
                                        int.TryParse(goalData[6], out bonus))
                                    {
                                        goal = new ChecklistGoal(name, description, points, target, bonus);
                                        ((ChecklistGoal)goal).SetAmountCompleted(amountCompleted);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Invalid data for ChecklistGoal: {line}");
                                        continue;
                                    }
                                    break;
                                default:
                                    Console.WriteLine($"Invalid goal type: {goalType}");
                                    continue;
                            }
    
                            _goals.Add(goal);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid points data: {line}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid goal data: {line}");
                    }
                }
    
                Console.WriteLine($"Goals loaded from {fileName} successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }


    private int GetUserChoice(int min, int max)
    {
        int choice;
        bool isValid;

        do
        {
            Console.Write($"Enter a number between {min} and {max}: ");
            isValid = int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max;

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (!isValid);

        return choice;
    }
}