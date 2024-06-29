using System;

class Checklist : Goal
{
    private int _completed = 0;
    private int _timesCompleted;
    private int _bonusValue;

    public Checklist(string name, string description, int pointValue, int bonusValue, int timesCompleted)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _bonusValue = bonusValue;
        _timesCompleted = timesCompleted;
    }

    public override bool IsComplete(string userInput)
    {
        if (userInput == "Y" || userInput == "y")
        {
            _completed++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int RecordEvent(string userInput)
    {
        if(IsComplete(userInput) == true){
            if(_completed == _timesCompleted)
            {
                _score += _bonusValue;
            }
        }

        return _score;
    }

    public override string GoalString()
    {
        string newGoal = $"{_name}: {_description} \n Times completed: {_completed}/{_timesCompleted}";

        return newGoal;
    }

    public override string ReturnName()
    {
        return _name;
    }
}