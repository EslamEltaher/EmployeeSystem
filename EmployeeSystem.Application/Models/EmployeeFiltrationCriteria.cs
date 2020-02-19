using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSystem.Application.Models
{
    public class EmployeeFiltrationCriteria
    {
        public string Name { get; set; }
        public string CountryName { get; set; }
        public string Title { get; set; }
        public float? SalaryFrom { get; set; }
        public float? SalaryTo { get; set; }
    }
}
