using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Infrastructure
{
    public interface INotificationService
    {
        void Enqueue(string messageType, string message);
        void ProcessQueue();
    }
}
