class SimpleGoal : Goal
{
    public string Name{
        get;
        private set;
    }

    public string Description {
        get;
        private set;
    }

    public bool IsAchieved{
        get;
        private set;
    }

    public SimpleGoal(string name, string description) {
        Name = name;
        Description = description;
        IsAchieved = false;
    }

    public override string GetGoalType()
    {
        return "SimpleGoal";
    }
    public override int RecordEvent()
    {
        IsAchieved = true;
        return 1;
    }
    public override void RunGoal()
    {
    }
}