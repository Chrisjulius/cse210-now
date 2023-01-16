using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2012;
        job1._endYear = 2013;

        Job job2 = new Job();
        job2._jobTitle = "UI/UX Engineer";
        job2._company = "Amazon";
        job2._startYear = 2014;
        job2._endYear = 2015;

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume._name = "Julius Ogar";

        resume.Display();

    }
}