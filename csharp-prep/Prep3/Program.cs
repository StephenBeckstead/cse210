using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random(); 
        int rand = randomGenerator.Next(1,100); 

        int guess = -1; 

        while (guess != rand) {
            Console.WriteLine("What is your guess"); 
            string notguess = Console.ReadLine(); 
            guess = int.Parse(notguess); 

            if (rand > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (rand < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }



    }
}