using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.Rules
{
    public interface IRule
    {
        bool IsValid();
    }
}
