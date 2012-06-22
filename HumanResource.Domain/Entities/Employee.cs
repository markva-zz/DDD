using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.Entities
{
    public class Employee : Person 
    {
        public Employee(int employeeID)
        {
            this.employeeID = employeeID;
        }

        private int employeeID;
        public int EmployeeID
        {
            get { return this.employeeID; ; }
        }
        
        public DateTime HireDate { get; set; }

        
    }
}
