using Lekadex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lekadex.Controllers
{
    public class MedicineController : Controller
    {
        

        public MedicineController()
        {
            
        }

        public IActionResult Index(int IndexOfDoctor , int IndexOfPrescription)
        {
            return View(TestDatabasePlysDelete.Doctors.ElementAt(IndexOfDoctor).Prescriptions.ElementAt(IndexOfPrescription));
        }
        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }




    }
}
