using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace ControladoresLogica
{
    public class ControladorClientes
    {
        public List<Cliente> ObtenerTodos()
        {
            return ClientesDB.ObtenerTodos();
        }

        public List<Cliente> ObtenerPorMiembro(int idUsuario)
        {
            return ClientesDB.ObtenerPorMiembro(idUsuario);
        }

        public static Cliente ObtenerCLiente(int? id_cliente)
        {
            return id_cliente != null ? ClientesDB.ObtenerCLiente(id_cliente.Value) : null;
        }

        public static List<Cliente> ObtenerCLientes()
        {
            return ClientesDB.ObtenerCLientes();
        }

        public static List<Cliente> ObtenerCLientesActivos()
        {
            return ClientesDB.ObtenerCLientesActivos();
        }
    }
}
