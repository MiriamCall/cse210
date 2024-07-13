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

    // GetGoal: Returns the goal at the specified 
    public Goal GetGoal(int goalNum)
    {
        return _goals[goalNum];
    }

    // SaveGoals: Saves the goals to a file
    public void SaveGoals()
    {
        Console.WriteLine("Saving goals...");
        Console.WriteLine("Haha... You tried to save but you haven't written the code to save yet :P ;)\n.");
    }

    // LoadGoals: Loads the goals from a file
    public void LoadGoals()
    {
        Console.WriteLine("Loading goals...");
        Console.WriteLine("Haha... You tried to load but you haven't written the code to load yet :P ;)\n.");
    }

    
}