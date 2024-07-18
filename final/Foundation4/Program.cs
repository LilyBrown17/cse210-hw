using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Biking biking = new Biking(2.0, 30, "05 May 2023");
        Running running = new Running(2.5, 75, "07 May 2023");
        Swimming swimming = new Swimming(10.0, 15, "08 May 2023");

        activities.Add(biking);
        activities.Add(running);
        activities.Add(swimming);

        Console.Write($"\n");

        foreach (Activity activity in activities)
        {
            Console.Write($"{activity.GetSummary()}\n\n");
        }
    }
}