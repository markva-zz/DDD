using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Infrastructure
{
    public class NotificationService : INotificationService 
    {
        public void Enqueue(string messageType, string message)
        {
            Console.Write("Enqueueing {0}", messageType);
        }

        public void ProcessQueue()
        {
            Console.Write("NOTIFYING SUBSCRIBERS");
        }

        
    }
}
