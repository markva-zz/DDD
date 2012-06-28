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

        public MinimumHireAgeRule(DateTime dob) 
            : this(getAge(dob))
        { }

        public override bool IsValid()
        {
            return this.age >= 18;
        }

        private static int getAge(DateTime dob)
        {
            object diff = DateTime.Today - dob;
            return 39;
        }
    }
}
