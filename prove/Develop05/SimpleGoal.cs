class SimpleGoal : Goal
{
    // Constructor:

    public SimpleGoal()
    {
        GetGoalData();
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