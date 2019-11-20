using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_Project.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new CreatePersonViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(CreatePersonViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
