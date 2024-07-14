class EternalGoal : Goal
{
    // Constructor:
    public EternalGoal()
    {
        _goalType = "Eternal Goal";
    }

    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
        _goalType = "Eternal Goal";
    }
    public override void UpdateGoalType(string goalType)
    {
        _goalType = goalType;
    }

    // Updates the goal 
    public override int UpdateGoal()
    {
        // Eternal Goals can never be completed
        _completed = false;
        
        // Returns the points
        return _points;
    }
}