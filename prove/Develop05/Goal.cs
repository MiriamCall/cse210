// help in various places throughout the code from chatGPT



using System.Net;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _completed;

    public Goal(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }

    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _completed = false;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public bool GetCompleted()
    {
        return _completed;
    }

    public void MarkCompleted(bool completed)
    {
        _completed = true;
    }

    public virtual string ListGoal()
    {
        return $"{_name}: {_description} - Points: {_points} - Completed: {_completed}";
    }

    public override string ToString()
    {
        return $"{_name}: {_description} - Points: {_points} - Completed: {_completed}";
    }

    public abstract string GetGoalType();
    public abstract int RecordEvent();
    public abstract void RunGoal();


    // int _points;
    // bool _completed;
    // string _goal;
}