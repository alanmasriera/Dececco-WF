Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Categoria_voz_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_categoria_voz As Int32
    Public ReadOnly Property id_categoria_voz() As Int32
        Get
            _id_categoria_voz = CInt(dr("id_categoria_voz"))
            Return _id_categoria_voz
        End Get
    end property

    Private _id_categoria As Int32
    Public Property id_categoria() As Int32
        Get
            _id_categoria = CInt(dr("id_categoria"))
            Return _id_categoria
        End Get
        Set(ByVal Value As Int32)
            dr("id_categoria") = Value
        End Set
    end property

    Private _id_voz As Int32
    Public Property id_voz() As Int32
        Get
            _id_voz = CInt(dr("id_voz"))
            Return _id_voz
        End Get
        Set(ByVal Value As Int32)
            dr("id_voz") = Value
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

    Private _desactivada As Boolean
    Public Property desactivada() As Boolean
        Get
            _desactivada = CBool(dr("desactivada"))
            Return _desactivada
        End Get
        Set(ByVal Value As Boolean)
            dr("desactivada") = Value
        End Set
    end property

    Private _sin_peso As Boolean
    Public Property sin_peso() As Boolean
        Get
            _sin_peso = CBool(dr("sin_peso"))
            Return _sin_peso
        End Get
        Set(ByVal Value As Boolean)
            dr("sin_peso") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Categoria_voz")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Categoria_voz_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_categoria_voz", SqlDbType.int, 0, "id_categoria_voz")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_categoria", SqlDbType.int, 4, "id_categoria")
        da.InsertCommand.Parameters.Add("@id_voz", SqlDbType.int, 4, "id_voz")
        da.InsertCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        da.InsertCommand.Parameters.Add("@desactivada", SqlDbType.bit, 1, "desactivada")
        da.InsertCommand.Parameters.Add("@sin_peso", SqlDbType.bit, 1, "sin_peso")

        dr = dt.NewRow()
        dr("id_categoria") = 0
        dr("id_voz") = 0
        dr("id_empleado") = 0
        dr("desactivada") = False
        dr("sin_peso") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCategoria_voz As Integer)
        dt = New DataTable("Categoria_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Categoria_voz WHERE id_categoria_voz = @id_Categoria_voz", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Categoria_voz", idCategoria_voz)
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
    Public Sub Borrar(ByVal idCategoria_voz As Integer)
        dt = New DataTable("Categoria_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Categoria_voz WHERE id_categoria_voz = " & _
        idCategoria_voz, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Categoria_voz_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_categoria_voz", SqlDbType.Int, 4, "id_categoria_voz")
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
               Case "id_categoria_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_categoria"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empleado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "desactivada"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "sin_peso"
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
        dt = New DataTable("Categoria_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Categoria_voz WHERE id_categoria_voz = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Categoria_voz_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Categoria_voz_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Categoria_voz_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Categoria_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Categoria_voz_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_categoria_voz", SqlDbType.Int, 4, "id_categoria_voz")
        oda.SelectCommand.Parameters("@id_categoria_voz").Value = id_Categoria_voz

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Categoria_voz_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_categoria", SqlDbType.int, 4, "id_categoria")
        oda.SelectCommand.Parameters("@id_categoria").Value = Me.id_categoria
        oda.SelectCommand.Parameters.Add("@id_voz", SqlDbType.int, 4, "id_voz")
        oda.SelectCommand.Parameters("@id_voz").Value = Me.id_voz
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = Me.id_empleado
        oda.SelectCommand.Parameters.Add("@desactivada", SqlDbType.bit, 1, "desactivada")
        oda.SelectCommand.Parameters("@desactivada").Value = Me.desactivada
        oda.SelectCommand.Parameters.Add("@sin_peso", SqlDbType.bit, 1, "sin_peso")
        oda.SelectCommand.Parameters("@sin_peso").Value = Me.sin_peso

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
        Command.CommandText = "DELETE FROM Categoria_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Categoria_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Categoria_voz_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Categoria_voz")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Categoria_voz.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
