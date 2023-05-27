using System;

//Extra was allowing the user to enter the scripture He or She wanted to memorize.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the scritpure reference: ");
        string referenceTitle = Console.ReadLine();

        Console.WriteLine("Enter the scripture: ");
        string scriptureText = Console.ReadLine();

        Scripture scripture = new Scripture(referenceTitle, scriptureText);

        ConsoleKeyInfo key;
        
        do{
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("Press Enter to hide words or type 'quit' to finish");
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter){
                scripture.HideRandomWord();
            }

        } while (key.Key != ConsoleKey.Escape);

        Console.WriteLine("Out of words. Press any key to excit");
        Console.ReadKey();
    }
}
