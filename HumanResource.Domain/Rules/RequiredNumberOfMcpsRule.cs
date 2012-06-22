using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Entities;
using HumanResource.Domain.ValueObjects;

namespace HumanResource.Domain.Rules
{
    public class RequiredNumberOfMcpsRule : RuleBase 
    {
        private Person person;

        public RequiredNumberOfMcpsRule(Person person) : base("Minimum of 2 MCPs are required") 
        {
            this.person = person;
        }
        
        public override bool IsValid()
        {
            int count = 0;

            foreach (Certificate cert in person.Certificates)
            {
                if (cert is Mcp)
                    count += 1;
            }

            return (count >= 2);
                
        }
    }
}
