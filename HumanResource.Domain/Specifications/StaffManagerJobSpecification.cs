using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.ValueObjects;

namespace HumanResource.Domain.Specifications
{
    public class StaffManagerJobSpecification : Job, ISpecification 
    {
        public override string ToString()
        {
            return "Staff manager";
        }

        public bool IsSatisfiedBy(object objectToByEvaluated)
        {
            return true;
        }
    }
}
