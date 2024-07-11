using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Libreeria de persistencias de datos
using Microsoft.EntityFrameworkCore;
// Referencias de los modelos de mis tablas
using SysInventario.EN;

namespace SysInventario.DAL
{
    public class BDContext: DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> producto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MORÁN\SQLEXPRESS;Initial Catalog=BDInventarioo;Integrated Security=True;Trust Server Certificate=True");
        }


    }
}