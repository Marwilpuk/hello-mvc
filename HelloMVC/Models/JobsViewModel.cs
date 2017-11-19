using System.Collections.Generic;

namespace HelloMVC.Models
{
    public class JobsViewModel
    {
        public string ApplyEndDate { get; set; }

        public List<JobOpening> EngineeringJobs { get; set; }

        public List<JobOpening> ManagementJobs { get; set; }

        public List<JobOpening> Internships { get; set; }
    }
}