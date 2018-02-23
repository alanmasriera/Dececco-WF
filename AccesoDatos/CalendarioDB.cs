using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class CalendarioDB
    {
        public static Calendario_Laboral InsertarCalendario(Calendario_Laboral calendario)
        {
            using (var bd = new DescarEntity())
            {
                bd.Calendario_Laboral.Add(calendario);
                bd.SaveChanges();
            }
            return calendario;
        }

        public static void Eliminar(Detalle_Calendario_Laboral detalle)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_Calendario_Laboral
                           where s.id_detalle_calendario_laboral == detalle.id_detalle_calendario_laboral
                           select s).Single();

                bd.Detalle_Calendario_Laboral.Remove(sub);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(Definicion_Calendario_Laboral def)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Definicion_Calendario_Laboral
                           where s.id_definicion_calendario_laboral == def.id_definicion_calendario_laboral
                           select s).Single();

                var det = (from s in bd.Detalle_Calendario_Laboral
                           where s.id_definicion_calendario_laboral == def.id_definicion_calendario_laboral
                           select s).ToList();

                bd.Detalle_Calendario_Laboral.RemoveRange(det);
                bd.Definicion_Calendario_Laboral.Remove(sub);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(Excepcion_Calendario exce)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Excepcion_Calendario
                           where s.id_exception_calendario == exce.id_exception_calendario
                           select s).Single();

                bd.Excepcion_Calendario.Remove(sub);
                bd.SaveChanges();
            }
        }

        public static Calendario_Laboral ActualizarCalendario(Calendario_Laboral calendario)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Calendario_Laboral
                           select s).Single();

                sub.nombre_calendario = calendario.nombre_calendario;
                sub.id_calendario_padre = calendario.id_calendario_padre;
                sub.es_calendario_base = calendario.es_calendario_base;

                bd.SaveChanges();
                return sub;
            }
        }

        public static Definicion_Calendario_Laboral InsertarDefinicionCalendario(Definicion_Calendario_Laboral definicion)
        {
            using (var bd = new DescarEntity())
            {
                bd.Definicion_Calendario_Laboral.Add(definicion);
                bd.SaveChanges();
            }
            return definicion;
        }


        public static Calendario_Laboral ObtenerCalendarioPorID(int id_calendario)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Calendario_Laboral
                           where s.id_calendario_laboral == id_calendario
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static List<Detalle_Calendario_Laboral> ObtenerDetallesDia(Definicion_Calendario_Laboral definicion, DateTime fecha)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_Calendario_Laboral
                           join d in bd.Dias on s.id_dia equals d.id_dia
                           join dl in bd.Definicion_Calendario_Laboral on s.id_definicion_calendario_laboral equals dl.id_definicion_calendario_laboral
                           where s.id_definicion_calendario_laboral == definicion.id_definicion_calendario_laboral
                           & fecha.Date >= dl.fecha_desde & fecha.Date <= dl.fecha_hasta
                           & (int)fecha.DayOfWeek == d.DayOfWeek
                           select s);
                return sub.ToList();
            }
        }

        public static List<Detalle_Calendario_Laboral> ObtenerDetalles(Definicion_Calendario_Laboral definicion)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_Calendario_Laboral
                           where s.id_definicion_calendario_laboral == definicion.id_definicion_calendario_laboral
                           select s);
                return sub.ToList();
            }
        }

        public static Excepcion_Calendario ObtenerExcepcionPorID(int idExcepcion)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Excepcion_Calendario
                           where s.id_exception_calendario == idExcepcion
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        public static Detalle_Calendario_Laboral ObtenerDetalle(int id_definicion_calendario_laboral, string nombreDia)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_Calendario_Laboral
                           join d in bd.Dias on s.id_dia equals d.id_dia
                           where s.id_definicion_calendario_laboral == id_definicion_calendario_laboral
                           & d.nombre_dia.Contains(nombreDia)
                           select s);
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static Excepcion_Calendario InsertarExcepcion(Excepcion_Calendario excepcion)
        {
            using (var bd = new DescarEntity())
            {
                bd.Excepcion_Calendario.Add(excepcion);
                bd.SaveChanges();
            }
            return excepcion;
        }

        public static List<Detalle_recurso> ObtenerAsignacionesDeMiembro(USUARIO miembro)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Detalle_recurso
                           where s.id_usuario == miembro.id_usuario
                           select s);
                return sub.ToList();
            }
        }

        public static Calendario_Laboral ObtenerCalendario(int idCalendarioLaboral)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Calendario_Laboral
                           where s.id_calendario_laboral == idCalendarioLaboral
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        public static Calendario_Laboral ObtenerCalendarioLaboraldeMiembro(USUARIO miembro)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Calendario_Laboral
                           where s.id_calendario_laboral == miembro.id_calendario_laboral
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        public static List<Excepcion_Calendario> ObtenerExcepcionesTotales(Calendario_Laboral calendario)
        {
            if (!calendario.es_calendario_base)
            {
                //Si no es calendario base, y tiene excepciones, solo toma esas, sino las de la base
                using (var bd = new DescarEntity())
                {
                    var sub = (from s in bd.Excepcion_Calendario                               
                               where calendario.id_calendario_laboral == s.id_calendario_laboral
                               select s);

                    if (sub.ToList().Count > 0)
                        return sub.ToList();
                    
                    else
                    {
                        //Devuelve las excepciones del padre
                        sub = (from s in bd.Excepcion_Calendario
                               join cb in bd.Calendario_Laboral on calendario.id_calendario_padre equals cb.id_calendario_laboral
                               where cb.id_calendario_laboral == s.id_calendario_laboral
                               select s);

                        return sub.ToList();
                    }
                }
            }

            //Si el calendario ya es base, devuelve sus excepciones
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Excepcion_Calendario
                            where calendario.id_calendario_laboral == s.id_calendario_laboral
                            select s);

                return sub.ToList();
            }
            
        }

        public static List<Definicion_Calendario_Laboral> ObtenerDefinicionesTotales(Calendario_Laboral calendario)
        {
            if (!calendario.es_calendario_base)
            {
                using (var bd = new DescarEntity())
                {
                    var sub = (from s in bd.Definicion_Calendario_Laboral
                               join c in bd.Calendario_Laboral on calendario.id_calendario_padre equals c.id_calendario_laboral
                               where calendario.id_calendario_laboral == s.id_calendario_laboral ||
                               s.id_calendario_laboral == c.id_calendario_laboral
                               select s);

                    return sub.ToList();
                }
            }
            else
            {
                using (var bd = new DescarEntity())
                {
                    var sub = (from s in bd.Definicion_Calendario_Laboral                               
                               where calendario.id_calendario_laboral == s.id_calendario_laboral
                               select s);

                    return sub.ToList();
                }
            }
                
        }

        public static Dia ObtenerDiaPorNombre(DayOfWeek dayOfWeek)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Dias
                           where s.DayOfWeek == (int)dayOfWeek
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        public static Definicion_Calendario_Laboral ObtenerDefinicionPorID(int idDefinicion)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Definicion_Calendario_Laboral
                           where s.id_definicion_calendario_laboral == idDefinicion
                           select s);
                
                return sub.Any() ? sub.Single() : null;
            }
        }

        public static Excepcion_Calendario ActualizarExcepcion(Excepcion_Calendario excepcion)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Excepcion_Calendario
                           where p.id_exception_calendario == excepcion.id_exception_calendario
                           select p).Single();

                pro.fecha_comienzo = excepcion.fecha_comienzo;
                pro.fecha_fin = excepcion.fecha_fin;
                pro.hora_fin_1 = excepcion.hora_fin_1;
                pro.hora_inicio_1 = excepcion.hora_inicio_1;
                pro.hora_inicio_2 = excepcion.hora_inicio_2;
                pro.hora_fin_2 = excepcion.hora_fin_2;
                pro.hora_inicio_3 = excepcion.hora_inicio_3;
                pro.hora_fin_3 = excepcion.hora_fin_3;
                pro.hora_fin_4 = excepcion.hora_fin_4;
                pro.hora_inicio_4 = excepcion.hora_inicio_4;
                pro.hora_inicio_5 = excepcion.hora_inicio_5;
                pro.hora_fin_5 = excepcion.hora_fin_5;
                pro.laborable = excepcion.laborable;
                pro.patron_repeticion = excepcion.patron_repeticion;
                pro.freq_interval = excepcion.freq_interval;
                pro.freq_recurrence_factor = excepcion.freq_recurrence_factor;
                pro.freq_relative_interval = excepcion.freq_relative_interval;
                pro.freq_subday_interval = excepcion.freq_subday_interval;
                pro.freq_subday_type = excepcion.freq_subday_type;
                pro.freq_type = excepcion.freq_type;
                
                bd.SaveChanges();
                return pro;
            }
        }

        public static List<Excepcion_Calendario> ObtenerExcepciones(Calendario_Laboral calendario)
        {
            if (calendario == null) return new List<Excepcion_Calendario>();
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Excepcion_Calendario
                           where s.id_calendario_laboral == calendario.id_calendario_laboral
                           select s);
                return sub.ToList();
            }
        }

        public static Definicion_Calendario_Laboral ActualizarDefinicion(Definicion_Calendario_Laboral def)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Definicion_Calendario_Laboral
                           where p.id_definicion_calendario_laboral == def.id_definicion_calendario_laboral
                           select p).Single();

                pro.fecha_desde = def.fecha_desde;
                pro.fecha_hasta = def.fecha_hasta;
                pro.nombre_definicion = def.nombre_definicion;

                bd.SaveChanges();

                return pro;
            }
        }

        public static Detalle_Calendario_Laboral ActualizarDetalle(Detalle_Calendario_Laboral detalle)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Detalle_Calendario_Laboral
                           where p.id_detalle_calendario_laboral == detalle.id_detalle_calendario_laboral
                           select p).Single();

                pro.hora_desde_1 = detalle.hora_desde_1;
                pro.hora_hasta_1 = detalle.hora_hasta_1;
                pro.hora_desde_2 = detalle.hora_desde_2;
                pro.hora_hasta_2 = detalle.hora_hasta_2;
                pro.hora_desde_3 = detalle.hora_desde_3;
                pro.hora_hasta_3 = detalle.hora_hasta_3;
                pro.hora_desde_4 = detalle.hora_desde_4;
                pro.hora_hasta_4 = detalle.hora_hasta_4;
                pro.hora_desde_5 = detalle.hora_desde_5;
                pro.hora_hasta_5 = detalle.hora_hasta_5;
                pro.importa_base = detalle.importa_base;
                pro.no_laborable = detalle.no_laborable;

                bd.SaveChanges();

                return pro;
            }
        }

        public static List<Definicion_Calendario_Laboral> ObtenerDefiniciones(Calendario_Laboral calendario)
        {
            if (calendario == null) return new List<Definicion_Calendario_Laboral>();
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Definicion_Calendario_Laboral
                           where s.id_calendario_laboral == calendario.id_calendario_laboral
                           select s);
                return sub.ToList();
            }
        }

        public static List<Calendario_Laboral> ObtenerCalendarios()
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Calendario_Laboral
                           select s);
                return sub.ToList();
            }
        }

        public static Detalle_Calendario_Laboral InsertarDetalleCalendario(Detalle_Calendario_Laboral calendario)
        {
            using (var bd = new DescarEntity())
            {
                bd.Detalle_Calendario_Laboral.Add(calendario);
                bd.SaveChanges();
            }
            return calendario;
        }
    }
}
