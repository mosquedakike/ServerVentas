using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntidadProducto
    {
        [Key]
        public int ProductoId { get; set; }

        [Required]
        [StringLength(80)]
        public string NombreProducto { get; set; }

        [Required]
        [StringLength(600)]
        public string DescripcionProducto { get; set; }

        public string Marca { get; set; }

        public bool Estatus { get; set; }
    }
}
