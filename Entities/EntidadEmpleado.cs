using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntidadEmpleado
    {
        [Key]
        public int EmpleadoId { get; set; }

        [Required]
        [StringLength(30)]
        public string NombreEmpleado { get; set; }

        [Required]
        [StringLength(30)]
        public string ApPaterno { get; set; }

        [Required]
        [StringLength(30)]
        public string ApMaterno { get; set; }

        //Relacion con EntidadCliente
        public int ProyectoId { get; set; }

        public EntidadProyecto Proyecto { get; set; }

        public string PuestoEmpleado { get; set; }

        [Required]
        public bool Estatus { get; set; }

        //Relacion con SaleEntity
        public ICollection<EntidadVenta> Ventas { get; set; }

        public ICollection<EntidadEvidencia> Evidencia { get; set; }
    }
}
