Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_proveedor_ent

    'defino las variables
    Friend dt As DataTable
    Private dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_resumen_PROVEEDOR As Int32
    Public ReadOnly Property id_resumen_PROVEEDOR() As Int32
        Get
            _id_resumen_PROVEEDOR = CInt(dr("id_resumen_PROVEEDOR"))
            Return _id_resumen_PROVEEDOR
        End Get
    end property

    Private _debe_PROVEEDOR As Decimal
    Public Property debe_PROVEEDOR() As Decimal
        Get
            _debe_PROVEEDOR = CDec(dr("debe_PROVEEDOR"))
            Return _debe_PROVEEDOR
        End Get
        Set(ByVal Value As Decimal)
            dr("debe_PROVEEDOR") = Value
        End Set
    end property

    Private _haber_PROVEEDOR As Decimal
    Public Property haber_PROVEEDOR() As Decimal
        Get
            _haber_PROVEEDOR = CDec(dr("haber_PROVEEDOR"))
            Return _haber_PROVEEDOR
        End Get
        Set(ByVal Value As Decimal)
            dr("haber_PROVEEDOR") = Value
        End Set
    end property

    Private _detalle_PROVEEDOR As String
    Public Property detalle_PROVEEDOR() As String
        Get
            _detalle_PROVEEDOR = CStr(dr("detalle_PROVEEDOR"))
            Return _detalle_PROVEEDOR
        End Get
        Set(ByVal Value As String)
            dr("detalle_PROVEEDOR") = Value
        End Set
    end property

    Private _fecha_PROVEEDOR As DateTime
    Public Property fecha_PROVEEDOR() As DateTime
        Get
            _fecha_PROVEEDOR = CDate(dr("fecha_PROVEEDOR"))
            Return _fecha_PROVEEDOR
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_PROVEEDOR") = Value
        End Set
    end property

    Private _saldo_PROVEEDOR As Decimal
    Public Property saldo_PROVEEDOR() As Decimal
        Get
            _saldo_PROVEEDOR = CDec(dr("saldo_PROVEEDOR"))
            Return _saldo_PROVEEDOR
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_PROVEEDOR") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Resumen_proveedor")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Resumen_proveedor_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_resumen_PROVEEDOR", SqlDbType.int, 0, "id_resumen_PROVEEDOR")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@debe_PROVEEDOR", SqlDbType.decimal, 9, "debe_PROVEEDOR")
        da.InsertCommand.Parameters.Add("@haber_PROVEEDOR", SqlDbType.decimal, 9, "haber_PROVEEDOR")
        da.InsertCommand.Parameters.Add("@detalle_PROVEEDOR", SqlDbType.varchar, 300, "detalle_PROVEEDOR")
        da.InsertCommand.Parameters.Add("@fecha_PROVEEDOR", SqlDbType.datetime, 8, "fecha_PROVEEDOR")
        da.InsertCommand.Parameters.Add("@saldo_PROVEEDOR", SqlDbType.decimal, 9, "saldo_PROVEEDOR")

        dr = dt.NewRow()
        dr("debe_PROVEEDOR") = 0
        dr("haber_PROVEEDOR") = 0
        dr("detalle_PROVEEDOR") = ""
        dr("fecha_PROVEEDOR") = DateTime.Now
        dr("saldo_PROVEEDOR") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idResumen_proveedor As Integer)
        dt = New DataTable("Resumen_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Resumen_proveedor WHERE id_resumen_PROVEEDOR = @id_Resumen_proveedor", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Resumen_proveedor", idResumen_proveedor)
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
    Public Sub Borrar(ByVal idResumen_proveedor As Integer)
        dt = New DataTable("Resumen_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Resumen_proveedor WHERE id_resumen_PROVEEDOR = " & _
        idResumen_proveedor, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Resumen_proveedor_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_resumen_PROVEEDOR", SqlDbType.Int, 4, "id_resumen_PROVEEDOR")
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
               Case "id_resumen_PROVEEDOR"
                  dc.DataType = Type.GetType("System.Int32")
               Case "debe_PROVEEDOR"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "haber_PROVEEDOR"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "detalle_PROVEEDOR"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_PROVEEDOR"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "saldo_PROVEEDOR"
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
        dt = New DataTable("Resumen_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Resumen_proveedor WHERE id_resumen_PROVEEDOR = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Resumen_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_PROVEEDOR", SqlDbType.Int, 4, "id_resumen_PROVEEDOR")
        oda.SelectCommand.Parameters("@id_resumen_PROVEEDOR").Value = id_Resumen_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@debe_PROVEEDOR", SqlDbType.decimal, 9, "debe_PROVEEDOR")
        oda.SelectCommand.Parameters("@debe_PROVEEDOR").Value = Me.debe_PROVEEDOR
        oda.SelectCommand.Parameters.Add("@haber_PROVEEDOR", SqlDbType.decimal, 9, "haber_PROVEEDOR")
        oda.SelectCommand.Parameters("@haber_PROVEEDOR").Value = Me.haber_PROVEEDOR
        oda.SelectCommand.Parameters.Add("@detalle_PROVEEDOR", SqlDbType.varchar, 300, "detalle_PROVEEDOR")
        oda.SelectCommand.Parameters("@detalle_PROVEEDOR").Value = Me.detalle_PROVEEDOR
        oda.SelectCommand.Parameters.Add("@fecha_PROVEEDOR", SqlDbType.datetime, 8, "fecha_PROVEEDOR")
        oda.SelectCommand.Parameters("@fecha_PROVEEDOR").Value = Me.fecha_PROVEEDOR
        oda.SelectCommand.Parameters.Add("@saldo_PROVEEDOR", SqlDbType.decimal, 9, "saldo_PROVEEDOR")
        oda.SelectCommand.Parameters("@saldo_PROVEEDOR").Value = Me.saldo_PROVEEDOR

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
        Command.CommandText = "DELETE FROM Resumen_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Resumen_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_proveedor_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Resumen_proveedor")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Resumen_proveedor.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
