using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeSystem.Application.Models
{
    /*
        CountryID int
        CountryName nchar(50)
        CountryCode Ncahr(2)
     */
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}
