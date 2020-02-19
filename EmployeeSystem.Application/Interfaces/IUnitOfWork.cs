using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Application.Interfaces
{
    interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; set; }
        ICountryRepository CountryRepository { get; set; }

        Task Save();
    }
}
