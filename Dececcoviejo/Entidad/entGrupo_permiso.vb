Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Grupo_permiso_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_grupo_permiso As Int32
    Public ReadOnly Property id_grupo_permiso() As Int32
        Get
            _id_grupo_permiso = CInt(dr("id_grupo_permiso"))
            Return _id_grupo_permiso
        End Get
    end property

    Private _id_grupo_usuario As Int32
    Public Property id_grupo_usuario() As Int32
        Get
            _id_grupo_usuario = CInt(dr("id_grupo_usuario"))
            Return _id_grupo_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_grupo_usuario") = Value
        End Set
    end property

    Private _id_permiso As Int32
    Public Property id_permiso() As Int32
        Get
            _id_permiso = CInt(dr("id_permiso"))
            Return _id_permiso
        End Get
        Set(ByVal Value As Int32)
            dr("id_permiso") = Value
        End Set
    end property

    Private _habilitado As Boolean
    Public Property habilitado() As Boolean
        Get
            _habilitado = CBool(dr("habilitado"))
            Return _habilitado
        End Get
        Set(ByVal Value As Boolean)
            dr("habilitado") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Grupo_permiso")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Grupo_permiso_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_grupo_permiso", SqlDbType.int, 0, "id_grupo_permiso")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.int, 4, "id_grupo_usuario")
        da.InsertCommand.Parameters.Add("@id_permiso", SqlDbType.int, 4, "id_permiso")
        da.InsertCommand.Parameters.Add("@habilitado", SqlDbType.bit, 1, "habilitado")

        dr = dt.NewRow()
        dr("id_grupo_usuario") = 0
        dr("id_permiso") = 0
        dr("habilitado") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idGrupo_permiso As Integer)
        dt = New DataTable("Grupo_permiso")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Grupo_permiso WHERE id_grupo_permiso = @id_Grupo_permiso", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Grupo_permiso", idGrupo_permiso)
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
    Public Sub Borrar(ByVal idGrupo_permiso As Integer)
        dt = New DataTable("Grupo_permiso")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Grupo_permiso WHERE id_grupo_permiso = " & _
        idGrupo_permiso, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Grupo_permiso_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_grupo_permiso", SqlDbType.Int, 4, "id_grupo_permiso")
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
               Case "id_grupo_permiso"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_grupo_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_permiso"
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
        dt = New DataTable("Grupo_permiso")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Grupo_permiso WHERE id_grupo_permiso = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_permiso_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_permiso_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_permiso_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Grupo_permiso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_permiso_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_permiso", SqlDbType.Int, 4, "id_grupo_permiso")
        oda.SelectCommand.Parameters("@id_grupo_permiso").Value = id_Grupo_permiso

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist(ByVal id_grupo_usuario As Integer, ByVal id_permiso As Integer, ByVal habilitado As Boolean) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_permiso_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 4, "id_grupo_usuario")
        oda.SelectCommand.Parameters("@id_grupo_usuario").Value = id_grupo_usuario
        oda.SelectCommand.Parameters.Add("@id_permiso", SqlDbType.Int, 4, "id_permiso")
        oda.SelectCommand.Parameters("@id_permiso").Value = id_permiso
        oda.SelectCommand.Parameters.Add("@habilitado", SqlDbType.Bit, 1, "habilitado")
        oda.SelectCommand.Parameters("@habilitado").Value = habilitado

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
        Command.CommandText = "DELETE FROM Grupo_permiso"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Grupo_permiso"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Grupo_permiso_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Grupo_permiso")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Grupo_permiso.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
