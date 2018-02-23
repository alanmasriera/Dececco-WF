using Entidades;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;

namespace ControladoresLogica
{
    public class ControladorSubproyecto 
    {
        /// <summary>
        /// Inserta un subproyecto en la base de datos.
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <returns></returns>
        public static SUBPROYECTO InsertarSubproyecto(SUBPROYECTO subproyecto)
        {
            return SubproyectoBD.Insertar(subproyecto);
        }

        /// <summary>
        /// Actualiza los datos del subproyecto.
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <returns></returns>
        public static SUBPROYECTO ActualizarSubproyecto(SUBPROYECTO subproyecto)
        {
            return SubproyectoBD.UpdateSubproyecto(subproyecto);
        }

        /// <summary>
        /// Genera la estructura del proyecto en Windows, en el directorio indicado, para el subproyecto o 
        /// proyecto indicado.
        /// </summary>
        /// <param name="path">Path donde se guardará la estructura</param>
        /// <param name="id_proyecto">El id del proyecto</param>
        /// <param name="id_subproyecto">El id del subproyecto</param>
        /// <param name="esProyecto">Si es true, agrega también el nombre del proyecto</param>
        public static void GenerarCarpetasProyecto(string path, int id_proyecto, int? id_subproyecto, bool esProyecto)
        {
            var subproyectosHijos = new List<SUBPROYECTO>();

            if (esProyecto)
            {
                path = path + "/" + ControladorProyecto.ObtenerPorID(id_proyecto).nombre_proyecto;
                Directory.CreateDirectory(path);
            }
            subproyectosHijos = ControladorSubproyecto.ObtenerPorProyecto(id_proyecto, id_subproyecto);
            if (subproyectosHijos.Count > 0)
            {
                foreach (var subproyecto in subproyectosHijos)
                {
                    Directory.CreateDirectory(path + "/" + subproyecto.nombre);
                    GenerarCarpetasProyecto(path + "/" + subproyecto.nombre, id_proyecto, subproyecto.id_subproyecto, false);
                }
            }
        }


        /// <summary>
        /// Obtiene la estructura de todo el proyecto, incluyendo las actividades que la involucran, y las asignaciones.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="sub"></param>
        /// <param name="nivel"></param>
        /// <returns></returns>
        public static List<ClaseExpGantt> ObtenerEstructuraSubproyectosConActividades(List<ClaseExpGantt> lista, SUBPROYECTO sub, int nivel)
        {
            List<SUBPROYECTO> listaSubproyectos = ObtenerSubproyectosHijos(subpro: sub);
            List<Actividad_proyecto> actividades = ControladorActividades.ObtenerActividadesProyectoDeSubproyecto(sub);
                    
            ClaseExpGantt estructura = new ClaseExpGantt() { subproyecto = sub, nivel = nivel };
            lista.Add(estructura);
            nivel = nivel + 1;

            foreach (var actividad in actividades)
            {
                Detalle_recurso tarea = ControladorTareas.ObtenerPorActividad(actividad);
                ClaseExpGantt ExpoActivida = new ClaseExpGantt() { actividadProy = actividad, nivel = nivel, tarea = tarea, subproyecto = null, actividad = ControladorActividades.ObtenerActividad(actividad), usuario = tarea != null ? ControladorUsuarios.ObtenerUsuario(tarea.id_usuario.Value) : null };
                lista.Add(ExpoActivida);
            }

            foreach (SUBPROYECTO subpro in listaSubproyectos)
            {
                ObtenerEstructuraSubproyectosConActividades(lista, subpro, nivel);
            }
            return lista;
        }

        /// <summary>
        /// Asigna una OT al subproyecto.
        /// </summary>
        /// <param name="idSubproyecto"></param>
        /// <returns></returns>
        public static bool AsignarOT(int idSubproyecto)
        {
            if (ControladorSubproyecto.BuscarPorId(idSubproyecto).ot == null || ControladorSubproyecto.BuscarPorId(idSubproyecto).ot == 0)
                return SubproyectoBD.AsignarOt(idSubproyecto);
            return false;
        }
        
