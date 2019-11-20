using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossTask2.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}