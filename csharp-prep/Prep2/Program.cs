using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");

        string input = Console.ReadLine(); 
        int grade = int.Parse(input); 

        string letter = ""; 

        if (grade >= 90) {
            letter = "a";
        }
        else if (grade >= 80) {
            letter = "b";
        }
        else if (grade >= 70) {
            letter = "c";
        }
        else if (grade >= 60) {
            letter = "d";
        }
        else {
            letter = "f";
        }

        Console.WriteLine($"Your grade is: {letter}"); 

        if (grade >= 70) {
            Console.WriteLine("Congratz");
        }
        else {
            Console.WriteLine("Maybe Next time");
        }
    }
}