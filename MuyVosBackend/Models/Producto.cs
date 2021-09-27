using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuyVosBackend.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public int CantidadStock { get; set; }
        [Required]
        public decimal PrecioCompra { get; set; }
        [Required]
        public decimal PrecioVenta { get; set; }
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public int IdSubCategoria { get; set; }
        [Required]
        public string SubCategoria { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
