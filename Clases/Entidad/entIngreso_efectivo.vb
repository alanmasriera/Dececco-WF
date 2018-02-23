Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Ingreso_efectivo_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_ingreso_efectivo As Int32
    Public ReadOnly Property id_ingreso_efectivo() As Int32
        Get
            _id_ingreso_efectivo = CInt(dr("id_ingreso_efectivo"))
            Return _id_ingreso_efectivo
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

    Private _archivado As Boolean
    Public Property archivado() As Boolean
        Get
            _archivado = CBool(dr("archivado"))
            Return _archivado
        End Get
        Set(ByVal Value As Boolean)
            dr("archivado") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Ingreso_efectivo")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Ingreso_efectivo_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_ingreso_efectivo", SqlDbType.int, 0, "id_ingreso_efectivo")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@comprobante", SqlDbType.varchar, 50, "comprobante")
        da.InsertCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 50, "detalle")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@archivado", SqlDbType.bit, 1, "archivado")

        dr = dt.NewRow()
        dr("fecha") = DateTime.Now
        dr("comprobante") = ""
        dr("importe") = 0
        dr("iva") = 0
        dr("detalle") = ""
        dr("id_empresa") = 0
        dr("control") = False
        dr("id_cliente") = 0
        dr("archivado") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idIngreso_efectivo As Integer)
        dt = New DataTable("Ingreso_efectivo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Ingreso_efectivo WHERE id_ingreso_efectivo = @id_Ingreso_efectivo", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Ingreso_efectivo", idIngreso_efectivo)
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
    Public Sub Borrar(ByVal idIngreso_efectivo As Integer)
        dt = New DataTable("Ingreso_efectivo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Ingreso_efectivo WHERE id_ingreso_efectivo = " & _
        idIngreso_efectivo, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Ingreso_efectivo_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_ingreso_efectivo", SqlDbType.Int, 4, "id_ingreso_efectivo")
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
               Case "id_ingreso_efectivo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "comprobante"
                  dc.DataType = Type.GetType("System.String")
               Case "importe"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "control"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "archivado"
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
        dt = New DataTable("Ingreso_efectivo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Ingreso_efectivo WHERE id_ingreso_efectivo = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Ingreso_efectivo_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Ingreso_efectivo_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Ingreso_efectivo_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Ingreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Ingreso_efectivo_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_ingreso_efectivo", SqlDbType.Int, 4, "id_ingreso_efectivo")
        oda.SelectCommand.Parameters("@id_ingreso_efectivo").Value = id_Ingreso_efectivo

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Ingreso_efectivo_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@comprobante", SqlDbType.varchar, 50, "comprobante")
        oda.SelectCommand.Parameters("@comprobante").Value = Me.comprobante
        oda.SelectCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        oda.SelectCommand.Parameters("@importe").Value = Me.importe
        oda.SelectCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        oda.SelectCommand.Parameters("@iva").Value = Me.iva
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 50, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        oda.SelectCommand.Parameters("@control").Value = Me.control
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@archivado", SqlDbType.bit, 1, "archivado")
        oda.SelectCommand.Parameters("@archivado").Value = Me.archivado

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
        Command.CommandText = "DELETE FROM Ingreso_efectivo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Ingreso_efectivo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Ingreso_efectivo_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Ingreso_efectivo")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Ingreso_efectivo.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
