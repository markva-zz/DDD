using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.ValueObjects
{
    public class ContactInfo
    {
        public string Name { get; set; }
        public Address HomeAddress { get; set; }
        public Address MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        
    }
}
