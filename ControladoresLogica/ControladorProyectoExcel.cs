using System;
using System.Resources;
using ClosedXML.Excel;
using Entidades;
using System.IO;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;

namespace ControladoresLogica
{
    public class ControladorProyectoExcel
    {
        private readonly ControladorProyecto _controladorProyecto = new ControladorProyecto();
        private readonly ControladorSubproyecto _controladorSubproyecto = new ControladorSubproyecto();

        private XLWorkbook _xlworkbook;
        private Proyecto _proyAux;

        private void OpenFile(string path)
        {
            //String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            //String strFilePath = Path.Combine(strAppPath, "Resources");
            //String strFullFilename = Path.Combine(strFilePath, "Sistema.xlsx");

            //_xlworkbook = new XLWorkbook(strFullFilename);
            //_xlworkbook.SaveAs(path);
            _xlworkbook = new XLWorkbook(path);
        }

        private void CloseFile()
        {
            //Genera de nuevo el excel para que se actualicen los ID
            new ControladorExportarExcel().ExportarDatosProyecto(_proyAux, false);
        }

        public void AgregarProyectoExcel(Entidades.Proyecto proyecto)
        {
            var orden = new int[100];
            orden[0] = 1;

            _proyAux = proyecto;
            
            OpenFile(proyecto.path+"\\"+proyecto.nombre_proyecto +".xlsx");

            foreach (IXLWorksheet worksheet in _xlworkbook.Worksheets)
            {
                if (worksheet.Name.ToLower().Contains("proyecto"))
                {
                    ImportarControlesPredeterminados(worksheet, proyecto);

                    SUBPROYECTO subAux;
                    //22 es la fila donde empiezan los nombres de los subproyectos, columna 2.
                    for (var i = 3; !string.IsNullOrEmpty(worksheet.Cell(i,2).Value.ToString()); i++)
                    {
                        int id;
                        SUBPROYECTO sub = null;
                        bool existeSubproyecto = false;
                        if( int.TryParse(worksheet.Cell(i, 1).Value.ToString(), out id))
                        {
                            sub = ControladorSubproyecto.BuscarPorId(id);
                        }
                        if (sub == null)
                        {
                            subAux = new SUBPROYECTO
                            {
                                nombre = worksheet.Cell(i, 3).Value.ToString(),
                                fecha_fin_estimada = DateTime.Today,
                                asignacion_automatica = true,
                                fecha_inicio_estimada = DateTime.Today,
                                fecha_inicio_real = DateTime.Today,
                                fecha_fin_real = DateTime.Today,
                                ot_cliente = worksheet.Cell(i, 6).Value.ToString(),
                                horas_estimadas = string.IsNullOrEmpty(worksheet.Cell(i, 7).Value.ToString()) ?
                                0 : Convert.ToInt32(worksheet.Cell(i, 7).Value.ToString()),
                                id_tipo_subproyecto = ControladorSubproyecto.ObtenerTipoSubproyectoPorNombre(worksheet.Cell(i, 4).Value.ToString()).id_tipo_subproyecto,
                            orden = 0,
                                id_hora_tipo_subproyecto = 0,
                                id_prioridad = 0,
                                observaciones = "",
                                ot = 0,
                                id_estado_proyecto = 0,
                                forzada_fecha_fin_estimada = false,
                                forzada_fecha_inicio_estimada = false,
                                genera_ot =
                               worksheet.Cell(i, 5).Value.ToString() == "SI",
                                id_proyecto = _proyAux.id_proyecto
                            };

                            ControladorSubproyecto.InsertarSubproyecto(subAux);
                        }
                        else
                        {
                            //Actualizacion de datos
                            subAux = sub;
                            subAux.nombre = worksheet.Cell(i, 3).Value.ToString();
                            subAux.ot_cliente = worksheet.Cell(i, 6).Value.ToString();
                            subAux.horas_estimadas = string.IsNullOrEmpty(worksheet.Cell(i, 6).Value.ToString()) ?
                                0 : Convert.ToInt32(worksheet.Cell(i, 7).Value.ToString());
                            subAux.genera_ot =
                               worksheet.Cell(i, 5).Value.ToString() != "NO";
                            subAux.id_tipo_subproyecto = ControladorSubproyecto.ObtenerTipoSubproyectoPorNombre(worksheet.Cell(i, 4).Value.ToString()).id_tipo_subproyecto;
                        }

                        if (subAux.nombre == null || subAux.nombre == "")
                        {
                            ControladorSubproyecto.EliminarSubproyecto(subAux);
                        }
                        else
                        {
                            //Asigna el nivel del subproyecto
                            int nivel = Convert.ToInt32(worksheet.Cell(i, 2).Value.ToString());
                            orden[nivel] = subAux.id_subproyecto;
                            subAux.id_subproyecto_padre = orden[nivel - 1];

                            //Actualiza la informacion
                            ControladorSubproyecto.ActualizarSubproyecto(subAux);

                            //Orden de trabajo. TODO verificar si ya tiene que no asigne otra
                            if (subAux.genera_ot == true)
                                ControladorSubproyecto.AsignarOT(subAux.id_subproyecto);
                        }                                          

                    }
                }
                else if (!worksheet.Name.ToLower().Contains("Template Dispositivo") && !worksheet.Name.ToLower().Contains("SOPORTE"))
                {
                    AgregarUnidades(worksheet);
                }
            }

            CloseFile();
            ControladorProyecto.ActualizarHorasSubproyecto(ControladorProyecto.ObtenerPorID(_proyAux.id_proyecto));

        }

