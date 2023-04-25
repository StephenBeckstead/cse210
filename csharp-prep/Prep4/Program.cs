using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> nlist = new List <int>(); 

        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while( number != 0 ) {
            Console.WriteLine("Enter number"); 
            string randnum = Console.ReadLine(); 
            number = int.Parse(randnum); 

            if(number != 0){
                nlist.Add(number); 
            }

        }
        int sum = 0; 
        foreach (int num in nlist) {
            sum += num; 
        }

        Console.WriteLine($"The sum is {sum}"); 

        float average = ((float)sum) / nlist.Count;
        Console.WriteLine($"The average is {average}"); 

        int max = 0; 

        foreach ( int num in nlist) {
            if (num > max) {
                max = num; 
            }
        }
        Console.WriteLine($"The Max is {max}");
    }
}