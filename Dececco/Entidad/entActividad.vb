Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Actividad_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_actividad As Int32
    Public ReadOnly Property id_actividad() As Int32
        Get
            _id_actividad = CInt(dr("id_actividad"))
            Return _id_actividad
        End Get
    end property

    Private _nombre_actividad As String
    Public Property nombre_actividad() As String
        Get
            _nombre_actividad = CStr(dr("nombre_actividad"))
            Return _nombre_actividad
        End Get
        Set(ByVal Value As String)
            dr("nombre_actividad") = Value
        End Set
    end property

    Private _tiempo_standart As Decimal
    Public Property tiempo_standart() As Decimal
        Get
            _tiempo_standart = CDec(dr("tiempo_standart"))
            Return _tiempo_standart
        End Get
        Set(ByVal Value As Decimal)
            dr("tiempo_standart") = Value
        End Set
    end property

    Private _costo_standart As Decimal
    Public Property costo_standart() As Decimal
        Get
            _costo_standart = CDec(dr("costo_standart"))
            Return _costo_standart
        End Get
        Set(ByVal Value As Decimal)
            dr("costo_standart") = Value
        End Set
    end property

    Private _id_tipo_actividad As Int32
    Public Property id_tipo_actividad() As Int32
        Get
            _id_tipo_actividad = CInt(dr("id_tipo_actividad"))
            Return _id_tipo_actividad
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_actividad") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Actividad")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Actividad_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_actividad", SqlDbType.int, 0, "id_actividad")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_actividad", SqlDbType.varchar, 100, "nombre_actividad")
        da.InsertCommand.Parameters.Add("@tiempo_standart", SqlDbType.decimal, 9, "tiempo_standart")
        da.InsertCommand.Parameters.Add("@costo_standart", SqlDbType.decimal, 9, "costo_standart")
        da.InsertCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.int, 4, "id_tipo_actividad")

        dr = dt.NewRow()
        dr("nombre_actividad") = ""
        dr("tiempo_standart") = 0
        dr("costo_standart") = 0
        dr("id_tipo_actividad") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idActividad As Integer)
        dt = New DataTable("Actividad")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Actividad WHERE id_actividad = @id_Actividad", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Actividad", idActividad)
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
    Public Sub Borrar(ByVal idActividad As Integer)
        dt = New DataTable("Actividad")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Actividad WHERE id_actividad = " & _
        idActividad, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Actividad_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_actividad", SqlDbType.Int, 4, "id_actividad")
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
               Case "id_actividad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_actividad"
                  dc.DataType = Type.GetType("System.String")
               Case "tiempo_standart"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "costo_standart"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_tipo_actividad"
                  dc.DataType = Type.GetType("System.Int32")
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
        dt = New DataTable("Actividad")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Actividad WHERE id_actividad = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Actividad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad", SqlDbType.Int, 4, "id_actividad")
        oda.SelectCommand.Parameters("@id_actividad").Value = id_Actividad

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_actividad", SqlDbType.varchar, 100, "nombre_actividad")
        oda.SelectCommand.Parameters("@nombre_actividad").Value = Me.nombre_actividad
        oda.SelectCommand.Parameters.Add("@tiempo_standart", SqlDbType.decimal, 9, "tiempo_standart")
        oda.SelectCommand.Parameters("@tiempo_standart").Value = Me.tiempo_standart
        oda.SelectCommand.Parameters.Add("@costo_standart", SqlDbType.decimal, 9, "costo_standart")
        oda.SelectCommand.Parameters("@costo_standart").Value = Me.costo_standart
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.int, 4, "id_tipo_actividad")
        oda.SelectCommand.Parameters("@id_tipo_actividad").Value = Me.id_tipo_actividad

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
        Command.CommandText = "DELETE FROM Actividad"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Actividad"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Actividad_InsertOne"

        Command.CommandType = CommandType.StoredProcedure

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Actividad")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Actividad.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
