using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Globalization;

namespace ControladoresLogica
{
    public class ControladorCalendario
    {
        public static Calendario_Laboral Insertar(Calendario_Laboral calendario)
        {
            return CalendarioDB.InsertarCalendario(calendario);
        }

        public static void Eliminar (Detalle_Calendario_Laboral detalle)
        {
            CalendarioDB.Eliminar(detalle);
        }

        public static void Eliminar(Definicion_Calendario_Laboral def)
        {
            CalendarioDB.Eliminar(def);
        }

        public static void Eliminar(Excepcion_Calendario exce)
        {
            CalendarioDB.Eliminar(exce);
        }

        public static Definicion_Calendario_Laboral Insertar(Definicion_Calendario_Laboral definicion)
        {
            Definicion_Calendario_Laboral def = CalendarioDB.InsertarDefinicionCalendario(definicion);
            CrearDetalleCalendario(DayOfWeek.Sunday, def.id_definicion_calendario_laboral);
            CrearDetalleCalendario(DayOfWeek.Monday, def.id_definicion_calendario_laboral);
            CrearDetalleCalendario(DayOfWeek.Tuesday, def.id_definicion_calendario_laboral);
            CrearDetalleCalendario(DayOfWeek.Wednesday, def.id_definicion_calendario_laboral);
            CrearDetalleCalendario(DayOfWeek.Thursday, def.id_definicion_calendario_laboral);
            CrearDetalleCalendario(DayOfWeek.Friday, def.id_definicion_calendario_laboral);
            CrearDetalleCalendario(DayOfWeek.Saturday, def.id_definicion_calendario_laboral);
            return def;
        }

        public static Excepcion_Calendario ObtenerExcepcionPorID(int idExcepcion)
        {
            return CalendarioDB.ObtenerExcepcionPorID(idExcepcion);
        }

        public static Calendario_Laboral ActualizarCalendario(Calendario_Laboral calendario)
        {
            return CalendarioDB.ActualizarCalendario(calendario);
        }
        
        private static void CrearDetalleCalendario(DayOfWeek dayOfWeek, int id_definicion_laboral)
        {
            Detalle_Calendario_Laboral detalle = new Detalle_Calendario_Laboral();
            detalle.id_definicion_calendario_laboral = id_definicion_laboral;
            detalle.id_dia = ObtenerDiaPorNombre(dayOfWeek).id_dia;
            detalle.no_laborable = false;
            Insertar(detalle);
        }

        public static Detalle_Calendario_Laboral Insertar(Detalle_Calendario_Laboral calendario)
        {
            return CalendarioDB.InsertarDetalleCalendario(calendario);
        }

        public static Excepcion_Calendario Insertar(Excepcion_Calendario excepcion)
        {
            return CalendarioDB.InsertarExcepcion(excepcion);
        }

        public static List<Detalle_Calendario_Laboral> ObtenerDetalles(Definicion_Calendario_Laboral definicion)
        {
            return CalendarioDB.ObtenerDetalles(definicion);
        }

        public static List<Detalle_Calendario_Laboral> ObtenerDetallesDia(Definicion_Calendario_Laboral definicion, DateTime fecha)
        {
            return CalendarioDB.ObtenerDetallesDia(definicion, fecha);
        }

        public static List<Calendario_Laboral> ObtenerCalendarios()
        {
            return CalendarioDB.ObtenerCalendarios();
        }

        public static Detalle_Calendario_Laboral ObtenerDetalle(int id_definicion_calendario_laboral, string nombreDia)
        {
            return CalendarioDB.ObtenerDetalle(id_definicion_calendario_laboral, nombreDia);
        }

        public static Definicion_Calendario_Laboral ObtenerDefinicionPorID(int idDefinicion)
        {
            return CalendarioDB.ObtenerDefinicionPorID(idDefinicion);
        }

        public static List<Definicion_Calendario_Laboral> ObtenerDefiniciones(Calendario_Laboral calendario)
        {
            return CalendarioDB.ObtenerDefiniciones(calendario);
        }

        public static Dia ObtenerDiaPorNombre(DayOfWeek dayOfWeek)
        {
            return CalendarioDB.ObtenerDiaPorNombre(dayOfWeek);
        }

        public static Definicion_Calendario_Laboral ActualizarDefinicion(Definicion_Calendario_Laboral def)
        {
            return CalendarioDB.ActualizarDefinicion(def);
        }