        /// <summary>
        /// Obtiene una lista de los subproyectos de un proyecto o subroyecto.
        /// </summary>
        /// <param name="id_proyecto">Id del proyecto</param>
        /// <param name="id_subproyecto">Id del subproyecto. Si es 1 busca los hijos directos del proyecto</param>
        /// <returns></returns>
        public static List<SUBPROYECTO> ObtenerPorProyecto(int id_proyecto, int? id_subproyecto)
        {
                return SubproyectoBD.ObtenerPorProyecto(id_proyecto, id_subproyecto > 1 ? id_subproyecto : 1);
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
            return SubproyectoBD.BuscarPorOTDeExportacion(nombre, idProyecto);
        }

        /// <summary>
        /// Busca un Subproyecto por la ot indicada. Si validaMiembro es true, valida que el usuario indicado
        /// sea miembro del mismo, de lo contrario no devuelve.
        /// </summary>
        /// <param name="ot"></param>
        /// <param name="idUsuario"></param>
        /// <param name="validaMiembro"></param>
        /// <returns></returns>
        public static SUBPROYECTO BuscarPorOT(int ot, int idUsuario, bool validaMiembro)
        {
            return SubproyectoBD.BuscarPorOT(ot, idUsuario, validaMiembro);
        }

        /// <summary>
        /// Verifica si el subproyecto ya tiene un hijo con ese nombre.
        /// </summary>
        /// <param name="nombreHijo">Nombre del hijo</param>
        /// <param name="idSubproyectoPadre">Subproyecto a buscar</param>
        /// <returns></returns>
        public static SUBPROYECTO YaExisteHijo(string nombreHijo, int idSubproyectoPadre)
        {
            return SubproyectoBD.YaExisteHijo(nombreHijo, idSubproyectoPadre);
        }

        /// <summary>
        /// Actualiza el valor de asignacion automatica al subproyecto indicado y sus hijos.
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <param name="nuevoValor"></param>
        public static void ActualizarAsignacionAutomatica(SUBPROYECTO subproyecto, bool nuevoValor)
        {
            SUBPROYECTO sub = subproyecto;
            List<SUBPROYECTO> subHijos = ObtenerSubproyectosHijos(sub);

            foreach (var item in subHijos)
            {
                SubproyectoBD.ActualizarAsignacionAutomatica(item, nuevoValor);
                ActualizarAsignacionAutomatica(item, nuevoValor);
            }                
           
        }        

        /// <summary>
        /// Busca un subproyecto por su ID.
        /// </summary>
        /// <param name="id_subproyecto"></param>
        /// <returns></returns>
        public static SUBPROYECTO BuscarPorId(int id_subproyecto)
        {
            return SubproyectoBD.BuscarPorId(id_subproyecto);
        }

        /// <summary>
        /// Obtiene los subproyectos hijos directos del subproyecto indicado.
        /// </summary>
        /// <param name="subpro"></param>
        /// <returns></returns>
        public static List<SUBPROYECTO> ObtenerSubproyectosHijos(SUBPROYECTO subpro)
        {
            return SubproyectoBD.ObtenerSubproyectosHijos(subpro);
        }

        /// <summary>
        /// Obtiene el subproyecto padre, null si es proyecto.
        /// </summary>
        /// <param name="subpro"></param>
        /// <returns></returns>
        public static SUBPROYECTO ObtenerSubproyectoPadre(SUBPROYECTO subpro)
        {
            return SubproyectoBD.ObtenerSubproyectoPadre(subpro);
        }

        /// <summary>
        /// Obtiene una tupla con Nivel y Subproyecto, hacia abajo, del subproyecto indicado
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="sub"></param>
        /// <param name="nivel"></param>
        /// <returns></returns>
        public static List<Tuple<SUBPROYECTO, int>> ObtenerEstructuraSubproyectos(List<Tuple<SUBPROYECTO, int>> lista, SUBPROYECTO sub, int nivel)
        {
            List<SUBPROYECTO> listaSubproyectos = ObtenerSubproyectosHijos(subpro: sub);

            Tuple<SUBPROYECTO, int> estructura = new Tuple<SUBPROYECTO, int>(sub, nivel);
            lista.Add(estructura);
            nivel = nivel + 1;

            foreach (SUBPROYECTO subpro in listaSubproyectos)
            {
                ObtenerEstructuraSubproyectos(lista, subpro, nivel);
            }
            return lista;
        }

        /// <summary>
        /// Obtiene una lista de las Horas_Tipo_Unidad, que contiene la descripcion y las horas 
        /// de los tipos de subproyecto.
        /// </summary>
        /// <returns></returns>
        internal static List<HORA_TIPO_SUBPROYECTO> ObtenerHorasTipoUnidad()
        {
            return SubproyectoBD.ObtenerHorasTipoUnidad().OrderBy(x => x.nombre).ToList();
        }

