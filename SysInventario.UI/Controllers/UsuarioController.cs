using Microsoft.AspNetCore.Mvc;

namespace SysInventario.UI.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Encriptar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Encriptar(String pPalabra)
        {
            string resultado = string.Empty;
            for (int i = 0; i < pPalabra.Length; i++)
            {
                string letra= pPalabra.Substring(i,1);
                int numeroletra = Convert.ToChar(letra);
                int letracifrada = numeroletra + 3;
                char letraresultado = (char)letracifrada;
                resultado = resultado + letraresultado;
               // int contador = i;
            }
            ViewData["Palabra"]= resultado;
            return View();
        }


        [HttpGet]
        public IActionResult Desencriptar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Desencriptar(String pPalabras)
        {
                string resultados = string.Empty;
                for (int i = 0; i < pPalabras.Length; i++)
                {
                    string letra = pPalabras.Substring(i,1);
                    int numeroletra = Convert.ToChar(letra);
                    int letradescifrada = numeroletra - 3;
                    char letraresultado = (char)letradescifrada;
                    resultados = resultados + letraresultado;
                    // int contador = i;
                }
                ViewData["Palabras"] = resultados;
                return View("Encriptar");
            

        }
    }
}
