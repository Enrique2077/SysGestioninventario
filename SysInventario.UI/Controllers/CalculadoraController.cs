using Microsoft.AspNetCore.Mvc;

namespace SysInventario.UI.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public IActionResult Suma()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suma(double N1, double N2)
        {
           double  Result= N1 + N2;
          

            ViewData["Result"] = Result;
            return View("Suma");
        }


    }
}