        /// <summary>
        /// Obtiene una lista de todos los Tipos de Subproyecto en la base de datos
        /// </summary>
        /// <returns></returns>
        internal static List<TIPO_SUBPROYECTO> ObtenerTiposSubproyecto()
        {
            return SubproyectoBD.ObtenerTipoSubproyectos();
        }

        /// <summary>
        /// Obtiene el TIpo de Subproyecto del Subproyecto indicado.
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <returns></returns>
        public static TIPO_SUBPROYECTO ObtenerTipoSubproyecto(SUBPROYECTO subproyecto)
        {
            return SubproyectoBD.ObtenerTipoSubproyecto(subproyecto);
        }

        /// <summary>
        /// Obtiene Tipo_Subproyecto por nombre
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <returns></returns>
        public static TIPO_SUBPROYECTO ObtenerTipoSubproyectoPorNombre(string subproyecto)
        {
            return SubproyectoBD.ObtenerTipoSubproyecto(subproyecto);
        }

        /// <summary>
        /// Obtiene una lista de Actividades_Proyecto que pertenecen a un subproyecto.
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <returns></returns>
        public static List<Actividad_proyecto> ObtenerActividades(SUBPROYECTO subproyecto)
        {
            return SubproyectoBD.ObtenerActividades(subproyecto);
        }

        /// <summary>
        /// Obtiene el objeto Hora_Tipo_Subproyecto con el id indicado. 
        /// </summary>
        /// <param name="id_hora_tipo_subproyecto"></param>
        /// <returns></returns>
        internal static HORA_TIPO_SUBPROYECTO ObtenerHoraTipoSubproyecto(int? id_hora_tipo_subproyecto)
        {
            if (id_hora_tipo_subproyecto == null || id_hora_tipo_subproyecto <= 0) return null;
            return SubproyectoBD.ObtenerHoraTipoSubproyecto(id_hora_tipo_subproyecto);
        }

        /// <summary>
        /// Obtiene el objeto Hora_Tipo_Subproyecto con le nombre indicado.
        /// </summary>
        /// <param name="hora_tipo_subproyecto"></param>
        /// <returns></returns>
        public static HORA_TIPO_SUBPROYECTO ObtenerHoraTipoSubproyecto(string hora_tipo_subproyecto)
        {
            if (hora_tipo_subproyecto == null || hora_tipo_subproyecto == "") return null;
            return SubproyectoBD.ObtenerHoraTipoSubproyecto(hora_tipo_subproyecto);
        }

        public static List<Tuple<USUARIO, double>> ObtenerHorasTrabajadasPorUsuario(SUBPROYECTO sUBPROYECTO)
        {
            var lista = new List<Tuple<SUBPROYECTO, int>>();
            List<Tuple<USUARIO, double>> listaReturn = new List<Tuple<USUARIO, double>>();
            List<SUBPROYECTO> subproyectos = ObtenerEstructuraSubproyectos(lista, sUBPROYECTO,1).Select(x => x.Item1).ToList();

            foreach (var item in subproyectos)
            {
                listaReturn.AddRange(SubproyectoBD.ObtenerHorasTrabajadasPorUsuario(item));
            }

            return listaReturn.GroupBy(x => x.Item1.id_usuario).ToList().Select(cl => new Tuple<USUARIO, double>(cl.First().Item1, cl.Sum(x => x.Item2))).ToList();
        }

        /// <summary>
        /// Obtiene las horas minimas de un subproyecto, esto es la suma de todas las actividades hijas, indirectamente.
        /// </summary>
        /// <param name="subpro"></param>
        /// <returns></returns>
        public static double ObtenerHorasMinimasSubproyecto(SUBPROYECTO subpro)
        {
            double total = 0;
            List<SUBPROYECTO> lisSubpro = ObtenerSubproyectosHijos(subpro);
            List<Actividad_proyecto> actividades = ControladorActividades.ObtenerActividadesProyectoDeSubproyecto(subpro);

            //Función recursiva para calcular las horas de los subproyectos hijos
            foreach (var sub in lisSubpro)
            {
                total += ObtenerHorasMinimasSubproyecto(sub);
            }

            //Recorre las actividades y suma sus horas asignadas
            foreach (var act in actividades)
            {
                total += ControladorActividades.ObtenerHorasAsignadas(act);
            }

            return total;
        }

