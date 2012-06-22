using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.Policies
{
    public abstract class PolicyBase : IPolicy 
    {
        public abstract bool IsAllowed();
    }
}