        public static Detalle_Calendario_Laboral ActualizarDetalle(Detalle_Calendario_Laboral detalle)
        {
            if (!(detalle.hora_desde_1.HasValue && detalle.hora_hasta_1.HasValue
                && detalle.hora_hasta_1 > detalle.hora_desde_1))
            {
                detalle.hora_desde_1 = null;
                detalle.hora_hasta_1 = null;
                detalle.hora_desde_2 = null;
                detalle.hora_hasta_2 = null;
                detalle.hora_desde_3 = null;
                detalle.hora_hasta_3 = null;
                detalle.hora_desde_4 = null;
                detalle.hora_hasta_4 = null;
                detalle.hora_desde_5 = null;
                detalle.hora_hasta_5 = null;
            }

            if (!(detalle.hora_desde_2.HasValue && detalle.hora_hasta_2.HasValue
                && detalle.hora_hasta_2 > detalle.hora_desde_2)
                & detalle.hora_desde_1.HasValue && detalle.hora_hasta_1.HasValue)
            {
                detalle.hora_desde_2 = null;
                detalle.hora_hasta_2 = null;
                detalle.hora_desde_3 = null;
                detalle.hora_hasta_3 = null;
                detalle.hora_desde_4 = null;
                detalle.hora_hasta_4 = null;
                detalle.hora_desde_5 = null;
                detalle.hora_hasta_5 = null;
            }

            if (!(detalle.hora_desde_3.HasValue && detalle.hora_hasta_3.HasValue
                && detalle.hora_hasta_3 > detalle.hora_desde_3)
                & detalle.hora_desde_2.HasValue && detalle.hora_hasta_2.HasValue)
            {
                detalle.hora_desde_3 = null;
                detalle.hora_hasta_3 = null;
                detalle.hora_desde_4 = null;
                detalle.hora_hasta_4 = null;
                detalle.hora_desde_5 = null;
                detalle.hora_hasta_5 = null;
            }

            if (!(detalle.hora_desde_4.HasValue && detalle.hora_hasta_4.HasValue
                && detalle.hora_hasta_4 > detalle.hora_desde_4)
                & detalle.hora_desde_3.HasValue && detalle.hora_hasta_3.HasValue)
            {
                detalle.hora_desde_4 = null;
                detalle.hora_hasta_4 = null;
                detalle.hora_desde_5 = null;
                detalle.hora_hasta_5 = null;
            }

            if (!(detalle.hora_desde_5.HasValue && detalle.hora_hasta_5.HasValue
                && detalle.hora_hasta_5 > detalle.hora_desde_5)
                & detalle.hora_desde_4.HasValue && detalle.hora_hasta_4.HasValue)
            {
                detalle.hora_desde_5 = null;
                detalle.hora_hasta_5 = null;
            }

            return CalendarioDB.ActualizarDetalle(detalle);
        }

        public static Excepcion_Calendario ActualizarExcepcion(Excepcion_Calendario excepcion)
        {
            return CalendarioDB.ActualizarExcepcion(excepcion);
        }

        public static List<Excepcion_Calendario> ObtenerExcepciones(Calendario_Laboral calendario)
        {
            return CalendarioDB.ObtenerExcepciones(calendario);
        }

        public static Calendario_Laboral ObtenerCalendario(int id_calendario_laboral_base)
        {
            return CalendarioDB.ObtenerCalendario(id_calendario_laboral_base);
        }

        public static List<Detalle_recurso> ObtenerAsignacionesDeMiembro(USUARIO miembro)
        {
            return CalendarioDB.ObtenerAsignacionesDeMiembro(miembro);
        }

