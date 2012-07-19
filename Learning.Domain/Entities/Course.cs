using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Learning.Domain.ValueObjects;

namespace Learning.Domain.Entities
{
    class Course
    {
        public string CourseID { get; set; }
        public string Name { get; set; }
        public IList<Category> Categories { get; set; }
    }
}
