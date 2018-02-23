Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Periodo_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_periodo As Int32
    Public ReadOnly Property id_periodo() As Int32
        Get
            _id_periodo = CInt(dr("id_periodo"))
            Return _id_periodo
        End Get
    end property

    Private _nombre_periodo As String
    Public Property nombre_periodo() As String
        Get
            _nombre_periodo = CStr(dr("nombre_periodo"))
            Return _nombre_periodo
        End Get
        Set(ByVal Value As String)
            dr("nombre_periodo") = Value
        End Set
    end property

    Private _id_tipo_periodo As Int32
    Public Property id_tipo_periodo() As Int32
        Get
            _id_tipo_periodo = CInt(dr("id_tipo_periodo"))
            Return _id_tipo_periodo
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_periodo") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Periodo")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Periodo_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_periodo", SqlDbType.int, 0, "id_periodo")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_periodo", SqlDbType.varchar, 50, "nombre_periodo")
        da.InsertCommand.Parameters.Add("@id_tipo_periodo", SqlDbType.int, 4, "id_tipo_periodo")

        dr = dt.NewRow()
        dr("nombre_periodo") = ""
        dr("id_tipo_periodo") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idPeriodo As Integer)
        dt = New DataTable("Periodo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Periodo WHERE id_periodo = @id_Periodo", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Periodo", idPeriodo)
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
    Public Sub Borrar(ByVal idPeriodo As Integer)
        dt = New DataTable("Periodo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Periodo WHERE id_periodo = " & _
        idPeriodo, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Periodo_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_periodo", SqlDbType.Int, 4, "id_periodo")
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
               Case "id_periodo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_periodo"
                  dc.DataType = Type.GetType("System.String")
               Case "id_tipo_periodo"
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
        dt = New DataTable("Periodo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Periodo WHERE id_periodo = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Periodo_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Periodo_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Periodo_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Periodo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Periodo_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_periodo", SqlDbType.Int, 4, "id_periodo")
        oda.SelectCommand.Parameters("@id_periodo").Value = id_Periodo

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Periodo_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_periodo", SqlDbType.varchar, 50, "nombre_periodo")
        oda.SelectCommand.Parameters("@nombre_periodo").Value = Me.nombre_periodo
        oda.SelectCommand.Parameters.Add("@id_tipo_periodo", SqlDbType.int, 4, "id_tipo_periodo")
        oda.SelectCommand.Parameters("@id_tipo_periodo").Value = Me.id_tipo_periodo

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
        Command.CommandText = "DELETE FROM Periodo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Periodo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Periodo_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campa�a desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Periodo")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Periodo.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
