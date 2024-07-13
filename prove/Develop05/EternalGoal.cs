class EternalGoal : Goal
{
    // Constructor:
    public EternalGoal(string name, string description, int points, bool completed) : base(name, description, points, completed)
    {
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