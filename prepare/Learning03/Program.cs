using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal form: {fraction1.GetDecimalValue()}");

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
        Console.WriteLine($"Decimal form: {fraction2.GetDecimalValue()}");

        Fraction fraction3 = new Fraction(6, 8);
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal form: {fraction3.GetDecimalValue()}");
    }
}