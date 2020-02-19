using EmployeeSystem.Application.Interfaces;
using EmployeeSystem.Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Persistence.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly EmployeeContext _context;

        public CountryRepository(EmployeeContext context)
        {
            _context = context;
        }

        public void AddCountry(Country country)
        {
            _context.Countries.Add(country);
        }

        public void UpdateCountry(Country country)
        {
            _context.Countries.Update(country);
        }
        public void DeleteCountry(Country country)
        {
            _context.Countries.Remove(country);
        }

        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country> GetCountryByCode(string code)
        {
            return await _context.Countries.FirstOrDefaultAsync(c => c.CountryCode == code);
        }

        public async Task<Country> GetCountryById(int id)
        {
            return await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
        }

    }
}
