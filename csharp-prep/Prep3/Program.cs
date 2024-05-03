using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string playloop = "yes";
        int games = 0;

        while (playloop == "yes")
        {
            int magic = randomGenerator.Next(1, 100);
            string gameloop = "yes";

            while (gameloop == "yes")
            {
	            Console.WriteLine("What is your guess? ");
	            string response = Console.ReadLine();
                int guess = int.Parse(response);
	
	            if (guess > magic)
	            {
	                Console.WriteLine("Try guessing lower.");
	            }	

	            else if (guess < magic)
	            {
	                Console.WriteLine("Try guessing higher.");
	            }

	            else if (guess == magic)
	            {
	                Console.WriteLine("You guessed it!");
	                gameloop = "no";
	                games += 1;
	            }
            }

            Console.WriteLine($"You have played {games} games!");
            Console.WriteLine("Would you like to play again? yes/no");
            playloop = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}