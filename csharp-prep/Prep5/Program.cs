using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);
        
    }

    static void DisplayWelcome()
    {
	    Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
	    Console.WriteLine("Please enter your name: ");
	    string name = Console.ReadLine();
	    return name;
    }

    static int PromptUserNumber()
    {
	    Console.WriteLine("Please enter your favorite number: ");
	    string response = Console.ReadLine();
        int number = int.Parse(response);
	    return number;
    }

    static int SquareNumber(int number)
    {
	    int square = number * number;
	    return square;
    }

    static void DisplayResult(string name, int square)
    {
	    Console.WriteLine($"{name}, the square of your number is {square}");
    }

}