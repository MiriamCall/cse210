class SimpleGoal : Goal
{
    // Constructor:
    public SimpleGoal()
    {
        GetGoalData();
        _goalType = "Simple Goal";
    }

    public SimpleGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
        _goalType = "Simple Goal";
    }

    public override void UpdateGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public override int UpdateGoal()
    {
        _completed = true;
        return _points;
    }
}