Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_Actividad_Usuario

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_tipo_actividad_usuario As Int32
    Public ReadOnly Property id_tipo_actividad_usuario() As Int32
        Get
            _id_tipo_actividad_usuario = CInt(dr("id_tipo_actividad_usuario"))
            Return _id_tipo_actividad_usuario
        End Get
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

    Private _id_usuario As Int32
    Public Property id_usuario() As Int32
        Get
            _id_usuario = CInt(dr("id_usuario"))
            Return _id_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario") = Value
        End Set
    End Property


    Private _habilitado As Boolean
    Public Property habilitado() As Boolean
        Get
            _habilitado = CBool(dr("habilitado"))
            Return _habilitado
        End Get
        Set(ByVal Value As Boolean)
            dr("habilitado") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Tipo_Actividad_Usuario")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_tipo_actividad_usuario_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_tipo_actividad_usuario", SqlDbType.Int, 0, "id_tipo_actividad_usuario")
        prm.Direction = ParameterDirection.Output

        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        da.InsertCommand.Parameters.Add("@habilitado", SqlDbType.Bit, 1, "habilitado")


        dr = dt.NewRow()
        dr("id_usuario") = 0
        dr("id_tipo_actividad") = 0
        dr("habilitado") = 0

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal id_tipo_actividad_usuario As Integer)
        dt = New DataTable("Tipo_Actividad_Usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_Actividad_Usuario WHERE id_tipo_actividad_usuario = @id_tipo_actividad_usuario", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_tipo_actividad_usuario", id_tipo_actividad_usuario)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se ha encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        CrearComandoUpdate()
    End Sub

    'procedimiento borrar
    Public Sub Borrar(ByVal id_usuario_proyecto As Integer)
        dt = New DataTable("Tipo_Actividad_Usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_Actividad_Usuario WHERE id_tipo_actividad_usuario = " & _
        id_usuario_proyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Tipo_Actividad_Usuario_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_tipo_actividad_usuario", SqlDbType.Int, 4, "id_tipo_actividad_usuario")
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
                Case "id_tipo_actividad_usuario"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_tipo_actividad"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_usuario"
                    dc.DataType = Type.GetType("System.Int32")
                Case "habilitado"
                    dc.DataType = Type.GetType("System.Boolean")

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
        dt = New DataTable("Tipo_Actividad_Usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_Actividad_Usuario WHERE id_tipo_actividad_usuario = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function



    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_Actividad_Usuario_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'TODO
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_Actividad_Usuario_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure


        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_tipo_actividad_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_Actividad_Usuario_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad_usuario", SqlDbType.Int, 4, "id_tipo_actividad_usuario")
        oda.SelectCommand.Parameters("@id_tipo_actividad_usuario").Value = id_tipo_actividad_usuario

        oda.Fill(odt)

        Return odt
    End Function


    Public Function GetFromUsuario(ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_Actividad_Usuario_GetFromUsuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetFromTipoActividad(ByVal id_tipo_actividad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_Actividad_Usuario_GetFromTipoActividad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        oda.SelectCommand.Parameters("@id_tipo_actividad").Value = id_tipo_actividad

        oda.Fill(odt)

        Return odt
    End Function


    'controla si existe el registro en la base de datos
    Public Function Exist() As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_Actividad_Usuario_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        oda.SelectCommand.Parameters("@id_tipo_actividad").Value = Me.id_tipo_actividad
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario

        oda.Fill(odt)
        Return CInt(odt.Rows(0).Item("Total").ToString)

    End Function

    'borra todos los datos de la tabla
    Public Sub BorrarTodo()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "DELETE FROM Tipo_Actividad_Usuario"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()

    End Sub


End Class
