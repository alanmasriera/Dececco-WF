Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_proveedor_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_recibo_proveedor As Int32
    Public ReadOnly Property id_recibo_proveedor() As Int32
        Get
            _id_recibo_proveedor = CInt(dr("id_recibo_proveedor"))
            Return _id_recibo_proveedor
        End Get
    end property

    Private _id_proveedor As Int32
    Public Property id_proveedor() As Int32
        Get
            _id_proveedor = CInt(dr("id_proveedor"))
            Return _id_proveedor
        End Get
        Set(ByVal Value As Int32)
            dr("id_proveedor") = Value
        End Set
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

    Private _pago As Decimal
    Public Property pago() As Decimal
        Get
            _pago = CDec(dr("pago"))
            Return _pago
        End Get
        Set(ByVal Value As Decimal)
            dr("pago") = Value
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

    Private _numero_recibo As String
    Public Property numero_recibo() As String
        Get
            _numero_recibo = CStr(dr("numero_recibo"))
            Return _numero_recibo
        End Get
        Set(ByVal Value As String)
            dr("numero_recibo") = Value
        End Set
    end property

    Private _retencion_iva As Decimal
    Public Property retencion_iva() As Decimal
        Get
            _retencion_iva = CDec(dr("retencion_iva"))
            Return _retencion_iva
        End Get
        Set(ByVal Value As Decimal)
            dr("retencion_iva") = Value
        End Set
    end property

    Private _ingreso_bruto As Decimal
    Public Property ingreso_bruto() As Decimal
        Get
            _ingreso_bruto = CDec(dr("ingreso_bruto"))
            Return _ingreso_bruto
        End Get
        Set(ByVal Value As Decimal)
            dr("ingreso_bruto") = Value
        End Set
    end property

    Private _impuesto_ganancia As Decimal
    Public Property impuesto_ganancia() As Decimal
        Get
            _impuesto_ganancia = CDec(dr("impuesto_ganancia"))
            Return _impuesto_ganancia
        End Get
        Set(ByVal Value As Decimal)
            dr("impuesto_ganancia") = Value
        End Set
    end property

    Private _suss As Decimal
    Public Property suss() As Decimal
        Get
            _suss = CDec(dr("suss"))
            Return _suss
        End Get
        Set(ByVal Value As Decimal)
            dr("suss") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Recibo_proveedor")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Recibo_proveedor_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.int, 0, "id_recibo_proveedor")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@pago", SqlDbType.decimal, 9, "pago")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 500, "detalle")
        da.InsertCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        da.InsertCommand.Parameters.Add("@retencion_iva", SqlDbType.decimal, 9, "retencion_iva")
        da.InsertCommand.Parameters.Add("@ingreso_bruto", SqlDbType.decimal, 9, "ingreso_bruto")
        da.InsertCommand.Parameters.Add("@impuesto_ganancia", SqlDbType.decimal, 9, "impuesto_ganancia")
        da.InsertCommand.Parameters.Add("@suss", SqlDbType.decimal, 9, "suss")

        dr = dt.NewRow()
        dr("id_proveedor") = 0
        dr("fecha") = DateTime.Now
        dr("pago") = 0
        dr("detalle") = ""
        dr("numero_recibo") = ""
        dr("retencion_iva") = 0
        dr("ingreso_bruto") = 0
        dr("impuesto_ganancia") = 0
        dr("suss") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idRecibo_proveedor As Integer)
        dt = New DataTable("Recibo_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_proveedor WHERE id_recibo_proveedor = @id_Recibo_proveedor", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Recibo_proveedor", idRecibo_proveedor)
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
    Public Sub Borrar(ByVal idRecibo_proveedor As Integer)
        dt = New DataTable("Recibo_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_proveedor WHERE id_recibo_proveedor = " & _
        idRecibo_proveedor, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Recibo_proveedor_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
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
               Case "id_recibo_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "pago"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "numero_recibo"
                  dc.DataType = Type.GetType("System.String")
               Case "retencion_iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "ingreso_bruto"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "impuesto_ganancia"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "suss"
                  dc.DataType = Type.GetType("System.Decimal")
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
        dt = New DataTable("Recibo_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_proveedor WHERE id_recibo_proveedor = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_proveedor_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_proveedor_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_proveedor_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_proveedor_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = id_Recibo_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_proveedor_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = Me.id_proveedor
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@pago", SqlDbType.decimal, 9, "pago")
        oda.SelectCommand.Parameters("@pago").Value = Me.pago
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 500, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        oda.SelectCommand.Parameters("@numero_recibo").Value = Me.numero_recibo
        oda.SelectCommand.Parameters.Add("@retencion_iva", SqlDbType.decimal, 9, "retencion_iva")
        oda.SelectCommand.Parameters("@retencion_iva").Value = Me.retencion_iva
        oda.SelectCommand.Parameters.Add("@ingreso_bruto", SqlDbType.decimal, 9, "ingreso_bruto")
        oda.SelectCommand.Parameters("@ingreso_bruto").Value = Me.ingreso_bruto
        oda.SelectCommand.Parameters.Add("@impuesto_ganancia", SqlDbType.decimal, 9, "impuesto_ganancia")
        oda.SelectCommand.Parameters("@impuesto_ganancia").Value = Me.impuesto_ganancia
        oda.SelectCommand.Parameters.Add("@suss", SqlDbType.decimal, 9, "suss")
        oda.SelectCommand.Parameters("@suss").Value = Me.suss

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
        Command.CommandText = "DELETE FROM Recibo_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Recibo_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Recibo_proveedor_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Recibo_proveedor")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Recibo_proveedor.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