        public static Calendario_Laboral ObtenerCalendarioLaboraldeMiembro(USUARIO miembro)
        {
            return CalendarioDB.ObtenerCalendarioLaboraldeMiembro(miembro);
        }

       
        public static DateTime? CalcularFechaFin(Actividad_proyecto actividad, USUARIO usuario, DateTime fecha_inicio, double? horas)
        {
            Calendario_Laboral calendario = ObtenerCalendarioLaboraldeMiembro(usuario);
            Calendario_Laboral padre = ObtenerCalendario(calendario.id_calendario_padre.Value);

            List<Definicion_Calendario_Laboral> definiciones_padre = ObtenerDefiniciones(padre).OrderByDescending(x => x.fecha_hasta).ToList();
            List<Excepcion_Calendario> excepciones = ObtenerExcepciones(padre);
            List<Definicion_Calendario_Laboral> definiciones_hijo = ObtenerDefiniciones(calendario).OrderByDescending(x => x.fecha_hasta).ToList();
            List<Excepcion_Calendario> excepciones_hijo = ObtenerExcepciones(calendario);

            List<DateTime> fechasIncluidas = new List<DateTime>();
            fechasIncluidas.AddRange(definiciones_padre.Select(x => x.fecha_hasta));
            fechasIncluidas.AddRange(excepciones.Select(x => x.fecha_fin.Value).ToList());
            fechasIncluidas.AddRange(definiciones_hijo.Select(x => x.fecha_hasta));
            fechasIncluidas.AddRange(excepciones_hijo.Select(x => x.fecha_fin.Value).ToList());
            fechasIncluidas.Sort((a, b) => b.CompareTo(a));

            double horasActividad = horas.HasValue ? horas.Value : ControladorActividades.ObtenerHorasTotalesActividad(actividad);
            double restante = horasActividad * 60;
            TimeSpan hora = fecha_inicio.TimeOfDay;
            DateTime fecha_fin;

            if (fechasIncluidas.Count > 0)
            {
                for (DateTime i = fecha_inicio; i <= fechasIncluidas.First(); i = i.AddDays(1))
                {
                    //Agregar si la expcecion no base no define un dia pero la base si,
                    //dentro de un período
                    var aux = ObtenerHorasLaboralesDia(calendario, i);
                    double tiempoDia = 0;

                    foreach (var item in aux)
                    {
                        if (fecha_inicio.Date == i.Date)
                        {
                            //Hay que tener en cuenta la hora, sino no
                            if (hora.Ticks > item.Item1.Ticks && hora.Ticks < item.Item2.Ticks)
                            {
                                tiempoDia += (item.Item2.Ticks - hora.Ticks) / TimeSpan.TicksPerMinute;
                            }
                            else if (hora.Ticks <= item.Item1.Ticks)
                            {
                                tiempoDia += (item.Item2.Ticks - item.Item1.Ticks) / TimeSpan.TicksPerMinute;
                            }
                        }
                        else
                        {
                            tiempoDia += (item.Item2.Ticks - item.Item1.Ticks) / TimeSpan.TicksPerMinute;
                        }
                        
                        if (restante - tiempoDia == 0)
                        {
                            fecha_fin = i;
                            TimeSpan hora_fin = TimeSpan.FromTicks(item.Item2.Ticks);
                            DateTime nuevo = new DateTime(i.Year, i.Month, i.Day, hora_fin.Hours, hora_fin.Minutes, hora_fin.Seconds);
                            return nuevo;
                        }
                        else if (restante - tiempoDia < 0)
                        {
                            TimeSpan hora_fin;
                            if (fecha_inicio.Date == i.Date && (hora.Ticks > item.Item1.Ticks && hora.Ticks < item.Item2.Ticks))
                            {
                                hora_fin = TimeSpan.FromTicks((long)(hora.Ticks + (restante * TimeSpan.TicksPerMinute)));
                            }
                            else
                            {
                                hora_fin = TimeSpan.FromTicks((long)(item.Item1.Ticks + (restante * TimeSpan.TicksPerMinute)));
                            }
                                
                            fecha_fin = i;
                            DateTime nuevo = new DateTime(i.Year, i.Month, i.Day, hora_fin.Hours, hora_fin.Minutes, hora_fin.Seconds);
                            return nuevo;
                        }
                        else
                        {
                            restante = restante - tiempoDia;
                            tiempoDia = 0;
                        }
                    }
                }
            }

            return null;
            
        }

