using Microsoft.AspNetCore.Mvc;

using SysInventario.BL;
using SysInventario.EN;

namespace SysInventario.UI.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        public async Task<IActionResult> Create (Categoria pCategoria)
        {
            int result = await CategoriaBL.AgregarCategoria(pCategoria);
            return View();
        }

    }
}
