class GoalTracker
{
    private int _totalPoints;
    private List<Goal> _goals = new List<Goal>();
    public void RecordEvent(Goal goal)
    {
        int pointsEarned = goal.UpdateGoal();
        _totalPoints += pointsEarned;
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.\n");
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.DisplayGoal();
        }
    }
}