        public static DateTime? CalcularFechaFinDesdeProyecto(Actividad_proyecto actividad, double tiempo_actividad)
        {
            Proyecto proyecto = ControladorProyecto.ObtenerPorID(actividad.id_proyecto.Value);
            Calendario_Laboral padre = ObtenerCalendario(proyecto.id_calendario_laboral_base.Value);

            List<Definicion_Calendario_Laboral> definiciones_padre = ObtenerDefiniciones(padre).OrderByDescending(x => x.fecha_hasta).ToList();
            List<Excepcion_Calendario> excepciones = ObtenerExcepciones(padre);

            List<DateTime> fechasIncluidas = ObtenerDefiniciones(padre).OrderByDescending(x => x.fecha_hasta).Select(x => x.fecha_hasta).ToList();
            fechasIncluidas.AddRange(excepciones.Select(x => x.fecha_fin.Value).ToList());
            fechasIncluidas.Sort((a,b) => b.CompareTo(a));

            double horasActividad = tiempo_actividad;
            double restante = horasActividad * 60;
            DateTime fecha_fin;
            TimeSpan hora = proyecto.fecha_inicio.Value.TimeOfDay;

            if (fechasIncluidas.Count > 0)
            {
                for (DateTime i = proyecto.fecha_inicio.Value; i <= fechasIncluidas.First(); i = i.AddDays(1))
                {
                    var aux = ObtenerHorasLaboralesDia(padre, i);
                    double tiempoDia = 0;

                    foreach (var item in aux)
                    {
                        if (proyecto.fecha_inicio.Value.Date == i.Date)
                        {
                            //Hay que tener en cuenta la hora, sino no
                            if (hora.Ticks > item.Item1.Ticks && hora.Ticks < item.Item2.Ticks)
                            {
                                tiempoDia += (item.Item2.Ticks - hora.Ticks) / TimeSpan.TicksPerMinute;
                            }
                            else if (hora.Ticks <= item.Item1.Ticks)
                            {
                                tiempoDia += (item.Item2.Ticks - item.Item1.Ticks) / TimeSpan.TicksPerMinute;
                            }
                        }
                        else
                        {
                            tiempoDia += (item.Item2.Ticks - item.Item1.Ticks) / TimeSpan.TicksPerMinute;
                        }                       
                        

                        if (restante - tiempoDia == 0)
                        {
                            fecha_fin = i;
                            TimeSpan hora_fin = TimeSpan.FromTicks(item.Item2.Ticks);
                            DateTime nuevo = new DateTime(i.Year, i.Month, i.Day, hora_fin.Hours, hora_fin.Minutes, hora_fin.Seconds);
                            return nuevo;
                        }
                        else if (restante - tiempoDia < 0)
                        {
                            var hora_fin = TimeSpan.FromTicks((long)(item.Item1.Ticks + (restante * TimeSpan.TicksPerMinute)));
                            fecha_fin = i;
                            DateTime nuevo = new DateTime(i.Year, i.Month, i.Day, hora_fin.Hours, hora_fin.Minutes, hora_fin.Seconds);
                            return nuevo;
                        }
                        else
                        {
                            restante = restante - tiempoDia;
                            tiempoDia = 0;
                        }
                    }
                }
            }

            return null;
        }

        public static DateTime? ObtenerFechaFinMinima(Actividad_proyecto actividad, DateTime fecha_inicio)
        {
            Proyecto proyecto = ControladorProyecto.ObtenerPorID(actividad.id_proyecto.Value);
            Calendario_Laboral padre = ObtenerCalendario(proyecto.id_calendario_laboral_base.Value);
            List<Definicion_Calendario_Laboral> definiciones_padre = ObtenerDefiniciones(padre).OrderByDescending(x => x.fecha_hasta).ToList();
            List<Excepcion_Calendario> excepciones = ObtenerExcepciones(padre);

            List<DateTime> fechasIncluidas = ObtenerDefiniciones(padre).OrderByDescending(x => x.fecha_hasta).Select(x => x.fecha_hasta).ToList();
            fechasIncluidas.AddRange(excepciones.Select(x => x.fecha_fin.Value).ToList());
            fechasIncluidas.Sort((a, b) => b.CompareTo(a));

            double horasActividad = ControladorActividades.ObtenerHorasTotalesActividad(actividad);
            double restante = horasActividad * 60;
            TimeSpan hora = fecha_inicio.TimeOfDay;
            DateTime fecha_fin;

            if (fechasIncluidas.Count > 0)
            {
                for (DateTime i = fecha_inicio; i <= fechasIncluidas.First(); i = i.AddDays(1))
                {
                    var aux = ObtenerHorasLaboralesDia(padre, i);

                    double tiempoDia = 0;

                    foreach (var item in aux)
                    {
                        if (fecha_inicio.Date == i.Date)
                        {
                            //Hay que tener en cuenta la hora, sino no
                            if (hora.Ticks > item.Item1.Ticks && hora.Ticks < item.Item2.Ticks)
                            {
                                tiempoDia += (item.Item2.Ticks - hora.Ticks) / TimeSpan.TicksPerMinute;
                            }
                            else if (hora.Ticks <= item.Item1.Ticks)
                            {
                                tiempoDia += (item.Item2.Ticks - item.Item1.Ticks) / TimeSpan.TicksPerMinute;
                            }
                        }
                        else
                        {
                            tiempoDia += (item.Item2.Ticks - item.Item1.Ticks) / TimeSpan.TicksPerMinute;
                        }
                        //restante = restante - tiempoDia;
                        if (restante - tiempoDia == 0)
                        {
                            fecha_fin = i;
                            TimeSpan hora_fin = TimeSpan.FromTicks(item.Item2.Ticks);
                            DateTime nuevo = new DateTime(i.Year, i.Month, i.Day, hora_fin.Hours, hora_fin.Minutes, hora_fin.Seconds);
                            return nuevo;
                        }
                        else if (restante - tiempoDia < 0)
                        {
                            var hora_fin = TimeSpan.FromTicks((long)(item.Item1.Ticks + (restante * TimeSpan.TicksPerMinute)));
                            fecha_fin = i;
                            DateTime nuevo = new DateTime(i.Year, i.Month, i.Day, hora_fin.Hours, hora_fin.Minutes, hora_fin.Seconds);
                            return nuevo;
                        }
                        else
                        {
                            restante = restante - tiempoDia;
                            tiempoDia = 0;
                        }
                    }
                }
            }

            return null;
        }

