using System;

class Program
{
    // I added a functionality that allows the user to set smarter goals 
    // more specificaly time-based goal
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}