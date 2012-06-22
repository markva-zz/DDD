using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Repositories;
using HumanResource.Domain.Entities;
using HumanResource.Domain.Specifications;

namespace HumanResource.Infrastructure
{
    public class JobApplicationSqlRepository : IJobApplicationRepository
    {
        public void Save(JobApplication jobApplication)
        {
            Console.Write("Using {0}\n", this.GetType().ToString());
        }

        public IList<JobApplication> Find(ISpecification spec)
        {
            Console.Write("Using {0} to find unhandled job applications\n", this.GetType().ToString());
            return new List<JobApplication>();
        }

        public void Delete(JobApplication jobApplication)
        {
            Console.Write("Using {0}\n", this.GetType().ToString());
        }

        public void Delete(IList<JobApplication> jobApplications)
        {
            Console.Write("Using {0}\n", this.GetType().ToString());
        }
    }
}
