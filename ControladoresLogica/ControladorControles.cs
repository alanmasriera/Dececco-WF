using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace ControladoresLogica
{
    public class ControladorControles
    {
        public List<Control> ObtenerTodos()
        {
            return ControlDB.ObtenerTodos();
        }

        public static Control ObtenerPorNombre(string nombreControl)
        {
            return ControlDB.ObtenerPorNombre(nombreControl);
        }

        public static CONTROL_SUBPROYECTO VerificarExistencia(Tipo_actividad actividad, Proyecto proyecto)
        {
            return ControlDB.VerificarExistencia(actividad, proyecto);
        }

        public static CONTROL_SUBPROYECTO ActualizarControlSubproyecto(CONTROL_SUBPROYECTO controlSub)
        {
            return ControlDB.ActualizarControlSubproyecto(controlSub);
        }

        public static CONTROL_SUBPROYECTO Insertar(CONTROL_SUBPROYECTO controlSub)
        {
            return ControlDB.Insertar(controlSub);
        }

        internal static Control ObtenerPorID(int? id_control)
        {
            return ControlDB.ObtenerPorID(id_control);
        }

        internal static List<CONTROL_SUBPROYECTO> ObtenerControlesProyecto(Proyecto proyecto)
        {
            return ControlDB.ObtenerControlesProyecto(proyecto);
        }
    }
}
