Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Pago_iva_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_pago_Iva As Int32
    Public ReadOnly Property id_pago_Iva() As Int32
        Get
            _id_pago_Iva = CInt(dr("id_pago_Iva"))
            Return _id_pago_Iva
        End Get
    end property

    Private _fecha_pago_Iva As DateTime
    Public Property fecha_pago_Iva() As DateTime
        Get
            _fecha_pago_Iva = CDate(dr("fecha_pago_Iva"))
            Return _fecha_pago_Iva
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_pago_Iva") = Value
        End Set
    end property

    Private _pago_Iva As Decimal
    Public Property pago_Iva() As Decimal
        Get
            _pago_Iva = CDec(dr("pago_Iva"))
            Return _pago_Iva
        End Get
        Set(ByVal Value As Decimal)
            dr("pago_Iva") = Value
        End Set
    end property

    Private _numero_recibo_pago_Iva As String
    Public Property numero_recibo_pago_Iva() As String
        Get
            _numero_recibo_pago_Iva = CStr(dr("numero_recibo_pago_Iva"))
            Return _numero_recibo_pago_Iva
        End Get
        Set(ByVal Value As String)
            dr("numero_recibo_pago_Iva") = Value
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

    Private _efectivo_Iva As Boolean
    Public Property efectivo_Iva() As Boolean
        Get
            _efectivo_Iva = CBool(dr("efectivo_Iva"))
            Return _efectivo_Iva
        End Get
        Set(ByVal Value As Boolean)
            dr("efectivo_Iva") = Value
        End Set
    end property

    Private _numero_cheque_Iva As String
    Public Property numero_cheque_Iva() As String
        Get
            _numero_cheque_Iva = CStr(dr("numero_cheque_Iva"))
            Return _numero_cheque_Iva
        End Get
        Set(ByVal Value As String)
            dr("numero_cheque_Iva") = Value
        End Set
    end property

    Private _fecha_emision_cheque_Iva As DateTime
    Public Property fecha_emision_cheque_Iva() As DateTime
        Get
            _fecha_emision_cheque_Iva = CDate(dr("fecha_emision_cheque_Iva"))
            Return _fecha_emision_cheque_Iva
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_emision_cheque_Iva") = Value
        End Set
    end property

    Private _fecha_pago_cheque_Iva As DateTime
    Public Property fecha_pago_cheque_Iva() As DateTime
        Get
            _fecha_pago_cheque_Iva = CDate(dr("fecha_pago_cheque_Iva"))
            Return _fecha_pago_cheque_Iva
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_pago_cheque_Iva") = Value
        End Set
    end property

    Private _detalle_cheque_Iva As String
    Public Property detalle_cheque_Iva() As String
        Get
            _detalle_cheque_Iva = CStr(dr("detalle_cheque_Iva"))
            Return _detalle_cheque_Iva
        End Get
        Set(ByVal Value As String)
            dr("detalle_cheque_Iva") = Value
        End Set
    end property

    Private _detalle_pago As String
    Public Property detalle_pago() As String
        Get
            _detalle_pago = CStr(dr("detalle_pago"))
            Return _detalle_pago
        End Get
        Set(ByVal Value As String)
            dr("detalle_pago") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Pago_iva")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Pago_iva_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_pago_Iva", SqlDbType.int, 0, "id_pago_Iva")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha_pago_Iva", SqlDbType.datetime, 8, "fecha_pago_Iva")
        da.InsertCommand.Parameters.Add("@pago_Iva", SqlDbType.decimal, 9, "pago_Iva")
        da.InsertCommand.Parameters.Add("@numero_recibo_pago_Iva", SqlDbType.varchar, 50, "numero_recibo_pago_Iva")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@id_Iva", SqlDbType.int, 4, "id_Iva")
        da.InsertCommand.Parameters.Add("@efectivo_Iva", SqlDbType.bit, 1, "efectivo_Iva")
        da.InsertCommand.Parameters.Add("@numero_cheque_Iva", SqlDbType.varchar, 50, "numero_cheque_Iva")
        da.InsertCommand.Parameters.Add("@fecha_emision_cheque_Iva", SqlDbType.datetime, 8, "fecha_emision_cheque_Iva")
        da.InsertCommand.Parameters.Add("@fecha_pago_cheque_Iva", SqlDbType.datetime, 8, "fecha_pago_cheque_Iva")
        da.InsertCommand.Parameters.Add("@detalle_cheque_Iva", SqlDbType.varchar, 50, "detalle_cheque_Iva")
        da.InsertCommand.Parameters.Add("@detalle_pago", SqlDbType.varchar, 50, "detalle_pago")

        dr = dt.NewRow()
        dr("fecha_pago_Iva") = DateTime.Now
        dr("pago_Iva") = 0
        dr("numero_recibo_pago_Iva") = ""
        dr("id_empresa") = 0
        dr("id_Iva") = 0
        dr("efectivo_Iva") = False
        dr("numero_cheque_Iva") = ""
        dr("fecha_emision_cheque_Iva") = DateTime.Now
        dr("fecha_pago_cheque_Iva") = DateTime.Now
        dr("detalle_cheque_Iva") = ""
        dr("detalle_pago") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idPago_iva As Integer)
        dt = New DataTable("Pago_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Pago_iva WHERE id_pago_Iva = @id_Pago_iva", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Pago_iva", idPago_iva)
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
    Public Sub Borrar(ByVal idPago_iva As Integer)
        dt = New DataTable("Pago_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Pago_iva WHERE id_pago_Iva = " & _
        idPago_iva, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Pago_iva_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_pago_Iva", SqlDbType.Int, 4, "id_pago_Iva")
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
               Case "id_pago_Iva"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_pago_Iva"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "pago_Iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "numero_recibo_pago_Iva"
                  dc.DataType = Type.GetType("System.String")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_Iva"
                  dc.DataType = Type.GetType("System.Int32")
               Case "efectivo_Iva"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "numero_cheque_Iva"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_emision_cheque_Iva"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_pago_cheque_Iva"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "detalle_cheque_Iva"
                  dc.DataType = Type.GetType("System.String")
               Case "detalle_pago"
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
        dt = New DataTable("Pago_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Pago_iva WHERE id_pago_Iva = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_iva_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_iva_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_iva_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Pago_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_iva_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_Iva", SqlDbType.Int, 4, "id_pago_Iva")
        oda.SelectCommand.Parameters("@id_pago_Iva").Value = id_Pago_iva

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_iva_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_pago_Iva", SqlDbType.datetime, 8, "fecha_pago_Iva")
        oda.SelectCommand.Parameters("@fecha_pago_Iva").Value = Me.fecha_pago_Iva
        oda.SelectCommand.Parameters.Add("@pago_Iva", SqlDbType.decimal, 9, "pago_Iva")
        oda.SelectCommand.Parameters("@pago_Iva").Value = Me.pago_Iva
        oda.SelectCommand.Parameters.Add("@numero_recibo_pago_Iva", SqlDbType.varchar, 50, "numero_recibo_pago_Iva")
        oda.SelectCommand.Parameters("@numero_recibo_pago_Iva").Value = Me.numero_recibo_pago_Iva
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@id_Iva", SqlDbType.int, 4, "id_Iva")
        oda.SelectCommand.Parameters("@id_Iva").Value = Me.id_Iva
        oda.SelectCommand.Parameters.Add("@efectivo_Iva", SqlDbType.bit, 1, "efectivo_Iva")
        oda.SelectCommand.Parameters("@efectivo_Iva").Value = Me.efectivo_Iva
        oda.SelectCommand.Parameters.Add("@numero_cheque_Iva", SqlDbType.varchar, 50, "numero_cheque_Iva")
        oda.SelectCommand.Parameters("@numero_cheque_Iva").Value = Me.numero_cheque_Iva
        oda.SelectCommand.Parameters.Add("@fecha_emision_cheque_Iva", SqlDbType.datetime, 8, "fecha_emision_cheque_Iva")
        oda.SelectCommand.Parameters("@fecha_emision_cheque_Iva").Value = Me.fecha_emision_cheque_Iva
        oda.SelectCommand.Parameters.Add("@fecha_pago_cheque_Iva", SqlDbType.datetime, 8, "fecha_pago_cheque_Iva")
        oda.SelectCommand.Parameters("@fecha_pago_cheque_Iva").Value = Me.fecha_pago_cheque_Iva
        oda.SelectCommand.Parameters.Add("@detalle_cheque_Iva", SqlDbType.varchar, 50, "detalle_cheque_Iva")
        oda.SelectCommand.Parameters("@detalle_cheque_Iva").Value = Me.detalle_cheque_Iva
        oda.SelectCommand.Parameters.Add("@detalle_pago", SqlDbType.varchar, 50, "detalle_pago")
        oda.SelectCommand.Parameters("@detalle_pago").Value = Me.detalle_pago

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
        Command.CommandText = "DELETE FROM Pago_iva"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Pago_iva"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Pago_iva_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Pago_iva")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Pago_iva.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
