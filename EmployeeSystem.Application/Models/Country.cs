using System;
using System.Collections.Generic;
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
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}
