using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int user = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (user != 0)
        {
	        Console.WriteLine("Enter number: ");
	        string response = Console.ReadLine();
            user = int.Parse(response);
	
	        if (user != 0)
            {
		        numbers.Add(user);
            }
        }
        
        int sum = 0;

        foreach (int number in numbers)
        {
	        sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
	        if (number > max)
	        {
		        max = number;
	        }
        }

        Console.WriteLine($"The largest number is: {max}");


    }
}