        public static List<Tuple<DateTime, Tuple<TimeSpan, TimeSpan>>> PruebaObtenerFechas (USUARIO usuario, DateTime fecha_inicio, DateTime fecha_fin)
        {
            Calendario_Laboral calendario = ObtenerCalendarioLaboraldeMiembro(usuario);

            List<Tuple<DateTime,Tuple<TimeSpan, TimeSpan>>> lista = new List<Tuple<DateTime, Tuple<TimeSpan, TimeSpan>>>();

            for (DateTime i = fecha_inicio; i < fecha_fin; i = i.AddDays(1))
            {
                var listaHoraDia = ObtenerHorasLaboralesDia(calendario, i);
                foreach (var item in listaHoraDia)
                {
                    lista.Add(new Tuple<DateTime, Tuple<TimeSpan, TimeSpan>>(i, item));
                }                  
            }
            return lista;
        }

        /// <summary>
        /// Calcula la cantidad de minutos disponibles para ese usuario entre las fecha indicadas, en base a su calendario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="fecha_fin"></param>
        /// <param name="fecha_inicio"></param>
        /// <returns></returns>
        public static double CalcularTiempoEntreFechas(Calendario_Laboral calendario, DateTime fecha_fin, DateTime fecha_inicio)
        {
            if (fecha_inicio > fecha_fin) return -1;

            List<Definicion_Calendario_Laboral> definiciones_padre = ObtenerDefiniciones(calendario).OrderByDescending(x => x.fecha_hasta).ToList();
            List<Excepcion_Calendario> excepciones = ObtenerExcepciones(calendario);

            List<DateTime> fechasIncluidas = ObtenerDefiniciones(calendario).OrderByDescending(x => x.fecha_hasta).Select(x => x.fecha_hasta).ToList();
            fechasIncluidas.AddRange(excepciones.Select(x => x.fecha_fin.Value).ToList());
            
            if (!calendario.es_calendario_base && calendario.id_calendario_padre.HasValue)
            {
                Calendario_Laboral calBase = ObtenerCalendario(calendario.id_calendario_padre.Value);
                List<Definicion_Calendario_Laboral> definiciones_base = ObtenerDefiniciones(calBase).OrderByDescending(x => x.fecha_hasta).ToList();
                List<Excepcion_Calendario> excepcionesBase = ObtenerExcepciones(calBase);

                fechasIncluidas.AddRange(definiciones_base.Select(x => x.fecha_hasta).ToList());
                fechasIncluidas.AddRange(excepcionesBase.Select(x => x.fecha_fin.Value).ToList());
            }

            fechasIncluidas.Sort((a, b) => b.CompareTo(a));

            TimeSpan hora = fecha_inicio.TimeOfDay;
            double tiempo = 0;

            if (fechasIncluidas.Count > 0)
            {
                for (DateTime i = fecha_inicio; i < fecha_fin; i = i.AddDays(1))
                {
                    var aux = ObtenerHorasLaboralesDia(calendario, i);
                    foreach (var item in aux)
                    {
                        if (fecha_inicio.Date == i.Date)
                        {
                            //Hay que tener en cuenta la hora, sino no
                            if (hora.Ticks > item.Item1.Ticks && hora.Ticks < item.Item2.Ticks)
                            {
                                if (fecha_fin.Date == fecha_inicio.Date)
                                {
                                    if (fecha_fin.TimeOfDay.Ticks < item.Item2.Ticks)
                                    {
                                        tiempo += (fecha_fin.TimeOfDay.Ticks - hora.Ticks) / TimeSpan.TicksPerMinute;
                                        return tiempo;
                                    }
                                    else
                                    {
                                        tiempo += (item.Item2.Ticks - hora.Ticks) / TimeSpan.TicksPerMinute;
                                        return tiempo;
                                    }
                                }
                                else
                                {
                                    tiempo += (item.Item2.Ticks - hora.Ticks) / TimeSpan.TicksPerMinute;
                                }
                                
                            }
                            else if (hora.Ticks <= item.Item1.Ticks)
                            {
                                tiempo += (item.Item2.Ticks - item.Item1.Ticks) / TimeSpan.TicksPerMinute;
                            }
                        }
                        else
                        {
                            tiempo += (item.Item2.Ticks - item.Item1.Ticks) / TimeSpan.TicksPerMinute;
                        }  
                                              
                    }
                }
            }

            return tiempo;
        }

