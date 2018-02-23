Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_sueldo_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_Recibo_sueldo As Int32
    Public ReadOnly Property id_Recibo_sueldo() As Int32
        Get
            _id_Recibo_sueldo = CInt(dr("id_Recibo_sueldo"))
            Return _id_Recibo_sueldo
        End Get
    end property

    Private _id_empleado As Int32
    Public Property id_empleado() As Int32
        Get
            _id_empleado = CInt(dr("id_empleado"))
            Return _id_empleado
        End Get
        Set(ByVal Value As Int32)
            dr("id_empleado") = Value
        End Set
    end property

    Private _liquidacion As String
    Public Property liquidacion() As String
        Get
            _liquidacion = CStr(dr("liquidacion"))
            Return _liquidacion
        End Get
        Set(ByVal Value As String)
            dr("liquidacion") = Value
        End Set
    end property

    Private _codigo As Decimal
    Public Property codigo() As Decimal
        Get
            _codigo = CDec(dr("codigo"))
            Return _codigo
        End Get
        Set(ByVal Value As Decimal)
            dr("codigo") = Value
        End Set
    end property

    Private _nombre_renglon As String
    Public Property nombre_renglon() As String
        Get
            _nombre_renglon = CStr(dr("nombre_renglon"))
            Return _nombre_renglon
        End Get
        Set(ByVal Value As String)
            dr("nombre_renglon") = Value
        End Set
    end property

    Private _cantidad As Decimal
    Public Property cantidad() As Decimal
        Get
            _cantidad = CDec(dr("cantidad"))
            Return _cantidad
        End Get
        Set(ByVal Value As Decimal)
            dr("cantidad") = Value
        End Set
    end property

    Private _haber As Decimal
    Public Property haber() As Decimal
        Get
            _haber = CDec(dr("haber"))
            Return _haber
        End Get
        Set(ByVal Value As Decimal)
            dr("haber") = Value
        End Set
    end property

    Private _deduccion As Decimal
    Public Property deduccion() As Decimal
        Get
            _deduccion = CDec(dr("deduccion"))
            Return _deduccion
        End Get
        Set(ByVal Value As Decimal)
            dr("deduccion") = Value
        End Set
    end property

    Private _adicional As Decimal
    Public Property adicional() As Decimal
        Get
            _adicional = CDec(dr("adicional"))
            Return _adicional
        End Get
        Set(ByVal Value As Decimal)
            dr("adicional") = Value
        End Set
    end property

    Private _remuneracion_basica As Decimal
    Public Property remuneracion_basica() As Decimal
        Get
            _remuneracion_basica = CDec(dr("remuneracion_basica"))
            Return _remuneracion_basica
        End Get
        Set(ByVal Value As Decimal)
            dr("remuneracion_basica") = Value
        End Set
    end property

    Private _fecha_liquidacion As DateTime
    Public Property fecha_liquidacion() As DateTime
        Get
            _fecha_liquidacion = CDate(dr("fecha_liquidacion"))
            Return _fecha_liquidacion
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_liquidacion") = Value
        End Set
    end property

    Private _remuneracion_basica_a_retenciones As Decimal
    Public Property remuneracion_basica_a_retenciones() As Decimal
        Get
            _remuneracion_basica_a_retenciones = CDec(dr("remuneracion_basica_a_retenciones"))
            Return _remuneracion_basica_a_retenciones
        End Get
        Set(ByVal Value As Decimal)
            dr("remuneracion_basica_a_retenciones") = Value
        End Set
    end property

    Private _retenciones_descuentos As Decimal
    Public Property retenciones_descuentos() As Decimal
        Get
            _retenciones_descuentos = CDec(dr("retenciones_descuentos"))
            Return _retenciones_descuentos
        End Get
        Set(ByVal Value As Decimal)
            dr("retenciones_descuentos") = Value
        End Set
    end property

    Private _remuneracion_no_sujeta_a_retencion As Decimal
    Public Property remuneracion_no_sujeta_a_retencion() As Decimal
        Get
            _remuneracion_no_sujeta_a_retencion = CDec(dr("remuneracion_no_sujeta_a_retencion"))
            Return _remuneracion_no_sujeta_a_retencion
        End Get
        Set(ByVal Value As Decimal)
            dr("remuneracion_no_sujeta_a_retencion") = Value
        End Set
    end property

    Private _neto_cobrado As Decimal
    Public Property neto_cobrado() As Decimal
        Get
            _neto_cobrado = CDec(dr("neto_cobrado"))
            Return _neto_cobrado
        End Get
        Set(ByVal Value As Decimal)
            dr("neto_cobrado") = Value
        End Set
    end property

    Private _tipo_sueldo As String
    Public Property tipo_sueldo() As String
        Get
            _tipo_sueldo = CStr(dr("tipo_sueldo"))
            Return _tipo_sueldo
        End Get
        Set(ByVal Value As String)
            dr("tipo_sueldo") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Recibo_sueldo")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Recibo_sueldo_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_Recibo_sueldo", SqlDbType.int, 0, "id_Recibo_sueldo")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        da.InsertCommand.Parameters.Add("@liquidacion", SqlDbType.varchar, 500, "liquidacion")
        da.InsertCommand.Parameters.Add("@codigo", SqlDbType.decimal, 9, "codigo")
        da.InsertCommand.Parameters.Add("@nombre_renglon", SqlDbType.varchar, 50, "nombre_renglon")
        da.InsertCommand.Parameters.Add("@cantidad", SqlDbType.decimal, 9, "cantidad")
        da.InsertCommand.Parameters.Add("@haber", SqlDbType.decimal, 9, "haber")
        da.InsertCommand.Parameters.Add("@deduccion", SqlDbType.decimal, 9, "deduccion")
        da.InsertCommand.Parameters.Add("@adicional", SqlDbType.decimal, 9, "adicional")
        da.InsertCommand.Parameters.Add("@remuneracion_basica", SqlDbType.decimal, 9, "remuneracion_basica")
        da.InsertCommand.Parameters.Add("@fecha_liquidacion", SqlDbType.datetime, 8, "fecha_liquidacion")
        da.InsertCommand.Parameters.Add("@remuneracion_basica_a_retenciones", SqlDbType.decimal, 9, "remuneracion_basica_a_retenciones")
        da.InsertCommand.Parameters.Add("@retenciones_descuentos", SqlDbType.decimal, 9, "retenciones_descuentos")
        da.InsertCommand.Parameters.Add("@remuneracion_no_sujeta_a_retencion", SqlDbType.decimal, 9, "remuneracion_no_sujeta_a_retencion")
        da.InsertCommand.Parameters.Add("@neto_cobrado", SqlDbType.decimal, 9, "neto_cobrado")
        da.InsertCommand.Parameters.Add("@tipo_sueldo", SqlDbType.char, 1, "tipo_sueldo")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")

        dr = dt.NewRow()
        dr("id_empleado") = 0
        dr("liquidacion") = ""
        dr("codigo") = 0
        dr("nombre_renglon") = ""
        dr("cantidad") = 0
        dr("haber") = 0
        dr("deduccion") = 0
        dr("adicional") = 0
        dr("remuneracion_basica") = 0
        dr("fecha_liquidacion") = DateTime.Now
        dr("remuneracion_basica_a_retenciones") = 0
        dr("retenciones_descuentos") = 0
        dr("remuneracion_no_sujeta_a_retencion") = 0
        dr("neto_cobrado") = 0
        dr("tipo_sueldo") = ""
        dr("fecha") = DateTime.Now
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idRecibo_sueldo As Integer)
        dt = New DataTable("Recibo_sueldo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_sueldo WHERE id_Recibo_sueldo = @id_Recibo_sueldo", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Recibo_sueldo", idRecibo_sueldo)
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
    Public Sub Borrar(ByVal idRecibo_sueldo As Integer)
        dt = New DataTable("Recibo_sueldo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_sueldo WHERE id_Recibo_sueldo = " & _
        idRecibo_sueldo, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Recibo_sueldo_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_Recibo_sueldo", SqlDbType.Int, 4, "id_Recibo_sueldo")
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
               Case "id_Recibo_sueldo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empleado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "liquidacion"
                  dc.DataType = Type.GetType("System.String")
               Case "codigo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "nombre_renglon"
                  dc.DataType = Type.GetType("System.String")
               Case "cantidad"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "haber"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "deduccion"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "adicional"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "remuneracion_basica"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "fecha_liquidacion"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "remuneracion_basica_a_retenciones"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "retenciones_descuentos"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "remuneracion_no_sujeta_a_retencion"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "neto_cobrado"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "tipo_sueldo"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
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
        dt = New DataTable("Recibo_sueldo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_sueldo WHERE id_Recibo_sueldo = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Recibo_sueldo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Recibo_sueldo", SqlDbType.Int, 4, "id_Recibo_sueldo")
        oda.SelectCommand.Parameters("@id_Recibo_sueldo").Value = id_Recibo_sueldo

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = Me.id_empleado
        oda.SelectCommand.Parameters.Add("@liquidacion", SqlDbType.varchar, 500, "liquidacion")
        oda.SelectCommand.Parameters("@liquidacion").Value = Me.liquidacion
        oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.decimal, 9, "codigo")
        oda.SelectCommand.Parameters("@codigo").Value = Me.codigo
        oda.SelectCommand.Parameters.Add("@nombre_renglon", SqlDbType.varchar, 50, "nombre_renglon")
        oda.SelectCommand.Parameters("@nombre_renglon").Value = Me.nombre_renglon
        oda.SelectCommand.Parameters.Add("@cantidad", SqlDbType.decimal, 9, "cantidad")
        oda.SelectCommand.Parameters("@cantidad").Value = Me.cantidad
        oda.SelectCommand.Parameters.Add("@haber", SqlDbType.decimal, 9, "haber")
        oda.SelectCommand.Parameters("@haber").Value = Me.haber
        oda.SelectCommand.Parameters.Add("@deduccion", SqlDbType.decimal, 9, "deduccion")
        oda.SelectCommand.Parameters("@deduccion").Value = Me.deduccion
        oda.SelectCommand.Parameters.Add("@adicional", SqlDbType.decimal, 9, "adicional")
        oda.SelectCommand.Parameters("@adicional").Value = Me.adicional
        oda.SelectCommand.Parameters.Add("@remuneracion_basica", SqlDbType.decimal, 9, "remuneracion_basica")
        oda.SelectCommand.Parameters("@remuneracion_basica").Value = Me.remuneracion_basica
        oda.SelectCommand.Parameters.Add("@fecha_liquidacion", SqlDbType.datetime, 8, "fecha_liquidacion")
        oda.SelectCommand.Parameters("@fecha_liquidacion").Value = Me.fecha_liquidacion
        oda.SelectCommand.Parameters.Add("@remuneracion_basica_a_retenciones", SqlDbType.decimal, 9, "remuneracion_basica_a_retenciones")
        oda.SelectCommand.Parameters("@remuneracion_basica_a_retenciones").Value = Me.remuneracion_basica_a_retenciones
        oda.SelectCommand.Parameters.Add("@retenciones_descuentos", SqlDbType.decimal, 9, "retenciones_descuentos")
        oda.SelectCommand.Parameters("@retenciones_descuentos").Value = Me.retenciones_descuentos
        oda.SelectCommand.Parameters.Add("@remuneracion_no_sujeta_a_retencion", SqlDbType.decimal, 9, "remuneracion_no_sujeta_a_retencion")
        oda.SelectCommand.Parameters("@remuneracion_no_sujeta_a_retencion").Value = Me.remuneracion_no_sujeta_a_retencion
        oda.SelectCommand.Parameters.Add("@neto_cobrado", SqlDbType.decimal, 9, "neto_cobrado")
        oda.SelectCommand.Parameters("@neto_cobrado").Value = Me.neto_cobrado
        oda.SelectCommand.Parameters.Add("@tipo_sueldo", SqlDbType.char, 1, "tipo_sueldo")
        oda.SelectCommand.Parameters("@tipo_sueldo").Value = Me.tipo_sueldo
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha

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
        Command.CommandText = "DELETE FROM Recibo_sueldo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Recibo_sueldo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Recibo_sueldo_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Recibo_sueldo")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Recibo_sueldo.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
