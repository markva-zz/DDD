using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.ValueObjects
{
    public class Mcp : Certificate
    {
        public Mcp(string name)
        {
            this.Name = name;
            this.IssuerName = "Microsoft";
        }
    }
}
