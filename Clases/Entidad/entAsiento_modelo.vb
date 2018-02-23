Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Asiento_modelo_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_asiento_modelo As Int32
    Public ReadOnly Property id_asiento_modelo() As Int32
        Get
            _id_asiento_modelo = CInt(dr("id_asiento_modelo"))
            Return _id_asiento_modelo
        End Get
    end property

    Private _id_cuenta_imputable As Int32
    Public Property id_cuenta_imputable() As Int32
        Get
            _id_cuenta_imputable = CInt(dr("id_cuenta_imputable"))
            Return _id_cuenta_imputable
        End Get
        Set(ByVal Value As Int32)
            dr("id_cuenta_imputable") = Value
        End Set
    end property

    Private _id_tipo_asiento As Int32
    Public Property id_tipo_asiento() As Int32
        Get
            _id_tipo_asiento = CInt(dr("id_tipo_asiento"))
            Return _id_tipo_asiento
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_asiento") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Asiento_modelo")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Asiento_modelo_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_asiento_modelo", SqlDbType.int, 0, "id_asiento_modelo")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.int, 4, "id_cuenta_imputable")
        da.InsertCommand.Parameters.Add("@id_tipo_asiento", SqlDbType.int, 4, "id_tipo_asiento")

        dr = dt.NewRow()
        dr("id_cuenta_imputable") = 0
        dr("id_tipo_asiento") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idAsiento_modelo As Integer)
        dt = New DataTable("Asiento_modelo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Asiento_modelo WHERE id_asiento_modelo = @id_Asiento_modelo", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Asiento_modelo", idAsiento_modelo)
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
    Public Sub Borrar(ByVal idAsiento_modelo As Integer)
        dt = New DataTable("Asiento_modelo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Asiento_modelo WHERE id_asiento_modelo = " & _
        idAsiento_modelo, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Asiento_modelo_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_asiento_modelo", SqlDbType.Int, 4, "id_asiento_modelo")
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
               Case "id_asiento_modelo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cuenta_imputable"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_tipo_asiento"
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
        dt = New DataTable("Asiento_modelo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Asiento_modelo WHERE id_asiento_modelo = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Asiento_modelo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_asiento_modelo", SqlDbType.Int, 4, "id_asiento_modelo")
        oda.SelectCommand.Parameters("@id_asiento_modelo").Value = id_Asiento_modelo

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.int, 4, "id_cuenta_imputable")
        oda.SelectCommand.Parameters("@id_cuenta_imputable").Value = Me.id_cuenta_imputable
        oda.SelectCommand.Parameters.Add("@id_tipo_asiento", SqlDbType.int, 4, "id_tipo_asiento")
        oda.SelectCommand.Parameters("@id_tipo_asiento").Value = Me.id_tipo_asiento

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
        Command.CommandText = "DELETE FROM Asiento_modelo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Asiento_modelo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Asiento_modelo_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Asiento_modelo")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Asiento_modelo.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