        private void ImportarControlesPredeterminados(IXLWorksheet worksheet, Proyecto proyecto)
        {
            //Controles Predeterminados
            for (int i = 2; i < 15; i++)
            {
                Control control;
                List<Tipo_actividad> actividades = ControladorActividades.ObtenerTiposActividad();
                foreach (var tipo_act in actividades)
                {
                    if (worksheet.Cell(i, 9).Value.ToString().ToLower().Equals(tipo_act.descripcion.ToLower()))
                    {
                        CONTROL_SUBPROYECTO controlSub = ControladorControles.VerificarExistencia(tipo_act, proyecto);
                        control = ControladorControles.ObtenerPorNombre(worksheet.Cell(i, 10).Value.ToString());
                        if (control != null)
                        {
                            if (controlSub == null)
                            {
                                controlSub = new CONTROL_SUBPROYECTO()
                                {
                                    id_proyecto = proyecto.id_proyecto,
                                    id_control = control.id_control,
                                    id_subproyecto = null,
                                    id_tipo_actividad = tipo_act.id_tipo_actividad
                                };
                                ControladorControles.Insertar(controlSub);
                            }

                            //Existe, pero puede haber cambiado el tipo de actividad
                            else
                            {
                                controlSub.id_control = control.id_control;
                                ControladorControles.ActualizarControlSubproyecto(controlSub);
                            }
                        }
                        break;
                    }
                }
            }
            //Fin controles predeterminados
        }

        private void AgregarUnidades(IXLWorksheet worksheet)
        {
            var sub = ControladorSubproyecto.BuscarPorOTDeExportacion(worksheet.Name, _proyAux.id_proyecto);

            if (sub == null) return;

            decimal horasOC;
            bool isNumericOC = decimal.TryParse(worksheet.Cell(3, 3).GetFormattedString(), out horasOC);

            if (isNumericOC)
                sub.horas_orden_compra = horasOC;
            else
                sub.horas_orden_compra = null;

            ControladorSubproyecto.ActualizarSubproyecto(sub);

            int i;
            //Por si las dudas hayan escrito algo en la fila 9 (no deberian) porque anda mal la exportacion de Excel
            int j = 9;
            //Que columna?
            for (i = j; !string.IsNullOrEmpty(worksheet.Cell(i, 2).Value.ToString()); i++)
            {
                int n;
                bool isNumeric = int.TryParse(worksheet.Cell(i, 4).GetFormattedString(), out n);
                HORA_TIPO_SUBPROYECTO hora_tipo = ControladorSubproyecto.ObtenerHoraTipoSubproyecto(worksheet.Cell(i, 3).Value.ToString());
                decimal? dec = null;
                var subAux = new SUBPROYECTO
                {    
                    nombre = worksheet.Cell(i, 2).Value.ToString(),
                    fecha_fin_estimada = DateTime.Today,
                    asignacion_automatica = true,
                    fecha_inicio_estimada = DateTime.Today,
                    fecha_inicio_real = DateTime.Today,
                    fecha_fin_real = DateTime.Today,
                    ot_cliente = "",                    
                    id_tipo_subproyecto = 4,
                    orden = 0,
                    id_hora_tipo_subproyecto = hora_tipo == null ? 0: hora_tipo.id_hora_tipo_subproyecto,
                    horas_estimadas = isNumeric ? n : hora_tipo == null ? 0 : hora_tipo.id_hora_tipo_subproyecto > 0 ? ControladorSubproyecto.ObtenerHoraTipoSubproyecto(worksheet.Cell(i, 3).Value.ToString()).horas : 0,
                    id_prioridad = 0,
                    observaciones = "",
                    ot = i - 9,
                    id_estado_proyecto = 0,
                    forzada_fecha_fin_estimada = false,
                    forzada_fecha_inicio_estimada = false,
                    genera_ot = false,
                    id_proyecto = _proyAux.id_proyecto                    
                };

                //mp existe
                //TODO ACTUALIZAR
                int id;
                SUBPROYECTO subPro = null;
                bool existeSubproyecto = false;
                SUBPROYECTO sub2 = null;
                if (int.TryParse(worksheet.Cell(i, 1).Value.ToString(), out id))
                {
                    sub2 = ControladorSubproyecto.BuscarPorId(id);
                }
                if (sub2 == null)
                {
                    ControladorSubproyecto.InsertarSubproyecto(subAux);
                    subAux.id_subproyecto_padre = sub.id_subproyecto;
                    ControladorSubproyecto.ActualizarSubproyecto(subAux);                   
                    //Check
                    CrearActividades(subAux);
                    subAux.horas_orden_compra = (decimal)ControladorSubproyecto.CalcularHorasOrdenCompra(subAux);
                    ControladorSubproyecto.ActualizarSubproyecto(subAux);
                }
                else
                {
                    sub2.nombre = worksheet.Cell(i, 2).Value.ToString();
                    sub2.id_hora_tipo_subproyecto = subAux.id_hora_tipo_subproyecto;
                    sub2.horas_estimadas = ControladorSubproyecto.CalcularHorasOrdenCompra(subAux) != null ? Convert.ToDecimal(ControladorSubproyecto.CalcularHorasOrdenCompra(subAux).Value.ToString("#.##")) : 0;
                    sub2.orden = subAux.orden;

                    //Eliminar subproyecto
                    if (sub2.nombre == null || sub2.nombre == "")
                    {
                        ControladorSubproyecto.EliminarSubproyecto(sub2);
                    }
                    else
                    {
                        ControladorSubproyecto.ActualizarSubproyecto(sub2);
                        decimal? valor = (decimal)ControladorSubproyecto.CalcularHorasOrdenCompra(sub2);
                        sub2.horas_orden_compra = ControladorSubproyecto.CalcularHorasOrdenCompra(sub2).HasValue ? decimal.Round((decimal)ControladorSubproyecto.CalcularHorasOrdenCompra(sub2).Value, 2, MidpointRounding.AwayFromZero) : 0;
                        ControladorSubproyecto.ActualizarSubproyecto(sub2);
                    }
                    
                }                
                   
            }

            List<Actividad> listaActividades = ControladorActividades.ObtenerActividadesDeSubproyecto(sub);
            for (i = 9; !string.IsNullOrEmpty(worksheet.Cell(i, 7).Value.ToString()); i++)
            {                
                string nombre = worksheet.Cell(i, 7).Value.ToString();
                if (listaActividades.Count == 0 || !listaActividades.Where(x => x.nombre_actividad == nombre).Any())
                    CrearActividad(sub, ControladorActividades.ObtenerTipoActividad(nombre) == null ? 1 : ControladorActividades.ObtenerTipoActividad(nombre).id_tipo_actividad, nombre, listaActividades.Count == 0 ? 1 : listaActividades.Count + 1);
            }
        }

