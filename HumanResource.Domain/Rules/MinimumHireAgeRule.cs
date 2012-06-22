using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Entities;

namespace HumanResource.Domain.Rules
{
    public class MinimumHireAgeRule : RuleBase 
    {
        private int age;
        public MinimumHireAgeRule(int age)
            : base(">= 18", "Min. hire age is 18")
        {
            this.age = age;
        }

        public override bool IsValid()
        {
            return this.age >= 18;
        }

        
    }
}
