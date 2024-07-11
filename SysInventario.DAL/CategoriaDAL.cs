using Microsoft.EntityFrameworkCore;
using SysInventario.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysInventario.DAL
{
    public class CategoriaDAL
    {
        //Escribir un metodo publico asincronico que retorne un entero y que como parametro
        //Reciba una categoria

        BDContext _BDContext = new BDContext();
        public static async Task<int> AgregarCategoria(Categoria pCategoria) 
        {
            int resultado = 0;
            using (var bdcontext = new BDContext())
            {
                bdcontext.Add(pCategoria);
                resultado = await bdcontext.SaveChangesAsync();
                return resultado;
            }
        }

        //Crear un metodo publico y asincronico, 
        //que retorne una lista de categorias 
        //y no necesita parametros

        public static async Task<List<Categoria>> MostrarCategoria()
        {
            List<Categoria> ListaDeCategoria = new List<Categoria>();
            using (var bdcontext = new BDContext())
            {
                ListaDeCategoria = await bdcontext.Categoria.ToListAsync();
            }
            return ListaDeCategoria;
        }


    }
}