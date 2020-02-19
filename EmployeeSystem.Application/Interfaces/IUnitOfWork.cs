using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; }
        ICountryRepository CountryRepository { get; }

        Task Save();
    }
}
