using System.Text.Json;
class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetChecklistInputCount;
    private int _currentChecklistCount;



    // Constructor:
    public ChecklistGoal()
    {   
        _goalType = "Checklist Goal";
    }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int targetChecklistInputCount)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
        _goalType = "Checklist Goal";
        _bonusPoints = bonusPoints;
        _targetChecklistInputCount = targetChecklistInputCount;
        _currentChecklistCount = 0;
    }

    // Updates the goal type
    public override void UpdateGoalType(string goalType)
    {
        _goalType = goalType;
    }

    // Updates the goal by incrementing the current checklist count
    // and checks if checklist count is equal to the target checklist input count
    // If it is, the goal is completed and the bonus is added to the points and the points are returned
    // If it is not, the points are returned
    public override int UpdateGoal()
    {
        _currentChecklistCount++;
        if (_currentChecklistCount == _targetChecklistInputCount)
        {
            _completed = true;
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    // Gets the number of times the goal needs to be accomplished for a bonus
    // and the bonus points for accomplishing the goal that many times
    public void UpdateChecklistGoalBonus()
    {
        // Gets the number of times the goal needs to be accomplished for a bonus
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string numberOfTimes = Console.ReadLine();

        // If the input is a valid integer, set _numberOfTimesToComplete
        if (int.TryParse(numberOfTimes, out _targetChecklistInputCount))
        {
            // Gets the bonus points for accomplishing the goal that many times
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusPoints = Console.ReadLine();

            // If the input is a valid integer, set _bonusPoints
            int.TryParse(bonusPoints, out _bonusPoints);
        }
    }


    public override void DisplayGoal()
    {
        // Adds a checkmark if the goal is completed
        string checkStatus = _completed ? "[✓]" : "[ ]";

        // Displays the goal with a checkmark box, Name, and Description
        Console.WriteLine($"{checkStatus} {_name}: ({_description}) -- Currently completed: {_currentChecklistCount}/{_targetChecklistInputCount}");
    }

    public override string ToString()
    {
        return $"{_name}| {_description}| {_points}| {_completed} | {_bonusPoints}| {_targetChecklistInputCount}| {_currentChecklistCount}";
    }

    // Gets the goal data
    public override void GetGoalData()
    {
        UpdateGoalName();
        UpdateGoalDescription();
        UpdateGoalPoints();
        UpdateChecklistGoalBonus();
    }

    // Add these methods for serialization and deserialization
    public override object GetSerializableData()
    {
        var baseData = base.GetSerializableData() as dynamic;
        return new
        {
            baseData.Type,
            baseData.Name,
            baseData.Description,
            baseData.Points,
            baseData.Completed,
            BonusPoints = _bonusPoints,
            RequiredCount = _targetChecklistInputCount,
            CurrentCount = _currentChecklistCount
        };
    }

    public override void LoadFromSerializedData(JsonElement data)
    {
        base.LoadFromSerializedData(data);
        _bonusPoints = data.GetProperty("BonusPoints").GetInt32();
        _targetChecklistInputCount = data.GetProperty("RequiredCount").GetInt32();
        _currentChecklistCount = data.GetProperty("CurrentCount").GetInt32();
    }

}