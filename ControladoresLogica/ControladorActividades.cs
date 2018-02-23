using System.Runtime.InteropServices;
using Entidades;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControladoresLogica
{
    public static class ControladorActividades
    {
        public static Actividad_proyecto InsertarActividadProyecto(Actividad_proyecto actividadSubproyecto)
        {
            var act = new Actividad_proyecto
            {
                asignable = actividadSubproyecto.asignable,
                asignada = actividadSubproyecto.asignada,
                avance = actividadSubproyecto.avance,
                cantidad_hora = actividadSubproyecto.cantidad_hora,
                complejidad = actividadSubproyecto.complejidad,
                fecha_fin_previsto = actividadSubproyecto.fecha_fin_previsto,
                fecha_fin_real = actividadSubproyecto.fecha_fin_real,
                fecha_inicio = actividadSubproyecto.fecha_inicio,
                fecha_inicio_real = actividadSubproyecto.fecha_inicio_real,
                forzada_fecha_fin = actividadSubproyecto.forzada_fecha_fin,
                forzada_fecha_inicio = actividadSubproyecto.forzada_fecha_inicio,
                horas = actividadSubproyecto.horas,
                id_actividad = actividadSubproyecto.id_actividad,
                id_cadista = actividadSubproyecto.id_cadista,
                id_cliente = actividadSubproyecto.id_cliente,
                id_control = actividadSubproyecto.id_control,
                id_controlador_1 = actividadSubproyecto.id_controlador_1,
                id_controlador_2 = actividadSubproyecto.id_controlador_2,
                id_estado_proyecto = actividadSubproyecto.id_estado_proyecto,
                id_prioridad = actividadSubproyecto.id_prioridad,
                id_proveedor = actividadSubproyecto.id_proveedor,
                id_proyecto = actividadSubproyecto.id_proyecto,
                id_subproyecto = actividadSubproyecto.id_subproyecto,
                motivo_no_conformidad = actividadSubproyecto.motivo_no_conformidad,
                no_conformidad = actividadSubproyecto.no_conformidad,
                nro = actividadSubproyecto.nro,
                objetivo = actividadSubproyecto.objetivo,
                observacion = actividadSubproyecto.observacion,
                orden = actividadSubproyecto.orden,
                porcentaje_avance = actividadSubproyecto.porcentaje_avance,
                prioridad = actividadSubproyecto.prioridad
            };

            act = ActividadProyectoDB.Insertar(act);
            return ActualizarHorasAsignadas(act);
            
        }

        public static List<Tipo_Actividad_usuario> ObtenerTiposActividadUsuario(USUARIO usuario)
        {
            return ActividadProyectoDB.ObtenerTiposActividadUsuario(usuario);
        }


        public static List<Tipo_Actividad_usuario> ObtenerTiposActividadUsuario(Tipo_actividad tipo_actividad)
        {
            return ActividadProyectoDB.ObtenerTiposActividadUsuario(tipo_actividad);
        }

        public static Actividad InsertarActividad(Entidades.Actividad actividad)
        {
            var act = new Actividad
            {
                costo_standart = actividad.costo_standart,
                id_tipo_actividad = actividad.id_tipo_actividad,
                nombre_actividad = actividad.nombre_actividad,
                tiempo_standart = actividad.tiempo_standart
            };

            return ActividadProyectoDB.Insertar(act);
        }

        public static Actividad ActualizarActividad(int idActividad, decimal? costoStandart, int? idTipoActividad, string nombreActividad, decimal? tiempoStandart )
        {
            var aux = new Actividad
            {
                id_actividad = idActividad,
                costo_standart = costoStandart,
                id_tipo_actividad = idTipoActividad,
                nombre_actividad =  nombreActividad,
                tiempo_standart = tiempoStandart
            };
            return ActividadProyectoDB.ActualizarActividad(aux);
        }

        public static Actividad ActualizarActividad(Actividad actividad)
        {
            return ActividadProyectoDB.ActualizarActividad(actividad);
        }

        public static Actividad_proyecto ActualizarActividadProyecto(Actividad_proyecto actividadProyecto)
        {
            return ActividadProyectoDB.ActualizarActividad_Proyecto(actividadProyecto);
        }

        public static Tipo_actividad ObtenerTipoActividad(int idTipoActividad)
        {
            return ActividadProyectoDB.ObtenerTipoActividad(idTipoActividad);
        }

        public static List<Tipo_actividad> ObtenerTiposActividad()
        {
            return ActividadProyectoDB.ObtenerTiposActividad();
        }

        public static List<Tipo_actividad> ObtenerTiposActividad(string filtro_nombre)
        {
            return ActividadProyectoDB.ObtenerTiposActividad(filtro_nombre);
        }

        public static Tipo_actividad ObtenerTipoActividad(string nombreActividad)
        {
            return ActividadProyectoDB.ObtenerTipoActividad(nombreActividad);
        }

        public static Tipo_actividad ActualizarTipoActividad(Tipo_actividad tipoActividad)
        {
            return ActividadProyectoDB.ActualizarTipoActividad(tipoActividad);
        }

        public static List<Actividad> ObtenerActividadesDeSubproyecto(SUBPROYECTO subpro)
        {
            return ActividadProyectoDB.ObtenerActividadesDeSubproyecto(subpro);
        }

        public static List<Actividad_proyecto> ObtenerActividadesProyectoDeSubproyecto(SUBPROYECTO subpro)
        {
            return ActividadProyectoDB.ObtenerActividadesProyectoDeSubproyecto(subpro);
        }

        public static Actividad_proyecto ObtenerActividadProyecto(int idActividadProyecto)
        {
            return ActividadProyectoDB.ObtenerActividadProyecto(idActividadProyecto);
        }

        public static Actividad ObtenerActividad(Actividad_proyecto act_pro)
        {
            return ActividadProyectoDB.ObtenerActividad(act_pro);
        }

        public static double ObtenerHorasAsignadas(Actividad_proyecto act_pto)
        {
            return ActividadProyectoDB.ObtenerHorasAsignadas(act_pto);
        }

        public static double ObtenerHorasPorOrdenCompra(Actividad_proyecto act_pto)
        {
            
            return ActividadProyectoDB.ObtenerHorasPorOrdenCompra(act_pto);
        }

        public static double ObtenerHorasAsignadasPorOrdenCompra(Actividad_proyecto act_pto)
        {
            return ActividadProyectoDB.ObtenerHorasAsignadasPorOrdenCompra(act_pto, (decimal)ControladorSubproyecto.ObtenerHorasMinimasSubproyecto(ControladorSubproyecto.BuscarPorId(ControladorSubproyecto.BuscarPorId(act_pto.id_subproyecto.Value).id_subproyecto_padre.Value)));
        }

        

        public static double ObtenerHorasTotalesActividad(Actividad_proyecto act_pto)
        {
            double horas_normales, eficiencia;
            horas_normales = ActividadProyectoDB.ObtenerHorasAsignadas(act_pto);
            eficiencia = ObtenerEficienciaActividad(act_pto).HasValue ? ObtenerEficienciaActividad(act_pto).Value : 100;
            eficiencia = horas_normales * eficiencia / 100;

            return horas_normales + eficiencia;
        }

        public static double ObtenerHorasOrdenCompraParaCadista(Actividad_proyecto act_pto)
        {
            double horas_orden_compra;
            horas_orden_compra = ActividadProyectoDB.ObtenerHorasPorOrdenCompra(act_pto);
            //Se le resta el 15% que corresponde a la calidad
            horas_orden_compra = horas_orden_compra - (horas_orden_compra * 0.15);
            
            //eficiencia = ObtenerEficienciaActividad(act_pto).HasValue ? ObtenerEficienciaActividad(act_pto).Value : 100;
            //eficiencia = horas_orden_compra * eficiencia / 100;

            return horas_orden_compra;
        }

        public static double? ObtenerEficienciaActividad(Actividad_proyecto act_pto)
        {
            return ActividadProyectoDB.ObtenerEficienciaActividad(act_pto);
        }

        public static Entidades.Tipo_Actividad_usuario ObtenerTipoActividadUsuario(int? id_tipo_actividad, int? id_usuario)
        {
            if (!id_tipo_actividad.HasValue || !id_usuario.HasValue) return null;
            return ActividadProyectoDB.ObtenerTipoActividadUsuario(id_tipo_actividad.Value, id_usuario.Value);
        }

        public static Actividad_proyecto ActualizarHorasAsignadas(Actividad_proyecto act_pto)
        {
            act_pto.cantidad_hora = (decimal)ActividadProyectoDB.ObtenerHorasAsignadas(act_pto);
            ActualizarActividadProyecto(act_pto);
            return act_pto;
        }

        public static Tipo_Actividad_usuario actualizarTipoActividadUsuario(Tipo_Actividad_usuario _Tipo_Actividad_Usuario)
        {
            return ActividadProyectoDB.actualizarTipoActividadUsuario(_Tipo_Actividad_Usuario);
        }

        public static double ObtenerHorasConsumidas(Actividad_proyecto acti, string tipo_logueo)
        {
            return ActividadProyectoDB.ObtenerHorasConsumidas(acti, tipo_logueo);
        }

        public static double ObtenerHorasConsumidas(Actividad_proyecto acti)
        {
            return ActividadProyectoDB.ObtenerHorasConsumidas(acti);
        }

        public static USUARIO ObtenerResponsableProduccion(int id_actividad_proyecto)
        {
            return ActividadProyectoDB.ObtenerResponsableProduccion(id_actividad_proyecto);
        }

        public static USUARIO ObtenerResponsableControln(int id_actividad_proyecto)
        {
            return ActividadProyectoDB.ObtenerResponsableControl(id_actividad_proyecto);
        }

        public static USUARIO ObtenerResponsableCorreccion(int id_actividad_proyecto)
        {
            return ActividadProyectoDB.ObtenerResponsableCorrecion(id_actividad_proyecto);
        }

        public static Tipo_actividad ObtenerTipoActividad(Actividad_proyecto ap)
        {
            return ActividadProyectoDB.ObtenerTipoActividad(ap);
        }

        public static bool EstaCompletada(Actividad_proyecto ap)
        {
            return ActividadProyectoDB.EstaCompletada(ap);
        }

        public static Actividad_proyecto ObtenerActividadAnterior(Actividad_proyecto act_pto)
        {
            return ActividadProyectoDB.ObtenerActividadAnterior(act_pto);
        }

        public static Actividad_proyecto ObtenerActividadPosterior(Actividad_proyecto act_pto)
        {
            return ActividadProyectoDB.ObtenerActividadPosterior(act_pto);
        }


        public static bool TieneControl_prod_1_Completado(Actividad_proyecto ap)
        {
            return ActividadProyectoDB.TieneControl_prod_1_Completado(ap);
        }


        public static bool TieneControl_prod_2_Completado(Actividad_proyecto ap)
        {
            return ActividadProyectoDB.TieneControl_prod_2_Completado(ap);
        }

        public static bool TieneControl_cal_1_Completado(Actividad_proyecto ap)
        {
            return ActividadProyectoDB.TieneControl_cal_1_Completado(ap);
        }

        public static bool TieneControl_cal_2_Completado(Actividad_proyecto ap)
        {
            return ActividadProyectoDB.TieneControl_cal_2_Completado(ap);
        }

        public static Movimiento_voz ObtenerMovimientoVoz(Actividad_proyecto ap)
        {
            return ActividadProyectoDB.ObtenerMovimientoVoz(ap);
        }

        public static bool TieneControl_corr_1_Completado(Actividad_proyecto ap)
        {
            return ActividadProyectoDB.TieneControl_corr_1_Completado(ap);
        }

        public static bool TieneControl_corr_2_Completado(Actividad_proyecto ap)
        {
            return ActividadProyectoDB.TieneControl_corr_2_Completado(ap);
        }

        public static void EliminarActividad(Actividad_proyecto item)
        {
            if (!TieneHorasLogueadas(item))
            {
                //Eliminar Detalle Recurso
                ControladorTareas.EliminarDetalleRecursoActividad(item);
                //Eliminar Programacion_Actividad
                ActividadProyectoDB.EliminarProgramacionActividadDeActividadProyecto(item);
                //Eliminar Actividad
                ActividadProyectoDB.EliminarActividadDeActividadProyecto(item);
                //Eliminar Actividad_Proyecto
                ActividadProyectoDB.EliminarActividadProyecto(item);
            }            
        }

        public static bool TieneHorasLogueadas(Actividad_proyecto item)
        {
            return ActividadProyectoDB.TieneHorasLogueadas(item);
        }

        public static bool TieneHorasLogueadas(Detalle_recurso item)
        {
            return ActividadProyectoDB.TieneHorasLogueadas(item);
        }

        public static DateTime ObtenerFechaInicioMinima(Actividad_proyecto actividad)
        {
            //Si la actividad es Concepto, le fecha minima de inicio es la fecha del proyecto
            //Si la actividad es Preparacion, la fecha minima de inicio es la fecha del proyecto 
            //mas el tiempo de concepto, pero si el concepto ya esta asignado, que la fecha minima de inicio sea la fecha
            //fin de concepto.. Lo mismo para preparacion.
            String tipo_actividad = ControladorActividades.ObtenerTipoActividad(actividad).descripcion.ToLower();
            SUBPROYECTO sub = ControladorSubproyecto.BuscarPorId(actividad.id_subproyecto.Value);

            List<Detalle_recurso> tareas = new List<Detalle_recurso>();
            DateTime fecha;

            Actividad_proyecto act_anterior = ControladorActividades.ObtenerActividadAnterior(actividad);

            if (act_anterior != null)
            {
                double tiempo_actividad;

                //Suma los tiempos del
                var act_anterior_aux = act_anterior;
                tiempo_actividad = 0;
                do
                {
                    tiempo_actividad = ObtenerHorasTotalesActividad(act_anterior_aux);
                    act_anterior_aux = ControladorActividades.ObtenerActividadAnterior(act_anterior_aux);
                } while (act_anterior_aux!= null);
                
                tareas = obtenerTareasDeActividad(act_anterior);

                if (tareas.Count == 0)
                {
                    //No esta asignada, se asigna a la fecha de proyecto + tiempo_actividad
                    fecha = ControladorCalendario.CalcularFechaFinDesdeProyecto(actividad, tiempo_actividad).Value;
                }
                else
                {
                    //Está asignada, se asigna a la fecha fin de la asignacion de actividad anterior.
                    tareas = tareas.OrderByDescending(x => x.fecha_fin).ToList();
                    fecha = tareas.First().fecha_fin.Value;
                }
            }
            else
            {
                fecha = ControladorProyecto.ObtenerPorID(actividad.id_proyecto.Value).fecha_inicio.Value;               
            }

            //if (tipo_actividad.Contains("prep") || (tipo_actividad.Contains("deta")))
            //{
            //    List<AvanceSubproyecto> avance;
            //    double tiempo_actividad;

            //    if (tipo_actividad.Contains("deta"))
            //    {                   
            //        tiempo_actividad = ObtenerHorasTotalesActividad(ObtenerActividadPorTipoActividad(sub,acti_concepto)) + ObtenerHorasTotalesActividad(ObtenerActividadPorTipoActividad(sub, acti_prepa));
            //        tareas = obtenerTareasDeActividad(ObtenerActividadPorTipoActividad(sub, acti_prepa));
            //    }
            //    else
            //    {                   
            //        tiempo_actividad = ObtenerHorasTotalesActividad(ObtenerActividadPorTipoActividad(sub, acti_concepto));
            //        tareas = obtenerTareasDeActividad(ObtenerActividadPorTipoActividad(sub, acti_concepto));
            //    }
                
            //    if (tareas.Count == 0)
            //    {
            //        //No esta asignada, se asigna a la fecha de proyecto + tiempo_actividad
            //        fecha = ControladorCalendario.CalcularFechaFinDesdeProyecto(actividad, tiempo_actividad).Value;
            //    }else
            //    {
            //        //Está asignada, se asigna a la fecha fin de la asignacion de actividad anterior.
            //        tareas = tareas.OrderByDescending(x => x.fecha_fin).ToList();
            //        fecha = tareas.First().fecha_fin.Value;
            //    }

            //}
            //else //Es concepto, o cualquier otro tipo de actividad, inicia cuando lo hace el proyecto.
            //{
            //    fecha = ControladorProyecto.ObtenerPorID(actividad.id_proyecto.Value).fecha_inicio.Value;
            //}

            return fecha < DateTime.Now ? DateTime.Now : fecha;
        }

        private static List<Detalle_recurso> obtenerTareasDeActividad(Actividad_proyecto actividad)
        {
            return ActividadProyectoDB.obtenerTareasDeActividad(actividad);
        }

        public static Actividad_proyecto ObtenerActividadPorTipoActividad(SUBPROYECTO subpr, Tipo_actividad tipo_actividad)
        {
            return ActividadProyectoDB.ObtenerActividadPorTipoActividad(subpr, tipo_actividad);
        }

        public static void SubirOrdenActividad(Actividad_proyecto actividad)
        {
            ActualizarOrdenActividades(ControladorSubproyecto.BuscarPorId(actividad.id_subproyecto.Value));
            List<Actividad_proyecto> actividades = ObtenerActividadesProyectoDeSubproyecto(ControladorSubproyecto.BuscarPorId(actividad.id_subproyecto.Value)).OrderBy(x => x.orden).ToList();

            int indexOf = actividades.IndexOf(actividades.Where(x => x.id_actividad_proyecto == actividad.id_actividad_proyecto).FirstOrDefault());
            if (indexOf == 0) return;

            actividades[indexOf].orden--;
            ControladorActividades.ActualizarActividadProyecto(actividades[indexOf]);

            if (indexOf - 1 >= 0)
            {
                actividades[indexOf - 1].orden++;
                ControladorActividades.ActualizarActividadProyecto(actividades[indexOf - 1]);
            }
        }

        public static void BajarOrdenActividad(Actividad_proyecto actividad)
        {
            ActualizarOrdenActividades(ControladorSubproyecto.BuscarPorId(actividad.id_subproyecto.Value));
            List<Actividad_proyecto> actividades = ObtenerActividadesProyectoDeSubproyecto(ControladorSubproyecto.BuscarPorId(actividad.id_subproyecto.Value)).OrderBy(x => x.orden).ToList();
                       

            int indexOf = actividades.IndexOf(actividades.Where(x => x.id_actividad_proyecto == actividad.id_actividad_proyecto).FirstOrDefault());
            if (indexOf == actividades.Count -1) return;

            actividades[indexOf].orden++;
            ControladorActividades.ActualizarActividadProyecto(actividades[indexOf]);

            if (indexOf+1 <= actividades.Count -1)
            {
                actividades[indexOf+1].orden--;
                ControladorActividades.ActualizarActividadProyecto(actividades[indexOf + 1]);
            }


        }

        /// <summary>
        /// Para que sean compatibles el orden que se usaba anteriormente de numeros impares al nuevo por 1,2,3,4..
        /// </summary>
        /// <param name="sub"></param>
        public static void ActualizarOrdenActividades(SUBPROYECTO sub)
        {
            List<Actividad_proyecto> actividades = ObtenerActividadesProyectoDeSubproyecto(sub).OrderBy(x => x.orden).ToList();

            foreach (var act in actividades)
            {
                if (act.orden != actividades.IndexOf(act) + 1)
                {
                    act.orden = actividades.IndexOf(act) + 1;
                    ControladorActividades.ActualizarActividadProyecto(act);
                }
            }
        }


    }
}