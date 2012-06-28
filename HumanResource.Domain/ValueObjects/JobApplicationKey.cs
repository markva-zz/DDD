using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.ValueObjects
{
    public class JobApplicationKey
    {
        public JobApplicationKey(int key)
        {
            this.key = key;
        }

        private int key;
        public int Key { get { return this.key; } }
    }
}
