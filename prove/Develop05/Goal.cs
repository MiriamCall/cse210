// help in various places throughout the code from chatGPT

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
        string checkStatus = _completed ? "[✓]" : "[]";
        Console.WriteLine($"{checkStatus} {_name}: {_description}");
    }

    // Abstract Method Definitions:

    // UpdateGoalType: Returns the type of goal
    public abstract void UpdateGoalType(string goalType);
    public abstract int UpdateGoal();
    // public abstract void RunGoal();


}