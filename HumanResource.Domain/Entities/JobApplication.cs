using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.ValueObjects;
using HumanResource.Domain.Services;

namespace HumanResource.Domain.Entities
{
    public class JobApplication 
    {

        public JobApplication()
        {
            this.jobApplicationID = Guid.NewGuid();
        }

        private Guid jobApplicationID;
        public Guid JobApplicationID { get { return this.jobApplicationID; } }

        public ContactInfo ContactInformation { get; set; }
        
        public Job Job { get; set; }
        
        public string Skills { get; set; }
        public int Age { get; set; }
        public DateTime DateSubmitted { get; set; } 
    }
}
