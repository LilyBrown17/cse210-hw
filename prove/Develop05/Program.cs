using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int _runProgram = 0;
        List<Goal> _currentGoals = new List<Goal>();
        List<string> _goalList = new List<string>();
        string _myGoals = "";
        int _myScore = 0;

        while (_runProgram == 0)
        {
            Console.WriteLine("\n Please select one of the following choices: \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
            string _selection = Console.ReadLine();

            if (_selection == "1")
            {
                Console.WriteLine("What kind of goal would you like to make? \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
                string selection = Console.ReadLine();

                if(selection == "1")
                {
                    Console.WriteLine("What is the name of the goal?");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is the descripton of the goal?");
                    string description = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth?");
                    string value = Console.ReadLine();
                    int pointValue;
                    if (int.TryParse(value, out int _result))
                    {
                        pointValue = _result;

                        Simple newSimple = new Simple(name, description, pointValue);
                        _currentGoals.Add(newSimple);
                        _goalList.Add(newSimple.GoalString());
                    }
                    else
                    {
                         Console.WriteLine("I'm sorry, that's not a valid input.");
                        pointValue = 0;
                    } 
                }
                else if(selection == "2")
                {
                    Console.WriteLine("What is the name of the goal?");
                    string name = Console.ReadLine();
                    
                    Console.WriteLine("What is the descripton of the goal?");
                    string description = Console.ReadLine();

                    Console.WriteLine("How many points are each completion of this goal worth?");
                    string value = Console.ReadLine();
                    int pointValue;
                    if (int.TryParse(value, out int _result))
                    {
                        pointValue = _result;

                        Eternal newEternal = new Eternal(name, description, pointValue);
                        _currentGoals.Add(newEternal);
                        _goalList.Add(newEternal.GoalString());
                    }
                    else
                    {
                         Console.WriteLine("I'm sorry, that's not a valid input.");
                        pointValue = 0;
                    }
                }
                else if(selection == "3")
                {
                    Console.WriteLine("What is the name of the goal?");
                    string name = Console.ReadLine();
                    
                    Console.WriteLine("What is the descripton of the goal?");
                    string description = Console.ReadLine();

                    Console.WriteLine("How many points are each completion of this goal worth?");
                    string pvalue = Console.ReadLine();
                    int pointValue;
                    if (int.TryParse(pvalue, out int presult))
                    {
                        pointValue = presult;

                        Console.WriteLine("How many bonus points are the final completion of this goal worth?");
                        string bvalue = Console.ReadLine();
                        int bonusValue;
                        if (int.TryParse(bvalue, out int bresult))
                        {
                            bonusValue = bresult;

                            Console.WriteLine("How many bonus points are the final completion of this goal worth?");
                            string cvalue = Console.ReadLine();
                            int timesCompleted;
                            if (int.TryParse(cvalue, out int cresult))
                            {
                                timesCompleted = cresult;

                                Checklist newChecklist = new Checklist(name, description, pointValue, bonusValue, timesCompleted);
                                _currentGoals.Add(newChecklist);
                                _goalList.Add(newChecklist.GoalString());
                            }
                            else
                            {
                                Console.WriteLine("I'm sorry, that's not a valid input.");
                                pointValue = 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry, that's not a valid input.");
                            pointValue = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that's not a valid input.");
                        pointValue = 0;
                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry, that's not a valid input.");
                }
            }
            else if (_selection == "2")
            {
                _myGoals = DisplayGoals(_goalList);
                Console.Write(_myGoals);
            }
            else if (_selection == "3")
            {
                Save(_goalList);
            }
            else if (_selection == "4")
            {
                Console.WriteLine("What is the name of the file?");
                string _filename = Console.ReadLine();
                _myGoals = Load(_filename);
                _goalList.Clear();
            }
            else if (_selection == "5")
            {
                bool _run = true;

                Console.WriteLine("Which goal would you like to work on? Enter the goal's name.");
                string _goalName = Console.ReadLine();

                Console.WriteLine("What kind of goal is it? \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
                string _goalType = Console.ReadLine();

                if(_goalType == "1")
                {
                    Simple _recordedGoal;
                }
                else if(_goalType == "2")
                {
                    Eternal _recordedGoal;
                }
                else if(_goalType == "3")
                {
                    Checklist _recordedGoal;
                }
                else
                {
                    _run = false;
                }

                if (_run == true)
                {
                    bool _isTrue = false;

                    foreach(Goal currentGoal in _currentGoals)
                    {
                        string _testName = currentGoal.ReturnName();
                        if(_testName == _goalName)
                        {
                            _recordedGoal = currentGoal;
                            _isTrue = true;
                        }
                    }

                    if(_isTrue == true)
                    {
                        Console.WriteLine("Have you completed this goal? Y/N");
                        string _input = Console.ReadLine();
                        int _newScore = _recordedGoal.RecordEvent(_input);

                        _myScore += _newScore;

                        Console.WriteLine($"Your current score is {_myScore}.");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that's not a valid input.");
                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry, that's not a valid input.");
                    
                }
            }
            else if (_selection == "6")
            {
                _runProgram = 1;
            }
            else
            {
                Console.WriteLine("I'm sorry, that's not a valid input.");
            }

        }

        
    }

    public static string DisplayGoals(List<string> _goalList)
    {
        string _newGoals = "";
        foreach (string _goal in _goalList)
        {
            _newGoals = $"{_newGoals}\n\n{_goal}";
        }

        return _newGoals;
    }

    public static void Save(List<string> _goalList)
    {
        string _newGoals = DisplayGoals(_goalList);

        Console.WriteLine("What would you like to name the file?");
        string _filename = Console.ReadLine();

        using (StreamWriter _outputFile = new StreamWriter(_filename))
        {
            _outputFile.WriteLine(_newGoals);
        } 
    }

    public static string Load(string _filename)
    {
        string[] _lines = System.IO.File.ReadAllLines(_filename);
        string _newGoals = "";

        foreach (string _line in _lines)
        {
            _newGoals = $"{_newGoals}\n{_line}";
        }

        return _newGoals;
    }
}