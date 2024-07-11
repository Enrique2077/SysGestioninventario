using Microsoft.AspNetCore.Mvc;

namespace SysInventario.UI.Controllers
{
    public class ConteoController : Controller
    {
        [HttpGet]
        public IActionResult Conteo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Conteo (string pPalabra)
        {

            ViewData["Palabra"] = pPalabra.Length;
            return View();

        }
    }
}
