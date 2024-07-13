class SimpleGoal : Goal
{
    // Constructor:
    public SimpleGoal(string name, string description, int points, bool completed) : base(name, description, points, completed)
    {
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