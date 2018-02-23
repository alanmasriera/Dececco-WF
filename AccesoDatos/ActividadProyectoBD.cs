using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.SqlServer;
using System.Linq;
using Entidades;
using System.Collections.Generic;

namespace AccesoDatos
{
    public static class ActividadProyectoDB
    {
        private static string _connexionStr = "Descar";

        public static Actividad_proyecto Insertar(Actividad_proyecto actividad)
        {
            using (var bd = new DescarEntity())
            {
                bd.Actividad_proyecto.Add(actividad);
                bd.SaveChanges();
            }
            return actividad;
        }

        public static Actividad Insertar(Actividad actividad)
        {
            using (var bd = new DescarEntity())
            {
                bd.Actividads.Add(actividad);
                bd.SaveChanges();
            }
            return actividad;
        }

        public static Tipo_actividad ObtenerTipoActividad(int idTipoActividad)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from n in bd.Tipo_actividad
                    where n.id_tipo_actividad == idTipoActividad
                    select n).Single();

                return act;
            }
        }

        public static Tipo_actividad ObtenerTipoActividad(string nombreTipo)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from n in bd.Tipo_actividad
                           where n.descripcion.ToLower().Contains(nombreTipo.ToLower())
                           select n);

                return act.Any() ? act.First() : null;
            }
        }

        public static Actividad ActualizarActividad(Actividad actividad)
        {
            throw new NotImplementedException();
            //return null;
        }


        public static Actividad_proyecto ActualizarActividad_Proyecto(Entidades.Actividad_proyecto actividadProyecto)
        {
            using (var bd = new DescarEntity())
            {
                var act_pro = (from ap in bd.Actividad_proyecto
                    where ap.id_actividad_proyecto == actividadProyecto.id_actividad_proyecto
                    select ap).First();


                act_pro.id_proyecto = actividadProyecto.id_proyecto;
                act_pro.id_actividad = actividadProyecto.id_actividad;
                act_pro.fecha_inicio = actividadProyecto.fecha_inicio;
                act_pro.fecha_fin_previsto = actividadProyecto.fecha_fin_previsto;
                act_pro.fecha_fin_real = actividadProyecto.fecha_fin_real;
                act_pro.cantidad_hora = actividadProyecto.cantidad_hora;
                act_pro.objetivo = actividadProyecto.objetivo;
                act_pro.prioridad = actividadProyecto.prioridad;
                act_pro.complejidad = actividadProyecto.complejidad;
                act_pro.avance = actividadProyecto.avance;
                act_pro.observacion = actividadProyecto.observacion;
                act_pro.orden = actividadProyecto.orden;
                act_pro.id_controlador_1 = actividadProyecto.id_controlador_1;
                act_pro.id_controlador_2 = actividadProyecto.id_controlador_2;
                act_pro.nro = actividadProyecto.nro;
                act_pro.id_cliente = actividadProyecto.id_cliente;
                act_pro.id_subproyecto = actividadProyecto.id_subproyecto;
                act_pro.horas = actividadProyecto.horas;
                act_pro.id_estado_proyecto = actividadProyecto.id_estado_proyecto;
                act_pro.porcentaje_avance = actividadProyecto.porcentaje_avance;
                act_pro.fecha_inicio_real = actividadProyecto.fecha_inicio_real;
                act_pro.asignada = actividadProyecto.asignada;
                act_pro.id_cadista = actividadProyecto.id_cadista;
                act_pro.id_prioridad = actividadProyecto.id_prioridad;
                act_pro.id_control = actividadProyecto.id_control;
                act_pro.id_proveedor = actividadProyecto.id_proveedor;
                act_pro.forzada_fecha_fin = actividadProyecto.forzada_fecha_fin;
                act_pro.forzada_fecha_inicio = actividadProyecto.forzada_fecha_inicio;
                act_pro.no_conformidad = actividadProyecto.no_conformidad;
                act_pro.motivo_no_conformidad = actividadProyecto.motivo_no_conformidad;
                act_pro.asignable = actividadProyecto.asignable;
                bd.SaveChanges();

                return act_pro;
            }
        }

        public static List<Tipo_Actividad_usuario> ObtenerTiposActividadUsuario(USUARIO usuario)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from n in bd.Tipo_Actividad_usuario
                           where n.id_usuario == usuario.id_usuario
                           select n);

                return act.Any() ? act.ToList() : null;
            }
        }


        public static List<Tipo_Actividad_usuario> ObtenerTiposActividadUsuario(Tipo_actividad tipo_actividad)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from n in bd.Tipo_Actividad_usuario
                           where n.id_tipo_actividad == tipo_actividad.id_tipo_actividad
                           select n);

                return act.Any() ? act.ToList() : null;
            }
        }

        public static List<Tipo_actividad> ObtenerTiposActividad()
        {
            using (var bd = new DescarEntity())
            {
                var act = (from n in bd.Tipo_actividad
                           select n);

                return act.Any() ? act.ToList() : null;
            }
        }

        public static List<Tipo_actividad> ObtenerTiposActividad(string filtro_nombre)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from n in bd.Tipo_actividad
                           where n.descripcion.ToLower().Contains(filtro_nombre.ToLower())
                           || filtro_nombre == ""
                           select n);

                return act.ToList();
            }
        }

        public static List<Actividad> ObtenerActividadesDeSubproyecto(SUBPROYECTO subpro)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from ap in bd.Actividad_proyecto
                           join a in bd.Actividads on ap.id_actividad equals a.id_actividad
                           where ap.id_subproyecto == subpro.id_subproyecto
                           select a);

                return act.ToList();
            }
        }
        public static List<Actividad_proyecto> ObtenerActividadesProyectoDeSubproyecto(SUBPROYECTO subpro)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from ap in bd.Actividad_proyecto
                           join a in bd.Actividads on ap.id_actividad equals a.id_actividad
                           where ap.id_subproyecto == subpro.id_subproyecto
                           select new { ap, a.id_tipo_actividad});

                return act.OrderBy(x => x.id_tipo_actividad).Select(x => x.ap).OrderBy(x => x.orden).ToList();
            }
        }

        public static double? ObtenerEficienciaActividad(Actividad_proyecto act_pto)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from ap in bd.Actividad_proyecto
                           join a in bd.Actividads on ap.id_actividad equals a.id_actividad
                           join ta in bd.Tipo_actividad on a.id_tipo_actividad equals ta.id_tipo_actividad
                           where ap.id_actividad_proyecto == act_pto.id_actividad_proyecto
                           select ta.porc_eficiencia);

                return act.Any() && act.First().HasValue ? (double?)act.First().Value : null;
            }
        }

        public static Tipo_Actividad_usuario ObtenerTipoActividadUsuario(int id_tipo_actividad, int id_usuario)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from ap in bd.Tipo_Actividad_usuario
                           where ap.id_tipo_actividad == id_tipo_actividad
                           && ap.id_usuario == id_usuario
                           select ap);

                return act.Any() ? act.First() : null;
            }
        }

        public static Tipo_Actividad_usuario actualizarTipoActividadUsuario(Tipo_Actividad_usuario _Tipo_Actividad_Usuario)
        {
            using (var bd = new DescarEntity())
            {
                var tipo_act = (from ta in bd.Tipo_Actividad_usuario
                                where ta.id_tipo_actividad_usuario == _Tipo_Actividad_Usuario.id_tipo_actividad_usuario
                                select ta).First();

                tipo_act.id_tipo_actividad = _Tipo_Actividad_Usuario.id_tipo_actividad;
                tipo_act.calificacion = _Tipo_Actividad_Usuario.calificacion;
                tipo_act.habilitado = _Tipo_Actividad_Usuario.habilitado;
                tipo_act.id_usuario = _Tipo_Actividad_Usuario.id_usuario;
                bd.SaveChanges();

                return tipo_act;
            }
        }

        public static Tipo_actividad ActualizarTipoActividad(Tipo_actividad tipoActividad)
        {
            using (var bd = new DescarEntity())
            {
                var tipo_act = (from ta in bd.Tipo_actividad
                           where ta.id_tipo_actividad == tipoActividad.id_tipo_actividad
                           select ta).First();

                tipo_act.criticidad = tipoActividad.criticidad;
                tipo_act.descripcion = tipoActividad.descripcion;
                tipo_act.asignable = tipoActividad.asignable;
                tipo_act.logueo_habilitado = tipoActividad.logueo_habilitado;
                tipo_act.porcentaje = tipoActividad.porcentaje;
                tipo_act.porc_eficiencia = tipoActividad.porc_eficiencia;
                bd.SaveChanges();

                return tipo_act;
            }
        }

        public static USUARIO ObtenerResponsableProduccion(int id_actividad_proyecto)
        {
            using (var bd = new DescarEntity())
            {
                var tipo_act = (from ta in bd.Cuerpo_movimiento_hora
                                    join mh in bd.Movimiento_hora on ta.id_movimiento_hora equals mh.id_movimiento_hora
                                    join us in bd.USUARIOs on mh.id_usuario equals us.id_usuario
                                    join ap in bd.Actividad_proyecto on ta.id_actividad_proyecto equals ap.id_actividad_proyecto
                                    join mv in bd.Movimiento_voz on ap.id_actividad_proyecto equals mv.id_actividad_proyecto
                                    where ta.id_actividad_proyecto == id_actividad_proyecto
                                          && (us.id_usuario == mv.id_usuario_1)
                                    orderby SqlFunctions.DateDiff("hour", ta.entrada, ta.salida) descending
                                    select us);

                if (!tipo_act.Any())
                {
                    tipo_act = (from ta in bd.Detalle_recurso
                        join us in bd.USUARIOs on ta.id_usuario equals us.id_usuario
                        where ta.id_actividad_proyecto == id_actividad_proyecto
                        select us);
                }
                if (!tipo_act.Any())
                {
                    tipo_act = (from ta in bd.Cuerpo_movimiento_hora
                                join mh in bd.Movimiento_hora on ta.id_movimiento_hora equals mh.id_movimiento_hora
                                    join us in bd.USUARIOs on mh.id_usuario equals us.id_usuario
                                    where ta.id_actividad_proyecto == id_actividad_proyecto
                                    orderby SqlFunctions.DateDiff("hour",ta.entrada,ta.salida) descending 
                                    select us);
                }

                if (!tipo_act.Any())
                {
                    tipo_act = (from ta in bd.Actividad_proyecto
                                join us in bd.USUARIOs on ta.id_cadista equals us.id_usuario
                                where ta.id_actividad_proyecto == id_actividad_proyecto
                                select us);
                }

                return tipo_act.Any() ? tipo_act.First() : null;
            }
        }

        public static Actividad_proyecto ObtenerActividadAnterior(Actividad_proyecto act_pto)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from ap_anterior in bd.Actividad_proyecto
                           where act_pto.id_subproyecto == ap_anterior.id_subproyecto
                           & ap_anterior.orden < act_pto.orden
                           select ap_anterior);

                return act.Any() ? act.OrderBy(x => x.orden).First() : null;
            }
        }

        public static Actividad_proyecto ObtenerActividadPosterior(Actividad_proyecto act_pto)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from ap_posterior in bd.Actividad_proyecto
                           where act_pto.id_subproyecto == ap_posterior.id_subproyecto
                           & ap_posterior.orden  > act_pto.orden
                           select ap_posterior);

                return act.Any() ? act.OrderBy(x => x.orden).First() : null;
            }
        }

        public static void EliminarActividadProyecto(Actividad_proyecto item)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Actividad_proyecto
                           where mv.id_actividad_proyecto == item.id_actividad_proyecto
                           select mv);

                bd.Actividad_proyecto.RemoveRange(act);
                bd.SaveChanges();
            }
        }

        public static bool TieneHorasLogueadas(Actividad_proyecto item)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from av in bd.Actividad_proyecto
                           join mv in bd.Cuerpo_movimiento_hora on av.id_actividad_proyecto equals mv.id_actividad_proyecto
                           where mv.id_actividad_proyecto == item.id_actividad_proyecto
                           select av);

               return act.Any();
            }
        }

        public static bool TieneHorasLogueadas(Detalle_recurso item)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from av in bd.Actividad_proyecto
                           join mv in bd.Cuerpo_movimiento_hora on av.id_actividad_proyecto equals mv.id_actividad_proyecto
                           where mv.id_actividad_proyecto == item.id_actividad_proyecto
                           & mv.id_detalle_recurso == item.id_detalle_recurso
                           select av);

                return act.Any();
            }
        }



        public static void EliminarActividadDeActividadProyecto(Actividad_proyecto item)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Actividads
                           where mv.id_actividad == item.id_actividad
                           select mv);

                bd.Actividads.RemoveRange(act);
                bd.SaveChanges();
            }
        }

        public static List<Detalle_recurso> obtenerTareasDeActividad(Actividad_proyecto actividad)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from av in bd.Detalle_recurso
                           where av.id_actividad_proyecto == actividad.id_actividad_proyecto
                           select av);

                return act.ToList();
            }
        }

        public static void EliminarProgramacionActividadDeActividadProyecto(Actividad_proyecto item)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Programacion_Actividad
                           where mv.id_actividad_proyecto == item.id_actividad_proyecto
                           select mv);

                bd.Programacion_Actividad.RemoveRange(act);
                bd.SaveChanges();
            }
        }

        public static Movimiento_voz ObtenerMovimientoVoz(Actividad_proyecto ap)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Movimiento_voz
                           where mv.id_actividad_proyecto == ap.id_actividad_proyecto
                           select mv);

                return act.Any() ? act.First() : null;
            }
        }

        
        public static bool TieneControl_cal_1_Completado(Actividad_proyecto ap)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Movimiento_voz
                           where mv.id_actividad_proyecto == ap.id_actividad_proyecto
                           & mv.control_1 == true
                           select mv);

                return act.Any();
            }
        }

        public static bool TieneControl_cal_2_Completado(Actividad_proyecto ap)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Movimiento_voz
                           where mv.id_actividad_proyecto == ap.id_actividad_proyecto
                           & mv.control_2 == true
                           select mv);

                return act.Any();
            }
        }

        public static Actividad_proyecto ObtenerActividadPorTipoActividad(SUBPROYECTO subpr, Tipo_actividad tipo_actividad)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                           join ap in bd.Actividad_proyecto on s.id_subproyecto equals ap.id_subproyecto
                           join a in bd.Actividads on ap.id_actividad equals a.id_actividad
                           where s.id_subproyecto == subpr.id_subproyecto
                           & a.id_tipo_actividad == tipo_actividad.id_tipo_actividad
                           select ap);

                return sub.Any() ? sub.First() : null;
            }
        }

        public static bool TieneControl_corr_1_Completado(Actividad_proyecto ap)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Movimiento_voz
                           where mv.id_actividad_proyecto == ap.id_actividad_proyecto
                           & mv.control_corr_1 == true
                           select mv);

                return act.Any();
            }
        }

        public static bool TieneControl_corr_2_Completado(Actividad_proyecto ap)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Movimiento_voz
                           where mv.id_actividad_proyecto == ap.id_actividad_proyecto
                           & mv.control_corr_2 == true
                           select mv);

                return act.Any();
            }
        }

        public static bool TieneControl_prod_1_Completado(Actividad_proyecto ap)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Movimiento_voz
                           where mv.id_actividad_proyecto == ap.id_actividad_proyecto
                           & mv.control_prod == true
                           select mv);

                return act.Any();
            }
        }

        public static bool TieneControl_prod_2_Completado(Actividad_proyecto ap)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Movimiento_voz
                           where mv.id_actividad_proyecto == ap.id_actividad_proyecto
                           & mv.control_prod_2 == true
                           select mv);

                return act.Any();
            }
        }

        public static bool EstaCompletada(Actividad_proyecto ap)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from mv in bd.Movimiento_voz
                           where mv.id_actividad_proyecto == ap.id_actividad_proyecto
                           & mv.completado == true
                           select mv);

                return act.Any();
            }
        }

        public static Tipo_actividad ObtenerTipoActividad(Actividad_proyecto ap)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from ta in bd.Tipo_actividad
                           join a in bd.Actividads on ta.id_tipo_actividad equals a.id_tipo_actividad
                           where a.id_actividad == ap.id_actividad
                           select ta);

                return act.Any() ? act.Single() : null;
            }
        }

        public static USUARIO ObtenerResponsableControl(int id_actividad_proyecto)
        {
            using (var bd = new DescarEntity())
            {
                var tipo_act = (from ta in bd.Cuerpo_movimiento_hora
                    join mh in bd.Movimiento_hora on ta.id_movimiento_hora equals mh.id_movimiento_hora
                    join us in bd.USUARIOs on mh.id_usuario equals us.id_usuario
                    join ap in bd.Actividad_proyecto on ta.id_actividad_proyecto equals ap.id_actividad_proyecto
                    join mv in bd.Movimiento_voz on ap.id_actividad_proyecto equals mv.id_actividad_proyecto
                    where ta.id_actividad_proyecto == id_actividad_proyecto
                          && (us.id_usuario == mv.id_controlador_1 || us.id_usuario == mv.id_controlador_2)
                    orderby SqlFunctions.DateDiff("hour", ta.entrada, ta.salida) descending
                    select us);

                if (!tipo_act.Any())
                {
                    tipo_act = (from mv in bd.Movimiento_voz 
                                join ap in bd.Actividad_proyecto on mv.id_actividad_proyecto equals ap.id_actividad_proyecto
                                join us in bd.USUARIOs on mv.id_controlador_1 equals us.id_usuario
                                where ap.id_actividad_proyecto == id_actividad_proyecto
                                select us);
                }

                if (!tipo_act.Any())
                {
                    tipo_act = (from ap in bd.Actividad_proyecto 
                                join s in bd.Proyectoes on ap.id_proyecto equals s.id_proyecto
                                join us in bd.USUARIOs on s.id_controlador_1 equals us.id_usuario
                                where ap.id_actividad_proyecto == id_actividad_proyecto
                                select us);
                }

                return tipo_act.Any() ? tipo_act.First() : null;
            }
        }

        public static USUARIO ObtenerResponsableCorrecion(int id_actividad_proyecto)
        {
            using (var bd = new DescarEntity())
            {
                var tipo_act = (from ta in bd.Cuerpo_movimiento_hora
                                join mh in bd.Movimiento_hora on ta.id_movimiento_hora equals mh.id_movimiento_hora
                                join us in bd.USUARIOs on mh.id_usuario equals us.id_usuario
                                join ap in bd.Actividad_proyecto on ta.id_actividad_proyecto equals ap.id_actividad_proyecto
                                join mv in bd.Movimiento_voz on ap.id_actividad_proyecto equals mv.id_actividad_proyecto
                                where ta.id_actividad_proyecto == id_actividad_proyecto
                                && ta.id_tipo_logueo == 2
                                && (us.id_usuario == mv.id_usuario_3.Value || us.id_usuario == mv.id_usuario_5.Value)
                                orderby SqlFunctions.DateDiff("hour", ta.entrada, ta.salida) descending
                                select us);

                return tipo_act.Any() ? tipo_act.First() : null;
            }
        }

        public static double ObtenerHorasConsumidas(Actividad_proyecto acti, string tipo_logueo)
        {
            using (var bd = new DescarEntity())
            {
                var tipo_act = (from ta in bd.Cuerpo_movimiento_hora
                                join tl in bd.TIPO_LOGUEO on ta.id_tipo_logueo equals tl.id_tipo_logueo
                                where ta.id_actividad_proyecto == acti.id_actividad_proyecto
                                && (tl.nombre.ToLower().Contains(tipo_logueo.ToLower())
                                || (tl.nombre.ToLower().Contains("sin asignar") && tipo_logueo.ToLower().Contains("produccion")))
                                select ta).ToList();

                return tipo_act.Select(x => ((TimeSpan)(x.salida - x.entrada)).TotalHours).Sum();
            }
        }

        public static double ObtenerHorasConsumidas(Actividad_proyecto acti)
        {
            using (var bd = new DescarEntity())
            {
                var tipo_act = (from ta in bd.Cuerpo_movimiento_hora
                                where ta.id_actividad_proyecto == acti.id_actividad_proyecto                                
                                select ta).ToList();

                return tipo_act.Select(x => ((TimeSpan)(x.salida - x.entrada)).TotalHours).Sum();
            }
        }

        public static Actividad ObtenerActividad(Actividad_proyecto act_pro)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from a in bd.Actividads
                           where a.id_actividad == act_pro.id_actividad
                           select a);

                return act.Any() ? act.First() : null;
            }
        }

        public static Actividad_proyecto ObtenerActividadProyecto(int idActividadProyecto)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from a in bd.Actividad_proyecto
                           where a.id_actividad_proyecto == idActividadProyecto
                           select a);

                return act.Any() ? act.First() : null;
            }
        }

        public static double ObtenerHorasAsignadas(Actividad_proyecto actividad)
        {
            //using (var bd = new DescarEntity())
            //{
            //    var act = (from ap in bd.Actividad_proyecto
            //               join s in bd.SUBPROYECTOes on ap.id_subproyecto equals s.id_subproyecto
            //               join acti in bd.Actividads on ap.id_actividad equals acti.id_actividad
            //               join ta in bd.Tipo_actividad on acti.id_tipo_actividad equals ta.id_tipo_actividad
            //               where ap.id_actividad_proyecto == actividad.id_actividad_proyecto
            //               select (s.horas_estimadas * ta.criticidad /100 ));

            //    return act.Any() ? (double)act.Single() : 0;
            //}
            using (var bd = new DescarEntity())
            {
                var act = (from ap in bd.Actividad_proyecto
                           join s in bd.SUBPROYECTOes on ap.id_subproyecto equals s.id_subproyecto
                           join hs in bd.HORA_TIPO_SUBPROYECTO on s.id_hora_tipo_subproyecto equals hs.id_hora_tipo_subproyecto
                           join acti in bd.Actividads on ap.id_actividad equals acti.id_actividad
                           join ta in bd.Tipo_actividad on acti.id_tipo_actividad equals ta.id_tipo_actividad
                           where ap.id_actividad_proyecto == actividad.id_actividad_proyecto
                           select (hs.horas * ta.criticidad / 100));

                return act.Any() ? (double)act.Single() : 0;
            }
        }

        /// <summary>
        /// Devuelve las horas para la actividad, en base a las horas presupuestadas.
        /// </summary>
        /// <param name="actividad"></param>
        /// <returns></returns>
        public static double ObtenerHorasPorOrdenCompra(Actividad_proyecto actividad)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from ap in bd.Actividad_proyecto
                           join s in bd.SUBPROYECTOes on ap.id_subproyecto equals s.id_subproyecto
                           join acti in bd.Actividads on ap.id_actividad equals acti.id_actividad
                           join ta in bd.Tipo_actividad on acti.id_tipo_actividad equals ta.id_tipo_actividad
                           where ap.id_actividad_proyecto == actividad.id_actividad_proyecto
                           join hs in bd.HORA_TIPO_SUBPROYECTO on s.id_hora_tipo_subproyecto equals hs.id_hora_tipo_subproyecto
                           select (s.horas_orden_compra.HasValue ? s.horas_orden_compra * ta.criticidad / 100 : hs.horas * ta.criticidad / 100));

                return act.Any() ? (double)act.Single() : 0;
            }
        }

        public static double ObtenerHorasAsignadasPorOrdenCompra(Actividad_proyecto actividad, decimal horas_minimas)
        {
            using (var bd = new DescarEntity())
            {
                var act = (from ap in bd.Actividad_proyecto
                           join s in bd.SUBPROYECTOes on ap.id_subproyecto equals s.id_subproyecto
                           join sd in bd.SUBPROYECTOes on s.id_subproyecto_padre equals sd.id_subproyecto
                           join acti in bd.Actividads on ap.id_actividad equals acti.id_actividad
                           join ta in bd.Tipo_actividad on acti.id_tipo_actividad equals ta.id_tipo_actividad
                           where ap.id_actividad_proyecto == actividad.id_actividad_proyecto
                           join hs in bd.HORA_TIPO_SUBPROYECTO on s.id_hora_tipo_subproyecto equals hs.id_hora_tipo_subproyecto
                           select (sd.horas_orden_compra.HasValue ? (sd.horas_orden_compra * hs.horas / horas_minimas) * ta.criticidad / 100 : hs.horas * ta.criticidad / 100));

                return act.Any() ? (double)act.Single() : 0;
            }
        }



    }
}
