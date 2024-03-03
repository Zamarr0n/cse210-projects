using System;
using System.Globalization;       
// Class: Job
// Responsibilities:
// Keeps track of the company, job title, start year, and end year.
// Behaviors:
// Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
// Class: Resume
// Responsibilities:
// Keeps track of the person's name and a list of their jobs.
// Behaviors:
// Displays the resume, which shows the name first, followed by displaying each one of the jobs

    public class job{
        public string _jobTittle;
        public string _Company;
        public int _startYear;
        public int _endYear;
        public void Display(){
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }

    }
