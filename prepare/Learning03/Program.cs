using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract = new Fraction(); 
        Console.WriteLine(fract.GetFractionString());
        Console.WriteLine(fract.GetDecimalValue()); 

        Fraction fract1 = new Fraction(1); 
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetDecimalValue()); 

        Fraction fract2 = new Fraction(2, 5); 
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue()); 

        Fraction fract3 = new Fraction(7, 9); 
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetDecimalValue()); 
    }
}