using EmployeeSystem.Application.Models;
using EmployeeSystem.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Presentation.Mapping
{
    //todo replace with automapper
    public static class Mapper
    {
        public static EmployeeViewModel MapToEmployeeViewModel(Employee employee)
        {
            return new EmployeeViewModel()
            {
                Id = employee.Id,
                Name = employee.Name,
                Title = employee.Title,
                Salary = employee.Salary,
                Email = employee.Email,
                BirthDate = employee.BirthDate,
                Photo = employee.Photo,
                CountryName = employee.Country.CountryName,
            };
        }
    }
}