        /// <summary>
        /// Solo para UNIDADES!
        /// Calcula las horas asignadas a ese subproyecto, en base al presupuesto asignado al dispositivo
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <returns></returns>
        public static decimal? CalcularHorasOrdenCompra(SUBPROYECTO subproyecto)
        {
            SUBPROYECTO subPadre = ObtenerSubproyectoPadre(subproyecto);
            if (subPadre != null)
            {
                if (subPadre.horas_orden_compra.HasValue)
                    return (decimal)ObtenerHorasMinimasSubproyecto(subPadre) > 0 ? Convert.ToDecimal(subPadre.horas_orden_compra.Value * (decimal)ObtenerHorasMinimasSubproyecto(subproyecto) / (decimal)ObtenerHorasMinimasSubproyecto(subPadre)) : 0;
                else
                    return (decimal)ObtenerHorasMinimasSubproyecto(subproyecto);

            }
            return null;
            
        }

        /// <summary>
        /// Solo para UNIDADES!
        /// Obtiene las horas asignadas a ese subproyecto, en base al presupuesto asignado al dispositivo,
        /// null si hoas orden de compra es nulo.
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <returns></returns>
        public static decimal? ObtenerHorasOrdenCompra(SUBPROYECTO subproyecto)
        {
            SUBPROYECTO subPadre = ObtenerSubproyectoPadre(subproyecto);
            if (subPadre != null)
                if (subPadre.horas_orden_compra.HasValue)
                    return subPadre.horas_orden_compra.Value * (decimal)ObtenerHorasMinimasSubproyecto(subproyecto) / (decimal)ObtenerHorasMinimasSubproyecto(subPadre);
                else
                    return (decimal)ObtenerHorasMinimasSubproyecto(subproyecto);
            else
                return (decimal)ObtenerHorasMinimasSubproyecto(subproyecto);
        }


        public static List<SUBPROYECTO> ObtenerSubproyectosConActividadesActivos()
        {
            return SubproyectoBD.ObtenerSubproyectosConActividadesActivos();
        }

        /// <summary>
        /// Actualiza la hora del subproyecto para que la suma sea igual a las horas de las actividades
        /// incluyendo los subproyectos hijos.
        /// </summary>
        /// <param name="subproyecto">Subproyecto a actualizar, incluyendo sus hijos</param>
        /// <returns></returns>
        public static decimal ActualizarHorasSubproyecto(SUBPROYECTO subproyecto)
        {
            List<SUBPROYECTO> subproyectos = ObtenerSubproyectosHijos(subproyecto);
            List<Actividad_proyecto> actividades = ControladorActividades.ObtenerActividadesProyectoDeSubproyecto(subproyecto);
            List<SUBPROYECTO> hijos;
            decimal total = 0;

            //Función recursiva para calcular las horas de los subproyectos hijos
            foreach (var subpro in subproyectos)
            {
                total += ActualizarHorasSubproyecto(subpro);
            }

            //Recorre las actividades y suma sus horas
            foreach (var item in actividades)
            {
                item.cantidad_hora = (decimal)ControladorActividades.ObtenerHorasTotalesActividad(item);
                ControladorActividades.ActualizarActividadProyecto(item);
                total += (decimal)ControladorActividades.ObtenerHorasTotalesActividad(item);
            }

            subproyecto.horas_estimadas = total;
            ActualizarSubproyecto(subproyecto);

            return total;
        }

        public static List<AvanceSubproyecto> ObtenerAvanceConcepto(SUBPROYECTO subpr, Tipo_actividad tipo_actividad)
        {
            return SubproyectoBD.ObtenerAvanceConcepto(subpr, tipo_actividad);
        }

        /// <summary>
        /// NO USAR TODAVIA !!!!!!!!!
        /// Asigna un miembros a
        /// </summary>
        /// <param name="subproyecto"></param>
        /// <returns></returns>
        public static USUARIO AsignarMiembroASubproyecto(Actividad_proyecto actividad)
        {
            List<USUARIO> miembros = ObtenerMiembrosIndirectos(BuscarPorId(actividad.id_subproyecto.Value));
            return miembros.First();
        }

