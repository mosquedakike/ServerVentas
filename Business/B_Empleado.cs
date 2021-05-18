using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Empleado
    {
        public static List<EntidadEmpleado> ListaEmpleado()
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Empleados.ToList();
            }
        }

        public static EntidadEmpleado EmpleadoPorId(int id)
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Empleados.ToList().LastOrDefault(p => p.EmpleadoId == id);
            }
        }

        public static void CrearEmpleado(EntidadEmpleado oEmpleado)
        {
            using (var db = new AplicacionVentasContext())
            {
                db.Empleados.Add(oEmpleado);
                db.SaveChanges();
            }
        }

        public static void ActualizarEmpleado(EntidadEmpleado oEmpleado)
        {
            using (var db = new AplicacionVentasContext())
            {
                db.Empleados.Update(oEmpleado);
                db.SaveChanges();
            }
        }
    }
}
