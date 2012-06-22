using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Infrastructure;
using System.Configuration;

namespace HumanResource.Presentation
{
    class Configuration
    {
        private static JobApplicationStoreType _jobApplicationStoreType = Infrastructure.JobApplicationStoreType.File;
        public static JobApplicationStoreType JobApplicationStoreType
        {
            get 
            {
                // get from settings file
                return _jobApplicationStoreType;
            }

            set 
            {
                // write to config. file
                _jobApplicationStoreType = value;
            }
        }
    }
}
