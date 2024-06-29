using System;

abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected int _score;

    

    public abstract bool IsComplete(string userInput);

    public abstract int RecordEvent(string userInput);

    public abstract string GoalString();

    public abstract string ReturnName();

}