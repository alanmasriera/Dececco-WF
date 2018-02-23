using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Entidades;
using System.Reflection;

namespace ControladoresLogica
{
    public class ControladorExportarExcelGantt
    {
        private readonly ControladorProyecto _controladorProyecto = new ControladorProyecto();
        private readonly ControladorSubproyecto _controladorSubproyecto = new ControladorSubproyecto();

        private XLWorkbook _xlworkbook;
        private Proyecto _proyAux;

        string path;

        public ControladorExportarExcelGantt(string path1)
        {
            this.path = path1;
        }

        private bool OpenFile()
        {
            if (path == null) return false;

            if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

            Stream str = GetResourceStream("Project.xlsx");
            
            _xlworkbook = new XLWorkbook(str);

            return true;
            
        }

        protected static Stream GetResourceStream(string resourcePath)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<string> resourceNames = new List<string>(assembly.GetManifestResourceNames());

            resourcePath = resourcePath.Replace(@"/", ".");
            resourcePath = resourceNames.FirstOrDefault(r => r.Contains(resourcePath));

            if (resourcePath == null)
                throw new FileNotFoundException("Resource not found");

            return assembly.GetManifestResourceStream(resourcePath);
        }



        private bool CloseFile()
        {


            try
            {
                //if (File.Exists(path)) File.Delete(fileName);
                _xlworkbook.SaveAs(path + "\\" + "Gantt" + ".xlsx");
            }
            catch (IOException)
            {
                return false;
            }
           
            return true;
        }
        

        public void ExportarTodosProyectos()
        {
            List<Proyecto> proyectos = ControladorProyecto.ObtenerProyectosActivos();
            if (OpenFile())
            {
                IXLWorksheet _worksheetProyecto = _xlworkbook.Worksheet("Tabla_Tareas");
                List<ClaseExpGantt> estructura;

                int fila = 2;
                int filaAsig = 2;

                CrearRecursos();

                foreach (var item in proyectos)
                {
                    estructura = _controladorProyecto.ObtenerEstructuraProyectoConActividades(item);



                    _worksheetProyecto.Cell(fila, 1).Value = fila - 1;
                    _worksheetProyecto.Cell(fila, 2).Value = "Sí";
                    _worksheetProyecto.Cell(fila, 3).Value = "Programada manualmente";
                    _worksheetProyecto.Cell(fila, 4).Value = item.nombre_proyecto;
                    _worksheetProyecto.Cell(fila, 5).Value = item.total_hora + " horas";
                    _worksheetProyecto.Cell(fila, 6).Value = ControladorTareas.CalcularFechaInicioProyecto(item);
                    _worksheetProyecto.Cell(fila, 7).Value = ControladorTareas.CalcularFechaFinProyecto(item);
                    _worksheetProyecto.Cell(fila, 9).Value = 1;

                    fila++;

                    foreach (ClaseExpGantt subproyecto in estructura)
                    {
                        filaAsig = CrearAsignacion(subproyecto, filaAsig, fila - 1);

                        if (subproyecto.subproyecto != null)
                        {
                            _worksheetProyecto.Cell(fila, 1).Value = fila - 1;
                            _worksheetProyecto.Cell(fila, 2).Value = "Sí";
                            _worksheetProyecto.Cell(fila, 3).Value = "Programada manualmente";
                            _worksheetProyecto.Cell(fila, 4).Value = subproyecto.subproyecto.nombre;
                            _worksheetProyecto.Cell(fila, 5).Value = subproyecto.subproyecto.horas_estimadas + " horas";// ControladorSubproyecto.ObtenerHorasOrdenCompra(subproyecto.subproyecto) + " horas";
                            _worksheetProyecto.Cell(fila, 6).Value = ControladorTareas.CalcularFechaInicioSubproyecto(subproyecto.subproyecto);
                            _worksheetProyecto.Cell(fila, 7).Value = ControladorTareas.CalcularFechaFinSubproyecto(subproyecto.subproyecto);
                            _worksheetProyecto.Cell(fila, 9).Value = subproyecto.nivel + 1;
                        }
                        else
                        {
                            _worksheetProyecto.Cell(fila, 1).Value = fila - 1;
                            _worksheetProyecto.Cell(fila, 2).Value = "Sí";
                            _worksheetProyecto.Cell(fila, 3).Value = "Programada automáticamente";
                            _worksheetProyecto.Cell(fila, 4).Value = subproyecto.actividad.nombre_actividad;

                            if (subproyecto.tarea != null)
                            {
                                if (subproyecto.actividad.id_tipo_actividad == ControladorActividades.ObtenerTipoActividad("prepa").id_tipo_actividad
                                    || subproyecto.actividad.id_tipo_actividad == ControladorActividades.ObtenerTipoActividad("deta").id_tipo_actividad)
                                {
                                    //Predecesores
                                    //_worksheetProyecto.Cell(fila, 8).Value = fila - 2;
                                }

                                _worksheetProyecto.Cell(fila, 4).Value = subproyecto.actividad.nombre_actividad + " - " + subproyecto.usuario.FullName;
                                _worksheetProyecto.Cell(fila, 5).Value = subproyecto.tarea.cantidad_hora + " horas";
                                _worksheetProyecto.Cell(fila, 6).Value = subproyecto.tarea.fecha_inicio;
                                _worksheetProyecto.Cell(fila, 7).Value = subproyecto.tarea.fecha_fin;
                                _worksheetProyecto.Cell(fila, 11).Value = subproyecto.actividadProy.id_actividad_proyecto;
                            }

                            _worksheetProyecto.Cell(fila, 9).Value = subproyecto.nivel + 1;
                        }

                        fila++;
                    }
                }

                if (CloseFile())
                {
                    System.Diagnostics.Process.Start(path + "\\" + "Gantt" + ".xlsx");
                }
            }            
        }


