// help in various places throughout the code from chatGPT, and Claude ai
using System.Text.Json;
public abstract class Goal
{
    // Member Variables:
    protected string _goalType;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;

    // Constructor:
    public Goal(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }

    // Default Constructor:
    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _completed = false;
    }

    // Get and Set _name
    public void UpdateName(string name)
    {
        _name = name;
    }

    // Get and Set _description
    public void UpdateDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }
    // Set _points
    public void SetPoints(int points)
    {
        _points = points;
    }

    // Get and Set _completed
    public void UpdateMarkedCompleted(bool completed)
    {
        _completed = completed;
    }

    public virtual void DisplayGoal()
    {
        // Adds a checkmark if the goal is completed
        string checkStatus = _completed ? "[✓]" : "[]";

        // Displays the goal with a checkmark box, Name, and Description
        Console.WriteLine($"{checkStatus} {_name}: ({_description})");
    }

    public void UpdateGoalName()
    {
        // Gets Goal Name
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        _name = name;
    }


    public void UpdateGoalDescription()
    {
        // Gets Goal Description
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        _description = description;
    }

    public void UpdateGoalPoints()
    {
        // Gets Goal Points
        Console.Write("Enter the number of points for the goal: ");
        string points = Console.ReadLine();
        int.TryParse(points, out _points);
    }

    public override string ToString()
    {
        return $"{_name}| {_description}| {_points}| {_completed} | {_goalType}";
    }
    public virtual void GetGoalData()
    {
        UpdateGoalName();
        UpdateGoalDescription();
        UpdateGoalPoints();
    }

     // Method to get data for serialization
    public virtual object GetSerializableData()
    {
        return new
        {
            Type = _goalType,
            Name = _name,
            Description = _description,
            Points = _points,
            Completed = _completed
        };
    }

    // Method to load data from deserialization
    public virtual void LoadFromSerializedData(JsonElement data)
    {
        _goalType = data.GetProperty("Type").GetString();
        _name = data.GetProperty("Name").GetString();
        _description = data.GetProperty("Description").GetString();
        _points = data.GetProperty("Points").GetInt32();
        _completed = data.GetProperty("Completed").GetBoolean();
    }


    // Abstract Method Definitions:

    // UpdateGoalType: Returns the type of goal
    public abstract void UpdateGoalType(string goalType);
    public abstract int UpdateGoal();

}