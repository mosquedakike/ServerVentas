using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntidadVenta
    {
        [Key]
        public int VentaId { get; set; }

        //Relacion con EntidadEmpleado
        public int EmpleadoId { get; set; }

        [Required]
        public EntidadEmpleado Empleado { get; set; }

        [Required(ErrorMessage = "El campo Producto es requerido")]
        public string NombreProducto { get; set; }

        [Required]
        public string DescripcionProducto { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public DateTime FechaVenta { get; set; }

        [Required]
        public DateTime FechaCaptura { get; set; }
    }
}
