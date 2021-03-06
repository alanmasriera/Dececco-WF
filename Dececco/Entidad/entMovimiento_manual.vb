Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Movimiento_manual_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_movimiento_manual As Int32
    Public ReadOnly Property id_movimiento_manual() As Int32
        Get
            _id_movimiento_manual = CInt(dr("id_movimiento_manual"))
            Return _id_movimiento_manual
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

    Private _id_renglon As Int32
    Public Property id_renglon() As Int32
        Get
            _id_renglon = CInt(dr("id_renglon"))
            Return _id_renglon
        End Get
        Set(ByVal Value As Int32)
            dr("id_renglon") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Movimiento_manual")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Movimiento_manual_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_movimiento_manual", SqlDbType.int, 0, "id_movimiento_manual")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        da.InsertCommand.Parameters.Add("@id_renglon", SqlDbType.int, 4, "id_renglon")
        da.InsertCommand.Parameters.Add("@cantidad", SqlDbType.decimal, 9, "cantidad")

        dr = dt.NewRow()
        dr("fecha") = DateTime.Now
        dr("id_empleado") = 0
        dr("id_renglon") = 0
        dr("cantidad") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idMovimiento_manual As Integer)
        dt = New DataTable("Movimiento_manual")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Movimiento_manual WHERE id_movimiento_manual = @id_Movimiento_manual", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Movimiento_manual", idMovimiento_manual)
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
    Public Sub Borrar(ByVal idMovimiento_manual As Integer)
        dt = New DataTable("Movimiento_manual")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Movimiento_manual WHERE id_movimiento_manual = " & _
        idMovimiento_manual, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Movimiento_manual_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_movimiento_manual", SqlDbType.Int, 4, "id_movimiento_manual")
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
               Case "id_movimiento_manual"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_empleado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_renglon"
                  dc.DataType = Type.GetType("System.Int32")
               Case "cantidad"
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
        dt = New DataTable("Movimiento_manual")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Movimiento_manual WHERE id_movimiento_manual = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_manual_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_manual_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_manual_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Movimiento_manual As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_manual_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_manual", SqlDbType.Int, 4, "id_movimiento_manual")
        oda.SelectCommand.Parameters("@id_movimiento_manual").Value = id_Movimiento_manual

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_manual_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = Me.id_empleado
        oda.SelectCommand.Parameters.Add("@id_renglon", SqlDbType.int, 4, "id_renglon")
        oda.SelectCommand.Parameters("@id_renglon").Value = Me.id_renglon
        oda.SelectCommand.Parameters.Add("@cantidad", SqlDbType.decimal, 9, "cantidad")
        oda.SelectCommand.Parameters("@cantidad").Value = Me.cantidad

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
        Command.CommandText = "DELETE FROM Movimiento_manual"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Movimiento_manual"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Movimiento_manual_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campa�a desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Movimiento_manual")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Movimiento_manual.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
