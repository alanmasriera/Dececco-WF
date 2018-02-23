Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Usuario_Proyecto

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_usuario_proyecto As Int32
    Public ReadOnly Property id_usuario_proyecto() As Int32
        Get
            _id_usuario_proyecto = CInt(dr("id_usuario_proyecto"))
            Return _id_usuario_proyecto
        End Get
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

    Private _id_proyecto As Int32
    Public Property id_proyecto() As Int32
        Get
            _id_proyecto = CInt(dr("id_proyecto"))
            Return _id_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_proyecto") = Value
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

    


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Usuario_proyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Usuario_proyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_usuario_proyecto", SqlDbType.Int, 0, "id_usuario_proyecto")
        prm.Direction = ParameterDirection.Output

        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        da.InsertCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        

        dr = dt.NewRow()
        dr("id_usuario") = 0
        dr("id_proyecto") = 0
        dr("id_subproyecto") = 0
        
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal id_usuario_proyecto As Integer)
        dt = New DataTable("Usuario_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Usuario_proyecto WHERE id_usuario_proyecto = @id_usuario_proyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_usuario_proyecto", id_usuario_proyecto)
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
    Public Sub Borrar(ByVal id_usuario_proyecto As Integer)
        dt = New DataTable("Usuario_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Usuario_proyecto WHERE id_usuario_proyecto = " & _
        id_usuario_proyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Usuario_proyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_usuario_proyecto", SqlDbType.Int, 4, "id_usuario_proyecto")
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
                Case "id_usuario_proyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_proyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_usuario"
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
        dt = New DataTable("Usuario_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Usuario_proyecto WHERE id_usuario_proyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_proyecto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'TODO
    Public Function GetCmb(ByVal id_proyecto As Integer, ByVal id_subproyecto As Integer, ByVal mostrar_actuales As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_proyecto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        oda.SelectCommand.Parameters.Add("@mostrar_actuales", SqlDbType.Int, 4, "mostrar_actuales")
        oda.SelectCommand.Parameters("@mostrar_actuales").Value = mostrar_actuales

        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_usuario_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_proyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario_proyecto", SqlDbType.Int, 4, "id_usuario_proyecto")
        oda.SelectCommand.Parameters("@id_usuario_proyecto").Value = id_usuario_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function EsPMoPiloto(ByVal id_usuario As Integer, ByVal id_proyecto As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_usuario_proyecto_EsPMoPiloto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Dim aux As Boolean = False
        If odt.Rows.Count > 0 Then
            aux = True
        End If

        Return aux
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_proyecto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = Me.id_proyecto
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = Me.id_subproyecto


        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'borra todos los datos de la tabla
    Public Sub BorrarTodo()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "DELETE FROM Usuario_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()

    End Sub


End Class
