using Entidades;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos
{
    public static class ControlDB
    {
        static readonly string ConnexionStr = "Descar";

        public static List<Control> ObtenerTodos()
        {
            using (var bd = new DescarEntity())
            {
                var controles = (from p in bd.Controls
                    select p);

                return controles.ToList();
            }
           
        }

        public static Control ObtenerPorNombre(string nombreControl)
        {
            using (var bd = new DescarEntity())
            {
                var controles = (from p in bd.Controls
                                 where p.nombre_control.ToLower() == nombreControl.ToLower()
                                 select p);

                return controles.Any() ? controles.First() : null;
            }
        }

        public static CONTROL_SUBPROYECTO ActualizarControlSubproyecto(CONTROL_SUBPROYECTO controlSub)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.CONTROL_SUBPROYECTO
                           where p.id_control_subproyecto == controlSub.id_control_subproyecto
                           select p).Single();

                pro.id_control = controlSub.id_control;                

                bd.SaveChanges();

                return pro;
            }
        }

        public static List<CONTROL_SUBPROYECTO> ObtenerControlesProyecto(Proyecto proyecto)
        {
            using (var bd = new DescarEntity())
            {
                var controles = (from p in bd.CONTROL_SUBPROYECTO
                                 where p.id_proyecto == proyecto.id_proyecto
                                 select p);

                return controles.ToList();
            }
        }

        public static Control ObtenerPorID(int? id_control)
        {
            using (var bd = new DescarEntity())
            {
                var controles = (from p in bd.Controls
                                 where p.id_control == id_control
                                 select p);

                return controles.Any() ? controles.First() : null;
            }
        }

        public static CONTROL_SUBPROYECTO Insertar(CONTROL_SUBPROYECTO controlSub)
        {
            using (var bd = new DescarEntity())
            {
                bd.CONTROL_SUBPROYECTO.Add(controlSub);
                bd.SaveChanges();
            }
            return controlSub;
        }

        public static CONTROL_SUBPROYECTO VerificarExistencia(Tipo_actividad actividad, Proyecto proyecto)
        {
            using (var bd = new DescarEntity())
            {
                var controles = (from p in bd.CONTROL_SUBPROYECTO
                                 where p.id_proyecto == proyecto.id_proyecto
                                 & p.id_tipo_actividad == actividad.id_tipo_actividad
                                 select p);

                return controles.Any() ? controles.First() : null;
            }
        }
    }
}
