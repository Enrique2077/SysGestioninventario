using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SysInventario.EN
{
    public class Categoria
    {
        [Key]
       public int IdCategoria { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El nombre debe tener menos de 50 caracteres")]
       public string? Nombre { get; set; }
        [Required]
       public byte Estado { get; set; }
       
    }
}
