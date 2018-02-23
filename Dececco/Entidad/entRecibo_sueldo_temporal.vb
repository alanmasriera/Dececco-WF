Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_sueldo_temporal_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_recibo_sueldo_temporal As Int32
    Public ReadOnly Property id_recibo_sueldo_temporal() As Int32
        Get
            _id_recibo_sueldo_temporal = CInt(dr("id_recibo_sueldo_temporal"))
            Return _id_recibo_sueldo_temporal
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Recibo_sueldo_temporal")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Recibo_sueldo_temporal_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_recibo_sueldo_temporal", SqlDbType.int, 0, "id_recibo_sueldo_temporal")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        da.InsertCommand.Parameters.Add("@codigo", SqlDbType.decimal, 9, "codigo")
        da.InsertCommand.Parameters.Add("@nombre_renglon", SqlDbType.varchar, 50, "nombre_renglon")
        da.InsertCommand.Parameters.Add("@cantidad", SqlDbType.decimal, 9, "cantidad")
        da.InsertCommand.Parameters.Add("@haber", SqlDbType.decimal, 9, "haber")
        da.InsertCommand.Parameters.Add("@deduccion", SqlDbType.decimal, 9, "deduccion")
        da.InsertCommand.Parameters.Add("@adicional", SqlDbType.decimal, 9, "adicional")

        dr = dt.NewRow()
        dr("id_empleado") = 0
        dr("codigo") = 0
        dr("nombre_renglon") = ""
        dr("cantidad") = 0
        dr("haber") = 0
        dr("deduccion") = 0
        dr("adicional") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idRecibo_sueldo_temporal As Integer)
        dt = New DataTable("Recibo_sueldo_temporal")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_sueldo_temporal WHERE id_recibo_sueldo_temporal = @id_Recibo_sueldo_temporal", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Recibo_sueldo_temporal", idRecibo_sueldo_temporal)
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
    Public Sub Borrar(ByVal idRecibo_sueldo_temporal As Integer)
        dt = New DataTable("Recibo_sueldo_temporal")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_sueldo_temporal WHERE id_recibo_sueldo_temporal = " & _
        idRecibo_sueldo_temporal, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Recibo_sueldo_temporal_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_recibo_sueldo_temporal", SqlDbType.Int, 4, "id_recibo_sueldo_temporal")
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
               Case "id_recibo_sueldo_temporal"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empleado"
                  dc.DataType = Type.GetType("System.Int32")
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
        dt = New DataTable("Recibo_sueldo_temporal")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_sueldo_temporal WHERE id_recibo_sueldo_temporal = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_temporal_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_temporal_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_temporal_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Recibo_sueldo_temporal As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_temporal_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_sueldo_temporal", SqlDbType.Int, 4, "id_recibo_sueldo_temporal")
        oda.SelectCommand.Parameters("@id_recibo_sueldo_temporal").Value = id_Recibo_sueldo_temporal

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_temporal_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = Me.id_empleado
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
        Command.CommandText = "DELETE FROM Recibo_sueldo_temporal"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Recibo_sueldo_temporal"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Recibo_sueldo_temporal_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Recibo_sueldo_temporal")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Recibo_sueldo_temporal.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
