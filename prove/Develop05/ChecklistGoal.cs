using System.Reflection.Metadata.Ecma335;

public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetAmountCompleted() => _amountCompleted;
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points = _points + _bonus;
        }
        
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
         if (_amountCompleted >= _target)
        {
            return $"[X] {base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target} times";
        }
        else
        {
            return $"[ ] {base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target} times";

        }
        
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}:{_description}:{_points}:{_amountCompleted}:{_target}:{_bonus}";
    }
}
