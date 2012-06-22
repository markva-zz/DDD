using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Rules;
using HumanResource.Domain.Entities;

namespace HumanResource.Domain.Policies
{
    public class EmploymentPolicy : PolicyBase 
    {
        private MinimumHireAgeRule minAge;
        private HasDriverLicenseRule driverLic;

        public EmploymentPolicy(Person person)
        {
            this.minAge = new MinimumHireAgeRule(person.Age);
            this.driverLic = new HasDriverLicenseRule(person);
        }

        public override bool IsAllowed()
        {
            return this.minAge.IsValid() && this.driverLic.IsValid();
        }
    }
}
