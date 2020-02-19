using EmployeeSystem.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeContext _context;

        public IEmployeeRepository EmployeeRepository { get; private set; }
        public ICountryRepository CountryRepository { get; private set; }

        public UnitOfWork(IEmployeeRepository employeeRepository, ICountryRepository countryRepository, EmployeeContext context)
        {
            EmployeeRepository = employeeRepository;
            CountryRepository = countryRepository;
            _context = context;
        }
        

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
