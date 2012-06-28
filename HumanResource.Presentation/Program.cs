using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Entities;
using HumanResource.Application.Services;
using HumanResource.Domain.Specifications;
using HumanResource.Domain.ValueObjects;
using HumanResource.Domain.Repositories;
using HumanResource.Infrastructure;

namespace HumanResource.Presentation
{
    class Program
    {
        static JobApplicantService jobApplicantService;

        static void Main(string[] args)
        {
            // BOOTSTRAPPER
            // which repository implementation are we using today? (read config)
            if (Configuration.JobApplicationStoreType == JobApplicationStoreType.File)
                jobApplicantService = new JobApplicantService(new JobApplicationFileRepository());

            else if (Configuration.JobApplicationStoreType == JobApplicationStoreType.InMem)
                jobApplicantService = new JobApplicantService(new JobApplicationInMemRepository());
            else
                throw new NotImplementedException();
            
            // test submit
            CreateAndSubmitJobApplication();

            // test purge
            PurgeOutOfDateAndInvalidJobApplications();

            Console.ReadLine();
        }

        static void CreateAndSubmitJobApplication()
        {
            JobApplication application = new JobApplication();
            ContactInfo applicant = new ContactInfo();
            applicant.Name = "Marcus Kvarnström";
            applicant.MailAddress = new Address();
            application.ContactInformation = applicant;
            application.Job = new SoftwareDeveloperJobSpecification();
            application.Skills = "I know almost everything and eager to learn what's left";
            application.DateOfBirth = new DateTime(1972, 8, 21);

            try
            {
                jobApplicantService.Submit(application);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void PurgeOutOfDateAndInvalidJobApplications()
        {
            try
            {
                jobApplicantService.Purge();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