        private void CrearRecursos()
        {
            IXLWorksheet _worksheetProyecto = _xlworkbook.Worksheet("Tabla_Recursos");
            List<USUARIO> usuarios = ControladorUsuarios.ObtenerTodosUsuarios().Where(x => x.activo == true).ToList();

            int fila = 2;

            foreach (var item in usuarios)
            {
                _worksheetProyecto.Cell(fila, 1).Value = fila - 1;
                _worksheetProyecto.Cell(fila, 2).Value = item.FullName;
                _worksheetProyecto.Cell(fila, 3).Value = item.nombre.ToCharArray().ElementAt(0).ToString().ToUpper() + item.apellido.ToCharArray().ElementAt(0).ToString().ToUpper();
                _worksheetProyecto.Cell(fila, 4).Value = "Trabajo";
                _worksheetProyecto.Cell(fila, 5).Value = "";
                _worksheetProyecto.Cell(fila, 6).Value = "Descar";
                _worksheetProyecto.Cell(fila, 9).Value = "100%";
                _worksheetProyecto.Cell(fila, 10).Value = "$ 0.00/h";
                _worksheetProyecto.Cell(fila, 10).Value = 0;

                fila++;
            }
        }

        private int CrearAsignacion(ClaseExpGantt item,int fila, int id)
        {
            IXLWorksheet _worksheetProyecto = _xlworkbook.Worksheet("Tabla_asignación");

            //foreach (var item in estructura)
            //{
                if (item.tarea != null)
                {
                    _worksheetProyecto.Cell(fila, 1).Value = item.actividad.nombre_actividad + " - " + item.usuario.nombre + " " + item.usuario.apellido;
                    _worksheetProyecto.Cell(fila, 2).Value = item.usuario.FullName;
                    _worksheetProyecto.Cell(fila, 3).Value = "0%";
                    _worksheetProyecto.Cell(fila, 4).Value = item.tarea.cantidad_hora + "h";
                    _worksheetProyecto.Cell(fila, 5).Value = "100%";
                    _worksheetProyecto.Cell(fila, 6).Value = id;

                    fila++;
                }                    
            //}
                        
            return fila;
        }



        public bool ExportarDatosProyecto(Proyecto proyecto, bool abrir)
        {
            _proyAux = proyecto;
            OpenFile();
            IXLWorksheet _worksheetProyecto = _xlworkbook.Worksheet("Tabla_Tareas");

            List<ClaseExpGantt> estructura;
            estructura = _controladorProyecto.ObtenerEstructuraProyectoConActividades(proyecto);

            //ExportarControlesPredeterminados(_worksheetProyecto, proyecto);

            int fila = 2;

            foreach (ClaseExpGantt subproyecto in estructura)
            {
                //No las unidades
                //if (subproyecto.Item1.id_tipo_subproyecto != 4)
                //{
                    //Formato
                    //_worksheetProyecto.Range(_worksheetProyecto.Cell(fila, 1), _worksheetProyecto.Cell(fila, 7)).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    //_worksheetProyecto.Range(_worksheetProyecto.Cell(fila, 1), _worksheetProyecto.Cell(fila, 7)).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                if (subproyecto.subproyecto != null)
                {
                    _worksheetProyecto.Cell(fila, 1).Value = estructura.IndexOf(subproyecto) +1;
                    _worksheetProyecto.Cell(fila, 2).Value = "Sí";
                    _worksheetProyecto.Cell(fila, 3).Value = "Programada automáticamente";
                    _worksheetProyecto.Cell(fila, 4).Value = subproyecto.subproyecto.nombre;
                    _worksheetProyecto.Cell(fila, 5).Value = ControladorSubproyecto.ObtenerHorasOrdenCompra(subproyecto.subproyecto) + " horas";
                    _worksheetProyecto.Cell(fila, 6).Value = subproyecto.subproyecto.fecha_inicio_estimada;
                    _worksheetProyecto.Cell(fila, 7).Value = subproyecto.subproyecto.fecha_fin_estimada;
                    _worksheetProyecto.Cell(fila, 9).Value = subproyecto.nivel;
                }
                else
                {
                    _worksheetProyecto.Cell(fila, 1).Value = estructura.IndexOf(subproyecto) +1;
                    _worksheetProyecto.Cell(fila, 2).Value = "Sí";
                    _worksheetProyecto.Cell(fila, 3).Value = "Programada automáticamente";
                    _worksheetProyecto.Cell(fila, 4).Value = subproyecto.actividad.nombre_actividad + " - " + subproyecto.usuario.nombre + " " + subproyecto.usuario.apellido ;
                    _worksheetProyecto.Cell(fila, 5).Value = subproyecto.tarea.cantidad_hora + " horas";
                    _worksheetProyecto.Cell(fila, 6).Value = subproyecto.tarea.fecha_inicio;
                    _worksheetProyecto.Cell(fila, 7).Value = subproyecto.tarea.fecha_fin;
                    _worksheetProyecto.Cell(fila, 9).Value = subproyecto.nivel;
                }

                    

                fila++;
               
            }

            if (CloseFile())
            {
                if (abrir)
                    System.Diagnostics.Process.Start(path + "\\" + "Prueba" + ".xlsx");
                return true;
            }
            else
            {
                return false;
            }
                
            
        }

    }
}
