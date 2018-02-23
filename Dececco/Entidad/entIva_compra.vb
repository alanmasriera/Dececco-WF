Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Iva_compra_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_iva_compra As Int32
    Public ReadOnly Property id_iva_compra() As Int32
        Get
            _id_iva_compra = CInt(dr("id_iva_compra"))
            Return _id_iva_compra
        End Get
    end property

    Private _numero As String
    Public Property numero() As String
        Get
            _numero = CStr(dr("numero"))
            Return _numero
        End Get
        Set(ByVal Value As String)
            dr("numero") = Value
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

    Private _factura As String
    Public Property factura() As String
        Get
            _factura = CStr(dr("factura"))
            Return _factura
        End Get
        Set(ByVal Value As String)
            dr("factura") = Value
        End Set
    end property

    Private _nombre As String
    Public Property nombre() As String
        Get
            _nombre = CStr(dr("nombre"))
            Return _nombre
        End Get
        Set(ByVal Value As String)
            dr("nombre") = Value
        End Set
    end property

    Private _cuit As String
    Public Property cuit() As String
        Get
            _cuit = CStr(dr("cuit"))
            Return _cuit
        End Get
        Set(ByVal Value As String)
            dr("cuit") = Value
        End Set
    end property

    Private _imp_gravado As Decimal
    Public Property imp_gravado() As Decimal
        Get
            _imp_gravado = CDec(dr("imp_gravado"))
            Return _imp_gravado
        End Get
        Set(ByVal Value As Decimal)
            dr("imp_gravado") = Value
        End Set
    end property

    Private _imp_exento As Decimal
    Public Property imp_exento() As Decimal
        Get
            _imp_exento = CDec(dr("imp_exento"))
            Return _imp_exento
        End Get
        Set(ByVal Value As Decimal)
            dr("imp_exento") = Value
        End Set
    end property

    Private _conc_no_grav As Decimal
    Public Property conc_no_grav() As Decimal
        Get
            _conc_no_grav = CDec(dr("conc_no_grav"))
            Return _conc_no_grav
        End Get
        Set(ByVal Value As Decimal)
            dr("conc_no_grav") = Value
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

    Private _imp_otro As Decimal
    Public Property imp_otro() As Decimal
        Get
            _imp_otro = CDec(dr("imp_otro"))
            Return _imp_otro
        End Get
        Set(ByVal Value As Decimal)
            dr("imp_otro") = Value
        End Set
    end property

    Private _totals As Decimal
    Public Property totals() As Decimal
        Get
            _totals = CDec(dr("totals"))
            Return _totals
        End Get
        Set(ByVal Value As Decimal)
            dr("totals") = Value
        End Set
    end property

    Private _iva_ret As Decimal
    Public Property iva_ret() As Decimal
        Get
            _iva_ret = CDec(dr("iva_ret"))
            Return _iva_ret
        End Get
        Set(ByVal Value As Decimal)
            dr("iva_ret") = Value
        End Set
    end property

    Private _cerrado As Boolean
    Public Property cerrado() As Boolean
        Get
            _cerrado = CBool(dr("cerrado"))
            Return _cerrado
        End Get
        Set(ByVal Value As Boolean)
            dr("cerrado") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Iva_compra")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Iva_compra_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_iva_compra", SqlDbType.int, 0, "id_iva_compra")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@factura", SqlDbType.varchar, 50, "factura")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.varchar, 500, "nombre")
        da.InsertCommand.Parameters.Add("@cuit", SqlDbType.varchar, 50, "cuit")
        da.InsertCommand.Parameters.Add("@imp_gravado", SqlDbType.decimal, 9, "imp_gravado")
        da.InsertCommand.Parameters.Add("@imp_exento", SqlDbType.decimal, 9, "imp_exento")
        da.InsertCommand.Parameters.Add("@conc_no_grav", SqlDbType.decimal, 9, "conc_no_grav")
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        da.InsertCommand.Parameters.Add("@imp_otro", SqlDbType.decimal, 9, "imp_otro")
        da.InsertCommand.Parameters.Add("@totals", SqlDbType.decimal, 9, "totals")
        da.InsertCommand.Parameters.Add("@iva_ret", SqlDbType.decimal, 9, "iva_ret")
        da.InsertCommand.Parameters.Add("@cerrado", SqlDbType.bit, 1, "cerrado")

        dr = dt.NewRow()
        dr("numero") = ""
        dr("fecha") = DateTime.Now
        dr("factura") = ""
        dr("nombre") = ""
        dr("cuit") = ""
        dr("imp_gravado") = 0
        dr("imp_exento") = 0
        dr("conc_no_grav") = 0
        dr("iva") = 0
        dr("imp_otro") = 0
        dr("totals") = 0
        dr("iva_ret") = 0
        dr("cerrado") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idIva_compra As Integer)
        dt = New DataTable("Iva_compra")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Iva_compra WHERE id_iva_compra = @id_Iva_compra", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Iva_compra", idIva_compra)
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
    Public Sub Borrar(ByVal idIva_compra As Integer)
        dt = New DataTable("Iva_compra")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Iva_compra WHERE id_iva_compra = " & _
        idIva_compra, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Iva_compra_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_iva_compra", SqlDbType.Int, 4, "id_iva_compra")
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
               Case "id_iva_compra"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "factura"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre"
                  dc.DataType = Type.GetType("System.String")
               Case "cuit"
                  dc.DataType = Type.GetType("System.String")
               Case "imp_gravado"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "imp_exento"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "conc_no_grav"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "imp_otro"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "totals"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva_ret"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "cerrado"
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
        dt = New DataTable("Iva_compra")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Iva_compra WHERE id_iva_compra = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva_compra_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva_compra_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva_compra_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Iva_compra As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva_compra_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_iva_compra", SqlDbType.Int, 4, "id_iva_compra")
        oda.SelectCommand.Parameters("@id_iva_compra").Value = id_Iva_compra

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva_compra_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        oda.SelectCommand.Parameters("@numero").Value = Me.numero
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@factura", SqlDbType.varchar, 50, "factura")
        oda.SelectCommand.Parameters("@factura").Value = Me.factura
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.varchar, 500, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Me.nombre
        oda.SelectCommand.Parameters.Add("@cuit", SqlDbType.varchar, 50, "cuit")
        oda.SelectCommand.Parameters("@cuit").Value = Me.cuit
        oda.SelectCommand.Parameters.Add("@imp_gravado", SqlDbType.decimal, 9, "imp_gravado")
        oda.SelectCommand.Parameters("@imp_gravado").Value = Me.imp_gravado
        oda.SelectCommand.Parameters.Add("@imp_exento", SqlDbType.decimal, 9, "imp_exento")
        oda.SelectCommand.Parameters("@imp_exento").Value = Me.imp_exento
        oda.SelectCommand.Parameters.Add("@conc_no_grav", SqlDbType.decimal, 9, "conc_no_grav")
        oda.SelectCommand.Parameters("@conc_no_grav").Value = Me.conc_no_grav
        oda.SelectCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        oda.SelectCommand.Parameters("@iva").Value = Me.iva
        oda.SelectCommand.Parameters.Add("@imp_otro", SqlDbType.decimal, 9, "imp_otro")
        oda.SelectCommand.Parameters("@imp_otro").Value = Me.imp_otro
        oda.SelectCommand.Parameters.Add("@totals", SqlDbType.decimal, 9, "totals")
        oda.SelectCommand.Parameters("@totals").Value = Me.totals
        oda.SelectCommand.Parameters.Add("@iva_ret", SqlDbType.decimal, 9, "iva_ret")
        oda.SelectCommand.Parameters("@iva_ret").Value = Me.iva_ret
        oda.SelectCommand.Parameters.Add("@cerrado", SqlDbType.bit, 1, "cerrado")
        oda.SelectCommand.Parameters("@cerrado").Value = Me.cerrado

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
        Command.CommandText = "DELETE FROM Iva_compra"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Iva_compra"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Iva_compra_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Iva_compra")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Iva_compra.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
