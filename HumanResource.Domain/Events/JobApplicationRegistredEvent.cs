using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Entities;

namespace HumanResource.Domain.Events
{
    public class JobApplicationRegistredEvent : IEvent 
    {
        //private object notificationService;
 
        public JobApplicationRegistredEvent(JobApplication jobApplication)
        { }

        public void FireEvent()
        {
            throw new NotImplementedException();
        }
    }
}
