using EmployeeSystem.Application.Interfaces;
using EmployeeSystem.Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Persistence.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _context.Employees
                .Include(e => e.Country)
                .ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Employees
                .Include(e => e.Country)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Employee>> SearchEmployees(EmployeeFiltrationCriteria criteria)
        {
            IQueryable<Employee> queriable = _context.Employees.Include(e => e.Country);

            if (!string.IsNullOrEmpty(criteria.Name))
                queriable = queriable.Where(e => e.Name == criteria.Name);
            if (!string.IsNullOrEmpty(criteria.CountryName))
                queriable = queriable.Where(e => e.Country.CountryName == criteria.CountryName);
            if (!string.IsNullOrEmpty(criteria.Title))
                queriable = queriable.Where(e => e.Title == criteria.Title);
            if (criteria.SalaryFrom != null)
                queriable = queriable.Where(e => e.Salary > criteria.SalaryFrom);
            if (criteria.SalaryTo != null)
                queriable = queriable.Where(e => e.Salary > criteria.SalaryTo);

            return await queriable.ToListAsync();
        }

    }
}
