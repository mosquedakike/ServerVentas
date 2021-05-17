using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Cliente
    {
        public static List<EntidadCliente> ListaCliente()
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Clientes.ToList();
            }
        }

        public static EntidadCliente ClientePorId(int id)
        {
            using (var db = new AplicacionVentasContext())
            {
                return db.Clientes.ToList().LastOrDefault(p => p.ClienteId == id);
            }
        }

        public static void CrearCliente(EntidadCliente oCliente)
        {
            using (var db = new AplicacionVentasContext())
            {
                db.Clientes.Add(oCliente);
                db.SaveChanges();
            }
        }
    }
}
