Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Estado_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_estado As Int32
    Public ReadOnly Property id_estado() As Int32
        Get
            _id_estado = CInt(dr("id_estado"))
            Return _id_estado
        End Get
    end property

    Private _nombre_estado As String
    Public Property nombre_estado() As String
        Get
            _nombre_estado = CStr(dr("nombre_estado"))
            Return _nombre_estado
        End Get
        Set(ByVal Value As String)
            dr("nombre_estado") = Value
        End Set
    end property

    Private _avance As Decimal
    Public Property avance() As Decimal
        Get
            _avance = CDec(dr("avance"))
            Return _avance
        End Get
        Set(ByVal Value As Decimal)
            dr("avance") = Value
        End Set
    end property

    Private _color As String
    Public Property color() As String
        Get
            _color = CStr(dr("color"))
            Return _color
        End Get
        Set(ByVal Value As String)
            dr("color") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Estado")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Estado_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_estado", SqlDbType.int, 0, "id_estado")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_estado", SqlDbType.varchar, 50, "nombre_estado")
        da.InsertCommand.Parameters.Add("@avance", SqlDbType.decimal, 9, "avance")
        da.InsertCommand.Parameters.Add("@color", SqlDbType.varchar, 50, "color")

        dr = dt.NewRow()
        dr("nombre_estado") = ""
        dr("avance") = 0
        dr("color") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idEstado As Integer)
        dt = New DataTable("Estado")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Estado WHERE id_estado = @id_Estado", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Estado", idEstado)
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
    Public Sub Borrar(ByVal idEstado As Integer)
        dt = New DataTable("Estado")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Estado WHERE id_estado = " & _
        idEstado, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Estado_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_estado", SqlDbType.Int, 4, "id_estado")
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
               Case "id_estado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_estado"
                  dc.DataType = Type.GetType("System.String")
               Case "avance"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "color"
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
        dt = New DataTable("Estado")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Estado WHERE id_estado = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Estado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_estado", SqlDbType.Int, 4, "id_estado")
        oda.SelectCommand.Parameters("@id_estado").Value = id_Estado

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_estado", SqlDbType.varchar, 50, "nombre_estado")
        oda.SelectCommand.Parameters("@nombre_estado").Value = Me.nombre_estado
        oda.SelectCommand.Parameters.Add("@avance", SqlDbType.decimal, 9, "avance")
        oda.SelectCommand.Parameters("@avance").Value = Me.avance
        oda.SelectCommand.Parameters.Add("@color", SqlDbType.varchar, 50, "color")
        oda.SelectCommand.Parameters("@color").Value = Me.color

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
        Command.CommandText = "DELETE FROM Estado"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Estado"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Estado_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Estado")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Estado.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
