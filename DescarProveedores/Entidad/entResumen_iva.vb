Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_iva_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_resumen_Iva As Int32
    Public ReadOnly Property id_resumen_Iva() As Int32
        Get
            _id_resumen_Iva = CInt(dr("id_resumen_Iva"))
            Return _id_resumen_Iva
        End Get
    end property

    Private _debe_Iva As Decimal
    Public Property debe_Iva() As Decimal
        Get
            _debe_Iva = CDec(dr("debe_Iva"))
            Return _debe_Iva
        End Get
        Set(ByVal Value As Decimal)
            dr("debe_Iva") = Value
        End Set
    end property

    Private _haber_Iva As Decimal
    Public Property haber_Iva() As Decimal
        Get
            _haber_Iva = CDec(dr("haber_Iva"))
            Return _haber_Iva
        End Get
        Set(ByVal Value As Decimal)
            dr("haber_Iva") = Value
        End Set
    end property

    Private _detalle_Iva As String
    Public Property detalle_Iva() As String
        Get
            _detalle_Iva = CStr(dr("detalle_Iva"))
            Return _detalle_Iva
        End Get
        Set(ByVal Value As String)
            dr("detalle_Iva") = Value
        End Set
    end property

    Private _fecha_Iva As DateTime
    Public Property fecha_Iva() As DateTime
        Get
            _fecha_Iva = CDate(dr("fecha_Iva"))
            Return _fecha_Iva
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_Iva") = Value
        End Set
    end property

    Private _saldo_Iva As Decimal
    Public Property saldo_Iva() As Decimal
        Get
            _saldo_Iva = CDec(dr("saldo_Iva"))
            Return _saldo_Iva
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_Iva") = Value
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

    Private _iva_no_ins As Decimal
    Public Property iva_no_ins() As Decimal
        Get
            _iva_no_ins = CDec(dr("iva_no_ins"))
            Return _iva_no_ins
        End Get
        Set(ByVal Value As Decimal)
            dr("iva_no_ins") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Resumen_iva")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Resumen_iva_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_resumen_Iva", SqlDbType.int, 0, "id_resumen_Iva")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@debe_Iva", SqlDbType.decimal, 9, "debe_Iva")
        da.InsertCommand.Parameters.Add("@haber_Iva", SqlDbType.decimal, 9, "haber_Iva")
        da.InsertCommand.Parameters.Add("@detalle_Iva", SqlDbType.varchar, 300, "detalle_Iva")
        da.InsertCommand.Parameters.Add("@fecha_Iva", SqlDbType.datetime, 8, "fecha_Iva")
        da.InsertCommand.Parameters.Add("@saldo_Iva", SqlDbType.decimal, 9, "saldo_Iva")
        da.InsertCommand.Parameters.Add("@imp_gravado", SqlDbType.decimal, 9, "imp_gravado")
        da.InsertCommand.Parameters.Add("@imp_exento", SqlDbType.decimal, 9, "imp_exento")
        da.InsertCommand.Parameters.Add("@conc_no_grav", SqlDbType.decimal, 9, "conc_no_grav")
        da.InsertCommand.Parameters.Add("@iva_no_ins", SqlDbType.decimal, 9, "iva_no_ins")
        da.InsertCommand.Parameters.Add("@iva_ret", SqlDbType.decimal, 9, "iva_ret")
        da.InsertCommand.Parameters.Add("@totals", SqlDbType.decimal, 9, "totals")

        dr = dt.NewRow()
        dr("debe_Iva") = 0
        dr("haber_Iva") = 0
        dr("detalle_Iva") = ""
        dr("fecha_Iva") = DateTime.Now
        dr("saldo_Iva") = 0
        dr("imp_gravado") = 0
        dr("imp_exento") = 0
        dr("conc_no_grav") = 0
        dr("iva_no_ins") = 0
        dr("iva_ret") = 0
        dr("totals") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idResumen_iva As Integer)
        dt = New DataTable("Resumen_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Resumen_iva WHERE id_resumen_Iva = @id_Resumen_iva", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Resumen_iva", idResumen_iva)
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
    Public Sub Borrar(ByVal idResumen_iva As Integer)
        dt = New DataTable("Resumen_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Resumen_iva WHERE id_resumen_Iva = " & _
        idResumen_iva, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Resumen_iva_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_resumen_Iva", SqlDbType.Int, 4, "id_resumen_Iva")
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
               Case "id_resumen_Iva"
                  dc.DataType = Type.GetType("System.Int32")
               Case "debe_Iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "haber_Iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "detalle_Iva"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_Iva"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "saldo_Iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "imp_gravado"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "imp_exento"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "conc_no_grav"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva_no_ins"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva_ret"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "totals"
                  dc.DataType = Type.GetType("System.Decimal")
            End Select
        Next
    End Sub

    'creo el commandbuilder
    Friend Sub CrearComandoUpdate()
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
        dt = New DataTable("Resumen_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Resumen_iva WHERE id_resumen_Iva = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_iva_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_iva_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_iva_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Resumen_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_iva_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_Iva", SqlDbType.Int, 4, "id_resumen_Iva")
        oda.SelectCommand.Parameters("@id_resumen_Iva").Value = id_Resumen_iva

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_iva_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@debe_Iva", SqlDbType.decimal, 9, "debe_Iva")
        oda.SelectCommand.Parameters("@debe_Iva").Value = Me.debe_Iva
        oda.SelectCommand.Parameters.Add("@haber_Iva", SqlDbType.decimal, 9, "haber_Iva")
        oda.SelectCommand.Parameters("@haber_Iva").Value = Me.haber_Iva
        oda.SelectCommand.Parameters.Add("@detalle_Iva", SqlDbType.varchar, 300, "detalle_Iva")
        oda.SelectCommand.Parameters("@detalle_Iva").Value = Me.detalle_Iva
        oda.SelectCommand.Parameters.Add("@fecha_Iva", SqlDbType.datetime, 8, "fecha_Iva")
        oda.SelectCommand.Parameters("@fecha_Iva").Value = Me.fecha_Iva
        oda.SelectCommand.Parameters.Add("@saldo_Iva", SqlDbType.decimal, 9, "saldo_Iva")
        oda.SelectCommand.Parameters("@saldo_Iva").Value = Me.saldo_Iva
        oda.SelectCommand.Parameters.Add("@imp_gravado", SqlDbType.decimal, 9, "imp_gravado")
        oda.SelectCommand.Parameters("@imp_gravado").Value = Me.imp_gravado
        oda.SelectCommand.Parameters.Add("@imp_exento", SqlDbType.decimal, 9, "imp_exento")
        oda.SelectCommand.Parameters("@imp_exento").Value = Me.imp_exento
        oda.SelectCommand.Parameters.Add("@conc_no_grav", SqlDbType.decimal, 9, "conc_no_grav")
        oda.SelectCommand.Parameters("@conc_no_grav").Value = Me.conc_no_grav
        oda.SelectCommand.Parameters.Add("@iva_no_ins", SqlDbType.decimal, 9, "iva_no_ins")
        oda.SelectCommand.Parameters("@iva_no_ins").Value = Me.iva_no_ins
        oda.SelectCommand.Parameters.Add("@iva_ret", SqlDbType.decimal, 9, "iva_ret")
        oda.SelectCommand.Parameters("@iva_ret").Value = Me.iva_ret
        oda.SelectCommand.Parameters.Add("@totals", SqlDbType.decimal, 9, "totals")
        oda.SelectCommand.Parameters("@totals").Value = Me.totals

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
        Command.CommandText = "DELETE FROM Resumen_iva"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Resumen_iva"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_iva_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Resumen_iva")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Resumen_iva.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
