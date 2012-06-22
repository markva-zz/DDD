using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Entities;
using HumanResource.Domain.Specifications;

namespace HumanResource.Domain.Repositories
{
    public interface IJobApplicationRepository
    {
        void Save(JobApplication jobApplication);
        IList<JobApplication> Find(ISpecification spec);
        void Delete(JobApplication jobApplication);
        void Delete(IList<JobApplication> jobApplications);
    }
}
