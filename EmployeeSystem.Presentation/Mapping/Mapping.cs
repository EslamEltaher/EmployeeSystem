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

        public static Employee MapToEmployee(AddEmployeeViewModel employee)
        {
            return new Employee()
            {
                Name = employee.Name,
                Title = employee.Title,
                Salary = employee.Salary,
                Email = employee.Email,
                BirthDate = employee.BirthDate,
                Photo = employee.Photo,
                CountryID = employee.CountryID,
            };
        }
        public static Employee MapToEmployee(UpdateEmployeeViewModel employee)
        {
            return new Employee()
            {
                Name = employee.Name,
                Title = employee.Title,
                Salary = employee.Salary,
                Email = employee.Email,
                BirthDate = employee.BirthDate,
                Photo = employee.Photo,
                CountryID = employee.CountryID,
            };
        }

        public static UpdateEmployeeViewModel MapToUpdateEmployeeViewModel(Employee employee)
        {
            return new UpdateEmployeeViewModel()
            {
                Name = employee.Name,
                Title = employee.Title,
                Salary = employee.Salary,
                Email = employee.Email,
                BirthDate = employee.BirthDate,
                Photo = employee.Photo,
                CountryID = employee.CountryID
            };
        }
    }
}
