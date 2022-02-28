using Lekadex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Lekadex.Controllers
{
    public class HomeController : Controller
    {

        
        public HomeController()
        {
         
        }

        public IActionResult Index()
        {
            return View(TestDatabasePlysDelete.Doctors);
        }

        public IActionResult View(int indexOfDoctor)
        {
            return RedirectToAction("Index", "Prescription", new { indexOfDoctor = indexOfDoctor } );
        }



        public IActionResult Delete(int indexOfDoctor)
        {

            return View(TestDatabasePlysDelete.Doctors);
        }

    }
}
