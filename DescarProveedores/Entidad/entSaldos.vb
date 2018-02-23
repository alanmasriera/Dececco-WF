Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Saldos_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_saldo As Int32
    Public ReadOnly Property id_saldo() As Int32
        Get
            _id_saldo = CInt(dr("id_saldo"))
            Return _id_saldo
        End Get
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

    Private _fecha_saldo As DateTime
    Public Property fecha_saldo() As DateTime
        Get
            _fecha_saldo = CDate(dr("fecha_saldo"))
            Return _fecha_saldo
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_saldo") = Value
        End Set
    end property

    Private _saldo As Decimal
    Public Property saldo() As Decimal
        Get
            _saldo = CDec(dr("saldo"))
            Return _saldo
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo") = Value
        End Set
    end property

    Private _saldo_libre As Decimal
    Public Property saldo_libre() As Decimal
        Get
            _saldo_libre = CDec(dr("saldo_libre"))
            Return _saldo_libre
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_libre") = Value
        End Set
    end property

    Private _utilizado As Decimal
    Public Property utilizado() As Decimal
        Get
            _utilizado = CDec(dr("utilizado"))
            Return _utilizado
        End Get
        Set(ByVal Value As Decimal)
            dr("utilizado") = Value
        End Set
    end property

    Private _otro As Decimal
    Public Property otro() As Decimal
        Get
            _otro = CDec(dr("otro"))
            Return _otro
        End Get
        Set(ByVal Value As Decimal)
            dr("otro") = Value
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

    Private _decreto_730 As Decimal
    Public Property decreto_730() As Decimal
        Get
            _decreto_730 = CDec(dr("decreto_730"))
            Return _decreto_730
        End Get
        Set(ByVal Value As Decimal)
            dr("decreto_730") = Value
        End Set
    end property

    Private _combustible As Decimal
    Public Property combustible() As Decimal
        Get
            _combustible = CDec(dr("combustible"))
            Return _combustible
        End Get
        Set(ByVal Value As Decimal)
            dr("combustible") = Value
        End Set
    end property

    Private _bandera As Int32
    Public Property bandera() As Int32
        Get
            _bandera = CInt(dr("bandera"))
            Return _bandera
        End Get
        Set(ByVal Value As Int32)
            dr("bandera") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Saldos")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Saldos_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_saldo", SqlDbType.int, 0, "id_saldo")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@fecha_saldo", SqlDbType.datetime, 8, "fecha_saldo")
        da.InsertCommand.Parameters.Add("@saldo", SqlDbType.decimal, 9, "saldo")
        da.InsertCommand.Parameters.Add("@saldo_libre", SqlDbType.decimal, 9, "saldo_libre")
        da.InsertCommand.Parameters.Add("@utilizado", SqlDbType.decimal, 9, "utilizado")
        da.InsertCommand.Parameters.Add("@otro", SqlDbType.decimal, 9, "otro")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.char, 50, "detalle")
        da.InsertCommand.Parameters.Add("@decreto_730", SqlDbType.decimal, 9, "decreto_730")
        da.InsertCommand.Parameters.Add("@combustible", SqlDbType.decimal, 9, "combustible")
        da.InsertCommand.Parameters.Add("@bandera", SqlDbType.int, 4, "bandera")

        dr = dt.NewRow()
        dr("id_empresa") = 0
        dr("fecha_saldo") = DateTime.Now
        dr("saldo") = 0
        dr("saldo_libre") = 0
        dr("utilizado") = 0
        dr("otro") = 0
        dr("detalle") = ""
        dr("decreto_730") = 0
        dr("combustible") = 0
        dr("bandera") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idSaldos As Integer)
        dt = New DataTable("Saldos")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Saldos WHERE id_saldo = @id_Saldos", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Saldos", idSaldos)
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
    Public Sub Borrar(ByVal idSaldos As Integer)
        dt = New DataTable("Saldos")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Saldos WHERE id_saldo = " & _
        idSaldos, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Saldos_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_saldo", SqlDbType.Int, 4, "id_saldo")
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
               Case "id_saldo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_saldo"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "saldo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "saldo_libre"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "utilizado"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "otro"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "decreto_730"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "combustible"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "bandera"
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
        dt = New DataTable("Saldos")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Saldos WHERE id_saldo = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldos_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldos_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldos_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Saldos As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldos_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_saldo", SqlDbType.Int, 4, "id_saldo")
        oda.SelectCommand.Parameters("@id_saldo").Value = id_Saldos

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldos_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@fecha_saldo", SqlDbType.datetime, 8, "fecha_saldo")
        oda.SelectCommand.Parameters("@fecha_saldo").Value = Me.fecha_saldo
        oda.SelectCommand.Parameters.Add("@saldo", SqlDbType.decimal, 9, "saldo")
        oda.SelectCommand.Parameters("@saldo").Value = Me.saldo
        oda.SelectCommand.Parameters.Add("@saldo_libre", SqlDbType.decimal, 9, "saldo_libre")
        oda.SelectCommand.Parameters("@saldo_libre").Value = Me.saldo_libre
        oda.SelectCommand.Parameters.Add("@utilizado", SqlDbType.decimal, 9, "utilizado")
        oda.SelectCommand.Parameters("@utilizado").Value = Me.utilizado
        oda.SelectCommand.Parameters.Add("@otro", SqlDbType.decimal, 9, "otro")
        oda.SelectCommand.Parameters("@otro").Value = Me.otro
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.char, 50, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@decreto_730", SqlDbType.decimal, 9, "decreto_730")
        oda.SelectCommand.Parameters("@decreto_730").Value = Me.decreto_730
        oda.SelectCommand.Parameters.Add("@combustible", SqlDbType.decimal, 9, "combustible")
        oda.SelectCommand.Parameters("@combustible").Value = Me.combustible
        oda.SelectCommand.Parameters.Add("@bandera", SqlDbType.int, 4, "bandera")
        oda.SelectCommand.Parameters("@bandera").Value = Me.bandera

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
        Command.CommandText = "DELETE FROM Saldos"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Saldos"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Saldos_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Saldos")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Saldos.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
