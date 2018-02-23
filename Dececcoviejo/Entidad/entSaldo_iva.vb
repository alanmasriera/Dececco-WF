Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Saldo_iva_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_saldo_Iva As Int32
    Public ReadOnly Property id_saldo_Iva() As Int32
        Get
            _id_saldo_Iva = CInt(dr("id_saldo_Iva"))
            Return _id_saldo_Iva
        End Get
    end property

    Private _fecha_saldo_Iva As DateTime
    Public Property fecha_saldo_Iva() As DateTime
        Get
            _fecha_saldo_Iva = CDate(dr("fecha_saldo_Iva"))
            Return _fecha_saldo_Iva
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_saldo_Iva") = Value
        End Set
    end property

    Private _saldo_Iva As Decimal
    Public Property saldo_Iva() As Decimal
        Get
            _saldo_Iva = CDec(dr("saldo_Iva"))
            Return _saldo_Iva
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_Iva") = Value
        End Set
    end property

    Private _id_Iva As Int32
    Public Property id_Iva() As Int32
        Get
            _id_Iva = CInt(dr("id_Iva"))
            Return _id_Iva
        End Get
        Set(ByVal Value As Int32)
            dr("id_Iva") = Value
        End Set
    end property

    Private _id_empresa As Int32
    Public Property id_empresa() As Int32
        Get
            _id_empresa = CInt(dr("id_empresa"))
            Return _id_empresa
        End Get
        Set(ByVal Value As Int32)
            dr("id_empresa") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Saldo_iva")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Saldo_iva_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_saldo_Iva", SqlDbType.int, 0, "id_saldo_Iva")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha_saldo_Iva", SqlDbType.datetime, 8, "fecha_saldo_Iva")
        da.InsertCommand.Parameters.Add("@saldo_Iva", SqlDbType.decimal, 9, "saldo_Iva")
        da.InsertCommand.Parameters.Add("@id_Iva", SqlDbType.int, 4, "id_Iva")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")

        dr = dt.NewRow()
        dr("fecha_saldo_Iva") = DateTime.Now
        dr("saldo_Iva") = 0
        dr("id_Iva") = 0
        dr("id_empresa") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idSaldo_iva As Integer)
        dt = New DataTable("Saldo_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Saldo_iva WHERE id_saldo_Iva = @id_Saldo_iva", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Saldo_iva", idSaldo_iva)
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
    Public Sub Borrar(ByVal idSaldo_iva As Integer)
        dt = New DataTable("Saldo_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Saldo_iva WHERE id_saldo_Iva = " & _
        idSaldo_iva, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Saldo_iva_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_saldo_Iva", SqlDbType.Int, 4, "id_saldo_Iva")
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
               Case "id_saldo_Iva"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_saldo_Iva"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "saldo_Iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_Iva"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empresa"
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
        dt = New DataTable("Saldo_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Saldo_iva WHERE id_saldo_Iva = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Saldo_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_saldo_Iva", SqlDbType.Int, 4, "id_saldo_Iva")
        oda.SelectCommand.Parameters("@id_saldo_Iva").Value = id_Saldo_iva

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_saldo_Iva", SqlDbType.datetime, 8, "fecha_saldo_Iva")
        oda.SelectCommand.Parameters("@fecha_saldo_Iva").Value = Me.fecha_saldo_Iva
        oda.SelectCommand.Parameters.Add("@saldo_Iva", SqlDbType.decimal, 9, "saldo_Iva")
        oda.SelectCommand.Parameters("@saldo_Iva").Value = Me.saldo_Iva
        oda.SelectCommand.Parameters.Add("@id_Iva", SqlDbType.int, 4, "id_Iva")
        oda.SelectCommand.Parameters("@id_Iva").Value = Me.id_Iva
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa

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
        Command.CommandText = "DELETE FROM Saldo_iva"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Saldo_iva"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Saldo_iva_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campa�a desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Saldo_iva")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Saldo_iva.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
