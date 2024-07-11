using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SysInventario.EN
{
    public class Producto
    {
        [Key]
        public int IdProducto {  get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El nombre debe tener menos de 50 caracteres")]
        public string? Nombre {  get; set; }
        [Required]
        [Range(0, 99999999.99)]
        public decimal Precio { get; set; }
        [Required]
        public int Existencia { get; set; }
        [Required]
        public int Estado {  get; set; }
        [Required]
        public int IdCategoria {  get; set; }
    }
}
