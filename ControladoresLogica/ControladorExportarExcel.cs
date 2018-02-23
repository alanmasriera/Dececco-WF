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
    public class ControladorExportarExcel
    {
        private readonly ControladorProyecto _controladorProyecto = new ControladorProyecto();
        private readonly ControladorSubproyecto _controladorSubproyecto = new ControladorSubproyecto();

        private XLWorkbook _xlworkbook;
        private Proyecto _proyAux;

        private void OpenFile()
        {
            if (string.IsNullOrEmpty(_proyAux.path))
            {
                _proyAux.path = @"E:\Proyectos\Exportaciones Excel\" + ControladorClientes.ObtenerCLiente(_proyAux.id_cliente).nombre_cliente + @"\" + _proyAux.nombre_proyecto;
                //_proyAux.path = @"C:\Users\infodba\Documents\Descar\export\" + _proyAux.nombre_proyecto;
                ControladorProyecto.Update(_proyAux);

                if (!Directory.Exists(_proyAux.path))
                    Directory.CreateDirectory(_proyAux.path);
            }
            Stream str = GetResourceStream("Sistema.xlsx");
            
            _xlworkbook = new XLWorkbook(str);
            ActualizarDesdeBaseDatos();
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
            string fileName = _proyAux.path;

            try
            {
                if (File.Exists(fileName)) File.Delete(fileName);
                _xlworkbook.SaveAs(_proyAux.path + "\\" + _proyAux.nombre_proyecto + ".xlsx");
            }
            catch (IOException)
            {
                return false;
            }
           
            return true;
        }

        private void ActualizarDesdeBaseDatos()
        {
            IXLWorksheet _worksheetProyecto = _xlworkbook.Worksheet("SOPORTE");

            List<USUARIO> usuarios = ControladorUsuarios.ObtenerTodosUsuarios();
            List<TIPO_SUBPROYECTO> tipoSubproyectos = ControladorSubproyecto.ObtenerTiposSubproyecto();
            List<HORA_TIPO_SUBPROYECTO> horaTipoSubproyectos = ControladorSubproyecto.ObtenerHorasTipoUnidad();
            List<Control> _controles = new ControladorControles().ObtenerTodos();

            int fila = 2;
            foreach (USUARIO usuario in usuarios)
            {
                _worksheetProyecto.Cell(fila, 3).Value = usuario.nombre + " " + usuario.apellido;
                fila++;
            }
            fila = 2;
            foreach (TIPO_SUBPROYECTO tipoSub in tipoSubproyectos)
            {
                _worksheetProyecto.Cell(fila, 4).Value = tipoSub.nombre_tipo_subproyecto;
                fila++;
            }
            fila = 2;
            foreach (HORA_TIPO_SUBPROYECTO horaUnidad in horaTipoSubproyectos)
            {
                _worksheetProyecto.Cell(fila, 5).Value = horaUnidad.nombre;
                _worksheetProyecto.Cell(fila, 6).Value = horaUnidad.horas;
                fila++;
            }

            fila = 2;
            foreach (Control control in _controles)
            {
                _worksheetProyecto.Cell(fila, 7).Value = control.nombre_control;
                fila++;
            }
            //_xlworkbook.Save();
        }

        public bool ExportarDatosProyecto(Proyecto proyecto, bool abrir)
        {
            _proyAux = proyecto;
            OpenFile();
            IXLWorksheet _worksheetProyecto = _xlworkbook.Worksheet("PROYECTO");
            List<Tuple<SUBPROYECTO, int>> estructura;

            estructura = _controladorProyecto.ObtenerEstructuraProyecto(proyecto);

            ExportarControlesPredeterminados(_worksheetProyecto, proyecto);

            int fila = 3;

            foreach (Tuple<SUBPROYECTO,int> subproyecto in estructura)
            {
                //No las unidades
                if (subproyecto.Item1.id_tipo_subproyecto != 4)
                {
                    //Formato
                    _worksheetProyecto.Range(_worksheetProyecto.Cell(fila, 1), _worksheetProyecto.Cell(fila, 7)).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    _worksheetProyecto.Range(_worksheetProyecto.Cell(fila, 1), _worksheetProyecto.Cell(fila, 7)).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                    _worksheetProyecto.Cell(fila, 1).Value =
                    subproyecto.Item1.id_subproyecto;
                    _worksheetProyecto.Cell(fila, 2).Value =
                    subproyecto.Item2;
                    _worksheetProyecto.Cell(fila, 3).Value =
                        subproyecto.Item1.nombre;
                    _worksheetProyecto.Cell(fila, 4).Value =
                        ControladorSubproyecto.ObtenerTipoSubproyecto(subproyecto.Item1).id_tipo_subproyecto > 0 ? ControladorSubproyecto.ObtenerTipoSubproyecto(subproyecto.Item1).nombre_tipo_subproyecto : "Sin asignar";
                    _worksheetProyecto.Range(_worksheetProyecto.Cell(fila, 5), _worksheetProyecto.Cell(fila, 4)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    _worksheetProyecto.Range(_worksheetProyecto.Cell(fila, 5), _worksheetProyecto.Cell(fila, 4)).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    _worksheetProyecto.Cell(fila, 5).Value = subproyecto.Item1.genera_ot.Value & subproyecto.Item1.ot > 0 ? subproyecto.Item1.ot.ToString() : "NO";
                    _worksheetProyecto.Cell(fila, 6).Value =
                        subproyecto.Item1.ot_cliente;
                    _worksheetProyecto.Cell(fila, 7).Value = ControladorSubproyecto.ObtenerHorasOrdenCompra(subproyecto.Item1);

                    fila++;
                }
                if (/*Simulacion*/ subproyecto.Item1.id_tipo_subproyecto == 7 || 
                    /*Dispositivo*/ subproyecto.Item1.id_tipo_subproyecto == 3 )
                {
                    GenerarDatosUnidades(subproyecto.Item1);
                }
            }

            if (CloseFile())
            {
                if (abrir)
                    System.Diagnostics.Process.Start(_proyAux.path + "\\" + _proyAux.nombre_proyecto + ".xlsx");
                return true;
            }
            else
            {
                return false;
            }
                
            
        }

        private void ExportarControlesPredeterminados(IXLWorksheet worksheet, Proyecto proyecto)
        {
            //Controles Predeterminados
            List<CONTROL_SUBPROYECTO> controles = ControladorControles.ObtenerControlesProyecto(proyecto);

            for (int i = 2; i < 15; i++)
            {
                worksheet.Cell(i, 10).Value = "";

                if (controles == null || controles.Count == 0)
                    continue;

                Control control;
                List<Tipo_actividad> actividades = ControladorActividades.ObtenerTiposActividad();

                foreach (var tipo_act in actividades)
                {
                    if (worksheet.Cell(i, 9).Value.ToString().ToLower().Equals(tipo_act.descripcion.ToLower()))
                    {
                        foreach (var ctrlSub in controles)
                        {
                            if (ctrlSub.id_tipo_actividad == tipo_act.id_tipo_actividad)
                            {
                                worksheet.Cell(i, 10).Value = ControladorControles.ObtenerPorID(ctrlSub.id_control).nombre_control;
                                break;
                            }
                        }                    
                        
                    }
                }
            }
            //Fin controles predeterminados
        }

        private void GenerarDatosUnidades(SUBPROYECTO sub)
        {
            IXLWorksheet _worksheetProyecto = _xlworkbook.Worksheet("Template Dispositivo");
            IXLWorksheet _worksheetSoporte = _xlworkbook.Worksheet("Soporte");

            IXLWorksheet sheetUnidad = _worksheetProyecto.CopyTo(sub.nombre.Length > 31 - sub.ot.Value.ToString().Length - 3 ? sub.ot + " - " + sub.nombre.Substring(0,31 - sub.ot.Value.ToString().Length -3) : sub.ot + " - " + sub.nombre, _worksheetProyecto.Position);
            sheetUnidad.Unhide();

            

            List<HORA_TIPO_SUBPROYECTO> _HORAS = ControladorSubproyecto.ObtenerHorasTipoUnidad();

            //Formato
            var dataV = sheetUnidad.Range("'+" + sheetUnidad.Name + "'!C9:C68").SetDataValidation();
            dataV.List(_worksheetSoporte.Range(_worksheetSoporte.Cell(2, 5), _worksheetSoporte.Cell(_HORAS.Count + 2, 5)));
            dataV.IgnoreBlanks = true;
            dataV.InCellDropdown = true;
            dataV.ShowInputMessage = true;
            dataV.ShowErrorMessage = true;
            dataV.ErrorStyle = ClosedXML.Excel.XLErrorStyle.Stop;


            sheetUnidad.Cell(1, 3).Value = sub.ot;
            sheetUnidad.Cell(2, 3).Value = sub.ot_cliente;
            sheetUnidad.Cell(3, 3).Value = sub.horas_orden_compra.HasValue ? sub.horas_orden_compra : null;

            int fila = 9;

            List<SUBPROYECTO> subproyectos = ControladorSubproyecto.ObtenerSubproyectosHijos(sub);
            List<Actividad_proyecto> actividades;

            foreach (var subproyecto in subproyectos)
            {

                sheetUnidad.Cell(fila, 1).Value = subproyecto.id_subproyecto;

                sheetUnidad.Cell(fila, 2).Value = subproyecto.nombre;
                HORA_TIPO_SUBPROYECTO hora =
                    ControladorSubproyecto.ObtenerHoraTipoSubproyecto(subproyecto.id_hora_tipo_subproyecto);

                if (hora != null)
                {
                    sheetUnidad.Cell(fila, 3).Value = hora.nombre;
                    //sheetUnidad.Cell(fila, 4).Value = hora.horas;
                }
                else
                {
                    sheetUnidad.Cell(fila, 3).Value = "";
                    sheetUnidad.Cell(fila, 4).Value = ControladorSubproyecto.CalcularHorasOrdenCompra(subproyecto);
                }

                sheetUnidad.Cell(fila, 5).Value = decimal.Round((decimal)ControladorSubproyecto.CalcularHorasOrdenCompra(subproyecto),2);

                actividades = ControladorSubproyecto.ObtenerActividades(subproyecto);

                int columna = 0;
                foreach (var acti in actividades)
                {
                    switch (ControladorActividades.ObtenerActividad(acti).id_tipo_actividad)
                    {
                        //Concepto
                        case 2:
                            columna = 9;
                            break;
                        case 3:
                            columna = 22;
                            break;
                        case 4:
                            columna = 35;
                            break;
                        default:
                            columna = -1;
                            break;
                    }
                    if (columna > 0)
                    {
                        decimal horaConsumida = (decimal)(Math.Round(ControladorActividades.ObtenerHorasConsumidas(acti, "prod"), 2));
                        decimal horaAsignada = (decimal)ControladorActividades.ObtenerHorasAsignadasPorOrdenCompra(acti) * (decimal)0.85;
                        USUARIO responsablePro =
                            ControladorActividades.ObtenerResponsableProduccion(acti.id_actividad_proyecto);

                        sheetUnidad.Cell(fila, columna + 1).DataType = XLCellValues.Number;
                        sheetUnidad.Cell(fila, columna + 1).Value = horaConsumida;
                        sheetUnidad.Cell(fila, columna + 2).Value = decimal.Round(horaAsignada,2);
                        sheetUnidad.Cell(fila, columna + 3).Value = horaAsignada > 0 ? decimal.Round(horaConsumida / horaAsignada * 100, 2) + "%" : "0%";
                        sheetUnidad.Cell(fila, columna + 4).Value = responsablePro != null ? responsablePro.nombre + " " +
                                                                    responsablePro.apellido : "Sin asignar";
                        sheetUnidad.Cell(fila, columna + 4).WorksheetColumn().AdjustToContents();

                        columna += 4;
                        //Control
                        horaConsumida = (decimal)(Math.Round(ControladorActividades.ObtenerHorasConsumidas(acti, "calidad"), 2));
                        horaAsignada = (decimal)(ControladorActividades.ObtenerHorasAsignadasPorOrdenCompra(acti) *0.10);
                        responsablePro =
                            ControladorActividades.ObtenerResponsableControln(acti.id_actividad_proyecto);

                        sheetUnidad.Cell(fila, columna + 1).DataType = XLCellValues.Number;
                        sheetUnidad.Cell(fila, columna + 1).Value = horaConsumida;
                        sheetUnidad.Cell(fila, columna + 2).Value = decimal.Round(horaAsignada, 2);
                        sheetUnidad.Cell(fila, columna + 3).Value = horaAsignada > 0 ? decimal.Round(horaConsumida / horaAsignada * 100, 2) + "%" : "0%";
                        sheetUnidad.Cell(fila, columna + 4).Value = responsablePro != null ? responsablePro.nombre + " " +
                                                                    responsablePro.apellido : "Sin asignar";
                        sheetUnidad.Cell(fila, columna + 4).WorksheetColumn().AdjustToContents();

                        columna += 4;
                        //Correccion
                        horaConsumida = (decimal)(Math.Round(ControladorActividades.ObtenerHorasConsumidas(acti, "correc"), 2));
                        horaAsignada = (decimal)(ControladorActividades.ObtenerHorasAsignadasPorOrdenCompra(acti) * 0.05);
                        responsablePro =
                            ControladorActividades.ObtenerResponsableCorreccion(acti.id_actividad_proyecto);

                        sheetUnidad.Cell(fila, columna + 1).DataType = XLCellValues.Number;
                        sheetUnidad.Cell(fila, columna + 1).Value = horaConsumida;
                        sheetUnidad.Cell(fila, columna + 2).Value = decimal.Round(horaAsignada, 2);
                        sheetUnidad.Cell(fila, columna + 3).Value = horaAsignada > 0 ? decimal.Round(horaConsumida / horaAsignada * 100,2) + "%" : "0%";
                        sheetUnidad.Cell(fila, columna + 4).Value = responsablePro != null ? responsablePro.nombre + " " +
                                                                    responsablePro.apellido : "Sin asignar";
                        sheetUnidad.Cell(fila, columna + 4).WorksheetColumn().AdjustToContents();
                    }
                    
                }
                fila++;

            }

            //Otras actividades

            fila = 9;
            List<Actividad_proyecto> listaActividades = ControladorSubproyecto.ObtenerActividades(sub);
            foreach (Actividad_proyecto actividad in listaActividades)
            {
                sheetUnidad.Cell(fila, 7).Value = ControladorActividades.ObtenerActividad(actividad).nombre_actividad;
                fila++;
            }

        }
    }
}
