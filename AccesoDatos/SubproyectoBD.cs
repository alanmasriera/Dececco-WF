using System.Linq;
using System.Configuration;
using Entidades;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace AccesoDatos
{
    public class SubproyectoBD
    {
        private static readonly string _connexionStr = "Descar";

        public static SUBPROYECTO Insertar(SUBPROYECTO subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = new SUBPROYECTO
                {
                    asignacion_automatica = subproyecto.asignacion_automatica,
                    fecha_fin_estimada = subproyecto.fecha_fin_estimada,
                    fecha_fin_real = subproyecto.fecha_fin_real,
                    fecha_inicio_estimada = subproyecto.fecha_inicio_estimada,
                    fecha_inicio_real = subproyecto.fecha_inicio_real,
                    forzada_fecha_fin_estimada = subproyecto.forzada_fecha_fin_estimada,
                    forzada_fecha_inicio_estimada = subproyecto.forzada_fecha_inicio_estimada,
                    genera_ot = subproyecto.genera_ot,
                    horas_estimadas = subproyecto.horas_estimadas,
                    id_estado_proyecto = subproyecto.id_estado_proyecto,
                    id_hora_tipo_subproyecto = subproyecto.id_hora_tipo_subproyecto,
                    id_prioridad = subproyecto.id_prioridad,
                    id_proyecto = subproyecto.id_proyecto,
                    id_proyecto_padre_viejo = subproyecto.id_proyecto_padre_viejo,
                    id_proyecto_viejo = subproyecto.id_proyecto_viejo,
                    id_subproyecto_padre = subproyecto.id_subproyecto_padre,
                    id_tipo_subproyecto = subproyecto.id_tipo_subproyecto,
                    nombre = subproyecto.nombre,
                    observaciones = subproyecto.observaciones,
                    orden = subproyecto.orden,
                    ot = subproyecto.ot,
                    ot_cliente = subproyecto.ot_cliente
                };

                bd.SUBPROYECTOes.Add(sub);
                bd.SaveChanges();
                subproyecto.id_subproyecto = sub.id_subproyecto;
            }
            return subproyecto;
        }

        public static List<SUBPROYECTO> ObtenerSubproyectosHijos(SUBPROYECTO subpro)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                           where s.id_subproyecto_padre == subpro.id_subproyecto
                           && s.id_proyecto == subpro.id_proyecto
                           select s);
                return sub.OrderBy(x => x.orden).ToList();
            }
        }

        public static List<HORA_TIPO_SUBPROYECTO> ObtenerHorasTipoUnidad()
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.HORA_TIPO_SUBPROYECTO
                           where s.id_tipo_subproyecto == 4
                           select s);
                return sub.ToList();
            }
        }

        public static List<TIPO_SUBPROYECTO> ObtenerTipoSubproyectos()
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.TIPO_SUBPROYECTO
                           select s);
                return sub.ToList();
            }
        }

        public static List<Actividad_proyecto> ObtenerActividades(SUBPROYECTO subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Actividad_proyecto
                           where s.id_subproyecto == subproyecto.id_subproyecto
                           select s);
                return sub.Any() ? sub.ToList().OrderBy(x => x.orden).ToList() : new List<Actividad_proyecto>();
            }
        }

        public static SUBPROYECTO ObtenerSubproyectoPadre(SUBPROYECTO subpro)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                           where s.id_subproyecto == subpro.id_subproyecto_padre
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static HORA_TIPO_SUBPROYECTO ObtenerHoraTipoSubproyecto(string hora_tipo_subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.HORA_TIPO_SUBPROYECTO
                           where s.nombre == hora_tipo_subproyecto
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static List<Tuple<USUARIO, double>> ObtenerHorasTrabajadasPorUsuario(SUBPROYECTO subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from mh in bd.Movimiento_hora
                           join cmh in bd.Cuerpo_movimiento_hora on mh.id_movimiento_hora equals cmh.id_movimiento_hora
                           join u in bd.USUARIOs on mh.id_usuario equals u.id_usuario
                           join ap in bd.Actividad_proyecto on cmh.id_actividad_proyecto equals ap.id_actividad_proyecto
                           where ap.id_subproyecto == subproyecto.id_subproyecto
                           select new { usuario = u, salida = cmh.salida.Value, entrada = cmh.entrada.Value });

                return pro.AsEnumerable().Select(x => new Tuple<USUARIO, double>(x.usuario, x.salida.Subtract(x.entrada).TotalHours)).ToList();

            }
        }

        public static double ObtenerHorasMinimasSubproyecto(SUBPROYECTO subpro)
        {
            throw new NotImplementedException();
        }

        public static HORA_TIPO_SUBPROYECTO ObtenerHoraTipoSubproyecto(int? id_hora_tipo_subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.HORA_TIPO_SUBPROYECTO
                           where s.id_hora_tipo_subproyecto == id_hora_tipo_subproyecto
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static TIPO_SUBPROYECTO ObtenerTipoSubproyecto(SUBPROYECTO subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.TIPO_SUBPROYECTO
                           where s.id_tipo_subproyecto == subproyecto.id_tipo_subproyecto
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static TIPO_SUBPROYECTO ObtenerTipoSubproyecto(string subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.TIPO_SUBPROYECTO
                           where s.nombre_tipo_subproyecto == subproyecto
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static SUBPROYECTO BuscarPorId(int id_subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                           where s.id_subproyecto == id_subproyecto
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static List<SUBPROYECTO> ObtenerPorProyecto(int id_proyecto, int? id_subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                    var subs = (from s in bd.SUBPROYECTOes
                                where s.id_subproyecto_padre == id_subproyecto
                                      & s.id_proyecto == id_proyecto
                                select s);

                return subs.ToList();
            }
            
        }

        /// <summary>
        /// El formato de las hojas de EXcel para la exportacion es: [ot] - Nombre.
        /// Este método toma ese String y devuelve el Subproyecto que tiene esa OT en ese proyecto.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idProyecto"></param>
        /// <returns></returns>
        public static SUBPROYECTO BuscarPorOTDeExportacion(string nombre, int idProyecto)
        {
            string ot = nombre.Split(new string[] { "- " }, StringSplitOptions.None).First().Trim();
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                           where s.id_proyecto == idProyecto
                & s.ot.ToString().Equals(ot)
                           select s);
                return sub.Any() ? sub.First(): null;
            }            
        }

        /// <summary>
        /// Busca por OT del subproyecto
        /// </summary>
        /// <param name="ot"></param>
        /// <returns></returns>
        public static SUBPROYECTO BuscarPorOT(int ot, int idUsuario, bool validarMiembro)
        {
            SUBPROYECTO subp = null;
            using (var bd = new DescarEntity())
            {
                if (!validarMiembro)
                {
                    var sub = (from s in bd.SUBPROYECTOes
                               join orden in bd.ORDEN_TRABAJO on s.ot.Value equals orden.id_orden_trabajo
                               where orden.nro_orden_trabajo == ot
                               select s);
                    subp = sub.Any() ? sub.First() : null;
                }
                else
                {
                    var sub = (from s in bd.SUBPROYECTOes
                               join up in bd.Usuario_Proyecto on s.id_proyecto equals up.id_proyecto
                               join orden in bd.ORDEN_TRABAJO on s.ot.Value equals orden.id_orden_trabajo
                               where orden.nro_orden_trabajo == ot
                                   & up.id_usuario == idUsuario
                               select s);

                    subp = sub.Any() ? sub.First() : null;
                }

                return subp;
            }
        }

        public static List<USUARIO> ObtenerMiembrosDirectos(SUBPROYECTO subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var subs = (from s in bd.USUARIOs
                            join us in bd.Usuario_Proyecto on s.id_usuario equals us.id_usuario
                            where us.id_subproyecto == subproyecto.id_subproyecto
                            select s);

                return subs.ToList();
            }
        }

        public static SUBPROYECTO YaExisteHijo(string nombre, int idSubproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                           where s.nombre.ToLower() == nombre.ToLower()
                & s.id_subproyecto_padre == idSubproyecto
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        public static SUBPROYECTO UpdateSubproyecto(SUBPROYECTO subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                             where s.id_subproyecto == subproyecto.id_subproyecto
                             select s).Single();

                sub.asignacion_automatica = subproyecto.asignacion_automatica;
                sub.fecha_fin_estimada = subproyecto.fecha_fin_estimada;
                sub.fecha_fin_real = subproyecto.fecha_fin_real;
                sub.fecha_inicio_estimada = subproyecto.fecha_inicio_estimada;
                sub.fecha_inicio_real = subproyecto.fecha_inicio_real;
                sub.forzada_fecha_fin_estimada = subproyecto.forzada_fecha_fin_estimada;
                sub.forzada_fecha_inicio_estimada = subproyecto.forzada_fecha_inicio_estimada;
                sub.genera_ot = subproyecto.genera_ot;
                sub.horas_estimadas = subproyecto.horas_estimadas;
                sub.id_estado_proyecto = subproyecto.id_estado_proyecto;
                sub.id_hora_tipo_subproyecto = subproyecto.id_hora_tipo_subproyecto;
                sub.id_prioridad = subproyecto.id_prioridad;
                sub.id_proyecto = subproyecto.id_proyecto;
                sub.id_proyecto_padre_viejo = subproyecto.id_proyecto_padre_viejo;
                sub.id_proyecto_viejo = subproyecto.id_proyecto_viejo;
                sub.id_subproyecto_padre = subproyecto.id_subproyecto_padre;
                sub.id_tipo_subproyecto = subproyecto.id_tipo_subproyecto;
                sub.nombre = subproyecto.nombre;
                sub.observaciones = subproyecto.observaciones;
                sub.orden = subproyecto.orden;
                sub.ot = subproyecto.ot;
                sub.ot_cliente = subproyecto.ot_cliente;
                sub.horas_orden_compra = subproyecto.horas_orden_compra;
                bd.SaveChanges();
            }
            return subproyecto;
        }

        public static SUBPROYECTO BuscarPorNombre(string nombre, int idUsuario, bool validarMiembro)
        {
            SUBPROYECTO subp = null;
            using (var bd = new DescarEntity())
            {
                if (!validarMiembro)
                {
                    var sub = (from s in bd.SUBPROYECTOes
                               where s.nombre.Trim().ToLower().Contains(nombre.Trim().ToLower())
                               select s);
                    subp = sub.Any() ? sub.First() : null;
                }
                else
                {
                    var sub = (from s in bd.SUBPROYECTOes
                               join up in bd.Usuario_Proyecto on s.id_proyecto equals up.id_proyecto
                               where s.nombre.Trim().ToLower().Contains(nombre.Trim().ToLower())
                               & up.id_usuario == idUsuario
                               select s);

                    subp = sub.Any() ? sub.First() : null;
                }

                return subp;
            }
        }

        public static List<AvanceSubproyecto> ObtenerAvanceConcepto(SUBPROYECTO subpr, Tipo_actividad tipo_actividad)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                           join ap in bd.Actividad_proyecto on s.id_subproyecto equals ap.id_subproyecto
                           join a in bd.Actividads on ap.id_actividad equals a.id_actividad
                           join mv in bd.Movimiento_voz on ap.id_actividad_proyecto equals mv.id_actividad_proyecto
                           join u_prod in bd.USUARIOs on mv.id_usuario_1 equals u_prod.id_usuario
                           join u_ctrl in bd.USUARIOs on mv.id_usuario_2 equals u_ctrl.id_usuario
                           join u_corr in bd.USUARIOs on mv.id_usuario_3 equals u_corr.id_usuario
                           where s.id_subproyecto == subpr.id_subproyecto
                           & a.id_tipo_actividad == tipo_actividad.id_tipo_actividad
                           select new AvanceSubproyecto() {
                               subproyecto = s,
                               completado = mv.completado.Value,
                               completado_control = mv.control_1.Value,
                               completado_correccion_1 = mv.control_corr_1.Value,
                               completado_produccion = mv.control_prod.Value,
                               responsableCalidad = u_ctrl,
                               responsableProduccion = u_prod,
                               actividad_proyecto = ap,
                               responsableCorreccion = u_corr

                           });

                return sub.ToList();
            }
        }

        public static List<SUBPROYECTO> ObtenerSubproyectosConActividadesActivos()
        {
            using (var bd = new DescarEntity())
            {
                var subs = (from s in bd.SUBPROYECTOes
                            join sp in bd.SUBPROYECTOes on s.id_subproyecto_padre equals sp.id_subproyecto
                            join ap in bd.Actividad_proyecto on s.id_subproyecto equals ap.id_subproyecto
                            join p in bd.Proyectoes on ap.id_proyecto equals p.id_proyecto
                            join ts in bd.TIPO_SUBPROYECTO on sp.id_tipo_subproyecto equals ts.id_tipo_subproyecto
                            where p.activo == true
                            & (ts.nombre_tipo_subproyecto.ToLower().Contains("simu") || ts.nombre_tipo_subproyecto.ToLower().Contains("dispo"))
                            select sp);

                return subs.Distinct().OrderBy(x => x.id_prioridad).ToList();
            }
        }

        public static SUBPROYECTO BuscarPorOTCliente(string ot, int idUsuario, bool validarMiembro)
        {
            SUBPROYECTO subp = null;
            using (var bd = new DescarEntity())
            {
                if (!validarMiembro)
                {
                    var sub = (from s in bd.SUBPROYECTOes
                               where s.ot_cliente.Contains(ot)
                               select s);
                    subp = sub.Any() ? sub.First() : null;
                }
                else
                {
                    var sub = (from s in bd.SUBPROYECTOes
                               join up in bd.Usuario_Proyecto on s.id_proyecto equals up.id_proyecto
                               where s.ot_cliente.Contains(ot)
                               & up.id_usuario == idUsuario
                               select s);

                    subp = sub.Any() ? sub.First() : null;
                }

                return subp;
            }            
        }

        /// <summary>
        /// Comprobar metodo
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <returns></returns>
        public static List<USUARIO> ObtenerMiembrosDirectosOrdenMenorCalificaciones(SUBPROYECTO subproyecto)
        {
            using (var bd = new DescarEntity())
            {
                var subs = (from s in bd.USUARIOs
                            join us in bd.Usuario_Proyecto on s.id_usuario equals us.id_usuario
                            join tau in bd.Tipo_Actividad_usuario on us.id_usuario equals tau.id_usuario
                            where us.id_subproyecto == subproyecto.id_subproyecto                            
                            select s);

                return subs.ToList().GroupBy(x => x.id_usuario).OrderByDescending(x => x.Count()).ToList().Select(x => x.First()).ToList();
            }
        }

        public static SUBPROYECTO ActualizarAsignacionAutomatica(SUBPROYECTO subproyecto, bool nuevo_valor)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                           where s.id_subproyecto == subproyecto.id_subproyecto
                           select s).Single();

                sub.asignacion_automatica = nuevo_valor;                
                bd.SaveChanges();
            }
            return subproyecto;
        }

        public static bool AsignarOt(int idSubproyecto)
        {
            var conexion = new SqlConnection(ConfigurationManager.ConnectionStrings[_connexionStr].ConnectionString);
            var cmd = new SqlCommand
            {
                CommandText = "cop_subproyecto_agregarOT",
                CommandType = System.Data.CommandType.StoredProcedure,
                Connection = conexion
            };


            cmd.Parameters.Add("@id_subproyecto", System.Data.SqlDbType.Int, 6, "id_subproyecto");
            cmd.Parameters["@id_subproyecto"].Value = idSubproyecto;

            conexion.Open();
            var rows = cmd.ExecuteNonQuery();
            conexion.Close();

            return rows == 1;
        }

        public static Actividad_proyecto ObtenerActividaHijaDeTipo(SUBPROYECTO subproyecto, Tipo_actividad tipo)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from ap in bd.Actividad_proyecto
                           join a in bd.Actividads on ap.id_actividad equals a.id_actividad                           
                           where ap.id_subproyecto == subproyecto.id_subproyecto
                           & a.id_tipo_actividad == tipo.id_tipo_actividad
                           select ap);

                return sub.Any() ? sub.First() : null;
            }
        }

        public static void EliminarSubproyecto(SUBPROYECTO item1)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from ap in bd.SUBPROYECTOes
                           where ap.id_subproyecto == item1.id_subproyecto
                           select ap);

                bd.SUBPROYECTOes.RemoveRange(sub);
                bd.SaveChanges();
            }
        }
    }
}
