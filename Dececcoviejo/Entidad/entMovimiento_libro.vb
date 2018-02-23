Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Movimiento_libro_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_movimiento_libro As Int32
    Public ReadOnly Property id_movimiento_libro() As Int32
        Get
            _id_movimiento_libro = CInt(dr("id_movimiento_libro"))
            Return _id_movimiento_libro
        End Get
    end property

    Private _numero_asiento As String
    Public Property numero_asiento() As String
        Get
            _numero_asiento = CStr(dr("numero_asiento"))
            Return _numero_asiento
        End Get
        Set(ByVal Value As String)
            dr("numero_asiento") = Value
        End Set
    end property

    Private _detalle_asiento As String
    Public Property detalle_asiento() As String
        Get
            _detalle_asiento = CStr(dr("detalle_asiento"))
            Return _detalle_asiento
        End Get
        Set(ByVal Value As String)
            dr("detalle_asiento") = Value
        End Set
    end property

    Private _fecha_asiento As DateTime
    Public Property fecha_asiento() As DateTime
        Get
            _fecha_asiento = CDate(dr("fecha_asiento"))
            Return _fecha_asiento
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_asiento") = Value
        End Set
    end property

    Private _estado As String
    Public Property estado() As String
        Get
            _estado = CStr(dr("estado"))
            Return _estado
        End Get
        Set(ByVal Value As String)
            dr("estado") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Movimiento_libro")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Movimiento_libro_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_movimiento_libro", SqlDbType.int, 0, "id_movimiento_libro")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@numero_asiento", SqlDbType.varchar, 50, "numero_asiento")
        da.InsertCommand.Parameters.Add("@detalle_asiento", SqlDbType.varchar, 50, "detalle_asiento")
        da.InsertCommand.Parameters.Add("@fecha_asiento", SqlDbType.datetime, 8, "fecha_asiento")
        da.InsertCommand.Parameters.Add("@estado", SqlDbType.char, 1, "estado")

        dr = dt.NewRow()
        dr("numero_asiento") = ""
        dr("detalle_asiento") = ""
        dr("fecha_asiento") = DateTime.Now
        dr("estado") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idMovimiento_libro As Integer)
        dt = New DataTable("Movimiento_libro")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Movimiento_libro WHERE id_movimiento_libro = @id_Movimiento_libro", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Movimiento_libro", idMovimiento_libro)
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
    Public Sub Borrar(ByVal idMovimiento_libro As Integer)
        dt = New DataTable("Movimiento_libro")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Movimiento_libro WHERE id_movimiento_libro = " & _
        idMovimiento_libro, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Movimiento_libro_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_movimiento_libro", SqlDbType.Int, 4, "id_movimiento_libro")
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
               Case "id_movimiento_libro"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero_asiento"
                  dc.DataType = Type.GetType("System.String")
               Case "detalle_asiento"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_asiento"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "estado"
                  dc.DataType = Type.GetType("System.String")
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
        dt = New DataTable("Movimiento_libro")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Movimiento_libro WHERE id_movimiento_libro = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_libro_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_libro_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_libro_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Movimiento_libro As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_libro_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_libro", SqlDbType.Int, 4, "id_movimiento_libro")
        oda.SelectCommand.Parameters("@id_movimiento_libro").Value = id_Movimiento_libro

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_libro_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero_asiento", SqlDbType.varchar, 50, "numero_asiento")
        oda.SelectCommand.Parameters("@numero_asiento").Value = Me.numero_asiento
        oda.SelectCommand.Parameters.Add("@detalle_asiento", SqlDbType.varchar, 50, "detalle_asiento")
        oda.SelectCommand.Parameters("@detalle_asiento").Value = Me.detalle_asiento
        oda.SelectCommand.Parameters.Add("@fecha_asiento", SqlDbType.datetime, 8, "fecha_asiento")
        oda.SelectCommand.Parameters("@fecha_asiento").Value = Me.fecha_asiento
        oda.SelectCommand.Parameters.Add("@estado", SqlDbType.char, 1, "estado")
        oda.SelectCommand.Parameters("@estado").Value = Me.estado

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
        Command.CommandText = "DELETE FROM Movimiento_libro"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Movimiento_libro"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Movimiento_libro_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Movimiento_libro")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Movimiento_libro.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
