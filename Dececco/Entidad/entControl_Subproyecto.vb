Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Control_Subproyecto

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_control_subproyecto As Int32
    Public ReadOnly Property id_control_subproyecto() As Int32
        Get
            _id_control_subproyecto = CInt(dr("id_control_subproyecto"))
            Return _id_control_subproyecto
        End Get
    End Property

    Private _id_control As Int32
    Public Property id_control() As Int32
        Get
            _id_control = CInt(dr("id_control"))
            Return _id_control
        End Get
        Set(ByVal Value As Int32)
            dr("id_control") = Value
        End Set
    End Property



    Private _id_subproyecto As Int32
    Public Property id_subproyecto() As Int32
        Get
            _id_subproyecto = CInt(dr("id_subproyecto"))
            Return _id_subproyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_subproyecto") = Value
        End Set
    End Property

    Private _id_tipo_actividad As Int32
    Public Property id_tipo_actividad() As Int32
        Get
            _id_tipo_actividad = CInt(dr("id_tipo_actividad"))
            Return _id_tipo_actividad
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_actividad") = Value
        End Set
    End Property




    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("CONTROL_SUBPROYECTO")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_control_subproyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_control_subproyecto", SqlDbType.Int, 0, "id_control_subproyecto")
        prm.Direction = ParameterDirection.Output

        da.InsertCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        da.InsertCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        da.InsertCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")


        dr = dt.NewRow()
        dr("id_control") = 0
        dr("id_tipo_actividad") = 0
        dr("id_subproyecto") = 0

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal id_control_subproyecto As Integer)
        dt = New DataTable("CONTROL_SUBPROYECTO")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM CONTROL_SUBPROYECTO WHERE id_control_subproyecto = @id_control_subproyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_control_subproyecto", id_control_subproyecto)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se a encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        CrearComandoUpdate()
    End Sub

    'procedimiento borrar
    Public Sub Borrar(ByVal id_control_subproyecto As Integer)
        dt = New DataTable("CONTROL_SUBPROYECTO")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM CONTROL_SUBPROYECTO WHERE id_control_subproyecto = " & _
        id_control_subproyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_CONTROL_SUBPROYECTO_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_control_subproyecto", SqlDbType.Int, 4, "id_control_subproyecto")
            dt.Rows(0).Delete()
            CrearComandoUpdate()
            Guardar()
        Catch ex As Exception
            If Err.Number = 5 Then
            End If
        End Try
    End Sub

    'asigno el tipo de datos a los parametros
    Private Sub AsignarTipos()
        For Each dc As DataColumn In dt.Columns
            Select Case dc.ColumnName
                Case "id_control_subproyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_tipo_actividad"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_control"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_subproyecto"
                    dc.DataType = Type.GetType("System.Int32")

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
        dt = New DataTable("CONTROL_SUBPROYECTO")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM CONTROL_SUBPROYECTO WHERE id_control_subproyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function



    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_CONTROL_SUBPROYECTO_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'TODO
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_CONTROL_SUBPROYECTOo_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        'oda.SelectCommand.Parameters.Add("@_id_tipo_actividad", SqlDbType.Int, 4, "_id_tipo_actividad")
        'oda.SelectCommand.Parameters("@_id_tipo_actividad").Value = _id_tipo_actividad
        'oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        'oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        'oda.SelectCommand.Parameters.Add("@mostrar_actuales", SqlDbType.Int, 4, "mostrar_actuales")
        'oda.SelectCommand.Parameters("@mostrar_actuales").Value = mostrar_actuales

        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_control_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_CONTROL_SUBPROYECTO_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control_subproyecto", SqlDbType.Int, 4, "id_control_subproyecto")
        oda.SelectCommand.Parameters("@id_control_subproyecto").Value = id_control_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetFromSubproyecto(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_control_subproyecto_GetFromSubproyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_CONTROL_SUBPROYECTO_Exist", cnn.Coneccion)
        Dim id_control_subproyecto As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        oda.SelectCommand.Parameters("@id_tipo_actividad").Value = Me.id_tipo_actividad
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_control").Value = Me.id_control
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = Me.id_subproyecto


        oda.Fill(odt)
        id_control_subproyecto = CInt(odt.Rows(0).Item("Total").ToString)
        Return id_control_subproyecto

    End Function

    'borra todos los datos de la tabla
    Public Sub BorrarTodo()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "DELETE FROM CONTROL_SUBPROYECTO"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()

    End Sub


End Class
