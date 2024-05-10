using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Front of House";
        job1._company = "Noodles & Company";
        job1._startYear = 2020;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Service Crew Member";
        job2._company = "McDonalds";
        job2._startYear = 2022;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Lily Brown";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}