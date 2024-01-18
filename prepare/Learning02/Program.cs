using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("");
        Job job1 = new Job();
        job1._jobTitle = "Transcriptionist";
        job1._companyName = "GoTranscript";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Graphic Designer";
        job2._companyName = "Prefab";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Graphamo";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResumeDetails();
    }
}