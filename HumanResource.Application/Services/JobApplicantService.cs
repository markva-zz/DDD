using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Services;
using HumanResource.Domain.Entities;
using HumanResource.Domain.Rules;
using HumanResource.Domain.Specifications;
using HumanResource.Infrastructure;
using HumanResource.Domain.Repositories;

namespace HumanResource.Application.Services
{
    public class JobApplicantService : HumanResource.Domain.Services.JobApplicantService
    {
        private INotificationService notificationService = new NotificationService();

        public JobApplicantService(IJobApplicationRepository jobApplicationRepository) : base(jobApplicationRepository)
        { }

        public override void Submit(JobApplication jobApplication)
        {
            // implement base behavoiur
            base.Submit(jobApplication);
            
            // write message to notification queue            
            notificationService.Enqueue(jobApplication.ToString(), jobApplication.JobApplicationID.ToString());
            
        }
    }
}
