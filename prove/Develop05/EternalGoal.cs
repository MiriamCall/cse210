class EternalGoal : Goal
{
    // Constructor:
    public EternalGoal()
    {
        GetGoalData();
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
    public override int UpdateGoal()
    {

        return 1;
    }
}