        private void CrearActividades(SUBPROYECTO Subproyecto)
        {
            CrearActividad(Subproyecto, ControladorActividades.ObtenerTipoActividad("Concepto") == null ? 1 : ControladorActividades.ObtenerTipoActividad("Concepto").id_tipo_actividad, "Concepto", 1);
            CrearActividad(Subproyecto, ControladorActividades.ObtenerTipoActividad("Preparación") == null ? 1 : ControladorActividades.ObtenerTipoActividad("Preparación").id_tipo_actividad, "Preparación", 2);
            CrearActividad(Subproyecto, ControladorActividades.ObtenerTipoActividad("Detallado") == null ? 1 : ControladorActividades.ObtenerTipoActividad("Detallado").id_tipo_actividad, "Detallado", 3);
        }

        private void CrearActividad(SUBPROYECTO Subproyecto, int idTipoActividad, string nombre, int orden)
        {
            //TODO controlar duplicaciones
            var actAux = ControladorActividades.InsertarActividad(
                new Entidades.Actividad(
                    ControladorActividades.ObtenerTipoActividad(idTipoActividad).criticidad, 
                    idTipoActividad,
                    nombre,
                    1));
            var actpro = ControladorActividades.InsertarActividadProyecto(new Actividad_proyecto(
                _proyAux.id_proyecto,
                actAux.id_actividad,
                fecha_inicio: DateTime.Now,
                fecha_fin_previsto: DateTime.Now,
                fecha_fin_real: DateTime.Now,
                cantidad_hora: 0,//Se actualiza después
                objetivo: "",
                prioridad: 1,
                complejidad: 1,
                avance: 0,
                observacion: "",
                orden: orden,
                id_controlador_1: 8,
                id_controlador_2: 8,
                nro: 0,
                id_cliente: _proyAux.id_cliente.HasValue ? _proyAux.id_cliente.Value : 0, 
                id_subproyecto: Subproyecto.id_subproyecto, 
                horas: 0, 
                id_estado_proyecto: 0, 
                porcentaje_avance: 0, 
                fecha_inicio_real: DateTime.Now, 
                asignada: false, 
                id_cadista: 0, 
                id_prioridad: 1, 
                id_control: 0, 
                id_proveedor: 0, 
                forzada_fecha_fin: false, 
                forzada_fecha_inicio: false, 
                no_conformidad: false, 
                motivo_no_conformidad: "", 
                asignable: true));

            //ControladorTareas.VerificarAsignacionAutomatica(actpro);
        }
    }
}
