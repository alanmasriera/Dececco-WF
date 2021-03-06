Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Proyecto
    Inherits Proyecto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAllFirst() As DataTable
        Dim odt As New DataTable("Proyecto")
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetAllFirst", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetTree() As DataTable
        Dim odt As New DataTable("Proyecto")
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetTree", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetClientes() As DataTable
        Dim odt As New DataTable("Proyecto")
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetClientes", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetTreeArchivado() As DataTable
        Dim odt As New DataTable("Proyecto")
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetTreeArchivado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetTree_2(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetTree_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetTree_conCliente(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetTree_conCliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetTree_conCliente_nvaImpl(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetTree_conCliente_nvaImpl", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)
        Return odt
    End Function


    Public Function GetTree_Padre(ByVal id_proyecto_padre As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetTreePadre", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto_padre", SqlDbType.Int, 4, "id_proyecto_padre")
        oda.SelectCommand.Parameters("@id_proyecto_padre").Value = id_proyecto_padre

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetTree_Padre_2(ByVal id_proyecto_padre As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetTreePadre_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto_padre", SqlDbType.Int, 4, "id_proyecto_padre")
        oda.SelectCommand.Parameters("@id_proyecto_padre").Value = id_proyecto_padre

        oda.Fill(odt)
        Return odt
    End Function


    'consulta duplicado
    Public Function GetAllExiste(ByVal nombre_proyecto As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetAllExiste", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_proyecto", SqlDbType.VarChar, 500, "nombre_proyecto")
        oda.SelectCommand.Parameters("@nombre_proyecto").Value = nombre_proyecto

        oda.Fill(odt)
        Return odt
    End Function
    'consulta duplicado en el directorio actual
    Public Function GetAllExiste2(ByVal id_proyecto_padre As Integer, ByVal nombre_proyecto As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_ExisteEndir", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto_padre", SqlDbType.Int, 4, "id_proyecto_padre")
        oda.SelectCommand.Parameters("@id_proyecto_padre").Value = id_proyecto_padre

        oda.SelectCommand.Parameters.Add("@nombre_proyecto", SqlDbType.VarChar, 500, "nombre_proyecto")
        oda.SelectCommand.Parameters("@nombre_proyecto").Value = nombre_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    'combo sin los archivados
    Public Function GetCmbArchivado() As DataTable
        Dim odt As New DataTable("Proyecto")
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetCmbArchivado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'agregado para traer las facturas para los proyectos en el arbol
    Public Function GetAll_facturas(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetAll_facturas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.Fill(odt)
        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne_2(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetCliente(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_obtenerCliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetResponsables(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_obtenerResponsables", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetFechas(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_obtenerFechas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetUnidades(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_getProyectosHijos", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)

        Return odt
    End Function


    Public Function GetHorasTrabajadas(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllConsumida_Proyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetHorasTrabajadasSubproyecto(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllConsumida_Subproyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetProyecto(ByVal id_Proyecto As Integer) As Proyecto
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetOne", cnn.Coneccion)
        Dim proyecto As New Proyecto

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)

        proyecto.Cargar()
        proyecto.Insertar()
        proyecto.fecha_fin_prevista = CType(odt.Rows(0).Item("fecha fin prevista"), Date)
        proyecto.fecha_inicio = CType(odt.Rows(0).Item("fecha inicio"), Date)
        proyecto.fecha_fin_real = CType(odt.Rows(0).Item("fecha fin real"), Date)
        proyecto.descripcion = odt.Rows(0).Item("descripcion").ToString()
        proyecto.nombre_proyecto = odt.Rows(0).Item("nombre proyecto").ToString()
        proyecto.id_cliente = CInt(odt.Rows(0).Item("id cliente").ToString())
        proyecto.id_proyecto_padre = CInt(odt.Rows(0).Item("id proyecto padre").ToString())
        proyecto.orden = odt.Rows(0).Item("orden").ToString()
        proyecto.id_estado = CInt(odt.Rows(0).Item("id estado").ToString())
        proyecto.total_hora = CType(odt.Rows(0).Item("total hora").ToString(), Decimal)
        proyecto.prioridad = CType(odt.Rows(0).Item("prioridad").ToString(), Decimal)
        proyecto.observacion = odt.Rows(0).Item("observacion").ToString()
        proyecto.id_controlador_1 = CInt(odt.Rows(0).Item("id controlador 1").ToString())
        proyecto.id_controlador_2 = CInt(odt.Rows(0).Item("id controlador 2").ToString())
        proyecto.path = odt.Rows(0).Item("path").ToString()
        proyecto.archivado = CBool(odt.Rows(0).Item("archivado").ToString())
        proyecto.indice = CInt(odt.Rows(0).Item("indice").ToString())
        proyecto.nro = CInt(odt.Rows(0).Item("nro").ToString())
        If Not String.IsNullOrEmpty(odt.Rows(0).Item("id piloto").ToString()) Then
            proyecto.id_piloto = CInt(odt.Rows(0).Item("id piloto").ToString())
        Else
            proyecto.id_piloto = 0
        End If


        Return proyecto

    End Function

    Public Function ObtenerAvanceConcepto(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_proyecto_obtenerAvanceConcepto", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerAvanceConcepto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ObtenerAvancePreparacion(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerAvancePreparacion", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ObtenerAvanceDetallado(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerAvanceDetallado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ObtenerUsuarioLogueado(ByVal id_subproyecto As Integer, ByVal tipo_actividad As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_obtenerLogueadoDiaActual", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        oda.SelectCommand.Parameters.Add("@tipo_actividad", SqlDbType.VarChar, 50, "tipo_actividad")
        oda.SelectCommand.Parameters("@tipo_actividad").Value = tipo_actividad

        oda.Fill(odt)

        Return odt
    End Function

    Public Function estaLogueado(ByVal id_subproyecto As Integer, ByVal tipo_actividad As String, ByVal id_usuario As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_proyectoLogueadoAhora", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        oda.SelectCommand.Parameters.Add("@tipo_actividad", SqlDbType.VarChar, 50, "tipo_actividad")
        oda.SelectCommand.Parameters("@tipo_actividad").Value = tipo_actividad
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        If odt.Rows.Count > 0 Then
            Return True
        End If

        Return False
    End Function

    'Cuyo padre tiene id_padre = 1
    Public Function ObtenerProyectos(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetAllProyectos", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)

        Return odt
    End Function


    Public Function ObtenerClienteProyecto(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_obtenerClienteProyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Sub AgregarOT(ByVal id_proyecto As Integer)
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_agregarOT", cnn.Coneccion)

        oda.InsertCommand = New SqlCommand("cop_proyecto_agregarOT", cnn.Coneccion)
        oda.InsertCommand.CommandType = CommandType.StoredProcedure
        oda.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 6, "id_proyecto")
        oda.InsertCommand.Parameters("@id_proyecto").Value = id_proyecto
        cnn.Abrir()
        oda.InsertCommand.ExecuteNonQuery()
        cnn.Cerrar()

    End Sub

    Public Function ObtenerPorOT(ByVal ot_interna As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_obtenerPorOT", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@ot_interna", SqlDbType.VarChar, 50, "ot_interna")
        oda.SelectCommand.Parameters("@ot_interna").Value = ot_interna

        oda.Fill(odt)

        If odt.Rows.Count > 0 Then
            Return odt
        Else
            Return Nothing
        End If

    End Function

    Public Function ObtenerActividadesControl(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_proyecto_obtenerActividadesControles", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ObtenerHorasDisponiblesProyecto(ByVal id_Proyecto As Integer) As Double
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_obtenerHorasDisponiblesProyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)
        If odt.Rows.Count > 0 Then
            Return Convert.ToDouble(odt.Rows.Item(0).Item("total_hora"))
        Else
            Return -1
        End If

    End Function

    Public Function EsHoraCorrecta(ByVal id_Proyecto As Integer, ByVal cantidad_horas As Double) As Boolean

        Return cantidad_horas <=  ControladoresLogica.ControladorProyecto.ObtenerHorasMinimasProyecto(ControladoresLogica.ControladorProyecto.ObtenerPorID(id_Proyecto))

    End Function

    Public Function ObtenerNroOrdenTrabajo(ByVal id_proyecto As Integer) As Integer
        dt = New DataTable("Subproyecto")
        da = New SqlClient.SqlDataAdapter("SELECT ot.nro_orden_trabajo FROM ORDEN_TRABAJO ot, Proyecto p WHERE  @id_proyecto = p.id_proyecto and p.orden = ot.id_orden_trabajo", cnn.Coneccion)
        da.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 6, "id_proyecto")
        da.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            Return 0
        End If

        Return CInt(dt.Rows(0).Item("nro_orden_trabajo"))
    End Function

    Public Sub CargarDesdeExcel(ByVal file_location As String)
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkBooks As Excel.Workbooks

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBooks = xlApp.Workbooks
        xlWorkBook = xlWorkBooks.Open(file_location, 0, True)

        ''Dim xlWorkSheet As Excel.Worksheet = DirectCast(xlWorkBook.Worksheets.Item(1), Excel.Worksheet)
        Dim xlWorkSheet As Excel.Worksheet

        Dim nuevo_proyecto As New Proyecto
        Dim nuevo_subproyecto As New entSubproyecto

        Dim id_operacion, id_unidad, id_proyecto As Integer

        With nuevo_proyecto
            .Cargar()
            .Insertar()
            .nombre_proyecto = xlWorkBook.Name
            .id_cliente = 2
            .Guardar()
            id_proyecto = .id_proyecto
            .AgregarOT(id_proyecto)
        End With

        For Each worksheet As Excel.Worksheet In xlWorkBook.Worksheets

            With nuevo_subproyecto
                .Cargar()
                .Insertar()
                .nombre = worksheet.Name
                .horas_estimadas = 10
                .id_proyecto = id_proyecto
                .id_subproyecto_padre = 1
                .genera_ot = False
                .Guardar()
                id_operacion = .id_suproyecto

                ''TODO
            End With

            Dim i As Integer = 2
            While Not String.IsNullOrEmpty(worksheet.Range(worksheet.Cells(i, 1), worksheet.Cells(i, 1)).Text.ToString()) _
                                           And worksheet.Range(worksheet.Cells(i, 1), worksheet.Cells(i, 1)).Text.ToString().Trim() <> "Totales"
                With nuevo_subproyecto
                    .Cargar()
                    .Insertar()
                    .nombre = worksheet.Range(worksheet.Cells(i, 1), worksheet.Cells(i, 1)).Text.ToString()
                    .id_proyecto = id_proyecto
                    .id_subproyecto_padre = id_operacion
                    .genera_ot = False
                    .Guardar()
                    id_unidad = .id_suproyecto
                End With

                nuevo_subproyecto.AgregarActividad(id_proyecto, id_unidad, 2, "Concepto")
                nuevo_subproyecto.AgregarActividad(id_proyecto, id_unidad, 3, "Preparación")
                nuevo_subproyecto.AgregarActividad(id_proyecto, id_unidad, 4, "Detallado")


                i = i + 1
            End While

        Next

        xlWorkBook.Close(False)
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)


    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class



