using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lekadex.Controllers
{
    public class PrescriptionController : Controller
    {

       private int mIndexOfDoctor { get; set; }
        public PrescriptionController()
        {
           
        }

        public IActionResult Index(int indexOfDoctor)
        {
            mIndexOfDoctor = indexOfDoctor;
            return View(TestDatabasePlysDelete.Doctors.ElementAt(indexOfDoctor));
        }
        public IActionResult View(int indexOfPrescription)
        {
          
           return RedirectToAction("Index", "Medicine",new { IndexOfDoctor = mIndexOfDoctor,IndexOfPrescription = indexOfPrescription});
        }
        public IActionResult Delete(int indexOfPrescription)
        {
            return View();
        }

       



    }
}