        public static List<USUARIO> ObtenerMiemrosHabilitados(Actividad_proyecto actividad)
        {
            List<USUARIO> miembros = ObtenerMiembrosIndirectos(BuscarPorId(actividad.id_subproyecto.Value));
            List<Tuple<USUARIO, Tuple<int, decimal>>> listaMiembros = new List<Tuple<USUARIO, Tuple<int, decimal>>>();
            foreach (var item in miembros)
            {
                if (!ControladorUsuarios.EstaHabilitadoParaActividad(item, actividad))
                {
                    listaMiembros.Add(new Tuple<USUARIO,Tuple<int,decimal>>( item, new Tuple<int,decimal>(ControladorUsuarios.ObtenerCantidadCalificaciones(item), ControladorActividades.ObtenerTipoActividadUsuario(ControladorActividades.ObtenerActividad(actividad).id_tipo_actividad,item.id_usuario).calificacion.Value)));
                }
            }

            return listaMiembros.OrderByDescending(x => x.Item2.Item2).ThenBy(x => x.Item2.Item1).Select(x => x.Item1).ToList();
        }

        public static List<Tuple<USUARIO,decimal>> ObtenerMiemrosHabilitadosParaAsignar(Actividad_proyecto actividad)
        {
            List<USUARIO> miembros = ObtenerMiembrosIndirectos(BuscarPorId(actividad.id_subproyecto.Value));
            List<Tuple<USUARIO, Tuple<int, decimal>>> listaMiembros = new List<Tuple<USUARIO, Tuple<int, decimal>>>();
            foreach (var item in miembros)
            {
                if (ControladorUsuarios.EstaHabilitadoParaActividad(item, actividad))
                {
                    decimal? calif = ControladorActividades.ObtenerTipoActividadUsuario(ControladorActividades.ObtenerActividad(actividad).id_tipo_actividad, item.id_usuario).calificacion;
                    listaMiembros.Add(new Tuple<USUARIO, Tuple<int, decimal>>(item, new Tuple<int, decimal>(ControladorUsuarios.ObtenerCantidadCalificaciones(item), calif.HasValue ? calif.Value : 1)));
                }
            }

            return listaMiembros.OrderByDescending(x => x.Item2.Item2).ThenBy(x => x.Item2.Item1).AsEnumerable().Select(x => new Tuple<USUARIO,decimal>( x.Item1, x.Item2.Item2)).ToList();
        }

        /// <summary>
        /// Obtiene la lista de miembros a un subproyecto. Esto es indirectamente, es decir 
        /// si el subproyecto no tiene asignados miembros explicitamente, se buscará en el nivel del arbol
        /// hacia arriba
        /// </summary>
        /// <param name="subproyecto">El subproyecto a buscar sus miembros</param>
        /// <returns>Lista de miembros que pueden trabajar en ese subproyecto</returns>
        public static List<USUARIO> ObtenerMiembrosIndirectos(SUBPROYECTO subproyecto)
        {
            List<USUARIO> miembros = ObtenerMiembrosDirectos(subproyecto);
            SUBPROYECTO subp_padre;
            if (miembros.Count > 0)
                return miembros;
            else
            {
                subp_padre = ObtenerSubproyectoPadre(subproyecto);
                if (subp_padre != null)
                    return ObtenerMiembrosIndirectos(subp_padre);
                else
                {
                    return ControladorProyecto.ObtenerMiembros(ControladorProyecto.ObtenerPorID(subproyecto.id_proyecto.Value));
                }
            }               
        }

        /// <summary>
        /// Obtiene la lista de miembros que fueron explicitamente asignados a ese subproyecto
        /// </summary>
        /// <param name="subproyecto">El subproyecto a buscar sus miembros</param>
        /// <returns>Lista de miembros que explicitamente pueden trabajar en ese subproyecto</returns>
        public static List<USUARIO> ObtenerMiembrosDirectos(SUBPROYECTO subproyecto)
        {
            return SubproyectoBD.ObtenerMiembrosDirectos(subproyecto);
        }

        /// <summary>
        /// Obtiene la lista de miembros que fueron explicitamente asignados a ese subproyecto
        /// </summary>
        /// <param name="subproyecto">El subproyecto a buscar sus miembros</param>
        /// <returns>Lista de miembros que explicitamente pueden trabajar en ese subproyecto</returns>
        public static List<USUARIO> ObtenerMiembrosDirectosOrdenMenorCalificaciones(SUBPROYECTO subproyecto)
        {
            return SubproyectoBD.ObtenerMiembrosDirectosOrdenMenorCalificaciones(subproyecto);
        }

