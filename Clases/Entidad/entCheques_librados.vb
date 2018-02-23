Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheques_librados_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cheque_librado As Int32
    Public ReadOnly Property id_cheque_librado() As Int32
        Get
            _id_cheque_librado = CInt(dr("id_cheque_librado"))
            Return _id_cheque_librado
        End Get
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

    Private _banco_cheque As Int32
    Public Property banco_cheque() As Int32
        Get
            _banco_cheque = CInt(dr("banco_cheque"))
            Return _banco_cheque
        End Get
        Set(ByVal Value As Int32)
            dr("banco_cheque") = Value
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

    Private _fecha_librado As DateTime
    Public Property fecha_librado() As DateTime
        Get
            _fecha_librado = CDate(dr("fecha_librado"))
            Return _fecha_librado
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_librado") = Value
        End Set
    end property

    Private _fecha_pago As DateTime
    Public Property fecha_pago() As DateTime
        Get
            _fecha_pago = CDate(dr("fecha_pago"))
            Return _fecha_pago
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_pago") = Value
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

    Private _id_chequera As Int32
    Public Property id_chequera() As Int32
        Get
            _id_chequera = CInt(dr("id_chequera"))
            Return _id_chequera
        End Get
        Set(ByVal Value As Int32)
            dr("id_chequera") = Value
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

    Private _anulado As Boolean
    Public Property anulado() As Boolean
        Get
            _anulado = CBool(dr("anulado"))
            Return _anulado
        End Get
        Set(ByVal Value As Boolean)
            dr("anulado") = Value
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
        dt = New DataTable("Cheques_librados")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cheques_librados_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cheque_librado", SqlDbType.int, 0, "id_cheque_librado")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 50, "detalle")
        da.InsertCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        da.InsertCommand.Parameters.Add("@banco_cheque", SqlDbType.int, 4, "banco_cheque")
        da.InsertCommand.Parameters.Add("@numero_cheque", SqlDbType.varchar, 50, "numero_cheque")
        da.InsertCommand.Parameters.Add("@fecha_librado", SqlDbType.datetime, 8, "fecha_librado")
        da.InsertCommand.Parameters.Add("@fecha_pago", SqlDbType.datetime, 8, "fecha_pago")
        da.InsertCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@periodo", SqlDbType.datetime, 8, "periodo")
        da.InsertCommand.Parameters.Add("@id_cuenta", SqlDbType.int, 4, "id_cuenta")
        da.InsertCommand.Parameters.Add("@id_chequera", SqlDbType.int, 4, "id_chequera")
        da.InsertCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        da.InsertCommand.Parameters.Add("@anulado", SqlDbType.bit, 1, "anulado")
        da.InsertCommand.Parameters.Add("@archivado", SqlDbType.bit, 1, "archivado")

        dr = dt.NewRow()
        dr("detalle") = ""
        dr("id_proveedor") = 0
        dr("banco_cheque") = 0
        dr("numero_cheque") = ""
        dr("fecha_librado") = DateTime.Now
        dr("fecha_pago") = DateTime.Now
        dr("importe") = 0
        dr("id_empresa") = 0
        dr("periodo") = DateTime.Now
        dr("id_cuenta") = 0
        dr("id_chequera") = 0
        dr("control") = False
        dr("iva") = 0
        dr("anulado") = False
        dr("archivado") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCheques_librados As Integer)
        dt = New DataTable("Cheques_librados")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheques_librados WHERE id_cheque_librado = @id_Cheques_librados", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cheques_librados", idCheques_librados)
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
    Public Sub Borrar(ByVal idCheques_librados As Integer)
        dt = New DataTable("Cheques_librados")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheques_librados WHERE id_cheque_librado = " & _
        idCheques_librados, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cheques_librados_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cheque_librado", SqlDbType.Int, 4, "id_cheque_librado")
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
               Case "id_cheque_librado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "id_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "banco_cheque"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero_cheque"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_librado"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_pago"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "importe"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "periodo"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_cuenta"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_chequera"
                  dc.DataType = Type.GetType("System.Int32")
               Case "control"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "anulado"
                  dc.DataType = Type.GetType("System.Boolean")
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
        dt = New DataTable("Cheques_librados")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheques_librados WHERE id_cheque_librado = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_librados_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_librados_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_librados_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cheques_librados As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_librados_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cheque_librado", SqlDbType.Int, 4, "id_cheque_librado")
        oda.SelectCommand.Parameters("@id_cheque_librado").Value = id_Cheques_librados

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_librados_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 50, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = Me.id_proveedor
        oda.SelectCommand.Parameters.Add("@banco_cheque", SqlDbType.int, 4, "banco_cheque")
        oda.SelectCommand.Parameters("@banco_cheque").Value = Me.banco_cheque
        oda.SelectCommand.Parameters.Add("@numero_cheque", SqlDbType.varchar, 50, "numero_cheque")
        oda.SelectCommand.Parameters("@numero_cheque").Value = Me.numero_cheque
        oda.SelectCommand.Parameters.Add("@fecha_librado", SqlDbType.datetime, 8, "fecha_librado")
        oda.SelectCommand.Parameters("@fecha_librado").Value = Me.fecha_librado
        oda.SelectCommand.Parameters.Add("@fecha_pago", SqlDbType.datetime, 8, "fecha_pago")
        oda.SelectCommand.Parameters("@fecha_pago").Value = Me.fecha_pago
        oda.SelectCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        oda.SelectCommand.Parameters("@importe").Value = Me.importe
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@periodo", SqlDbType.datetime, 8, "periodo")
        oda.SelectCommand.Parameters("@periodo").Value = Me.periodo
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = Me.id_cuenta
        oda.SelectCommand.Parameters.Add("@id_chequera", SqlDbType.int, 4, "id_chequera")
        oda.SelectCommand.Parameters("@id_chequera").Value = Me.id_chequera
        oda.SelectCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        oda.SelectCommand.Parameters("@control").Value = Me.control
        oda.SelectCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        oda.SelectCommand.Parameters("@iva").Value = Me.iva
        oda.SelectCommand.Parameters.Add("@anulado", SqlDbType.bit, 1, "anulado")
        oda.SelectCommand.Parameters("@anulado").Value = Me.anulado
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
        Command.CommandText = "DELETE FROM Cheques_librados"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cheques_librados"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheques_librados_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cheques_librados")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cheques_librados.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
