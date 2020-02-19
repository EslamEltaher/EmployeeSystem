using EmployeeSystem.Application.Interfaces;
using EmployeeSystem.Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
