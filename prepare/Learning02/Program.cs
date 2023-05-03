using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); 
        job1._jobTitle = "Fork Lifter"; 
        job1._company = "Deseret Mill";
        job1._startYear = 1; 
        job1._endYear = 2; 

        Job job2 = new Job(); 
        job2._jobTitle = "Foamer"; 
        job2._company = "Harvest Right";
        job2._startYear = 1; 
        job2._endYear = 2; 

        Resume myResume = new Resume(); 
        myResume._name = "Stephen Becktead"; 

        myResume._jobs.Add(job1); 
        myResume._jobs.Add(job2); 

        myResume.Display();
    }
}