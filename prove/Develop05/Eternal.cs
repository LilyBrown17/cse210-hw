using System;

class Eternal : Goal
{
    private int _completed = 0;
    public Eternal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
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
            _score += _pointValue;
        }
        return _score;
    }

    public override string GoalString()
    {
        string newGoal = $"{_name}: {_description} \n Times completed: {_completed}";

        return newGoal;
    }

    public override string ReturnName()
    {
        return _name;
    }
}