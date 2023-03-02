using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Developer Intern";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "Seven Oaks Group";
        job2._jobTitle = "Software Engineer Junior";
        job2._startYear = 2021;
        job2._endYear = 2023;

        // Testing Code 
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Testing Code
        //Console.WriteLine(resume._jobs[1]._company);

        resume.DisplayResumeDetails();
        
    }
}