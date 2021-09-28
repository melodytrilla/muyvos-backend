using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuyVosBackend.Models
{
    public class Venta
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int Id_producto { get; set; }
        [Required]
        public int Cantidad { get; set; }
    }
}
