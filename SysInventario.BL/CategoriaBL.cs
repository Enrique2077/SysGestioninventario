using SysInventario.EN;
using SysInventario.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysInventario.BL
{
    public class CategoriaBL
    {
        public static async Task<int> AgregarCategoria(Categoria pCategoria)
        {
            return await CategoriaDAL.AgregarCategoria(pCategoria);
        }

        public static async Task<List<Categoria>> MostrarCategoria()
        {
            return await CategoriaDAL.MostrarCategoria();
        }
    }
}
