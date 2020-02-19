using EmployeeSystem.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeById(int id);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<IEnumerable<Employee>> SearchEmployees(EmployeeFiltrationCriteria criteria);

        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
