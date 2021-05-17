using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Proyecto
    {
        public static List<EntidadProyecto> ListaProyecto()
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Proyectos.ToList();
            }
        }

        public static EntidadProyecto ProyectoPorId(int id)
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Proyectos.ToList().LastOrDefault(p => p.ProyectoId == id);
            }
        }

        public static void CrearProyecto(EntidadProyecto oProyecto)
        {
            using (var db = new AplicacionVentasContext())
            {
                db.Proyectos.Add(oProyecto);
                db.SaveChanges();
            }
        }
    }
}
