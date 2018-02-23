Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Obra_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_obra As Int32
    Public ReadOnly Property id_obra() As Int32
        Get
            _id_obra = CInt(dr("id_obra"))
            Return _id_obra
        End Get
    end property

    Private _nombre_obra As String
    Public Property nombre_obra() As String
        Get
            _nombre_obra = CStr(dr("nombre_obra"))
            Return _nombre_obra
        End Get
        Set(ByVal Value As String)
            dr("nombre_obra") = Value
        End Set
    end property

    Private _detalle_obra As String
    Public Property detalle_obra() As String
        Get
            _detalle_obra = CStr(dr("detalle_obra"))
            Return _detalle_obra
        End Get
        Set(ByVal Value As String)
            dr("detalle_obra") = Value
        End Set
    end property

    Private _extra As Boolean
    Public Property extra() As Boolean
        Get
            _extra = CBool(dr("extra"))
            Return _extra
        End Get
        Set(ByVal Value As Boolean)
            dr("extra") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Obra")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Obra_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_obra", SqlDbType.int, 0, "id_obra")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_obra", SqlDbType.varchar, 50, "nombre_obra")
        da.InsertCommand.Parameters.Add("@detalle_obra", SqlDbType.varchar, 500, "detalle_obra")
        da.InsertCommand.Parameters.Add("@extra", SqlDbType.bit, 1, "extra")

        dr = dt.NewRow()
        dr("nombre_obra") = ""
        dr("detalle_obra") = ""
        dr("extra") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idObra As Integer)
        dt = New DataTable("Obra")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Obra WHERE id_obra = @id_Obra", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Obra", idObra)
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
    Public Sub Borrar(ByVal idObra As Integer)
        dt = New DataTable("Obra")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Obra WHERE id_obra = " & _
        idObra, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Obra_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_obra", SqlDbType.Int, 4, "id_obra")
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
               Case "id_obra"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_obra"
                  dc.DataType = Type.GetType("System.String")
               Case "detalle_obra"
                  dc.DataType = Type.GetType("System.String")
               Case "extra"
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
        dt = New DataTable("Obra")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Obra WHERE id_obra = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Obra As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_obra", SqlDbType.Int, 4, "id_obra")
        oda.SelectCommand.Parameters("@id_obra").Value = id_Obra

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_obra", SqlDbType.varchar, 50, "nombre_obra")
        oda.SelectCommand.Parameters("@nombre_obra").Value = Me.nombre_obra
        oda.SelectCommand.Parameters.Add("@detalle_obra", SqlDbType.varchar, 500, "detalle_obra")
        oda.SelectCommand.Parameters("@detalle_obra").Value = Me.detalle_obra
        oda.SelectCommand.Parameters.Add("@extra", SqlDbType.bit, 1, "extra")
        oda.SelectCommand.Parameters("@extra").Value = Me.extra

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
        Command.CommandText = "DELETE FROM Obra"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Obra"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Obra_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Obra")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Obra.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