        /// <summary>
        /// Obtiene las horas laborales de ese calendario para la fecha indicada. Ignora los días no
        /// laborables. (Si se trabaja ese dia, entonces va a retornar algo).
        /// TODO: Periodos nulos, o del padre.
        /// </summary>
        /// <param name="calendario"></param>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static List<Tuple<TimeSpan, TimeSpan>> ObtenerHorasLaboralesDia(Calendario_Laboral calendario, DateTime fecha)
        {
            List<Excepcion_Calendario> excepciones = ObtenerExcepcionesTotalesDentroDelRango(calendario, fecha);
            //Este no considera si llama de la base, tenerlo en cuenta para futuro.
            List<Definicion_Calendario_Laboral> definiciones = ObtenerDefinicionesTotalesDentroDelRango(calendario, fecha);

            List<Excepcion_Calendario> excepcionesBase = new List<Excepcion_Calendario>();
            List<Definicion_Calendario_Laboral> definicionesBase = new List<Definicion_Calendario_Laboral>();

            if (!calendario.es_calendario_base && calendario.id_calendario_padre.HasValue)
            {
                excepcionesBase = ObtenerExcepcionesTotalesDentroDelRango(ObtenerCalendario(calendario.id_calendario_padre.Value), fecha);
                definicionesBase = ObtenerDefinicionesTotalesDentroDelRango(ObtenerCalendario(calendario.id_calendario_padre.Value), fecha);
            }

            List<Detalle_Calendario_Laboral> detalles;
            List<Tuple<TimeSpan, TimeSpan>> listaHoras = new List<Tuple<TimeSpan, TimeSpan>>();
            bool laborable = true;

            //Si tiene excepciones, tienen prioridad y se ignoran las deciniciones
            if (excepciones.Count > 0 || excepcionesBase.Count > 0)
            {
                List<Tuple<TimeSpan, TimeSpan>> aux  = ObtenerHorasDeExcepciones(excepciones,fecha, out laborable);
                if (laborable)
                {
                    //El dia no tiene definiciones de que no sea laborable. Si viene vacío, entonces
                    // hay que usar el calendario base, sino tomar los datos de este.
                    if (aux.Count == 0 && !calendario.es_calendario_base
                        && calendario.id_calendario_padre.HasValue)
                    {
                        listaHoras.AddRange(ObtenerHorasDeExcepciones(excepcionesBase, fecha, out laborable));
                    }
                    else
                    {
                        //Si tiene datos, entonces solo se cuenta el del calendario del usuario/proyecto. 
                        listaHoras.AddRange(aux);
                    }
                }
                else return new List<Tuple<TimeSpan, TimeSpan>>();

            }
            
            if (laborable == false)
            {
                //En este caso, habia excepciones del original, pero no para ese dia en particular,
                //sin embargo el calendario base si tiene definicion para ese dia, e indica que no es laboral
                return new List<Tuple<TimeSpan, TimeSpan>>();
            }
            //Sino no tiene excepciones o no hay excepciones para ese dia en particular,
            //se toman las definiciones
            if ((laborable = true && listaHoras.Count == 0 && 
                (excepciones.Count > 0 || excepcionesBase.Count > 0))
                || (excepciones.Count == 0 || excepcionesBase.Count == 0))
                {
                laborable = true;
                List<Tuple<TimeSpan, TimeSpan>> auxDef = ObtenerHorasDeDefiniciones(definiciones, fecha, out laborable);
                if (laborable)
                {
                    //El dia no tiene definiciones de que no sea laborable. Si viene vacío, entonces
                    // hay que usar el calendario base, sino tomar los datos de este.
                    if (auxDef.Count == 0 && !calendario.es_calendario_base
                        && calendario.id_calendario_padre.HasValue)
                    {
                        listaHoras.AddRange(ObtenerHorasDeDefiniciones(definicionesBase, fecha, out laborable));
                    }
                    else
                    {
                        //Si tiene datos, entonces solo se cuenta el del calendario del usuario/proyecto. 
                        listaHoras.AddRange(auxDef);
                    }
                }
                else
                {
                    return new List<Tuple<TimeSpan, TimeSpan>>();
                }
            }

            return listaHoras;
        }


