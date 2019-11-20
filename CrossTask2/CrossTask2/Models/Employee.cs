using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrossTask2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [DisplayName("Employee Name")]
        [Required]
        public string EmployeeName { get; set; }

        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }
    }
}