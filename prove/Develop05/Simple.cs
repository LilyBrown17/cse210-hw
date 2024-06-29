using System;

class Simple : Goal
{
    public Simple(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }

    public override bool IsComplete(string userInput)
    {
        if(userInput == "Y" || userInput == "y")
        {
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
        string newGoal = $"{_name}: {_description}";

        return newGoal;
    }

    public override string ReturnName()
    {
        return _name;
    }
}