/*

    Class: Job
    Attributes: 
    *_jobTitle : string
    *_startYear : int
    *_endYear : int

    Behaviors:
    *Display() : void

*/

public class Job
{
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _endYear;

    public Job()
    {

    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}
