using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace ControladoresLogica
{
    public static class ControladorTareas
    {
        /// <summary>
        /// Inserta un objeto Detalle Recurso en la base da datos
        /// </summary>
        /// <param name="tarea"></param>
        /// <returns></returns>
        public static Detalle_recurso Insertar(Detalle_recurso tarea)
        {
            return TareaDB.Insertar(tarea);
        }

        /// <summary>
        /// Verifica que se le haya asignado una tarea a esa actividad para el usuario indicado
        /// </summary>
        /// <param name="idActividadProyecto"></param>
        /// <param name="idUsuario"></param>
        /// <returns>True si encuentra, False si no</returns>
        public static bool ExistFromActividad(int idActividadProyecto, int idUsuario)
        {
            return TareaDB.Existe(idActividadProyecto, idUsuario);
        }

        /// <summary>
        /// Obtiene el objeto Detalle Recurso con ese ID
        /// </summary>
        /// <param name="idDetalleRecurso"></param>
        /// <returns></returns>
        public static Detalle_recurso ObtenerPorID(int idDetalleRecurso)
        {
            return TareaDB.ObtenerPorID(idDetalleRecurso);
        }

        /// <summary>
        /// Agrega una tarea en la base de datos para el usuario seleccionado.
        /// Se asigna con estado Pendiente.
        /// Si el usuaro ya tiene ese
        /// </summary>
        /// <param name="idActividadProyectoSolicitar"></param>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public static Detalle_recurso RequerirTarea(int idActividadProyectoSolicitar, int idUsuario)
        {
            Detalle_recurso tarea = new Detalle_recurso();
            tarea.id_actividad_proyecto = idActividadProyectoSolicitar;
            tarea.forzada = false;
            tarea.id_usuario = idUsuario;
            tarea.motivo = "solicitud";
            tarea.tipo = "";
            tarea.porcentaje_avance = 0;
            tarea.realizada = false;
            tarea.cantidad_hora = Convert.ToDecimal(ControladorActividades.ObtenerHorasTotalesActividad(ControladorActividades.ObtenerActividadProyecto(idActividadProyectoSolicitar)));
            tarea.id_estado = ObtenerEstadoPorNombre("Pendiente").IdEstadoTarea;
            tarea.fecha_inicio = DateTime.Now;
            tarea.fecha_fin = ControladorCalendario.CalcularFechaFin(ControladorActividades.ObtenerActividadProyecto(idActividadProyectoSolicitar), ControladorUsuarios.ObtenerUsuario(idUsuario), tarea.fecha_inicio.Value, ControladorActividades.ObtenerHorasTotalesActividad(ControladorActividades.ObtenerActividadProyecto(idActividadProyectoSolicitar)));
            tarea.duracion_cadista = (decimal)ControladorActividades.ObtenerHorasOrdenCompraParaCadista(ControladorActividades.ObtenerActividadProyecto(idActividadProyectoSolicitar));
            tarea.fecha_inicio_cadista = tarea.fecha_inicio;
            tarea.fecha_fin_cadista = tarea.fecha_fin;


            if (ControladorTareas.EstaAsignadaAUsuario(idActividadProyectoSolicitar, idUsuario) == null)
            {
                return Insertar(tarea);
            }
            return null;
            

        }

        public static Detalle_recurso ObtenerPorActividad(Actividad_proyecto actividad)
        {
            return TareaDB.ObtenerPorActividad(actividad);
        }

        public static DateTime CalcularFechaInicioProyecto(Proyecto item)
        {
            List<SUBPROYECTO> subproyectos = ControladorProyecto.ObtenerSubproyectosHijos(item);
            List<DateTime?> fechas = new List<DateTime?>();
            foreach (var subpro in subproyectos)
            {
                fechas.Add(CalcularFechaInicioSubproyecto(subpro));
            }

            fechas.Sort((a, b) => b.Value.CompareTo(a.Value));
            return fechas.Count > 0 ? fechas.ElementAt(fechas.Count - 1).Value : item.fecha_inicio.Value;
        }

        public static DateTime CalcularFechaFinProyecto(Proyecto item)
        {
            List<SUBPROYECTO> subproyectos = ControladorProyecto.ObtenerSubproyectosHijos(item);
            List<DateTime?> fechas = new List<DateTime?>();
            foreach (var subpro in subproyectos)
            {
                fechas.Add(CalcularFechaFinSubproyecto(subpro));
            }

            fechas.Sort((a, b) => a.Value.CompareTo(b.Value));
            return fechas.Count > 0 ? fechas.ElementAt(fechas.Count - 1).Value : item.fecha_fin_prevista.Value;
        }

        public static Detalle_recurso EstaAsignadaAUsuario(int idActividadProyectoSolicitar, int idUsuario)
        {
            return TareaDB.EstaAsignadaAUsuario(idActividadProyectoSolicitar, idUsuario);
        }

        public static Programacion_Actividad InsertarOActualizarProgramacion(Programacion_Actividad progr)
        {
            if (ExisteProgramacion(progr) == null)
                return TareaDB.InsertarProgramacion(progr);
            else
                return TareaDB.UpdateProgramacion(progr);
        }

        public static Programacion_Actividad ExisteProgramacion(Programacion_Actividad progr)
        {
            return TareaDB.ExisteProgramacion(progr);
        }

        public static DateTime? CalcularFechaInicioSubproyecto(SUBPROYECTO subproyecto)
        {
            List<ClaseExpGantt> exp = new List<ClaseExpGantt>();
            ControladorSubproyecto.ObtenerEstructuraSubproyectosConActividades(exp, subproyecto, 1);
            List<DateTime?> fecha = new List<DateTime?>();
            foreach (var item in exp)
            {
                if (item.actividad != null)
                {
                    Detalle_recurso tarea = ObtenerPorActividad(item.actividadProy);
                    if (tarea != null && tarea.fecha_inicio.HasValue) fecha.Add(tarea.fecha_inicio.Value);
                }
            }

            fecha.Sort((a, b) => b.Value.CompareTo(a.Value));
            return fecha.Count > 0 ? fecha.ElementAt(fecha.Count - 1) : subproyecto.fecha_inicio_estimada.Value;
        }


        /// <summary>
        /// Verifica si la actividad tiene asignación automática, y si no tiene
        /// se lo asigna a todos sus miebros.
        /// </summary>
        /// <param name="act"></param>
        /// <returns></returns>
        public static bool VerificarAsignacionAutomatica(Actividad_proyecto act)
        {
            var subproyecto = ControladorSubproyecto.BuscarPorId(act.id_subproyecto.Value);

            if (subproyecto.asignacion_automatica)
            {
                Usuario_Proyecto _Usuario_proyecto = new Usuario_Proyecto();
                List<USUARIO> odt_miembros_subproyectos = ControladorSubproyecto.ObtenerMiembrosIndirectos(subproyecto);

                foreach (USUARIO row in odt_miembros_subproyectos)
                {
                    var detalle = new Detalle_recurso()
                    {
                        realizada = false,
                        tipo = "automatico",
                        porcentaje_avance = 0,
                        id_actividad_proyecto = act.id_actividad_proyecto,
                        motivo = "- Asignada automáticamente - ",
                        cantidad_hora = Convert.ToDecimal(ControladorActividades.ObtenerHorasPorOrdenCompra(act)),
                        id_usuario = Convert.ToInt32(row.id_usuario),
                        fecha_inicio = null,
                        fecha_fin = null
                    };

                    ControladorTareas.Insertar(detalle);
                }
                return true;
            }
            return false;
        }

        public static Detalle_recurso Actualizar(Detalle_recurso detalle_recurso)
        {
            return TareaDB.Actualizar(detalle_recurso);
        }

        public static DateTime? CalcularFechaFinSubproyecto(SUBPROYECTO subproyecto)
        {
            List<ClaseExpGantt> exp = new List<ClaseExpGantt>();
            ControladorSubproyecto.ObtenerEstructuraSubproyectosConActividades(exp, subproyecto, 1);
            List<DateTime?> fecha = new List<DateTime?>();
            foreach (var item in exp)
            {
                if (item.actividad != null) {
                    Detalle_recurso tarea = ObtenerPorActividad(item.actividadProy);
                    if (tarea != null && tarea.fecha_fin.HasValue) fecha.Add(tarea.fecha_fin.Value);
                }
            }

            fecha.Sort((a, b) => a.Value.CompareTo(b.Value));
            return fecha.Count > 0 ? fecha.ElementAt(fecha.Count - 1) : subproyecto.fecha_inicio_estimada.Value;
        }

        public static Programacion_Actividad ObtenerProgramacion(Actividad_proyecto activ_proy)
        {
            return TareaDB.ObtenerProgramacion(activ_proy);
        }

        public static List<Detalle_recurso> ObtenerSolicitudes(int id_usuario_piloto)
        {
            return TareaDB.ObtenerSolicitudes(id_usuario_piloto);
        }

        public static List<DatosTarea> ObtenerTareasPendientes(int idUsuario)
        {
            List<DatosTarea> tareas = TareaDB.ObtenerTareasPendientesDeUsuario(idUsuario);
            //List<Detalle_recurso> tareasPendientes = new List<Detalle_recurso>();
            //foreach (var item in tareas)
            //{
            //    if (MostrarTareaPendiente(item)) tareasPendientes.Add(item);
            //}
            return tareas;
        }
        public static List<Detalle_recurso> ObtenerTareasPorUsuario(int idUsuario)
        {
            return TareaDB.ObtenerTareasPorUsuario(idUsuario);
        }

        public static void ResolverSolicitud(Detalle_recurso detalle_recurso, bool decision,USUARIO responsable )
        { 
            TareaDB.ResolverSolicitud(detalle_recurso, decision, responsable);
        }

        /// <summary>
        /// Obtiene el objeto Estado para una tarea con el nombre indicado
        /// </summary>
        /// <param name="nombreEstado">El nombre del estado a buscar</param>
        /// <returns></returns>
        public static EstadoTarea ObtenerEstadoPorNombre(string nombreEstado)
        {
            return TareaDB.ObtenerEstadoPorNombre(nombreEstado);
        }


        /// <summary>
        /// Asigna la actividad al usuario - VER TEMA DE FECHAS
        /// </summary>
        /// <param name="actividad"></param>
        /// <param name="usuario"></param>
        public static Detalle_recurso AsignarActividad(Actividad_proyecto actividad, USUARIO usuario, DateTime fecha_inicio, DateTime fecha_fin)
        {           

            Detalle_recurso tarea = new Detalle_recurso();
            tarea.cantidad_hora = (decimal)(ControladorActividades.ObtenerHorasTotalesActividad(actividad)); 
            tarea.fecha_fin = fecha_fin;
            tarea.fecha_inicio = fecha_inicio;
            tarea.forzada = false;
            tarea.id_actividad_proyecto = actividad.id_actividad_proyecto;
            tarea.id_estado = ObtenerEstadoPorNombre("Asignado") != null ? ObtenerEstadoPorNombre("Asignado").IdEstadoTarea : 0;
            tarea.id_usuario = usuario.id_usuario;
            tarea.motivo = "asignada por algoritmo";
            tarea.porcentaje_avance = 0;
            tarea.realizada = false;
            tarea.tipo = "asignada por algoritmo";
            tarea.fecha_inicio_cadista = fecha_inicio;
            tarea.fecha_fin_cadista = fecha_fin;
            tarea.duracion_cadista = (decimal)(ControladorActividades.ObtenerHorasOrdenCompraParaCadista(actividad)) ;

            return TareaDB.AsignarActividad(tarea);
        }


        public static bool TieneLogueoPermitido(Detalle_recurso dr)
        {
            Actividad_proyecto ap = ActividadProyectoDB.ObtenerActividadProyecto(dr.id_actividad_proyecto.Value);
            SUBPROYECTO subproyecto = ControladorSubproyecto.BuscarPorId(ap.id_subproyecto.Value);
            Proyecto p = ControladorProyecto.ObtenerPorID(ap.id_proyecto.Value);
            Tipo_actividad ta = ControladorActividades.ObtenerTipoActividad(ap);
            Movimiento_voz mv = ControladorActividades.ObtenerMovimientoVoz(ap);

            bool decision = false;
            int orden = (int)ap.orden;            

            if (dr.realizada.Value) return false;
            if (dr.forzada && !dr.realizada.Value) decision = true;
            if (ap.no_conformidad) return false;
            if (p.activo.HasValue && !p.activo.Value) return false;

            if (orden == 1) decision = true;

            var anterior = ControladorActividades.ObtenerActividadAnterior(ap);
            if (anterior == null) return true;

            if (ControladorActividades.TieneControl_prod_1_Completado(anterior)) decision = true;

            else decision = false;

            ///////// TODO - CAMBIAR A POR ORDEN
            //if (ta.descripcion.ToLower().Contains("conce"))
            //{
            //    if(mv == null || !mv.control_prod.Value)
            //    {
            //        decision = true;
            //    }
            //}
            //else if (ta.descripcion.ToLower().Contains("prep"))
            //{
            //    Tipo_actividad tipo_act_concepto = ControladorActividades.ObtenerTipoActividad("concepto");
            //    Actividad_proyecto concepto = ControladorSubproyecto.ObtenerActividaHijaDeTipo(subproyecto, tipo_act_concepto);
            //    if (ControladorActividades.TieneControl_prod_1_Completado(concepto) && !ControladorActividades.TieneControl_prod_1_Completado(ap))
            //    {
            //        decision = true;
            //    }                
            //}
            //else if (ta.descripcion.ToLower().Contains("deta"))
            //{
            //    Tipo_actividad tipo_act_concepto = ControladorActividades.ObtenerTipoActividad("concepto");
            //    Tipo_actividad tipo_act_preparacion = ControladorActividades.ObtenerTipoActividad("preparac");

            //    Actividad_proyecto concepto = ControladorSubproyecto.ObtenerActividaHijaDeTipo(subproyecto, tipo_act_concepto);
            //    Actividad_proyecto preparacion = ControladorSubproyecto.ObtenerActividaHijaDeTipo(subproyecto, tipo_act_preparacion);
            //    if (ControladorActividades.TieneControl_prod_1_Completado(concepto) && ControladorActividades.TieneControl_prod_1_Completado(preparacion) && !ControladorActividades.TieneControl_prod_1_Completado(ap))
            //    {
            //        decision = true;
            //    }
            //}
            //else
            //{
            //    decision = true;
            //}

            ////////////// END TODO

            if (decision)
            {
                if (dr.id_estado.HasValue)
                {
                    if (dr.id_estado <= 2)
                        return true;
                    return false;
                }
                else { return decision; }

            }
            return false;
        }

        public static void EliminarDetalleRecursoActividad(Actividad_proyecto item)
        {
            TareaDB.EliminarDetalleRecursoActividad(item);
        }

        public static bool AsignarSubproyecto(SUBPROYECTO subproyecto, double cantidad_horas_solapamiento)
        {
            bool salida = true;
            if (subproyecto != null && subproyecto.asignacion_automatica)
            {
                ControladorActividades.ActualizarOrdenActividades(subproyecto);

                List<Actividad_proyecto> actividades = ControladorActividades.ObtenerActividadesProyectoDeSubproyecto(subproyecto).OrderBy(x => x.orden).ToList();
                Proyecto proyecto = ControladorProyecto.ObtenerPorID(subproyecto.id_proyecto.Value);

                if (!proyecto.activo.Value) return false;

                foreach (var actividad in actividades)
                {
                    if (!ControladorActividades.EstaCompletada(actividad) && ObtenerPorActividad(actividad) == null)
                    {
                        if (!AsignarActividadProyecto(actividad, cantidad_horas_solapamiento))
                        {
                            //La actividad no pudo ser asignada
                            salida = false;
                        }
                            
                    }

                    else if (ObtenerPorActividad(actividad) != null)
                    {
                        //TODO si la actividad ya esta logueada, verificar el tema de las horas, calcular hora fin, etc

                    }
                }                
                return salida;
            }
            return salida;
            /*
            Consideraciones:
            - El subproyecto tiene que tener los miembros asignados, o el proyecto.
            - El proyecto tiene que estar activo
            - Las actividades no tienen que estar completadas (recordar que pasa con el primer control) 
            - Las actividades no tienen que tener una tarea asignada, ya que los correspondtientes fueron borrados, sino
            hay que respetar la tarea a ese usuario o esta forzada.
            - Solo los usuarios miembros para esa actividad pueden realizarla
            - Primero las actividades mas largas
            - Ordenar la lista de usuarios por el que tiene menos calificaciones primero.
            - Tener en cuenta que a futuro se agregan prioridades.
            
                Como ordenar por fecha?. SI erdeno la lista por usuarios, pero otro que está mas alto en la lista 
                puede empezarlo antes.           
            */
        }

        private static void EliminarDetalleRecursoSubproyecto(SUBPROYECTO subproyecto)
        {
            TareaDB.EliminarDetalleRecursoSubproyecto(subproyecto);
        }

        /// <summary>
        /// Borra las tareas de un proyecto en el las horas logueadas por el usuario
        /// es 0, o no fueron logueadas por ese usuario
        /// </summary>
        /// <param name="proyecto"></param>
        private static void EliminarDetalleRecursoProyecto(Proyecto proyecto)
        {
            TareaDB.EliminarDetalleRecursoProyectoNoLogueados(proyecto);
        }


        public static void AsignarProyecto(int id_proyecto)
        {
            Proyecto proyecto = ControladorProyecto.ObtenerPorID(id_proyecto);
            List<SUBPROYECTO> lista = ControladorProyecto.ObtenerSubproyectosHijos(proyecto);

            EliminarDetalleRecursoProyecto(proyecto);

            foreach (var item in lista)
            {
                List<Tuple<SUBPROYECTO, int>> estrucuraProyecto = new List<Tuple<SUBPROYECTO, int>>();
                List<SUBPROYECTO> listaSubproyectos = ControladorSubproyecto.ObtenerEstructuraSubproyectos(estrucuraProyecto, item, 1).OrderByDescending(x => x.Item2).Select(x => x.Item1).ToList();
                listaSubproyectos.OrderByDescending(x => x.horas_estimadas).ToList();

                foreach (var sub in listaSubproyectos)
                {
                    AsignarSubproyecto(sub, 0);
                }
            }

        }

        /// <summary>
        /// Completar
        /// </summary>
        /// <param name="actividad"></param>
        /// <returns></returns>
        public static bool AsignarActividadProyecto(Actividad_proyecto actividad, double cantidad_horas_solapamiento)
        {
            List<Tuple<USUARIO,decimal>> miembros_habilitados = ControladorSubproyecto.ObtenerMiemrosHabilitadosParaAsignar(actividad);

            DateTime fecha_inicio;
            DateTime fecha_fin;
            double tiempo_trabajado, tiempo_total;

            tiempo_total = ControladorActividades.ObtenerHorasTotalesActividad(actividad);
            tiempo_trabajado = 0;//ControladorActividades.ObtenerHorasConsumidas(actividad);
            //Modificar este metodo para que verifique fecha inicio mayor a la actual.
            fecha_inicio = ControladorActividades.ObtenerFechaInicioMinima(actividad);
            //Devuelve la fecha fin ideal
            fecha_fin = ControladorCalendario.ObtenerFechaFinMinima(actividad, fecha_inicio).Value;

            List<Tuple<Tuple<USUARIO, decimal>, Tuple<DateTime, DateTime>>> listaPorFechaFin;
            List<Tuple<Tuple<USUARIO, decimal>, Tuple<DateTime, DateTime>>> listaPorCalifi;

            List<Tuple<Tuple<USUARIO,decimal>, Tuple<DateTime, DateTime>>> listaOrdenada = new List<Tuple<Tuple<USUARIO,decimal>, Tuple<DateTime, DateTime>>>();
            if (!ControladorActividades.EstaCompletada(actividad))
            {
                foreach (var miem in miembros_habilitados)
                {
                    DateTime fecha = ObtenerFechaInicioMinimaUsuario(miem.Item1, fecha_inicio, tiempo_total - tiempo_trabajado, actividad, fecha_fin);
                    DateTime? fecha_fin_usuario = ControladorCalendario.CalcularFechaFin(actividad, miem.Item1, fecha, null);

                    listaOrdenada.Add(new Tuple<Tuple<USUARIO,decimal>, Tuple<DateTime,DateTime>>(miem, new Tuple<DateTime,DateTime>(fecha, fecha_fin_usuario.Value)));
                }

                if (listaOrdenada.Count > 0)
                {
                    //Ordena la lista primero por fecha de fin, luego por calificaciones, el que tiene mas primero.
                    listaOrdenada = listaOrdenada.OrderBy(x => x.Item2.Item2).ThenByDescending(x => x.Item1.Item2).ToList();
                    listaPorFechaFin = listaOrdenada.OrderBy(x => x.Item2.Item2).ToList();
                    listaPorCalifi = listaOrdenada.OrderByDescending(x => x.Item1.Item2).ToList();

                    if (listaOrdenada.ElementAt(0).Item2.Item2.Subtract(listaPorCalifi.ElementAt(0).Item2.Item2).TotalHours <= cantidad_horas_solapamiento)
                    {
                        AsignarActividad(actividad, listaPorCalifi.ElementAt(0).Item1.Item1, listaPorCalifi.ElementAt(0).Item2.Item1, listaPorCalifi.ElementAt(0).Item2.Item2);
                    }
                    else
                    {
                        AsignarActividad(actividad, listaOrdenada.ElementAt(0).Item1.Item1, listaOrdenada.ElementAt(0).Item2.Item1, listaOrdenada.ElementAt(0).Item2.Item2);
                    }

                    
                    return true;
                }
                return false;                
            }
            return false;
        }

        public static DateTime ObtenerFechaInicioMinimaUsuario (USUARIO usuario, DateTime fecha, double tiempo, Actividad_proyecto actividad, DateTime fecha_fin)
        {
            //Obtener una lista de los miembros, y ver todas las asignaciones que tiene,
            //buscar los detalles con fechas de inicio mayor a la fecha de parametro
            //y hacer una simulación para ver donde ese usuario tendría a esa tarea
            //Para cada miembro hacer lo mismo, y dársela al que inicia lo mas temprano posible
            List<Detalle_recurso> listaTareasUsuario = ObtenerTareasPorUsuario(usuario.id_usuario).Where(x => x.fecha_fin >= fecha).OrderBy(x => x.fecha_inicio).ToList();

            List<Detalle_recurso> listaFinal = new List<Detalle_recurso>();
            //listaFinal.AddRange(tareasArrancaAntesYTerminaDespues);
            listaFinal.AddRange(listaTareasUsuario);
            //listaFinal.AddRange(tareasArrancaAntesyTerminaEnMedio);
            listaFinal = listaFinal.OrderBy(x => x.fecha_fin.Value).ToList();

            //Para calcular la fecha inicio
            List<Detalle_recurso> listaFechaInicio = listaFinal.OrderBy(x => x.fecha_inicio.Value).ToList();

            double horas_disponibles = 0;

            if (listaFinal.Count > 0)
            {
                //Puede ser que la primer fecha asignada al usuario sea mas tarde,
                //permitiendo que entre la fecha de parametro y la primera fecha asignada pueda asignarse una
                // tarea
                if (listaFechaInicio.ElementAt(0).fecha_inicio > fecha)
                {
                    horas_disponibles = ControladorCalendario.CalcularTiempoEntreFechas(ControladorCalendario.ObtenerCalendario(usuario.id_calendario_laboral.Value), listaFechaInicio.ElementAt(0).fecha_inicio.Value, fecha) / 60;
                    if (horas_disponibles  >= tiempo)
                    {
                        return fecha;
                    }
                }                

                listaFinal = listaFinal.OrderBy(x => x.fecha_fin.Value).ToList();
                for (int i = 1; i < listaFinal.Count; i++)
                {                  
                    horas_disponibles = ControladorCalendario.CalcularTiempoEntreFechas(ControladorCalendario.ObtenerCalendario(usuario.id_calendario_laboral.Value), listaFinal.ElementAt(i - 1).fecha_fin.Value, listaFinal.ElementAt(i).fecha_inicio.Value) / 60;
                    if (horas_disponibles  >= tiempo)
                    {
                        return listaFinal.ElementAt(i - 1).fecha_fin.Value;
                    }
                }

                return listaFinal.ElementAt(listaFinal.Count - 1).fecha_fin.Value;
            }


            return fecha;
        }

        public static bool AsignarTareasAutomaticamente(double cant_horas_solapamiento)
        {
            List<SUBPROYECTO> subproyectosOrdenados = ControladorSubproyecto.ObtenerSubproyectosConActividadesActivos();
            EliminarDetalleRecursoProyectosActivos();
            bool salida = true;

            foreach (var item in subproyectosOrdenados)
            {
                List<Tuple<SUBPROYECTO, int>> estrucuraProyecto = new List<Tuple<SUBPROYECTO, int>>();
                List<SUBPROYECTO> listaSubproyectos = ControladorSubproyecto.ObtenerEstructuraSubproyectos(estrucuraProyecto, item, 1).OrderByDescending(x => x.Item2).Select(x => x.Item1).ToList();
                listaSubproyectos = listaSubproyectos.OrderByDescending(x => x.horas_estimadas).ToList();

                foreach (var sub in listaSubproyectos)
                {
                    if (!AsignarSubproyecto(sub, cant_horas_solapamiento))
                    {
                        salida = false;
                    }
                }
                
            }

            ControladorProyecto.ActualizarHorasProyectosActivos();
            return salida;
        }

        /// <summary>
        /// Borra las tareas de los proyectos activos en el las horas logueadas por el usuario
        /// es 0, o no fueron logueadas por ese usuario
        /// </summary>
        /// <param name="proyecto"></param>
        private static void EliminarDetalleRecursoProyectosActivos()
        {
            TareaDB.EliminarDetalleRecursoProyectosActivos();
        }

        public static decimal ObtenerHorasConsumidas(Detalle_recurso tarea)
        {
            return TareaDB.ObtenerHorasConsumidas(tarea);
        }
    }
}
