using System;

class Fraction
{
        private int numerator;
    private int denominator;

    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int whole)
    {
        numerator = whole;
        denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }

    public string GetFraction()
    {
        string fractionText = $"{numerator}/{denominator}";
        return fractionText;
    }

    public double GetDecimal()
    {
        return (double)numerator / (double)denominator;
    }
}