class GoalTracker
{
    // Member Variables:

    // _totalPoints: An integer variable of The total points earned
    private int _totalPoints;

    // _goals: A list of goals (Goal objects)
    private List<Goal> _goals = new List<Goal>();

    // Constructor: Initializes the total points to 0
    public GoalTracker()
    {
        _totalPoints = 0;
    }

    // RecordEvent: Records the event of completing a goal
    public void RecordEvent(Goal goal)
    {
        int pointsEarned = goal.UpdateGoal();
        _totalPoints += pointsEarned;
    }

    // DisplayPoints: Displays the total points
    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.\n");
    }

    // DisplayGoals: Displays all goals in the list of goals
    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.DisplayGoal();
        }
    }

    // AddGoal: Adds a goal to the list of goals
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // GetGoalIndex: Returns the goal at the specified index
    public Goal GetGoalIndex(int goalNum)
    {
        return _goals[goalNum];
    }

    
}