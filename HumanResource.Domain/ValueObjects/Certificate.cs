using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.ValueObjects
{
    public class Certificate
    {
        public string Name { get; set; }
        public string IssuerName { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
