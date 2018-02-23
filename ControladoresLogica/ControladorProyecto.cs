using System;
using System.Collections.Generic;
//using Excel = Microsoft.Office.Interop.Excel;
using Entidades;
using AccesoDatos;
using System.Data;
using System.Linq;

namespace ControladoresLogica
{
    public class ControladorProyecto : AControladorProyecto
    {
        private ControladorSubproyecto _controladorSubproyecto = new ControladorSubproyecto();
        
        public Proyecto Insertar(Proyecto proyecto, bool asignarOT)
        {
            var aux = ProyectoDB.Insertar(proyecto);
            if (asignarOT)
                AsignarOT(aux.id_proyecto);

            return aux;
        }

        public static bool AsignarOT(int idProyecto)
        {
            return ProyectoDB.AsignarOt(idProyecto);
        }

        public static Proyecto ObtenerPorID(int idProyecto)
        {
            return ProyectoDB.ObtenerPorID(idProyecto);
        }

        public override bool AsignarMiembros(List<USUARIO> usuarios, int idProyecto)
        {
            return ProyectoDB.AsignarMiembros(usuarios, idProyecto);
        }

        public static List<SUBPROYECTO> ObtenerSubproyectosHijos(Proyecto proyecto)
        {
            return ProyectoDB.ObtenerSubproyectosHijos(proyecto);
        }

        public static Proyecto ActualizarActivo(int id_proyecto, bool value)
        {
            return ProyectoDB.ActualizarActivo(id_proyecto, value);
        }

        public List<Tuple<SUBPROYECTO, int>> ObtenerEstructuraProyecto(Proyecto proyecto)
        {
            List<Tuple<SUBPROYECTO,int>> estrucutaProyecto = new List<Tuple<SUBPROYECTO, int>>();
            List<SUBPROYECTO> listaSubproyecto = ObtenerSubproyectosHijos(proyecto);
            foreach (var subpro in listaSubproyecto)
            {
                ControladorSubproyecto.ObtenerEstructuraSubproyectos(estrucutaProyecto, subpro, 1);
            }

            return estrucutaProyecto;

        }

        public List<ClaseExpGantt> ObtenerEstructuraProyectoConActividades(Proyecto proyecto)
        {
            List<ClaseExpGantt> estrucutaProyecto = new List<ClaseExpGantt>();
            List<SUBPROYECTO> listaSubproyecto = ObtenerSubproyectosHijos(proyecto);

            foreach (var subpro in listaSubproyecto)
            {
                ControladorSubproyecto.ObtenerEstructuraSubproyectosConActividades(estrucutaProyecto, subpro, 1);
            }

            return estrucutaProyecto;

        }

        public static Proyecto Update(Proyecto proyAux)
        {
            return ProyectoDB.Update(proyAux);
        }

        public static void ActualizarHorasSubproyecto(Proyecto proy)
        {
            List<SUBPROYECTO> subproyectos = ObtenerSubproyectosHijos(proy);
            decimal total = 0;
            foreach (var subp in subproyectos)
            {
                total += ControladorSubproyecto.ActualizarHorasSubproyecto(subp);
            }

            proy.total_hora = total;
            Update(proy);
        }

        public static double ObtenerHorasMinimasProyecto(Proyecto proy)
        {
            List<SUBPROYECTO> subproyectos = ObtenerSubproyectosHijos(proy);
            double total = 0;
            foreach (var subp in subproyectos)
            {
                total += ControladorSubproyecto.ObtenerHorasMinimasSubproyecto(subp);
            }

            return total;
        }

        public static List<USUARIO> ObtenerMiembros(Proyecto proyecto)
        {
            return ProyectoDB.ObtenerMiembros(proyecto);
        }

        public static List<Proyecto> ObtenerProyectos()
        {
            return ProyectoDB.ObtenerProyectos();
        }

        public static List<Proyecto> ObtenerProyectosActivos()
        {
            return ProyectoDB.ObtenerProyectosActivos();
        }

        public static List<Proyecto> ObtenerProyectosCliente(int idCliente)
        {
            return ProyectoDB.ObtenerProyectosCliente(idCliente);
        }
        public static List<Proyecto> ObtenerProyectosActivosCliente(int idCliente)
        {
            return ProyectoDB.ObtenerProyectosActivosCliente(idCliente);
        }

        public static List<Proyecto> ObtenerProyectosClienteSoloMiembro(int idCliente, int id_usuario)
        {
            List<Proyecto> proyectosMiembro = new List<Proyecto>();
            List<Proyecto> proyectos = ProyectoDB.ObtenerProyectosCliente(idCliente).Where(x => x.activo == true).ToList();
            List<USUARIO> miembros = new List<USUARIO>();
            foreach (var proyecto in proyectos)
            {
                miembros = ObtenerMiembros(proyecto).Where(x => x.id_usuario == id_usuario).ToList();
                if (miembros.Count > 0)
                    proyectosMiembro.Add(proyecto);
            }
            return proyectosMiembro;
        }

        public static List<Tuple<USUARIO, double>> ObtenerHorasTrabajadasPorUsuario(Proyecto proyecto)
        {
            return ProyectoDB.ObtenerHorasTrabajadasPorUsuario(proyecto).GroupBy(x => x.Item1.id_usuario).ToList().Select( cl => new Tuple<USUARIO, double>(cl.First().Item1,cl.Sum(x => x.Item2))).ToList();
        }

        internal static void ActualizarHorasProyectosActivos()
        {
            List<Proyecto> proyectos_activos = ObtenerProyectosActivos();
            decimal totalProy = 0;
            decimal totalSub = 0;
            foreach (var proyecto in proyectos_activos)
            {
                totalProy = 0;
                List<SUBPROYECTO> subproyectos = ObtenerSubproyectosHijos(proyecto);

                foreach (var subpro in subproyectos)
                {
                    List<SUBPROYECTO> subproyectosHijos = ControladorSubproyecto.ObtenerSubproyectosHijos(subpro);
                    List<Actividad_proyecto> actividades = ControladorActividades.ObtenerActividadesProyectoDeSubproyecto(subpro);
                    List<SUBPROYECTO> hijos;
                    totalSub = 0;

                    //Función recursiva para calcular las horas de los subproyectos hijos
                    foreach (var sub in subproyectosHijos)
                    {
                        totalSub += ControladorSubproyecto.ActualizarHorasSubproyecto(sub);
                    }

                    //Recorre las actividades y suma sus horas
                    foreach (var item in actividades)
                    {
                        item.cantidad_hora = (decimal)ControladorActividades.ObtenerHorasTotalesActividad(item);
                        ControladorActividades.ActualizarActividadProyecto(item);
                        totalSub += (decimal)ControladorActividades.ObtenerHorasTotalesActividad(item);
                    }

                    totalProy += totalSub;
                    subpro.horas_estimadas = totalSub;
                    ControladorSubproyecto.ActualizarSubproyecto(subpro);
                }
                proyecto.total_hora = totalProy;
                Update(proyecto);
            }           
        }
    }
}
