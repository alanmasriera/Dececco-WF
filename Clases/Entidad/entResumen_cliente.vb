Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_cliente_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_resumen_cliente As Int32
    Public ReadOnly Property id_resumen_cliente() As Int32
        Get
            _id_resumen_cliente = CInt(dr("id_resumen_cliente"))
            Return _id_resumen_cliente
        End Get
    end property

    Private _debe_cliente As Decimal
    Public Property debe_cliente() As Decimal
        Get
            _debe_cliente = CDec(dr("debe_cliente"))
            Return _debe_cliente
        End Get
        Set(ByVal Value As Decimal)
            dr("debe_cliente") = Value
        End Set
    end property

    Private _haber_cliente As Decimal
    Public Property haber_cliente() As Decimal
        Get
            _haber_cliente = CDec(dr("haber_cliente"))
            Return _haber_cliente
        End Get
        Set(ByVal Value As Decimal)
            dr("haber_cliente") = Value
        End Set
    end property

    Private _detalle_cliente As String
    Public Property detalle_cliente() As String
        Get
            _detalle_cliente = CStr(dr("detalle_cliente"))
            Return _detalle_cliente
        End Get
        Set(ByVal Value As String)
            dr("detalle_cliente") = Value
        End Set
    end property

    Private _fecha_cliente As DateTime
    Public Property fecha_cliente() As DateTime
        Get
            _fecha_cliente = CDate(dr("fecha_cliente"))
            Return _fecha_cliente
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_cliente") = Value
        End Set
    end property

    Private _saldo_cliente As Decimal
    Public Property saldo_cliente() As Decimal
        Get
            _saldo_cliente = CDec(dr("saldo_cliente"))
            Return _saldo_cliente
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_cliente") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Resumen_cliente")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Resumen_cliente_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_resumen_cliente", SqlDbType.int, 0, "id_resumen_cliente")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@debe_cliente", SqlDbType.decimal, 9, "debe_cliente")
        da.InsertCommand.Parameters.Add("@haber_cliente", SqlDbType.decimal, 9, "haber_cliente")
        da.InsertCommand.Parameters.Add("@detalle_cliente", SqlDbType.varchar, 500, "detalle_cliente")
        da.InsertCommand.Parameters.Add("@fecha_cliente", SqlDbType.datetime, 8, "fecha_cliente")
        da.InsertCommand.Parameters.Add("@saldo_cliente", SqlDbType.decimal, 9, "saldo_cliente")

        dr = dt.NewRow()
        dr("debe_cliente") = 0
        dr("haber_cliente") = 0
        dr("detalle_cliente") = ""
        dr("fecha_cliente") = DateTime.Now
        dr("saldo_cliente") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idResumen_cliente As Integer)
        dt = New DataTable("Resumen_cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Resumen_cliente WHERE id_resumen_cliente = @id_Resumen_cliente", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Resumen_cliente", idResumen_cliente)
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
    Public Sub Borrar(ByVal idResumen_cliente As Integer)
        dt = New DataTable("Resumen_cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Resumen_cliente WHERE id_resumen_cliente = " & _
        idResumen_cliente, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Resumen_cliente_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_resumen_cliente", SqlDbType.Int, 4, "id_resumen_cliente")
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
               Case "id_resumen_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "debe_cliente"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "haber_cliente"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "detalle_cliente"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_cliente"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "saldo_cliente"
                  dc.DataType = Type.GetType("System.Decimal")
            End Select
        Next
    End Sub

    'creo el commandbuilder
    Friend Sub CrearComandoUpdate()
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
        dt = New DataTable("Resumen_cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Resumen_cliente WHERE id_resumen_cliente = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cliente_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cliente_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cliente_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Resumen_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cliente_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_cliente", SqlDbType.Int, 4, "id_resumen_cliente")
        oda.SelectCommand.Parameters("@id_resumen_cliente").Value = id_Resumen_cliente

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cliente_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@debe_cliente", SqlDbType.decimal, 9, "debe_cliente")
        oda.SelectCommand.Parameters("@debe_cliente").Value = Me.debe_cliente
        oda.SelectCommand.Parameters.Add("@haber_cliente", SqlDbType.decimal, 9, "haber_cliente")
        oda.SelectCommand.Parameters("@haber_cliente").Value = Me.haber_cliente
        oda.SelectCommand.Parameters.Add("@detalle_cliente", SqlDbType.varchar, 500, "detalle_cliente")
        oda.SelectCommand.Parameters("@detalle_cliente").Value = Me.detalle_cliente
        oda.SelectCommand.Parameters.Add("@fecha_cliente", SqlDbType.datetime, 8, "fecha_cliente")
        oda.SelectCommand.Parameters("@fecha_cliente").Value = Me.fecha_cliente
        oda.SelectCommand.Parameters.Add("@saldo_cliente", SqlDbType.decimal, 9, "saldo_cliente")
        oda.SelectCommand.Parameters("@saldo_cliente").Value = Me.saldo_cliente

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
        Command.CommandText = "DELETE FROM Resumen_cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Resumen_cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_cliente_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Resumen_cliente")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Resumen_cliente.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