        private static List<Tuple<TimeSpan, TimeSpan>> ObtenerHorasDeExcepciones(List<Excepcion_Calendario> excepciones, DateTime fecha, out bool laborable)
        {
            List<DateTime> listaExcepciones = new List<DateTime>();
            List<Tuple<TimeSpan, TimeSpan>> listaHoras = new List<Tuple<TimeSpan, TimeSpan>>();

            foreach (var exc in excepciones)
            {
                listaExcepciones = CalcularExcepciones(exc);

                if (exc.laborable.HasValue && exc.laborable.Value && listaExcepciones.Contains(fecha.Date))
                {
                    //Verifica que la fecha este dentro de las excepciones
                    if (exc.hora_inicio_1.HasValue && exc.hora_fin_1.HasValue)
                    {
                        listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(exc.hora_inicio_1.Value, exc.hora_fin_1.Value));

                        if (exc.hora_inicio_2.HasValue && exc.hora_fin_2.HasValue)
                        {
                            listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(exc.hora_inicio_2.Value, exc.hora_fin_2.Value));

                            if (exc.hora_inicio_3.HasValue && exc.hora_fin_3.HasValue)
                            {
                                listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(exc.hora_inicio_3.Value, exc.hora_fin_3.Value));

                                if (exc.hora_inicio_4.HasValue && exc.hora_fin_4.HasValue)
                                {
                                    listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(exc.hora_inicio_4.Value, exc.hora_fin_4.Value));

                                    if (exc.hora_inicio_5.HasValue && exc.hora_fin_5.HasValue)
                                    {
                                        listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(exc.hora_inicio_5.Value, exc.hora_fin_5.Value));
                                    }
                                }
                            }
                        }
                    }
                }

                else if (!listaExcepciones.Contains(fecha.Date))
                {
                    //Esa excepcion no define el día indicado, probar con el siguiente.
                }
                else {
                    //Define que NO es laborable, no se deberia trabajar
                    laborable = false;
                    return listaHoras;
                }
            }
            laborable = true;
            return listaHoras;
        }

        private static List<Tuple<TimeSpan, TimeSpan>> ObtenerHorasDeDefiniciones(List<Definicion_Calendario_Laboral> definiciones, DateTime fecha, out bool laborable)
        {
            List<Detalle_Calendario_Laboral> detalles = new List<Detalle_Calendario_Laboral>();
            List<Tuple<TimeSpan, TimeSpan>> listaHoras = new List<Tuple<TimeSpan, TimeSpan>>();

            foreach (var def in definiciones)
            {
                detalles = ObtenerDetallesDia(def, fecha);
                foreach (var det in detalles)
                {
                    //Si el detalle es laborable
                    if (!det.no_laborable.Value && !det.importa_base)
                    {
                        if (det.hora_desde_1.HasValue && det.hora_hasta_1.HasValue)
                        {
                            listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(det.hora_desde_1.Value, det.hora_hasta_1.Value));

                            if (det.hora_desde_2.HasValue && det.hora_hasta_2.HasValue)
                            {
                                listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(det.hora_desde_2.Value, det.hora_hasta_2.Value));

                                if (det.hora_desde_3.HasValue && det.hora_hasta_3.HasValue)
                                {
                                    listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(det.hora_desde_3.Value, det.hora_hasta_3.Value));

                                    if (det.hora_desde_4.HasValue && det.hora_hasta_4.HasValue)
                                    {
                                        listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(det.hora_desde_4.Value, det.hora_hasta_4.Value));

                                        if (det.hora_desde_5.HasValue && det.hora_hasta_5.HasValue)
                                        {
                                            listaHoras.Add(new Tuple<TimeSpan, TimeSpan>(det.hora_desde_5.Value, det.hora_hasta_5.Value));
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (det.no_laborable.HasValue && det.no_laborable.Value)
                    {
                        //No es laborable
                        laborable = false;
                        return new List<Tuple<TimeSpan, TimeSpan>>();

                    }
                    else //Importa de base
                    {
                        laborable = true;
                        return new List<Tuple<TimeSpan, TimeSpan>>();
                    }
                }
            }
            laborable = true;
            return listaHoras;
        }

        private static List<Excepcion_Calendario> ObtenerExcepcionesTotales(Calendario_Laboral calendario)
        {
            return CalendarioDB.ObtenerExcepcionesTotales(calendario);
        }

        private static List<Definicion_Calendario_Laboral> ObtenerDefinicionesTotales(Calendario_Laboral calendario)
        {
            return CalendarioDB.ObtenerDefinicionesTotales(calendario);
        }

        private static List<Excepcion_Calendario> ObtenerExcepcionesTotalesDentroDelRango(Calendario_Laboral calendario, DateTime fecha)
        {
            return CalendarioDB.ObtenerExcepcionesTotales(calendario).Where(x => x.fecha_comienzo.Value.Date <= fecha.Date && x.fecha_fin.Value.Date >= fecha.Date).ToList();
        }

        /// <summary>
        /// INCOMPLETO. VERIFICAR LABORAL Y COMPLETAR SWITCH
        /// Devuelve una lista de los días que corre la excepcion
        /// </summary>
        /// <param name="exc"></param>
        /// <returns></returns>
        private static List<DateTime> CalcularExcepciones(Excepcion_Calendario exc)
        {
            List<DateTime> fechasExcepcion = new List<DateTime>();
            DateTime fecha_actual = exc.fecha_comienzo.Value;

            switch (exc.freq_type)
            {
                //Única vez, se usa en las fechas indicadas
                case 1:
                    fechasExcepcion.Add(fecha_actual);
                    return fechasExcepcion;
                    break;

                //Diario
                case 4:
                    //Se usa cada freq_interval dias                    
                    do
                    {
                        fechasExcepcion.Add(fecha_actual);
                        fecha_actual = fecha_actual.AddDays((double)exc.freq_interval == 0 ? 1 : (double)exc.freq_interval);
                    } while (fecha_actual <= exc.fecha_fin.Value);
                    break;

                //Semanal
                case 8:
                    // 1: Domingo, 2: Lunes, 4: Martes, 8: Miercoles, 
                    // 16: Jueves, 32: Viernes, 64: Sábado
                    do
                    {
                        char[] dias = Convert.ToString(exc.freq_interval.Value, 2).PadLeft(7, '0').ToCharArray().Reverse().ToArray();
                        if (dias[(int)fecha_actual.DayOfWeek] == '1')
                        {
                            fechasExcepcion.Add(fecha_actual);
                        }
                        fecha_actual = fecha_actual.AddDays(1);

                    } while (fecha_actual <= exc.fecha_fin.Value);
                    break;

                //Mensual
                case 16:
                    // El dia freq_interval del mes
                    do{
                        if ((int)fecha_actual.Day == exc.freq_interval)
                        {
                            fechasExcepcion.Add(fecha_actual);
                            fecha_actual = fecha_actual.AddMonths(1);
                        }
                        else
                            fecha_actual = fecha_actual.AddDays(1);

                    } while (fecha_actual <= exc.fecha_fin.Value) ;
                    break;

                //Mensual relativo
                case 32:
                    //TODOOO
                    break;

                //Anual
                case 64:
                    //La fecha en formato ddMM
                    String aux = exc.freq_interval.ToString().PadLeft(4, '0').Insert(2,"/") + "/" + exc.fecha_comienzo.Value.Year;
                    DateTime fecha_aux = DateTime.Parse(aux, CultureInfo.CreateSpecificCulture("es-ES"));
                    if (fecha_aux < exc.fecha_comienzo)
                        fecha_aux = fecha_aux.AddYears(1);
                    while (fecha_aux >= exc.fecha_comienzo & fecha_aux <= exc.fecha_fin)
                    {
                        fechasExcepcion.Add(fecha_aux);
                        fecha_aux = fecha_aux.AddYears(1);
                    } 
                    break;
            }

            return fechasExcepcion;
        }

        public static List<Definicion_Calendario_Laboral> ObtenerDefinicionesTotalesDentroDelRango(Calendario_Laboral calendario, DateTime fecha)
        {
            return CalendarioDB.ObtenerDefinicionesTotales(calendario).Where(x => x.fecha_desde.Date <= fecha.Date && x.fecha_hasta.Date >= fecha.Date).ToList();
        }


        

        /// <summary>
        /// Cuidado con esto!!.. Va a verificar que todos los proyectos y usuarios tengan asignados el calendario
        /// Descar, y para los usuarios, crea un calendario propio.
        /// </summary>
        public static void ActualizarCalendariosUsuariosYProyectos()
        {
            List<USUARIO> usuarios = ControladorUsuarios.ObtenerTodosUsuarios();
            foreach (var item in usuarios)
            {
                if (item.id_calendario_laboral == 1 || item.id_calendario_laboral == null)
                {
                    Calendario_Laboral calendario = new Calendario_Laboral()
                    {
                        es_calendario_base = false,
                        id_calendario_padre = 1,
                        nombre_calendario = item.FullName
                    };
                    calendario = ControladorCalendario.Insertar(calendario);
                    item.id_calendario_laboral = calendario.id_calendario_laboral;
                    ControladorUsuarios.Actualizar(item);
                }
                
            }


            List<Proyecto> proyectos = ControladorProyecto.ObtenerProyectos();
            foreach (var item in proyectos)
            {
                if (item.id_calendario_laboral_base == null)
                {
                    item.id_calendario_laboral_base = 1;
                    ControladorProyecto.Update(item);         
                }
            }
        }
    }
}
