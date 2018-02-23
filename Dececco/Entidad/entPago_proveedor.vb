Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Pago_proveedor_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_pago_proveedor As Int32
    Public ReadOnly Property id_pago_proveedor() As Int32
        Get
            _id_pago_proveedor = CInt(dr("id_pago_proveedor"))
            Return _id_pago_proveedor
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

    Private _numero_remito As String
    Public Property numero_remito() As String
        Get
            _numero_remito = CStr(dr("numero_remito"))
            Return _numero_remito
        End Get
        Set(ByVal Value As String)
            dr("numero_remito") = Value
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

    Private _efectivo As Boolean
    Public Property efectivo() As Boolean
        Get
            _efectivo = CBool(dr("efectivo"))
            Return _efectivo
        End Get
        Set(ByVal Value As Boolean)
            dr("efectivo") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Pago_proveedor")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Pago_proveedor_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_pago_proveedor", SqlDbType.int, 0, "id_pago_proveedor")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@pago", SqlDbType.decimal, 9, "pago")
        da.InsertCommand.Parameters.Add("@numero_remito", SqlDbType.varchar, 50, "numero_remito")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 5000, "detalle")
        da.InsertCommand.Parameters.Add("@efectivo", SqlDbType.bit, 1, "efectivo")

        dr = dt.NewRow()
        dr("id_proveedor") = 0
        dr("fecha") = DateTime.Now
        dr("pago") = 0
        dr("numero_remito") = ""
        dr("detalle") = ""
        dr("efectivo") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idPago_proveedor As Integer)
        dt = New DataTable("Pago_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Pago_proveedor WHERE id_pago_proveedor = @id_Pago_proveedor", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Pago_proveedor", idPago_proveedor)
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
    Public Sub Borrar(ByVal idPago_proveedor As Integer)
        dt = New DataTable("Pago_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Pago_proveedor WHERE id_pago_proveedor = " & _
        idPago_proveedor, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Pago_proveedor_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_pago_proveedor", SqlDbType.Int, 4, "id_pago_proveedor")
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
               Case "id_pago_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "pago"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "numero_remito"
                  dc.DataType = Type.GetType("System.String")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "efectivo"
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
        dt = New DataTable("Pago_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Pago_proveedor WHERE id_pago_proveedor = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_proveedor_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_proveedor_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_proveedor_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Pago_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_proveedor_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_proveedor", SqlDbType.Int, 4, "id_pago_proveedor")
        oda.SelectCommand.Parameters("@id_pago_proveedor").Value = id_Pago_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_proveedor_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = Me.id_proveedor
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@pago", SqlDbType.decimal, 9, "pago")
        oda.SelectCommand.Parameters("@pago").Value = Me.pago
        oda.SelectCommand.Parameters.Add("@numero_remito", SqlDbType.varchar, 50, "numero_remito")
        oda.SelectCommand.Parameters("@numero_remito").Value = Me.numero_remito
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 5000, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@efectivo", SqlDbType.bit, 1, "efectivo")
        oda.SelectCommand.Parameters("@efectivo").Value = Me.efectivo

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
        Command.CommandText = "DELETE FROM Pago_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Pago_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Pago_proveedor_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Pago_proveedor")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Pago_proveedor.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
