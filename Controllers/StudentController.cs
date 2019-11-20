using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174_Project.Models;

namespace CIS174_Project.Controllers
{

    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
