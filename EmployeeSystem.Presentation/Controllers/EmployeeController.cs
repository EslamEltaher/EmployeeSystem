using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeSystem.Application.Interfaces;
using EmployeeSystem.Application.Models;
using EmployeeSystem.Presentation.Mapping;
using EmployeeSystem.Presentation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Presentation.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _uow;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        // GET: Employee
        public async Task<ActionResult> Index()
        {
            var employees = await _uow.EmployeeRepository.GetAllEmployees();
            var employeeList = employees.Select(e => Mapper.MapToEmployeeViewModel(e));
            return View(employeeList);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public async Task<ActionResult> Create()
        {
            var countries = await _uow.CountryRepository.GetAllCountries();
            var viewModel = new AddEmployeeViewModel() {
                Countries = countries.ToList()
            };
            return View(viewModel);
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AddEmployeeViewModel addEmployee)
        {
            try
            {
                var employee = Mapper.MapToEmployee(addEmployee);
                _uow.EmployeeRepository.AddEmployee(employee);
                await _uow.Save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}