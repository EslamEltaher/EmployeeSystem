using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeSystem.Application.Models
{
    /*
        empID int
        empName nchar(50)
        empTitle nchar(50)
        empSalary float
        empEmail nchar(50)
        empBirthDate date
        empPhoto varbinary(MAX)
        CountryID int

        //naming is applied in context
     */
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        public float Salary { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] Photo { get; set; }

        public Country Country { get; set; }
        [Required]
        public int CountryID { get; set; }
    }
}
