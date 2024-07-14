using System.IO;
using System.Text.Json;

public class GoalTracker
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
        Console.WriteLine($"\nYou have {_totalPoints} points.\n");
    }

    // DisplayGoals: Displays all goals in the list of goals
    public void DisplayGoals()
    {   
        Console.WriteLine("\nGoals:");
        // If goals list is empty display message
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals in the list.");
        }
        foreach (Goal goal in _goals)
        {
            int goalIndex = _goals.IndexOf(goal) + 1;
            Console.Write($"{goalIndex}. ");
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

    public void ClearGoals()
    {
        _goals.Clear();
        Console.WriteLine("All goals cleared successfully.");
    }

    // SaveGoals: Saves goals and total points to a JSON file
    // Public properties to access private fields
    // Method to get data for serialization
    public object GetSerializableData()
    {
        return new
        {
            TotalPoints = _totalPoints,
            Goals = _goals
        };
    }

    // Method to load data from deserialization
    public void LoadFromSerializedData(JsonElement data)
    {
        _totalPoints = data.GetProperty("TotalPoints").GetInt32();
        _goals = JsonSerializer.Deserialize<List<Goal>>(
            data.GetProperty("Goals").GetRawText(), 
            new JsonSerializerOptions { Converters = { new GoalConverter() } }
        );
    }
    

    
}