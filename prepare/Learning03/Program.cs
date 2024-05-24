using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Console.WriteLine(test1.GetFraction());
        Console.WriteLine(test1.GetDecimal());

        Fraction test2 = new Fraction(17);
        Console.WriteLine(test2.GetFraction());
        Console.WriteLine(test2.GetDecimal());

        Fraction test3 = new Fraction(3, 8);
        Console.WriteLine(test3.GetFraction());
        Console.WriteLine(test3.GetDecimal());

        Fraction test4 = new Fraction(9, 7);
        Console.WriteLine(test4.GetFraction());
        Console.WriteLine(test4.GetDecimal());
    }
}