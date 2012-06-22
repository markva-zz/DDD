using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.Events
{
    public interface IEvent
    {
        void FireEvent();
    }
}
