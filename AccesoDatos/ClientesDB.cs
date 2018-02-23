using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace AccesoDatos
{
    public static class ClientesDB
    {
        public static List<Cliente> ObtenerTodos()
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Clientes
                           select s);
                return sub.ToList();
            }
        }

        public static Cliente ObtenerCLiente(int value)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Clientes
                           where s.id_cliente == value
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static List<Cliente> ObtenerCLientes()
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Clientes
                           select s);

                return sub.OrderBy(x => x.nombre_cliente).ToList();
            }
        }

        public static List<Cliente> ObtenerCLientesActivos()
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from p in bd.Proyectoes
                           join c in bd.Clientes on p.id_cliente equals c.id_cliente
                           where p.activo == true
                           select c);

                return sub.OrderBy(x => x.nombre_cliente).Distinct().ToList();
            }
        }

        public static List<Cliente> ObtenerPorMiembro(int idUsuario)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Clientes
                           join p in bd.Proyectoes on s.id_cliente equals p.id_cliente
                           join up in bd.Usuario_Proyecto on p.id_proyecto equals up.id_proyecto
                           where up.id_usuario == idUsuario
                           select s);
                return sub.ToList();
            }
        }
    }
}
