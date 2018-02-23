Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Libro_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_libro As Int32
    Public ReadOnly Property id_libro() As Int32
        Get
            _id_libro = CInt(dr("id_libro"))
            Return _id_libro
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

    Private _id_cuenta_imputable As Int32
    Public Property id_cuenta_imputable() As Int32
        Get
            _id_cuenta_imputable = CInt(dr("id_cuenta_imputable"))
            Return _id_cuenta_imputable
        End Get
        Set(ByVal Value As Int32)
            dr("id_cuenta_imputable") = Value
        End Set
    end property

    Private _debe As Decimal
    Public Property debe() As Decimal
        Get
            _debe = CDec(dr("debe"))
            Return _debe
        End Get
        Set(ByVal Value As Decimal)
            dr("debe") = Value
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
        dt = New DataTable("Libro")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Libro_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_libro", SqlDbType.int, 0, "id_libro")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@numero_asiento", SqlDbType.varchar, 50, "numero_asiento")
        da.InsertCommand.Parameters.Add("@detalle_asiento", SqlDbType.varchar, 50, "detalle_asiento")
        da.InsertCommand.Parameters.Add("@fecha_asiento", SqlDbType.datetime, 8, "fecha_asiento")
        da.InsertCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.int, 4, "id_cuenta_imputable")
        da.InsertCommand.Parameters.Add("@debe", SqlDbType.decimal, 9, "debe")
        da.InsertCommand.Parameters.Add("@haber", SqlDbType.decimal, 9, "haber")
        da.InsertCommand.Parameters.Add("@estado", SqlDbType.char, 1, "estado")

        dr = dt.NewRow()
        dr("numero_asiento") = ""
        dr("detalle_asiento") = ""
        dr("fecha_asiento") = DateTime.Now
        dr("id_cuenta_imputable") = 0
        dr("debe") = 0
        dr("haber") = 0
        dr("estado") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idLibro As Integer)
        dt = New DataTable("Libro")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Libro WHERE id_libro = @id_Libro", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Libro", idLibro)
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
    Public Sub Borrar(ByVal idLibro As Integer)
        dt = New DataTable("Libro")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Libro WHERE id_libro = " & _
        idLibro, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Libro_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_libro", SqlDbType.Int, 4, "id_libro")
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
               Case "id_libro"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero_asiento"
                  dc.DataType = Type.GetType("System.String")
               Case "detalle_asiento"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_asiento"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_cuenta_imputable"
                  dc.DataType = Type.GetType("System.Int32")
               Case "debe"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "haber"
                  dc.DataType = Type.GetType("System.Decimal")
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
        dt = New DataTable("Libro")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Libro WHERE id_libro = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Libro_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Libro_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Libro_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Libro As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Libro_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_libro", SqlDbType.Int, 4, "id_libro")
        oda.SelectCommand.Parameters("@id_libro").Value = id_Libro

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Libro_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero_asiento", SqlDbType.varchar, 50, "numero_asiento")
        oda.SelectCommand.Parameters("@numero_asiento").Value = Me.numero_asiento
        oda.SelectCommand.Parameters.Add("@detalle_asiento", SqlDbType.varchar, 50, "detalle_asiento")
        oda.SelectCommand.Parameters("@detalle_asiento").Value = Me.detalle_asiento
        oda.SelectCommand.Parameters.Add("@fecha_asiento", SqlDbType.datetime, 8, "fecha_asiento")
        oda.SelectCommand.Parameters("@fecha_asiento").Value = Me.fecha_asiento
        oda.SelectCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.int, 4, "id_cuenta_imputable")
        oda.SelectCommand.Parameters("@id_cuenta_imputable").Value = Me.id_cuenta_imputable
        oda.SelectCommand.Parameters.Add("@debe", SqlDbType.decimal, 9, "debe")
        oda.SelectCommand.Parameters("@debe").Value = Me.debe
        oda.SelectCommand.Parameters.Add("@haber", SqlDbType.decimal, 9, "haber")
        oda.SelectCommand.Parameters("@haber").Value = Me.haber
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
        Command.CommandText = "DELETE FROM Libro"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Libro"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Libro_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Libro")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Libro.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
