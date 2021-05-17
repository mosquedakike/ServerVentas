using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Producto
    {
        public static List<EntidadProducto> ListaProducto()
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Productos.ToList();
            }
        }

        public static EntidadProducto ProductoPorId(int id)
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Productos.ToList().LastOrDefault(p => p.ProductoId == id);
            }
        }

        public static void CrearProducto(EntidadProducto oProducto)
        {
            using (var db = new AplicacionVentasContext())
            {
                db.Productos.Add(oProducto);
                db.SaveChanges();
            }
        }
    }
}
