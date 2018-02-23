Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Renglon_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_renglon As Int32
    Public ReadOnly Property id_renglon() As Int32
        Get
            _id_renglon = CInt(dr("id_renglon"))
            Return _id_renglon
        End Get
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

    Private _codigo As String
    Public Property codigo() As String
        Get
            _codigo = CStr(dr("codigo"))
            Return _codigo
        End Get
        Set(ByVal Value As String)
            dr("codigo") = Value
        End Set
    end property

    Private _mensual As Boolean
    Public Property mensual() As Boolean
        Get
            _mensual = CBool(dr("mensual"))
            Return _mensual
        End Get
        Set(ByVal Value As Boolean)
            dr("mensual") = Value
        End Set
    end property

    Private _id_tipo_renglon As Int32
    Public Property id_tipo_renglon() As Int32
        Get
            _id_tipo_renglon = CInt(dr("id_tipo_renglon"))
            Return _id_tipo_renglon
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_renglon") = Value
        End Set
    end property

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            _descripcion = CStr(dr("descripcion"))
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            dr("descripcion") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Renglon")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Renglon_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_renglon", SqlDbType.int, 0, "id_renglon")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_renglon", SqlDbType.varchar, 50, "nombre_renglon")
        da.InsertCommand.Parameters.Add("@codigo", SqlDbType.varchar, 50, "codigo")
        da.InsertCommand.Parameters.Add("@mensual", SqlDbType.bit, 1, "mensual")
        da.InsertCommand.Parameters.Add("@id_tipo_renglon", SqlDbType.int, 4, "id_tipo_renglon")
        da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 500, "descripcion")

        dr = dt.NewRow()
        dr("nombre_renglon") = ""
        dr("codigo") = ""
        dr("mensual") = False
        dr("id_tipo_renglon") = 0
        dr("descripcion") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idRenglon As Integer)
        dt = New DataTable("Renglon")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Renglon WHERE id_renglon = @id_Renglon", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Renglon", idRenglon)
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
    Public Sub Borrar(ByVal idRenglon As Integer)
        dt = New DataTable("Renglon")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Renglon WHERE id_renglon = " & _
        idRenglon, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Renglon_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_renglon", SqlDbType.Int, 4, "id_renglon")
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
               Case "id_renglon"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_renglon"
                  dc.DataType = Type.GetType("System.String")
               Case "codigo"
                  dc.DataType = Type.GetType("System.String")
               Case "mensual"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_tipo_renglon"
                  dc.DataType = Type.GetType("System.Int32")
               Case "descripcion"
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
        dt = New DataTable("Renglon")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Renglon WHERE id_renglon = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Renglon_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Renglon_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Renglon_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Renglon As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Renglon_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_renglon", SqlDbType.Int, 4, "id_renglon")
        oda.SelectCommand.Parameters("@id_renglon").Value = id_Renglon

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Renglon_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_renglon", SqlDbType.varchar, 50, "nombre_renglon")
        oda.SelectCommand.Parameters("@nombre_renglon").Value = Me.nombre_renglon
        oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.varchar, 50, "codigo")
        oda.SelectCommand.Parameters("@codigo").Value = Me.codigo
        oda.SelectCommand.Parameters.Add("@mensual", SqlDbType.bit, 1, "mensual")
        oda.SelectCommand.Parameters("@mensual").Value = Me.mensual
        oda.SelectCommand.Parameters.Add("@id_tipo_renglon", SqlDbType.int, 4, "id_tipo_renglon")
        oda.SelectCommand.Parameters("@id_tipo_renglon").Value = Me.id_tipo_renglon
        oda.SelectCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 500, "descripcion")
        oda.SelectCommand.Parameters("@descripcion").Value = Me.descripcion

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
        Command.CommandText = "DELETE FROM Renglon"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Renglon"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Renglon_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Renglon")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Renglon.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
