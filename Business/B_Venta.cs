using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Venta
    {
        public static List<EntidadVenta> ListaVenta()
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Ventas.ToList();
            }
        }

        public static EntidadVenta VentaPorId(int id)
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Ventas.ToList().LastOrDefault(p => p.VentaId == id);
            }
        }

        public static void CrearVenta(EntidadVenta oVenta)
        {
            using (var db = new AplicacionVentasContext())
            {
                db.Ventas.Add(oVenta);
                db.SaveChanges();
            }
        }
    }
}
