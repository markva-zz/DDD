using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace HumanResource.Domain.Entities
{
    public class Person 
    {
        public Person()
        { 
            this.certificates = new List<Certificate>();
        }

        [Required]
        public string PersonID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get 
            {
                return DateTime.Today.Year - this.DateOfBirth.Year;
            }
        }

        private IList<Certificate> certificates;
        public IList<Certificate> Certificates
        {
            get { return this.certificates; }
        }
    }
}
