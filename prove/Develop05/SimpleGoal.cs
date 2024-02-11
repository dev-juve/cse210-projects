public class SimpleGoal : Goal
{
    protected bool _isComplete;
    protected DateTime? _expirationDate; // Nullable DateTime for optional expiration date

    public SimpleGoal(string name, string description, int points, DateTime? expirationDate = null)
        : base(name, description, points)
    {
        _isComplete = false;
        _expirationDate = expirationDate;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public void SetExpirationDate(DateTime expirationDate)
    {
        // Extract the date part only and save it to _expirationDate
        _expirationDate = expirationDate.Date;
    }

    public override void RecordEvent()
    {
        if (_expirationDate == null || DateTime.Now <= _expirationDate)
        {
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        if (_expirationDate != null)
        {
            string formattedDate = _expirationDate.HasValue ? _expirationDate.Value.ToString("MM/dd/yyyy") : "";
            return $"{_shortName}:{_description}:{_points}:{_isComplete}:{formattedDate}";
        }
        else
        {
            return $"{_shortName}:{_description}:{_points}:{_isComplete}";
        }
        
    }

    public override string GetDetailsString()
    {
        string display;

        if (_expirationDate != null)
        {
            string expirationStatus = _isComplete
                ? "Completed"
                : (DateTime.Now > _expirationDate ? "Expired" : "Not Completed");

            // Use [X] or [ ] based on completion status
            display = _isComplete ? $"[X] {base.GetDetailsString()} - Expiration Status: {expirationStatus}" : $"[ ] {base.GetDetailsString()} - Expiration Status: {expirationStatus}";
        }
        else
        {
            // Use [X] or [ ] based on completion status
            display = _isComplete ? $"[X] {base.GetDetailsString()}" : $"[ ] {base.GetDetailsString()}";
        }

        return display;
    }
}




/*public class SimpleGoal : Goal
{
    protected bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override string GetDetailsString()
    {
        if (_isComplete == true)
        {
            return $"[X] {base.GetDetailsString()}";
        }
        else
        {
            return $"[ ] {base.GetDetailsString()}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}:{_description}:{_points}:{IsComplete()}";
    }

}
*/
