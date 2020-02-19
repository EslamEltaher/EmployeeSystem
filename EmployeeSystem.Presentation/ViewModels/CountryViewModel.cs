using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Presentation.ViewModels
{
    public class CountryViewModel
    {
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; }
        [MaxLength(2)]
        public string CountryCode { get; set; }
    }
}
