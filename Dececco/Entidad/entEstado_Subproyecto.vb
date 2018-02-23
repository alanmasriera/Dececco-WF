Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class entEstado_Subproyecto

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_estado_subproyecto As Int32
    Public ReadOnly Property id_estado_subproyecto() As Int32
        Get
            _id_estado_subproyecto = CInt(dr("id_estado_subproyecto"))
            Return _id_estado_subproyecto
        End Get
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            _nombre = CStr(dr("nombre"))
            Return _nombre
        End Get
        Set(ByVal Value As String)
            dr("nombre") = Value
        End Set
    End Property

    Private _porcentaje As Decimal
    Public Property porcentaje() As Decimal
        Get
            _porcentaje = CDec(dr("porcentaje"))
            Return _porcentaje
        End Get
        Set(ByVal Value As Decimal)
            dr("porcentaje") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Estado_Subproyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_estado_subproyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_estado_subproyecto", SqlDbType.Int, 0, "id_estado_subproyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre")
        da.InsertCommand.Parameters.Add("@porcentaje", SqlDbType.Decimal, 9, "porcentaje")

        dr = dt.NewRow()
        dr("nombre") = ""
        dr("porcentaje") = 0

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTipo_actividad As Integer)
        dt = New DataTable("Estado_Subproyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Estado_Subproyecto WHERE id_estado_subproyecto = @id_estado_subproyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_estado_subproyecto", idTipo_actividad)
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
    Public Sub Borrar(ByVal idTipo_actividad As Integer)
        dt = New DataTable("Estado_Subproyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Estado_Subproyecto WHERE id_estado_subproyecto = " & _
        idTipo_actividad, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_estado_subproyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_estado_subproyecto", SqlDbType.Int, 4, "id_estado_subproyecto")
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
                Case "id_estado_subproyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "nombre"
                    dc.DataType = Type.GetType("System.String")
                Case "porcentaje"
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
        dt = New DataTable("Estado_subproyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Estado_subproyecto WHERE id_estado_subproyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_Subproyecto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 100, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_subproyecto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_subproyecto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_estado_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_Subproyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_estado_subproyecto", SqlDbType.Int, 4, "id_estado_subproyecto")
        oda.SelectCommand.Parameters("@id_estado_subproyecto").Value = id_estado_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_subproyecto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Me.nombre
        oda.SelectCommand.Parameters.Add("@porcentaje", SqlDbType.Decimal, 9, "porcentaje")
        oda.SelectCommand.Parameters("@porcentaje").Value = Me.porcentaje

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
        Command.CommandText = "DELETE FROM Estado_Subproyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Estado_Subproyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Estado_subproyecto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub



End Class
