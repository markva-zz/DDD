using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Entities;
using HumanResource.Domain.Rules;
using HumanResource.Domain.Specifications;
using HumanResource.Domain.Repositories;

namespace HumanResource.Domain.Services
{
    public abstract class JobApplicantService 
    {
        protected IJobApplicationRepository jobApplicationRepository;

        protected JobApplicantService(IJobApplicationRepository jobApplicationRepository)
        {
            this.jobApplicationRepository = jobApplicationRepository;
        }

        public virtual void Submit(JobApplication jobApplication)
        {
            // evaluate business rules/policies
            RuleBase minHireAge = new MinimumHireAgeRule(jobApplication.Age);
            if (!minHireAge.IsValid())
                throw new ApplicationException(String.Format("{0} was violated", minHireAge.Description));

            try
            {
                this.jobApplicationRepository.Save(jobApplication);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Purge()
        { 
            // find old and invalid job applications
            this.jobApplicationRepository.Delete(
                this.jobApplicationRepository.Find(new InvalidJobApplicationSpecification()));
        }

        
    }
}
