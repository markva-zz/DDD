using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Entities;
using HumanResource.Domain.Specifications;
using HumanResource.Domain.ValueObjects;

namespace HumanResource.Domain.Repositories
{
    public interface IJobApplicationRepository
    {
        void Save(JobApplication jobApplication);
        JobApplication Find(JobApplicationKey key);
        IList<JobApplication> Find(ISpecification spec);
        void Delete(JobApplication jobApplication);
        void Delete(IList<JobApplication> jobApplications);
    }
}
