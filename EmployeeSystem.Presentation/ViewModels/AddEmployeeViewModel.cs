using EmployeeSystem.Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Presentation.ViewModels
{
    public class AddEmployeeViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        public float Salary { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] Photo { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int CountryID { get; set; }

        public List<Country> Countries { get; set; }
    }
}
