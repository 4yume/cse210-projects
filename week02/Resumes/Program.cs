using System;

class Program
{
    static void Main(string[] args)
    {
        //job class
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Developper";
        job2._company = "Apple";
        job2._startYear = 2025;
        job2._endYear = 2028;


        //Resume class
        Resume myResume = new Resume();
        myResume._name = "John";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}