        /// <summary>
        /// Busca un subproyecto por el siguiente orden: <para/>
        /// OT, OT Cliente, Nombre. Si validaMiembro es true, valida que el usuario indicado
        /// sea miembro del mismo, de lo contrario no devuelve.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static SUBPROYECTO Buscar(string texto, int idUsuario, bool validaMiembro)
        {
            SUBPROYECTO sub = null;
            int ot = 0;
            if (Int32.TryParse(texto, out ot))
            {
                sub = BuscarPorOT(ot, idUsuario, validaMiembro);
            }
            //Busca por OT cliente
            if (sub == null)
            {
                sub = BuscarPorOTCliente(texto, idUsuario, validaMiembro);
            }
            //Busca por el nombre
            if (sub == null)
            {
                sub = BuscarPorNombre(texto, idUsuario, validaMiembro);
            }
            return sub;
        }


        /// <summary>
        /// Busca un subproyecto por OT del cliente.
        /// </summary>
        /// <param name="ot"></param>
        /// <param name="idUsuario"></param>
        /// <param name="validaMiembro"></param>
        /// <returns></returns>
        public static SUBPROYECTO BuscarPorOTCliente(string ot, int idUsuario, bool validaMiembro)
        {
            return SubproyectoBD.BuscarPorOTCliente(ot, idUsuario, validaMiembro);
        }

        /// <summary>
        /// Busca un subproyecto por su nombre, si validaMiembro es true, valida que el usuario indicado
        /// sea miembro del mismo, de lo contrario no devuelve.
        /// </summary>
        /// <param name="nombre">Nombre a buscar</param>
        /// <param name="idUsuario">Id del usuario que hace la busqueda</param>
        /// <param name="validarMiembro">Booleano para indicar si valida el usuario o muestra todos</param>
        /// <returns></returns>
        public static SUBPROYECTO BuscarPorNombre(string nombre, int idUsuario, bool validarMiembro)
        {
            return SubproyectoBD.BuscarPorNombre(nombre, idUsuario, validarMiembro);
        }


        /// <summary>
        /// Devuelve el nombre del subproyecto segun ubicacion en el arbol
        /// </summary>
        /// <param name="subpro"></param>
        /// <returns></returns>
        public static String ObtenerPathSubproyecto(SUBPROYECTO subpro)
        {
            SUBPROYECTO subp_padre = ObtenerSubproyectoPadre(subpro);
            List<String> path = new List<string>();
            path.Add(subpro.nombre);

            while (subp_padre != null)
            {
                path.Add(subp_padre.nombre);
                subp_padre = ObtenerSubproyectoPadre(subp_padre);
            }

            path.Reverse();
            return string.Join(" / ", path);
        }


        public static Actividad_proyecto ObtenerActividaHijaDeTipo(SUBPROYECTO subproyecto, Tipo_actividad tipo)
        {
            return SubproyectoBD.ObtenerActividaHijaDeTipo(subproyecto, tipo);
        }


        public static bool EliminarSubproyecto(SUBPROYECTO subproyecto)
        {
            var lista = new List<Tuple< SUBPROYECTO, int>>();
            var subpHijos = ObtenerEstructuraSubproyectos(lista, subproyecto, 1);

            foreach (var subp in subpHijos)
            {
                List<Actividad_proyecto> actividades = ControladorActividades.ObtenerActividadesProyectoDeSubproyecto(subp.Item1);
                foreach (var item in actividades)
                {
                    if (ControladorActividades.TieneHorasLogueadas(item))
                        return false;
                }
            }

            foreach (var subp in subpHijos)
            {
                List<Actividad_proyecto> actividades = ControladorActividades.ObtenerActividadesProyectoDeSubproyecto(subp.Item1);
                foreach (var item in actividades)
                {
                    ControladorActividades.EliminarActividad(item);
                }
                SubproyectoBD.EliminarSubproyecto(subp.Item1);
            }

            return true;
        }

        public static void ActualizarHorasOrdenCompraHijos(SUBPROYECTO subpr)
        {
            if (subpr.horas_orden_compra.HasValue)
            {
                List<SUBPROYECTO> hijos = ObtenerSubproyectosHijos(subpr);
                foreach (var item in hijos)
                {
                    item.horas_orden_compra = (decimal)CalcularHorasOrdenCompra(item);
                    ActualizarSubproyecto(item);
                }
            }
        }
    }
}
