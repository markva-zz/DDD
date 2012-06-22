using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.Specifications
{
    public interface ISpecification
    {
        string Expression { get; }
    }
}
