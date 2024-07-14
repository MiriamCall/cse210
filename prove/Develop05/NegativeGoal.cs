class NegativeGoal : Goal
{
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
        _completed = true;
        return - _points;
    }
}