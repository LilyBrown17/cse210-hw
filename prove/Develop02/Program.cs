using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int runProgram = 0;
        Journal newJournal = new Journal();
        Entry addedEntry = new Entry();

        string currentJournal = InitialLoad();

        Console.WriteLine("Welcome to the Journal!");

        while (runProgram == 0)
        {
            Console.WriteLine("\n Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                string myEntry = addedEntry.Write();
                newJournal.AddEntry(myEntry);
            }
            else if (selection == "2")
            {
                DisplayJournal(currentJournal, newJournal);
            }
            else if (selection == "3")
            {
                newJournal = new Journal();
                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();
                currentJournal = Load(filename);
            }
            else if (selection == "4")
            {
                newJournal.Save();
            }
            else if (selection == "5")
            {
                runProgram = 1;
            }
            else
            {
                Console.WriteLine("I'm sorry, that's not a valid input.");
            }

        }  
    }


    public static string Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        string returnJournal = "";

        foreach (string line in lines)
        {
            returnJournal = $"{returnJournal}\n{line}";
        }
        return returnJournal;
    }

    public static void DisplayJournal(string myJournal, Journal journal)
    {
        string showJournal = journal.ToNewString(myJournal);
        Console.WriteLine(showJournal);
    }

    public static string InitialLoad()
    {
        string firstJournal = "";
        return firstJournal;
    }
}