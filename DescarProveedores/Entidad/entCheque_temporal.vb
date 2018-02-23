Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheque_temporal_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_pk As Int32
    Public ReadOnly Property id_pk() As Int32
        Get
            _id_pk = CInt(dr("id_pk"))
            Return _id_pk
        End Get
    end property

    Private _id_cheque As Int32
    Public Property id_cheque() As Int32
        Get
            _id_cheque = CInt(dr("id_cheque"))
            Return _id_cheque
        End Get
        Set(ByVal Value As Int32)
            dr("id_cheque") = Value
        End Set
    end property

    Private _tipo_cheque As String
    Public Property tipo_cheque() As String
        Get
            _tipo_cheque = CStr(dr("tipo_cheque"))
            Return _tipo_cheque
        End Get
        Set(ByVal Value As String)
            dr("tipo_cheque") = Value
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

    Private _numero_cheque As String
    Public Property numero_cheque() As String
        Get
            _numero_cheque = CStr(dr("numero_cheque"))
            Return _numero_cheque
        End Get
        Set(ByVal Value As String)
            dr("numero_cheque") = Value
        End Set
    end property

    Private _importe_cheque As Decimal
    Public Property importe_cheque() As Decimal
        Get
            _importe_cheque = CDec(dr("importe_cheque"))
            Return _importe_cheque
        End Get
        Set(ByVal Value As Decimal)
            dr("importe_cheque") = Value
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

    Private _fecha_1 As DateTime
    Public Property fecha_1() As DateTime
        Get
            _fecha_1 = CDate(dr("fecha_1"))
            Return _fecha_1
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_1") = Value
        End Set
    end property

    Private _fecha_2 As DateTime
    Public Property fecha_2() As DateTime
        Get
            _fecha_2 = CDate(dr("fecha_2"))
            Return _fecha_2
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_2") = Value
        End Set
    end property

    Private _fecha_3 As DateTime
    Public Property fecha_3() As DateTime
        Get
            _fecha_3 = CDate(dr("fecha_3"))
            Return _fecha_3
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_3") = Value
        End Set
    end property

    Private _nombre_banco As String
    Public Property nombre_banco() As String
        Get
            _nombre_banco = CStr(dr("nombre_banco"))
            Return _nombre_banco
        End Get
        Set(ByVal Value As String)
            dr("nombre_banco") = Value
        End Set
    end property

    Private _cliente_proveedor As String
    Public Property cliente_proveedor() As String
        Get
            _cliente_proveedor = CStr(dr("cliente_proveedor"))
            Return _cliente_proveedor
        End Get
        Set(ByVal Value As String)
            dr("cliente_proveedor") = Value
        End Set
    end property

    Private _vendido As Boolean
    Public Property vendido() As Boolean
        Get
            _vendido = CBool(dr("vendido"))
            Return _vendido
        End Get
        Set(ByVal Value As Boolean)
            dr("vendido") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cheque_temporal")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cheque_temporal_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_pk", SqlDbType.int, 0, "id_pk")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_cheque", SqlDbType.int, 4, "id_cheque")
        da.InsertCommand.Parameters.Add("@tipo_cheque", SqlDbType.varchar, 50, "tipo_cheque")
        da.InsertCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        da.InsertCommand.Parameters.Add("@numero_cheque", SqlDbType.varchar, 50, "numero_cheque")
        da.InsertCommand.Parameters.Add("@importe_cheque", SqlDbType.decimal, 9, "importe_cheque")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 500, "detalle")
        da.InsertCommand.Parameters.Add("@fecha_1", SqlDbType.datetime, 8, "fecha_1")
        da.InsertCommand.Parameters.Add("@fecha_2", SqlDbType.datetime, 8, "fecha_2")
        da.InsertCommand.Parameters.Add("@fecha_3", SqlDbType.datetime, 8, "fecha_3")
        da.InsertCommand.Parameters.Add("@nombre_banco", SqlDbType.varchar, 50, "nombre_banco")
        da.InsertCommand.Parameters.Add("@cliente_proveedor", SqlDbType.varchar, 50, "cliente_proveedor")
        da.InsertCommand.Parameters.Add("@vendido", SqlDbType.bit, 1, "vendido")

        dr = dt.NewRow()
        dr("id_cheque") = 0
        dr("tipo_cheque") = ""
        dr("control") = False
        dr("numero_cheque") = ""
        dr("importe_cheque") = 0
        dr("detalle") = ""
        dr("fecha_1") = DateTime.Now
        dr("fecha_2") = DateTime.Now
        dr("fecha_3") = DateTime.Now
        dr("nombre_banco") = ""
        dr("cliente_proveedor") = ""
        dr("vendido") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCheque_temporal As Integer)
        dt = New DataTable("Cheque_temporal")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheque_temporal WHERE id_pk = @id_Cheque_temporal", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cheque_temporal", idCheque_temporal)
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
    Public Sub Borrar(ByVal idCheque_temporal As Integer)
        dt = New DataTable("Cheque_temporal")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheque_temporal WHERE id_pk = " & _
        idCheque_temporal, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cheque_temporal_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_pk", SqlDbType.Int, 4, "id_pk")
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
               Case "id_pk"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cheque"
                  dc.DataType = Type.GetType("System.Int32")
               Case "tipo_cheque"
                  dc.DataType = Type.GetType("System.String")
               Case "control"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "numero_cheque"
                  dc.DataType = Type.GetType("System.String")
               Case "importe_cheque"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_1"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_2"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_3"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "nombre_banco"
                  dc.DataType = Type.GetType("System.String")
               Case "cliente_proveedor"
                  dc.DataType = Type.GetType("System.String")
               Case "vendido"
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
        dt = New DataTable("Cheque_temporal")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheque_temporal WHERE id_pk = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_temporal_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_temporal_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_temporal_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cheque_temporal As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_temporal_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pk", SqlDbType.Int, 4, "id_pk")
        oda.SelectCommand.Parameters("@id_pk").Value = id_Cheque_temporal

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_temporal_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cheque", SqlDbType.int, 4, "id_cheque")
        oda.SelectCommand.Parameters("@id_cheque").Value = Me.id_cheque
        oda.SelectCommand.Parameters.Add("@tipo_cheque", SqlDbType.varchar, 50, "tipo_cheque")
        oda.SelectCommand.Parameters("@tipo_cheque").Value = Me.tipo_cheque
        oda.SelectCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        oda.SelectCommand.Parameters("@control").Value = Me.control
        oda.SelectCommand.Parameters.Add("@numero_cheque", SqlDbType.varchar, 50, "numero_cheque")
        oda.SelectCommand.Parameters("@numero_cheque").Value = Me.numero_cheque
        oda.SelectCommand.Parameters.Add("@importe_cheque", SqlDbType.decimal, 9, "importe_cheque")
        oda.SelectCommand.Parameters("@importe_cheque").Value = Me.importe_cheque
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 500, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@fecha_1", SqlDbType.datetime, 8, "fecha_1")
        oda.SelectCommand.Parameters("@fecha_1").Value = Me.fecha_1
        oda.SelectCommand.Parameters.Add("@fecha_2", SqlDbType.datetime, 8, "fecha_2")
        oda.SelectCommand.Parameters("@fecha_2").Value = Me.fecha_2
        oda.SelectCommand.Parameters.Add("@fecha_3", SqlDbType.datetime, 8, "fecha_3")
        oda.SelectCommand.Parameters("@fecha_3").Value = Me.fecha_3
        oda.SelectCommand.Parameters.Add("@nombre_banco", SqlDbType.varchar, 50, "nombre_banco")
        oda.SelectCommand.Parameters("@nombre_banco").Value = Me.nombre_banco
        oda.SelectCommand.Parameters.Add("@cliente_proveedor", SqlDbType.varchar, 50, "cliente_proveedor")
        oda.SelectCommand.Parameters("@cliente_proveedor").Value = Me.cliente_proveedor
        oda.SelectCommand.Parameters.Add("@vendido", SqlDbType.bit, 1, "vendido")
        oda.SelectCommand.Parameters("@vendido").Value = Me.vendido

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
        Command.CommandText = "DELETE FROM Cheque_temporal"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cheque_temporal"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheque_temporal_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cheque_temporal")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cheque_temporal.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
