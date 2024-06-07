using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment _assignment1 = new Assignment("Julian", "Science");
        Console.WriteLine(_assignment1.GetSummary());

        MathAssignment _assignment2 = new MathAssignment("Danielle", "Algebra", "8", "1-5");
        Console.WriteLine(_assignment2.GetSummary());
        Console.WriteLine(_assignment2.GetHomeworkList());

        WritingAssignment _assignment3 = new WritingAssignment("Clara", "Argumentative Writing", "Why AI Needs to be Regulated");
        Console.WriteLine(_assignment3.GetSummary());
        Console.WriteLine(_assignment3.GetWritingInformation());
    }
}