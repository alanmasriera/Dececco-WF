Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class entTipo_Subproyecto

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    ''

    ''' Gets or Sets id_proyecto
    '''

    Public Property id_tipo_actividad() As Integer
        Get
            _id_tipo_actividad = CInt(dr("_id_tipo_actividad"))
            Return _id_tipo_actividad
        End Get
        Set(value As Integer)
            dr("_id_tipo_actividad") = value
        End Set
    End Property
    Private _id_tipo_actividad As Integer

    ''

    ''' Gets or Sets id_tipo_subproyecto
    '''

    Public Property id_tipo_subproyecto() As Integer
        Get
            _id_tipo_subproyecto = CInt(dr("id_tipo_subproyecto"))
            Return _id_tipo_subproyecto
        End Get
        Set(value As Integer)
            dr("id_tipo_subproyecto") = value
        End Set
    End Property
    Private _id_tipo_subproyecto As Integer

    ''

    ''' Gets or Sets id_subproyecto_padre
    '''

    Public Property nombre_tipo_subproyecto() As String
        Get
            _nombre_tipo_subproyecto = CStr(dr("nombre_tipo_subproyecto"))
            Return _nombre_tipo_subproyecto
        End Get
        Set(value As String)
            dr("nombre_tipo_subproyecto") = value
        End Set
    End Property
    Private _nombre_tipo_subproyecto As String

    Public Property descripcion() As String
        Get
            _descripcion = CStr(dr("descripcion"))
            Return _descripcion
        End Get
        Set(value As String)
            dr("descripcion") = value
        End Set
    End Property
    Private _descripcion As String



    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("TIPO_SUBPROYECTO")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_tipo_subproyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_tipo_subproyecto", SqlDbType.Int, 0, "id_tipo_subproyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_tipo_subproyecto", SqlDbType.VarChar, 50, "nombre_tipo_subproyecto")
        da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.VarChar, 100, "descripcion")



        dr = dt.NewRow()
        dr("nombre_tipo_subproyecto") = ""
        dr("descripcion") = ""

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal id_tipo_subproyecto As Integer)
        dt = New DataTable("TIPO_SUBPROYECTO")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM TIPO_SUBPROYECTO WHERE id_tipo_subproyecto = @id_tipo_subproyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_tipo_subproyecto", id_tipo_subproyecto)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se ha encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        'CrearComandoUpdate()
    End Sub

    'Public Function ObtenerPorProyecto(ByVal id_proyecto As Integer, ByVal id_subproyecto_padre As Integer) As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_subproyecto_getFromProyecto", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 6, "id_proyecto")
    '    oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
    '    oda.SelectCommand.Parameters.Add("@id_subproyecto_padre", SqlDbType.Int, 6, "id_subproyecto_padre")
    '    oda.SelectCommand.Parameters("@id_subproyecto_padre").Value = id_subproyecto_padre

    '    oda.Fill(odt)

    '    Return odt
    'End Function

    'Public Function GetCMB_TipoSubproyecto() As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_tipo_subproyecto_getCmb", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure

    '    oda.Fill(odt)

    '    Return odt
    'End Function

    'Public Function GetActividadesTipoProyecto(ByVal id_tipo_subproyecto As Integer) As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_tipo_subproyecto_obtenerActividades", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@id_tipo_subproyecto", SqlDbType.Int, 6, "id_tipo_subproyecto")
    '    oda.SelectCommand.Parameters("@id_tipo_subproyecto").Value = id_tipo_subproyecto

    '    oda.Fill(odt)

    '    Return odt
    'End Function

    'procedimiento borrar
    Public Function Borrar(ByVal id_tipo_subproyecto As Integer) As Boolean
        dt = New DataTable("TIPO_SUBPROYECTO")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM TIPO_SUBPROYECTO WHERE id_tipo_subproyecto = " & _
        id_tipo_subproyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        Dim dt_subproyecto As DataTable
        Dim da_subproyecto As SqlDataAdapter
        dt_subproyecto = New DataTable("SUBPROYECTO")
        da_subproyecto = New SqlClient.SqlDataAdapter("SELECT * FROM SUBPROYECTO WHERE id_tipo_subproyecto = " & _
        id_tipo_subproyecto, cnn.Coneccion)
        da_subproyecto.Fill(dt_subproyecto)

        'Hay subproyectos con ese tipo de subproyecto. No se puee eliminar
        If dt_subproyecto.Rows.Count > 0 Then
            Return False
            Exit Function
        End If

        If dt.Rows.Count = 0 Then
            Return False
            Exit Function
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_tipo_subproyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_tipo_subproyecto", SqlDbType.Int, 4, "id_tipo_subproyecto")
            dt.Rows(0).Delete()
            CrearComandoUpdate()
            Guardar()
        Catch ex As Exception
            If Err.Number = 5 Then
            End If
        End Try
        Return True
    End Function

    'asigno el tipo de datos a los parametros
    Private Sub AsignarTipos()
        For Each dc As DataColumn In dt.Columns
            Select Case dc.ColumnName
                Case "id_tipo_subproyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "nombre_tipo_subproyecto"
                    dc.DataType = Type.GetType("System.String")
                Case "descripcion"
                    dc.DataType = Type.GetType("System.String")

            End Select
        Next
    End Sub

    'creo el commandbuilder
    Private Sub CrearComandoUpdate()
        Dim cmd As New SqlCommandBuilder(da)
        da.UpdateCommand = cmd.GetUpdateCommand
    End Sub

    'cancelo los cambios del datatable
    Public Sub Cancelar()
        dt.Clear()
    End Sub

    'asigno el datatable
    Public Function DataTable() As DataTable
        Return dt
    End Function

    'actualizo la base de datos
    Public Sub Guardar()
        da.Update(dt)
    End Sub

    'funcion que carga el datatable
    Public Function Cargar() As DataTable
        dt = New DataTable("TIPO_SUBPROYECTO")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM TIPO_SUBPROYECTO WHERE id_tipo_subproyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    ''funcion de busqueda
    Public Function Buscar(ByVal nombre_tipo_subproyecto As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_tipo_subproyecto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_tipo_subproyecto", SqlDbType.VarChar, 50, "nombre_tipo_subproyecto")
        oda.SelectCommand.Parameters("@nombre_tipo_subproyecto").Value = nombre_tipo_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    ''funcion de consulta
    'Public Function ConsultarTodo() As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Proyecto_GetAll", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.Fill(odt)

    '    Return odt
    'End Function

    ''funcion para llenar el combo
    'Public Function GetCmb() As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Proyecto_GetCmb", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.Fill(odt)

    '    Return odt
    'End Function

    ''funcion que trae un registro poniendo el id
    'Public Function GetOne(ByVal id_Proyecto As Integer) As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Proyecto_GetOne", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
    '    oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

    '    oda.Fill(odt)

    '    Return odt
    'End Function

    'controla si existe el registro en la base de datos
    'Public Function Exist() As Boolean
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Proyecto_Exist", cnn.Coneccion)
    '    Dim Total As Integer

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@descripcion", SqlDbType.VarChar, 500, "descripcion")
    '    oda.SelectCommand.Parameters("@descripcion").Value = Me.descripcion
    '    oda.SelectCommand.Parameters.Add("@nombre_proyecto", SqlDbType.VarChar, 500, "nombre_proyecto")
    '    oda.SelectCommand.Parameters("@nombre_proyecto").Value = Me.nombre_proyecto
    '    oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
    '    oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
    '    oda.SelectCommand.Parameters.Add("@id_proyecto_padre", SqlDbType.Int, 4, "id_proyecto_padre")
    '    oda.SelectCommand.Parameters("@id_proyecto_padre").Value = Me.id_proyecto_padre
    '    oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.Int, 4, "id_proyect_manager")
    '    oda.SelectCommand.Parameters("@id_proyect_manager").Value = Me.id_proyect_manager
    '    oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
    '    oda.SelectCommand.Parameters("@fecha_inicio").Value = Me.fecha_inicio
    '    oda.SelectCommand.Parameters.Add("@fecha_fin_prevista", SqlDbType.DateTime, 8, "fecha_fin_prevista")
    '    oda.SelectCommand.Parameters("@fecha_fin_prevista").Value = Me.fecha_fin_prevista
    '    oda.SelectCommand.Parameters.Add("@fecha_fin_real", SqlDbType.DateTime, 8, "fecha_fin_real")
    '    oda.SelectCommand.Parameters("@fecha_fin_real").Value = Me.fecha_fin_real
    '    oda.SelectCommand.Parameters.Add("@orden", SqlDbType.VarChar, 50, "orden")
    '    oda.SelectCommand.Parameters("@orden").Value = Me.orden
    '    oda.SelectCommand.Parameters.Add("@id_estado", SqlDbType.Int, 4, "id_estado")
    '    oda.SelectCommand.Parameters("@id_estado").Value = Me.id_estado
    '    oda.SelectCommand.Parameters.Add("@total_hora", SqlDbType.Decimal, 9, "total_hora")
    '    oda.SelectCommand.Parameters("@total_hora").Value = Me.total_hora
    '    oda.SelectCommand.Parameters.Add("@prioridad", SqlDbType.Decimal, 9, "prioridad")
    '    oda.SelectCommand.Parameters("@prioridad").Value = Me.prioridad
    '    oda.SelectCommand.Parameters.Add("@observacion", SqlDbType.VarChar, 500, "observacion")
    '    oda.SelectCommand.Parameters("@observacion").Value = Me.observacion
    '    oda.SelectCommand.Parameters.Add("@id_controlador_1", SqlDbType.Int, 4, "id_controlador_1")
    '    oda.SelectCommand.Parameters("@id_controlador_1").Value = Me.id_controlador_1
    '    oda.SelectCommand.Parameters.Add("@id_controlador_2", SqlDbType.Int, 4, "id_controlador_2")
    '    oda.SelectCommand.Parameters("@id_controlador_2").Value = Me.id_controlador_2
    '    oda.SelectCommand.Parameters.Add("@path", SqlDbType.VarChar, 5000, "path")
    '    oda.SelectCommand.Parameters("@path").Value = Me.path
    '    oda.SelectCommand.Parameters.Add("@archivado", SqlDbType.Bit, 1, "archivado")
    '    oda.SelectCommand.Parameters("@archivado").Value = Me.archivado
    '    oda.SelectCommand.Parameters.Add("@indice", SqlDbType.Int, 4, "indice")
    '    oda.SelectCommand.Parameters("@indice").Value = Me.indice
    '    oda.SelectCommand.Parameters.Add("@nro", SqlDbType.Int, 4, "nro")
    '    oda.SelectCommand.Parameters("@nro").Value = Me.nro
    '    oda.SelectCommand.Parameters.Add("@id_piloto", SqlDbType.Int, 4, "nro")
    '    oda.SelectCommand.Parameters("@id_piloto").Value = Me.id_piloto

    '    oda.Fill(odt)
    '    Total = CInt(odt.Rows(0).Item("Total").ToString)
    '    If Total = 0 Then
    '        Return False  'NO EXISTE
    '    Else
    '        Return True 'SI EXISTE
    '    End If
    'End Function

    'borra todos los datos de la tabla
    Public Sub BorrarTodo()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "DELETE FROM TIPO_SUBPROYECTO"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE TIPO_SUBPROYECTO"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function GetCMB_TipoSubproyecto() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_tipo_subproyecto_getCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetActividadesTipoProyecto(ByVal id_tipo_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_tipo_subproyecto_obtenerActividades", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_subproyecto", SqlDbType.Int, 6, "id_tipo_subproyecto")
        oda.SelectCommand.Parameters("@id_tipo_subproyecto").Value = id_tipo_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetHorasTipoProyecto(ByVal id_tipo_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_tipo_subproyecto_obtenerHoras", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_subproyecto", SqlDbType.Int, 6, "id_tipo_subproyecto")
        oda.SelectCommand.Parameters("@id_tipo_subproyecto").Value = id_tipo_subproyecto

        oda.Fill(odt)

        Return odt
    End Function



End Class

