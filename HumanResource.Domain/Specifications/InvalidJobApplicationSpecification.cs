using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Rules;

namespace HumanResource.Domain.Specifications
{
    public class InvalidJobApplicationSpecification : ISpecification 
    {
        public InvalidJobApplicationSpecification()
        { }
        
        public string Expression
        {
            get
            {
                return String.Format("SubmittedDate < '{0}'", DateTime.Today);
            }
        }
    }
}
