class NegativeGoal : Goal
{
    private int _currentCount = 0;
    // Constructor:
    public NegativeGoal()
    {
        _goalType = "Negative Goal";
    }

    public NegativeGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
        _goalType = "Negative Goal";
    }

    public override void UpdateGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public override int UpdateGoal()
    {
        // Keep count of how many times the goal has been updated
        _currentCount++;
        return - _points;
    }

    public void DisplayNegativeCount()
    {
        Console.WriteLine($"{_currentCount}");
    }

    public virtual void DisplayGoal()
    {
        // Adds a checkmark if the goal is completed
        string checkStatus = _completed ? "[✓]" : "[ ]";

        // Displays the goal with a checkmark box, Name, and Description
        Console.WriteLine($"{checkStatus} {_name}: ({_description}) -- {_name} has been used {_currentCount} times");
    }
}