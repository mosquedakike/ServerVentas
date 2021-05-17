using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class EntidadProyecto
    {
        [Key]
        public int ProyectoId { get; set; }

        public string NombreProyecto { get; set; }

        public string Municipio { get; set; }

        public bool Estatus { get; set; }

        public int ClienteId { get; set; }

        public EntidadCliente Cliente { get; set; }

        public ICollection<EntidadEmpleado> Empleado { get; set; }
    }
}
