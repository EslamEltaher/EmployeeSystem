using EmployeeSystem.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Application.Interfaces
{
    public interface ICountryRepository
    {
        Task<Country> GetCountryById(int id);
        Task<Country> GetCountryByCode(string code);
        Task<IEnumerable<Country>> GetAllCountries();

        void AddCountry(Country country);
        void UpdateCountry(Country country);
        void DeleteCountry(Country country);
    }
}
