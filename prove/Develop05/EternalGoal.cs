using System.Drawing;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    
    }

    public override void RecordEvent()
    {
        
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {base.GetDetailsString()}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}:{_description}:{_points}";
    }
}
