using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Services
{
    public class JobsService
    {
        public List<JobOpening> GetEngineeringJobOpenings()
        {
            List<JobOpening> engineeringJobs = new List<JobOpening>
            {
                new JobOpening
                {
                    Title = "Software Engineer",
                    Description = ".NET Coding monkey"
                },
                new JobOpening
                {
                    Title = "Software Engineer",
                    Description = "Java Coding monkey"
                }
            };

            return engineeringJobs;
        }

        public List<JobOpening> GetManagementJobOpenings()
        {
            return null;
        }

        public List<JobOpening> GetInternships()
        {
            List<JobOpening> internships = new List<JobOpening>
            {
                new JobOpening
                {
                    Title = "Software Engineer Intern",
                    Description = "Little .NET Coding monkey"
                },
                new JobOpening
                {
                    Title = "Software Engineer Intern",
                    Description = "Little Java Coding monkey"
                }
            };

            return internships;
        }
    }
}