using Microsoft.AspNetCore.Mvc;

namespace Work_01.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
