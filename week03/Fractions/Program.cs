using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFranctionString());
        Console.WriteLine(f1.GerDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFranctionString());
        Console.WriteLine(f2.GerDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFranctionString());
        Console.WriteLine(f3.GerDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFranctionString());
        Console.WriteLine(f4.GerDecimalValue());

        
    }
}