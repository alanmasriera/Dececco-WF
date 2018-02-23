Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Subtipo_producto_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_subtipo_producto As Int32
    Public ReadOnly Property id_subtipo_producto() As Int32
        Get
            _id_subtipo_producto = CInt(dr("id_subtipo_producto"))
            Return _id_subtipo_producto
        End Get
    end property

    Private _nombre_subtipo_producto As String
    Public Property nombre_subtipo_producto() As String
        Get
            _nombre_subtipo_producto = CStr(dr("nombre_subtipo_producto"))
            Return _nombre_subtipo_producto
        End Get
        Set(ByVal Value As String)
            dr("nombre_subtipo_producto") = Value
        End Set
    end property

    Private _id_tipo_producto As Int32
    Public Property id_tipo_producto() As Int32
        Get
            _id_tipo_producto = CInt(dr("id_tipo_producto"))
            Return _id_tipo_producto
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_producto") = Value
        End Set
    end property

    Private _tilde As Boolean
    Public Property tilde() As Boolean
        Get
            _tilde = CBool(dr("tilde"))
            Return _tilde
        End Get
        Set(ByVal Value As Boolean)
            dr("tilde") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Subtipo_producto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Subtipo_producto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_subtipo_producto", SqlDbType.int, 0, "id_subtipo_producto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_subtipo_producto", SqlDbType.varchar, 50, "nombre_subtipo_producto")
        da.InsertCommand.Parameters.Add("@id_tipo_producto", SqlDbType.int, 4, "id_tipo_producto")
        da.InsertCommand.Parameters.Add("@tilde", SqlDbType.bit, 1, "tilde")

        dr = dt.NewRow()
        dr("nombre_subtipo_producto") = ""
        dr("id_tipo_producto") = 0
        dr("tilde") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idSubtipo_producto As Integer)
        dt = New DataTable("Subtipo_producto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Subtipo_producto WHERE id_subtipo_producto = @id_Subtipo_producto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Subtipo_producto", idSubtipo_producto)
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
    Public Sub Borrar(ByVal idSubtipo_producto As Integer)
        dt = New DataTable("Subtipo_producto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Subtipo_producto WHERE id_subtipo_producto = " & _
        idSubtipo_producto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Subtipo_producto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_subtipo_producto", SqlDbType.Int, 4, "id_subtipo_producto")
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
               Case "id_subtipo_producto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_subtipo_producto"
                  dc.DataType = Type.GetType("System.String")
               Case "id_tipo_producto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "tilde"
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
        dt = New DataTable("Subtipo_producto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Subtipo_producto WHERE id_subtipo_producto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Subtipo_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subtipo_producto", SqlDbType.Int, 4, "id_subtipo_producto")
        oda.SelectCommand.Parameters("@id_subtipo_producto").Value = id_Subtipo_producto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_subtipo_producto", SqlDbType.varchar, 50, "nombre_subtipo_producto")
        oda.SelectCommand.Parameters("@nombre_subtipo_producto").Value = Me.nombre_subtipo_producto
        oda.SelectCommand.Parameters.Add("@id_tipo_producto", SqlDbType.int, 4, "id_tipo_producto")
        oda.SelectCommand.Parameters("@id_tipo_producto").Value = Me.id_tipo_producto
        oda.SelectCommand.Parameters.Add("@tilde", SqlDbType.bit, 1, "tilde")
        oda.SelectCommand.Parameters("@tilde").Value = Me.tilde

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
        Command.CommandText = "DELETE FROM Subtipo_producto"

        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Subtipo_producto"

        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Subtipo_producto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Subtipo_producto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Subtipo_producto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
