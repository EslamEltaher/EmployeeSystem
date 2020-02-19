using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Presentation.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public float Salary { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] Photo { get; set; }
        public string CountryName { get; set; }
    }
}
