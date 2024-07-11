using Microsoft.AspNetCore.Mvc;

namespace SysInventario.UI.Controllers
{
    public class PromedioController : Controller
    {
        [HttpGet]
        public IActionResult promedio()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult promedio(double N1,double N2, double N3, double N4, double N5)
        {
            double suma = N1 + N2 + N3 + N4 + N5;
            double result = suma /5;

            ViewData["result"] = result;
            return View();
        }
    }

}
