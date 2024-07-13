class EternalGoal : Goal
{
    // Constructor:
    public EternalGoal()
    {
        GetGoalData();
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