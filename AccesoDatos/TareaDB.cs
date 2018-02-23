using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity.SqlServer;

namespace AccesoDatos
{
    public static class TareaDB
    {
        /// <summary>
        /// Agrega una tarea a la base de datos
        /// </summary>
        /// <param name="tarea"></param>
        /// <returns></returns>
        public static Detalle_recurso Insertar(Detalle_recurso tarea)
        {
            using (var bd = new DescarEntity())
            {
                bd.Detalle_recurso.Add(tarea);
                bd.SaveChanges();
            }
            return tarea;
        }

        /// <summary>
        /// Indica si existe una tarea para esa actividad y para ese usuario
        /// </summary>
        /// <param name="idActividadProyecto"></param>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public static bool Existe(int idActividadProyecto, int idUsuario)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_recurso
                           where s.id_actividad_proyecto == idActividadProyecto
                           && s.id_usuario == idUsuario
                           select s);
                return sub.Any();
            }
        }

        /// <summary>
        /// Obtiene la tarea con el ID indicado
        /// </summary>
        /// <param name="idDetalleRecurso"></param>
        /// <returns></returns>
        public static Detalle_recurso ObtenerPorID(int idDetalleRecurso)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_recurso
                           where s.id_detalle_recurso == idDetalleRecurso
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        /// <summary>
        /// Obtiene las solicitudes de tareas de los proyectos en los que el usuario indicado
        /// es piloto o project manager.
        /// </summary>
        /// <param name="id_usuario_piloto"></param>
        /// <returns>Lista de soliciturdes -Detalle Recurso-</returns>
        public static List<Detalle_recurso> ObtenerSolicitudes(int id_usuario_piloto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_recurso
                           join a in bd.Actividad_proyecto on s.id_actividad_proyecto equals a.id_actividad_proyecto
                           join p in bd.Proyectoes on a.id_proyecto equals p.id_proyecto
                           where s.id_estado == 1
                           & (id_usuario_piloto == p.id_piloto || id_usuario_piloto == p.id_proyect_manager)
                           select s);
                return sub.ToList();
            }
        }

        public static Detalle_recurso ObtenerPorActividad(Actividad_proyecto actividad)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_recurso
                           where s.id_actividad_proyecto == actividad.id_actividad_proyecto
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        public static Detalle_recurso EstaAsignadaAUsuario(int idActividadProyectoSolicitar, int idUsuario)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_recurso
                           join a in bd.Actividad_proyecto on s.id_actividad_proyecto equals a.id_actividad_proyecto
                           where s.id_usuario == idUsuario
                           & a.id_actividad_proyecto == idActividadProyectoSolicitar
                           select s);

                return sub.Any() ? sub.First() : null;
            }
        }

        /// <summary>
        /// Actualiza la base de datos con los nuevos datos de la programación de la tarea.
        /// </summary>
        /// <param name="progr"></param>
        /// <returns></returns>
        public static Programacion_Actividad UpdateProgramacion(Programacion_Actividad progr)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Programacion_Actividad
                           where s.id_programacion_actividad == progr.id_programacion_actividad
                           select s).Single();

                sub.nombre_programacion = progr.nombre_programacion;
                sub.fecha_inicio = progr.fecha_inicio;
                sub.fecha_fin = progr.fecha_fin;
                sub.freq_interval = progr.freq_interval;
                sub.freq_type = progr.freq_type;
                sub.freq_relative_interval = progr.freq_relative_interval;
                bd.SaveChanges();

                return sub;
            }
        }

        /// <summary>
        /// Agrega la programación a la base de datos
        /// </summary>
        /// <param name="progr"></param>
        /// <returns></returns>
        public static Programacion_Actividad InsertarProgramacion(Programacion_Actividad progr)
        {
            using (var bd = new DescarEntity())
            {
                bd.Programacion_Actividad.Add(progr);
                bd.SaveChanges();
            }
            return progr;
        }

        public static object CaalcularFechaFinSubproyecto(SUBPROYECTO subproyecto)
        {
            throw new NotImplementedException();
        }

        public static Programacion_Actividad ExisteProgramacion(Programacion_Actividad progr)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Programacion_Actividad
                           where s.id_actividad_proyecto == progr.id_actividad_proyecto
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        public static List<DatosTarea> ObtenerTareasPendientesDeUsuario(int idUsuario)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from dr in bd.Detalle_recurso
                           join ap in bd.Actividad_proyecto on dr.id_actividad_proyecto equals ap.id_actividad_proyecto
                           join a in bd.Actividads on ap.id_actividad equals a.id_actividad
                           join s in bd.SUBPROYECTOes on ap.id_subproyecto equals s.id_subproyecto
                           join p in bd.Proyectoes on s.id_proyecto equals p.id_proyecto

                           //join up in bd.Usuario_Proyecto on p.id_proyecto equals up.id_proyecto //ALAN
                           //join us in bd.Usuario_Proyecto on ap.id_subproyecto equals us.id_subproyecto //ALAN


                           where (dr.id_usuario == idUsuario || idUsuario ==0) 
                           //& up.id_usuario == idUsuario  //ALAN
                           ////& us.id_usuario == idUsuario //ALAN
                           & dr.realizada == false
                           & ap.no_conformidad == false
                           & ap.asignable == true    
                           & p.activo == true 
                           
                           select new DatosTarea() {tarea = dr, actividad = a, actividad_proyecto = ap, proyecto = p, subproyecto = s });

                return sub.OrderBy(x => x.tarea.fecha_inicio.Value).ToList();
            }
        }

        public static List<Detalle_recurso> ObtenerTareasPorUsuario(int idUsuario)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_recurso
                           join ap in bd.Actividad_proyecto on s.id_actividad_proyecto equals ap.id_actividad_proyecto
                           join p in bd.Proyectoes on ap.id_proyecto equals p.id_proyecto
                           where s.id_usuario == idUsuario
                           && p.activo == true
                           select s);
                return sub.ToList();
            }
        }

        public static Detalle_recurso Actualizar(Detalle_recurso detalle_recurso)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Detalle_recurso
                           where p.id_detalle_recurso == detalle_recurso.id_detalle_recurso
                           select p).Single();

                pro.cantidad_hora = detalle_recurso.cantidad_hora;
                pro.duracion_cadista = detalle_recurso.duracion_cadista;
                pro.fecha_fin = detalle_recurso.fecha_fin;
                pro.fecha_fin_cadista = detalle_recurso.fecha_fin_cadista;
                pro.fecha_inicio = detalle_recurso.fecha_inicio;
                pro.fecha_inicio_cadista = detalle_recurso.fecha_inicio_cadista;
                pro.forzada = detalle_recurso.forzada;
                pro.id_actividad_proyecto = detalle_recurso.id_actividad_proyecto;
                pro.id_estado = detalle_recurso.id_estado;
                pro.id_usuario = detalle_recurso.id_usuario;
                pro.motivo = detalle_recurso.motivo;
                pro.porcentaje_avance = detalle_recurso.porcentaje_avance;
                pro.realizada = detalle_recurso.realizada;
                pro.tipo = detalle_recurso.tipo;
                bd.SaveChanges();

                return pro;
            }
        }
        /// <summary>
        /// Indica si la tarea esta en condiciones de ser mostrada al usuario
        /// </summary>
        /// <param name="a"></param>
        public static EstadoTarea ObtenerEstadoPorNombre(string nombreEstado)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.EstadoTarea
                           where s.nombre.ToLower().Contains(nombreEstado.ToLower())
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        /// <summary>
        /// Resuelve la solicitud para realizar una tarea, requerida por un cadista
        /// </summary>
        /// <param name="detalleRecurso">La tarea creada automaticamente</param>
        /// <param name="decision">Decisión final del piloto, si acepta o rechaza</param>
        /// <param name="responsable">El piloto de proyecto que tomo la decisión</param>
        public static void ResolverSolicitud(Detalle_recurso detalleRecurso, bool decision, USUARIO responsable)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Detalle_recurso
                           where p.id_detalle_recurso == detalleRecurso.id_detalle_recurso
                           select p).Single();
                if (decision)
                {
                    pro.motivo = "solicitud aceptada por " + responsable.nombre_usuario;
                    pro.tipo = "solicitud aceptada por " + responsable.nombre_usuario;
                    pro.id_estado = ObtenerEstadoPorNombre("Asignado").IdEstadoTarea;
                    pro.forzada = true;
                }
                else
                {
                    pro.motivo = "solicitud rechazada por " + responsable.nombre_usuario;
                    pro.tipo = "solicitud rechazada por " + responsable.nombre_usuario;
                    pro.id_estado = ObtenerEstadoPorNombre("Rechazado").IdEstadoTarea;
                    pro.forzada = false;
                }

                bd.SaveChanges();
            }
        }

        public static void EliminarDetalleRecursoActividad(Actividad_proyecto item)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Detalle_recurso
                           where mv.id_actividad_proyecto == item.id_actividad_proyecto
                           select mv);

                bd.Detalle_recurso.RemoveRange(act);
                bd.SaveChanges();
            }
        }

        public static Detalle_recurso AsignarActividad(Detalle_recurso tarea)
        {
            using (var bd = new DescarEntity())
            {
                tarea = bd.Detalle_recurso.Add(tarea);
                bd.SaveChanges();

                return tarea;
            }
        }

        public static Programacion_Actividad ObtenerProgramacion(Actividad_proyecto activ_proy)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Programacion_Actividad
                           where s.id_actividad_proyecto == activ_proy.id_actividad_proyecto
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        public static void EliminarDetalleRecursoSubproyecto(SUBPROYECTO subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Detalle_recurso
                           join ap in bd.Actividad_proyecto on mv.id_actividad_proyecto equals ap.id_actividad_proyecto
                           where ap.id_subproyecto == subproyecto.id_subproyecto
                           select mv);

                bd.Detalle_recurso.RemoveRange(act);
                bd.SaveChanges();
            }
        }

        /// <summary>
        /// Borra las tareas de un proyecto en el las horas logueadas por el usuario
        /// es 0, o no fueron logueadas por ese usuario
        /// </summary>
        /// <param name="proyecto"></param>
        public static void EliminarDetalleRecursoProyectoNoLogueados(Proyecto proyecto)
        {
            using (var bd = new DescarEntity())
            {
                var noborrar = (from s in bd.Detalle_recurso
                                join ap in bd.Actividad_proyecto on s.id_actividad_proyecto equals ap.id_actividad_proyecto
                                join cmh in bd.Cuerpo_movimiento_hora on ap.id_actividad_proyecto equals cmh.id_cuerpo_movimiento_hora
                                join mh in bd.Movimiento_hora on cmh.id_movimiento_hora equals mh.id_movimiento_hora
                                where ap.id_proyecto.Value == proyecto.id_proyecto
                                && s.id_usuario == mh.id_usuario
                                select s);


                var todas = (from s in bd.Detalle_recurso
                             join ap in bd.Actividad_proyecto on s.id_actividad_proyecto equals ap.id_actividad_proyecto
                             where ap.id_proyecto.Value == proyecto.id_proyecto
                             select s);

                todas = todas.Where(x => noborrar.Select(y => y.id_detalle_recurso).Contains(x.id_detalle_recurso));
                bd.Detalle_recurso.RemoveRange(todas);
                bd.SaveChanges();
            }
        }

        /// <summary>
        /// Borra las tareas de los proyectos activos en el las horas logueadas por el usuario
        /// es 0, o no fueron logueadas por ese usuario
        /// </summary>
        /// <param name="proyecto"></param>
        public static void EliminarDetalleRecursoProyectosActivos()
        {
            using (var bd = new DescarEntity())
            {
                //No se borran las tareas que tienen horas logueadas por el mismo usuario de la tarea
                var noborrar = (from s in bd.Detalle_recurso
                                join ap in bd.Actividad_proyecto on s.id_actividad_proyecto equals ap.id_actividad_proyecto
                                join cmh in bd.Cuerpo_movimiento_hora on ap.id_actividad_proyecto equals cmh.id_actividad_proyecto
                                join mh in bd.Movimiento_hora on cmh.id_movimiento_hora equals mh.id_movimiento_hora
                                join p in bd.Proyectoes on ap.id_proyecto equals p.id_proyecto
                                where p.activo == true
                                && s.id_usuario == mh.id_usuario
                                && s.forzada == false
                                && s.realizada == false
                                select s);

                //No se borran las tareas que esten forzadas o ya fueron completadas
                var noborrarForzadas = (from s in bd.Detalle_recurso
                                join ap in bd.Actividad_proyecto on s.id_actividad_proyecto equals ap.id_actividad_proyecto                               
                                join p in bd.Proyectoes on ap.id_proyecto equals p.id_proyecto
                                where p.activo == true
                                && (s.forzada == true
                                || s.realizada == true)
                                select s);

                noborrar = noborrar.Union(noborrarForzadas);

                var todas = (from s in bd.Detalle_recurso
                             join ap in bd.Actividad_proyecto on s.id_actividad_proyecto equals ap.id_actividad_proyecto
                             join p in bd.Proyectoes on ap.id_proyecto equals p.id_proyecto
                             where p.activo == true
                             && s.forzada == false
                             && s.realizada == false
                             select s);

                todas = todas.Except(todas.Where(x => noborrar.Select(y => y.id_detalle_recurso).Contains(x.id_detalle_recurso)));
                bd.Detalle_recurso.RemoveRange(todas);
                bd.SaveChanges();
            }
        }

        public static int ObtenerHorasConsumidas(Detalle_recurso tarea)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_recurso
                           join cmh in bd.Cuerpo_movimiento_hora on s.id_detalle_recurso equals cmh.id_detalle_recurso
                           where s.id_detalle_recurso == tarea.id_detalle_recurso
                           select new { hora = SqlFunctions.DateDiff("s", cmh.entrada, cmh.salida) });

                return sub.Any() ? sub.First().hora.HasValue ? sub.Sum(x => x.hora.Value): 0 : 0;
            }
        }
    }
}
