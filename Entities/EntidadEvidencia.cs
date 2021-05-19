using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntidadEvidencia
    {
        [Key]
        public int EvidenciaId { get; set; }

        public string Foto { get; set; }

        public DateTime FechaCaptura { get; set; }

        public int EmpleadoId { get; set; }

        public EntidadEmpleado Empleado { get; set; }
    }
}
