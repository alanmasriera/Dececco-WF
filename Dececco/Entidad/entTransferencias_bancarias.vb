Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Transferencias_bancarias_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_transferencia_bancaria As Int32
    Public ReadOnly Property id_transferencia_bancaria() As Int32
        Get
            _id_transferencia_bancaria = CInt(dr("id_transferencia_bancaria"))
            Return _id_transferencia_bancaria
        End Get
    end property

    Private _fecha As DateTime
    Public Property fecha() As DateTime
        Get
            _fecha = CDate(dr("fecha"))
            Return _fecha
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha") = Value
        End Set
    end property

    Private _comprobante As String
    Public Property comprobante() As String
        Get
            _comprobante = CStr(dr("comprobante"))
            Return _comprobante
        End Get
        Set(ByVal Value As String)
            dr("comprobante") = Value
        End Set
    end property

    Private _detalle As String
    Public Property detalle() As String
        Get
            _detalle = CStr(dr("detalle"))
            Return _detalle
        End Get
        Set(ByVal Value As String)
            dr("detalle") = Value
        End Set
    end property

    Private _banco_origen As Int32
    Public Property banco_origen() As Int32
        Get
            _banco_origen = CInt(dr("banco_origen"))
            Return _banco_origen
        End Get
        Set(ByVal Value As Int32)
            dr("banco_origen") = Value
        End Set
    end property

    Private _banco_destino As Int32
    Public Property banco_destino() As Int32
        Get
            _banco_destino = CInt(dr("banco_destino"))
            Return _banco_destino
        End Get
        Set(ByVal Value As Int32)
            dr("banco_destino") = Value
        End Set
    end property

    Private _id_cuenta As Int32
    Public Property id_cuenta() As Int32
        Get
            _id_cuenta = CInt(dr("id_cuenta"))
            Return _id_cuenta
        End Get
        Set(ByVal Value As Int32)
            dr("id_cuenta") = Value
        End Set
    end property

    Private _importe As Decimal
    Public Property importe() As Decimal
        Get
            _importe = CDec(dr("importe"))
            Return _importe
        End Get
        Set(ByVal Value As Decimal)
            dr("importe") = Value
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

    Private _periodo As DateTime
    Public Property periodo() As DateTime
        Get
            _periodo = CDate(dr("periodo"))
            Return _periodo
        End Get
        Set(ByVal Value As DateTime)
            dr("periodo") = Value
        End Set
    end property

    Private _control As Boolean
    Public Property control() As Boolean
        Get
            _control = CBool(dr("control"))
            Return _control
        End Get
        Set(ByVal Value As Boolean)
            dr("control") = Value
        End Set
    end property

    Private _iva As Decimal
    Public Property iva() As Decimal
        Get
            _iva = CDec(dr("iva"))
            Return _iva
        End Get
        Set(ByVal Value As Decimal)
            dr("iva") = Value
        End Set
    end property

    Private _id_cliente As Int32
    Public Property id_cliente() As Int32
        Get
            _id_cliente = CInt(dr("id_cliente"))
            Return _id_cliente
        End Get
        Set(ByVal Value As Int32)
            dr("id_cliente") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Transferencias_bancarias")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Transferencias_bancarias_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_transferencia_bancaria", SqlDbType.int, 0, "id_transferencia_bancaria")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@comprobante", SqlDbType.varchar, 50, "comprobante")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 50, "detalle")
        da.InsertCommand.Parameters.Add("@banco_origen", SqlDbType.int, 4, "banco_origen")
        da.InsertCommand.Parameters.Add("@banco_destino", SqlDbType.int, 4, "banco_destino")
        da.InsertCommand.Parameters.Add("@id_cuenta", SqlDbType.int, 4, "id_cuenta")
        da.InsertCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@periodo", SqlDbType.datetime, 8, "periodo")
        da.InsertCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")

        dr = dt.NewRow()
        dr("fecha") = DateTime.Now
        dr("comprobante") = ""
        dr("detalle") = ""
        dr("banco_origen") = 0
        dr("banco_destino") = 0
        dr("id_cuenta") = 0
        dr("importe") = 0
        dr("id_empresa") = 0
        dr("periodo") = DateTime.Now
        dr("control") = False
        dr("iva") = 0
        dr("id_cliente") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTransferencias_bancarias As Integer)
        dt = New DataTable("Transferencias_bancarias")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Transferencias_bancarias WHERE id_transferencia_bancaria = @id_Transferencias_bancarias", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Transferencias_bancarias", idTransferencias_bancarias)
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
    Public Sub Borrar(ByVal idTransferencias_bancarias As Integer)
        dt = New DataTable("Transferencias_bancarias")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Transferencias_bancarias WHERE id_transferencia_bancaria = " & _
        idTransferencias_bancarias, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Transferencias_bancarias_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_transferencia_bancaria", SqlDbType.Int, 4, "id_transferencia_bancaria")
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
               Case "id_transferencia_bancaria"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "comprobante"
                  dc.DataType = Type.GetType("System.String")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "banco_origen"
                  dc.DataType = Type.GetType("System.Int32")
               Case "banco_destino"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cuenta"
                  dc.DataType = Type.GetType("System.Int32")
               Case "importe"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "periodo"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "control"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_cliente"
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
        dt = New DataTable("Transferencias_bancarias")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Transferencias_bancarias WHERE id_transferencia_bancaria = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Transferencias_bancarias_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Transferencias_bancarias_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Transferencias_bancarias_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Transferencias_bancarias As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Transferencias_bancarias_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_transferencia_bancaria", SqlDbType.Int, 4, "id_transferencia_bancaria")
        oda.SelectCommand.Parameters("@id_transferencia_bancaria").Value = id_Transferencias_bancarias

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Transferencias_bancarias_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@comprobante", SqlDbType.varchar, 50, "comprobante")
        oda.SelectCommand.Parameters("@comprobante").Value = Me.comprobante
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 50, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@banco_origen", SqlDbType.int, 4, "banco_origen")
        oda.SelectCommand.Parameters("@banco_origen").Value = Me.banco_origen
        oda.SelectCommand.Parameters.Add("@banco_destino", SqlDbType.int, 4, "banco_destino")
        oda.SelectCommand.Parameters("@banco_destino").Value = Me.banco_destino
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = Me.id_cuenta
        oda.SelectCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        oda.SelectCommand.Parameters("@importe").Value = Me.importe
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@periodo", SqlDbType.datetime, 8, "periodo")
        oda.SelectCommand.Parameters("@periodo").Value = Me.periodo
        oda.SelectCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        oda.SelectCommand.Parameters("@control").Value = Me.control
        oda.SelectCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        oda.SelectCommand.Parameters("@iva").Value = Me.iva
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente

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
        Command.CommandText = "DELETE FROM Transferencias_bancarias"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Transferencias_bancarias"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Transferencias_bancarias_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Transferencias_bancarias")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Transferencias_bancarias.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
