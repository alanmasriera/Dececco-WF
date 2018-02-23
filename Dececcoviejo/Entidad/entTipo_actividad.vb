Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_actividad_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_tipo_actividad As Int32
    Public ReadOnly Property id_tipo_actividad() As Int32
        Get
            _id_tipo_actividad = CInt(dr("id_tipo_actividad"))
            Return _id_tipo_actividad
        End Get
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

    Private _criticidad As Decimal
    Public Property criticidad() As Decimal
        Get
            _criticidad = CDec(dr("criticidad"))
            Return _criticidad
        End Get
        Set(ByVal Value As Decimal)
            dr("criticidad") = Value
        End Set
    end property

    Private _logueo_habilitado As Boolean
    Public Property logueo_habilitado() As Boolean
        Get
            _logueo_habilitado = CBool(dr("logueo_habilitado"))
            Return _logueo_habilitado
        End Get
        Set(ByVal Value As Boolean)
            dr("logueo_habilitado") = Value
        End Set
    End Property


    Private _asignable As Boolean
    Public Property asignable() As Boolean
        Get
            _asignable = CBool(dr("asignable"))
            Return _asignable
        End Get
        Set(ByVal Value As Boolean)
            dr("asignable") = Value
        End Set
    End Property

    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Tipo_actividad")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Tipo_actividad_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.int, 0, "id_tipo_actividad")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 50, "descripcion")
        da.InsertCommand.Parameters.Add("@criticidad", SqlDbType.Decimal, 9, "criticidad")
        da.InsertCommand.Parameters.Add("@logueo_habilitado", SqlDbType.Bit, 1, "logueo_habilitado")
        da.InsertCommand.Parameters.Add("@asignable", SqlDbType.Bit, 1, "asignable")

        dr = dt.NewRow()
        dr("descripcion") = ""
        dr("criticidad") = 0
        dr("logueo_habilitado") = 0
        dr("asignable") = 1

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTipo_actividad As Integer)
        dt = New DataTable("Tipo_actividad")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_actividad WHERE id_tipo_actividad = @id_Tipo_actividad", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Tipo_actividad", idTipo_actividad)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se a encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        'CrearComandoUpdate()
    End Sub

    'procedimiento borrar
    Public Sub Borrar(ByVal idTipo_actividad As Integer)
        dt = New DataTable("Tipo_actividad")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_actividad WHERE id_tipo_actividad = " & _
        idTipo_actividad, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Tipo_actividad_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
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
               Case "id_tipo_actividad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "descripcion"
                  dc.DataType = Type.GetType("System.String")
               Case "criticidad"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "habilitado"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "asignable"
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
        dt = New DataTable("Tipo_actividad")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_actividad WHERE id_tipo_actividad = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_actividad_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 100, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_actividad_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_actividad_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Tipo_actividad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_actividad_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        oda.SelectCommand.Parameters("@id_tipo_actividad").Value = id_Tipo_actividad

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_actividad_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 50, "descripcion")
        oda.SelectCommand.Parameters("@descripcion").Value = Me.descripcion
        oda.SelectCommand.Parameters.Add("@criticidad", SqlDbType.decimal, 9, "criticidad")
        oda.SelectCommand.Parameters("@criticidad").Value = Me.criticidad

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
        Command.CommandText = "DELETE FROM Tipo_actividad"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Tipo_actividad"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Tipo_actividad_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Tipo_actividad")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Tipo_actividad.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function

End Class
