using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.Policies
{
    public interface IPolicy
    {
        bool IsAllowed();
    }
}
