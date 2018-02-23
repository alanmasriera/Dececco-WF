Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Egreso_efectivo_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_Egreso_efectivo As Int32
    Public ReadOnly Property id_Egreso_efectivo() As Int32
        Get
            _id_Egreso_efectivo = CInt(dr("id_Egreso_efectivo"))
            Return _id_Egreso_efectivo
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

    Private _a_rendir As Boolean
    Public Property a_rendir() As Boolean
        Get
            _a_rendir = CBool(dr("a_rendir"))
            Return _a_rendir
        End Get
        Set(ByVal Value As Boolean)
            dr("a_rendir") = Value
        End Set
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

    Private _id_tipo_egreso As Int32
    Public Property id_tipo_egreso() As Int32
        Get
            _id_tipo_egreso = CInt(dr("id_tipo_egreso"))
            Return _id_tipo_egreso
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_egreso") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Egreso_efectivo")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Egreso_efectivo_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_Egreso_efectivo", SqlDbType.int, 0, "id_Egreso_efectivo")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@comprobante", SqlDbType.varchar, 50, "comprobante")
        da.InsertCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 50, "detalle")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        da.InsertCommand.Parameters.Add("@a_rendir", SqlDbType.bit, 1, "a_rendir")
        da.InsertCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        da.InsertCommand.Parameters.Add("@archivado", SqlDbType.bit, 1, "archivado")
        da.InsertCommand.Parameters.Add("@id_tipo_egreso", SqlDbType.int, 4, "id_tipo_egreso")

        dr = dt.NewRow()
        dr("fecha") = DateTime.Now
        dr("comprobante") = ""
        dr("importe") = 0
        dr("iva") = 0
        dr("detalle") = ""
        dr("id_empresa") = 0
        dr("control") = False
        dr("a_rendir") = False
        dr("id_proveedor") = 0
        dr("archivado") = False
        dr("id_tipo_egreso") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idEgreso_efectivo As Integer)
        dt = New DataTable("Egreso_efectivo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Egreso_efectivo WHERE id_Egreso_efectivo = @id_Egreso_efectivo", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Egreso_efectivo", idEgreso_efectivo)
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
    Public Sub Borrar(ByVal idEgreso_efectivo As Integer)
        dt = New DataTable("Egreso_efectivo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Egreso_efectivo WHERE id_Egreso_efectivo = " & _
        idEgreso_efectivo, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Egreso_efectivo_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_Egreso_efectivo", SqlDbType.Int, 4, "id_Egreso_efectivo")
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
               Case "id_Egreso_efectivo"
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
               Case "a_rendir"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "archivado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_tipo_egreso"
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
        dt = New DataTable("Egreso_efectivo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Egreso_efectivo WHERE id_Egreso_efectivo = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Egreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Egreso_efectivo", SqlDbType.Int, 4, "id_Egreso_efectivo")
        oda.SelectCommand.Parameters("@id_Egreso_efectivo").Value = id_Egreso_efectivo

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_Exist", cnn.Coneccion)
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
        oda.SelectCommand.Parameters.Add("@a_rendir", SqlDbType.bit, 1, "a_rendir")
        oda.SelectCommand.Parameters("@a_rendir").Value = Me.a_rendir
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = Me.id_proveedor
        oda.SelectCommand.Parameters.Add("@archivado", SqlDbType.bit, 1, "archivado")
        oda.SelectCommand.Parameters("@archivado").Value = Me.archivado
        oda.SelectCommand.Parameters.Add("@id_tipo_egreso", SqlDbType.int, 4, "id_tipo_egreso")
        oda.SelectCommand.Parameters("@id_tipo_egreso").Value = Me.id_tipo_egreso

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
        Command.CommandText = "DELETE FROM Egreso_efectivo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Egreso_efectivo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Egreso_efectivo_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Egreso_efectivo")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Egreso_efectivo.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
