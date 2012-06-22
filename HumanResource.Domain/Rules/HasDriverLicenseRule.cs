using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Entities;
using HumanResource.Domain.ValueObjects;

namespace HumanResource.Domain.Rules
{
    public class HasDriverLicenseRule : RuleBase 
    {
        private Person person;

        public HasDriverLicenseRule(Person person) : base("Driver license is required") 
        {
            this.person = person;
        }

        public override bool IsValid()
        {
            bool returnValue = false;

            foreach (Certificate cert in person.Certificates)
            {
                if (cert is DriverLicense)
                {
                    returnValue = true;
                    break;
                }
            }

            return returnValue;
        }
    }
}
