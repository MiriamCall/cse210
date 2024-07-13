class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetChecklistInputCount;
    private int _currentChecklistCount;



    // Constructor:
    public ChecklistGoal()
    {   
        GetGoalData();
        _goalType = "Checklist Goal";
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
        string checkStatus = _completed ? "[✓]" : "[]";

        // Displays the goal with a checkmark box, Name, and Description
        Console.WriteLine($"{checkStatus} {_name}: ({_description}) -- Currently completed: {_currentChecklistCount}/{_targetChecklistInputCount}");
    }

    // Gets the goal data
    public override void GetGoalData()
    {
        UpdateGoalName();
        UpdateGoalDescription();
        UpdateGoalPoints();
        UpdateChecklistGoalBonus();
    }

}