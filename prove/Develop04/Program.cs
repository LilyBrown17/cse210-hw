using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool _runProgram = true;

        while (_runProgram == true)
        {
            Console.Clear();

            Console.WriteLine("Menu Options: \n1. Start Breathing Activity \n2. Start Reflecting Activity \n3. Start Listing Activity \n4. Quit");
            Console.WriteLine("Select a choice from the menu:");

            string _selection = Console.ReadLine();

            if(_selection == "1")
            {
                BreathingActivity _breathing = new BreathingActivity("Breathing", 
                "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                _breathing.InteractBreathing();
            }
            else if(_selection == "2")
            {
                ReflectingActivity _reflection = new ReflectingActivity("Reflecting", 
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                _reflection.InteractReflecting();
            }
            else if(_selection == "3")
            {
                ListingActivity _listing = new ListingActivity("Listing", 
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                _listing.InteractListing();
            }
            else if(_selection == "4")
            {
                _runProgram = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}