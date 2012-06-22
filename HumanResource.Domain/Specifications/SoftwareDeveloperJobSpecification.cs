using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.ValueObjects;
using HumanResource.Domain.Entities;
using HumanResource.Domain.Rules;

namespace HumanResource.Domain.Specifications
{
    public class SoftwareDeveloperJobSpecification : Job, ISpecification 
    {
        public SoftwareDeveloperJobSpecification()
        {
            this.Name = "Software developer";
            this.Description = "Works with coding...";
        }

        public override string ToString()
        {
            return this.Name;
        }

        public bool IsSatisfiedBy(object objectToByEvaluated)
        {
            Person person = (Person)objectToByEvaluated;

            HasDriverLicenseRule hasDriverLicense = new HasDriverLicenseRule(person);
            RequiredNumberOfMcpsRule reqMcps = new RequiredNumberOfMcpsRule(person);

            return hasDriverLicense.IsValid() && reqMcps.IsValid();
        }
    }
}
