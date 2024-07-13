class ChecklistGoal : Goal
{
    private int _numberOfTimesToComplete;
    private int _bonusPoints;
    // Constructor:
    public ChecklistGoal()
    {   
        GetGoalData();
        _goalType = "Checklist Goal";
    }

    public override void UpdateGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public override int UpdateGoal()
    {

        return 1;
    }

    public void SetChecklistGoalBonus()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string numberOfTimes = Console.ReadLine();
        if (int.TryParse(numberOfTimes, out _numberOfTimesToComplete))
        {
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusPoints = Console.ReadLine();
            if (int.TryParse(bonusPoints, out _bonusPoints))
            {
                _completed = true;
                _points += _bonusPoints;
            }
        }

    }

    public override void GetGoalData()
    {
        UpdateGoalName();
        UpdateGoalDescription();
        UpdateGoalPoints();
        SetChecklistGoalBonus();
    }

}