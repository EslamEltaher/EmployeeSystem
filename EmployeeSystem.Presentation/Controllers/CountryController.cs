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
    public class CountryController : Controller
    {
        private readonly IUnitOfWork _uow;

        public CountryController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
        // GET: Country
        public async Task<ActionResult> Index()
        {
            var countries = await _uow.CountryRepository.GetAllCountries();
            return View(countries);
        }

        // GET: Country/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Country/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Country/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CountryViewModel viewModel)
        {
            try
            {
                Country country = Mapper.MapToCountry(viewModel);
                _uow.CountryRepository.AddCountry(country);
                await _uow.Save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Country/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Country/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}