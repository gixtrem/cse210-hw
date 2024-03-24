using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Computer Scientist";
        job1._startYear = 2019;
        job1._endYear = 2021;
        job1._companyName = "Azure Enterprise";
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Project manager";
        job2._startYear = 2017;
        job2._endYear = 2018;
        job2._companyName = "Cisco";
        job2.Display();



        Resume resume1 = new Resume();
        resume1._name = "Umah";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();

    }
}