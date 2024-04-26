using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);

        string letter;
        if (grade >= 90){
            letter = "A";
        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
        else if (grade >= 60){
            letter = "D";
        }
        else {
            letter = "F";
        }

        string sign;
        if ((grade % 10) >= 7){
            if (letter == "A" || letter == "F"){
                sign = "";
            }
            else {
                sign = "+";
            }
        }
        else if ((grade % 10) < 3){
            if (letter == "F"){
                sign = "";
            }
            else {
                sign = "-";
            }
        }
        else {
            sign = "";
        }

        if (letter == "A" || letter == "F") {
            Console.WriteLine($"Your grade is an {letter}{sign}!");
        }
        else {
            Console.WriteLine($"Your grade is a {letter}{sign}!");
        }
        
        if (grade >= 70) {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else {
            Console.WriteLine("I'm sorry, you didn't pass. But I bet you will next time!");
        }

    }
}