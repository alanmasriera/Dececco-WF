Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Sucursal_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_sucursal As Int32
    Public ReadOnly Property id_sucursal() As Int32
        Get
            _id_sucursal = CInt(dr("id_sucursal"))
            Return _id_sucursal
        End Get
    end property

    Private _nombre As String
    Public Property nombre() As String
        Get
            _nombre = CStr(dr("nombre"))
            Return _nombre
        End Get
        Set(ByVal Value As String)
            dr("nombre") = Value
        End Set
    end property

    Private _direccion As String
    Public Property direccion() As String
        Get
            _direccion = CStr(dr("direccion"))
            Return _direccion
        End Get
        Set(ByVal Value As String)
            dr("direccion") = Value
        End Set
    end property

    Private _telefono As String
    Public Property telefono() As String
        Get
            _telefono = CStr(dr("telefono"))
            Return _telefono
        End Get
        Set(ByVal Value As String)
            dr("telefono") = Value
        End Set
    end property

    Private _id_localidad As Int32
    Public Property id_localidad() As Int32
        Get
            _id_localidad = CInt(dr("id_localidad"))
            Return _id_localidad
        End Get
        Set(ByVal Value As Int32)
            dr("id_localidad") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Sucursal")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Sucursal_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_sucursal", SqlDbType.int, 0, "id_sucursal")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        da.InsertCommand.Parameters.Add("@direccion", SqlDbType.varchar, 500, "direccion")
        da.InsertCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        da.InsertCommand.Parameters.Add("@id_localidad", SqlDbType.int, 4, "id_localidad")

        dr = dt.NewRow()
        dr("nombre") = ""
        dr("direccion") = ""
        dr("telefono") = ""
        dr("id_localidad") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idSucursal As Integer)
        dt = New DataTable("Sucursal")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Sucursal WHERE id_sucursal = @id_Sucursal", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Sucursal", idSucursal)
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
    Public Sub Borrar(ByVal idSucursal As Integer)
        dt = New DataTable("Sucursal")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Sucursal WHERE id_sucursal = " & _
        idSucursal, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Sucursal_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_sucursal", SqlDbType.Int, 4, "id_sucursal")
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
               Case "id_sucursal"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre"
                  dc.DataType = Type.GetType("System.String")
               Case "direccion"
                  dc.DataType = Type.GetType("System.String")
               Case "telefono"
                  dc.DataType = Type.GetType("System.String")
               Case "id_localidad"
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
        dt = New DataTable("Sucursal")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Sucursal WHERE id_sucursal = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sucursal_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sucursal_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sucursal_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Sucursal As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sucursal_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_sucursal", SqlDbType.Int, 4, "id_sucursal")
        oda.SelectCommand.Parameters("@id_sucursal").Value = id_Sucursal

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sucursal_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Me.nombre
        oda.SelectCommand.Parameters.Add("@direccion", SqlDbType.varchar, 500, "direccion")
        oda.SelectCommand.Parameters("@direccion").Value = Me.direccion
        oda.SelectCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        oda.SelectCommand.Parameters("@telefono").Value = Me.telefono
        oda.SelectCommand.Parameters.Add("@id_localidad", SqlDbType.int, 4, "id_localidad")
        oda.SelectCommand.Parameters("@id_localidad").Value = Me.id_localidad

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
        Command.CommandText = "DELETE FROM Sucursal"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Sucursal"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Sucursal_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Sucursal")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Sucursal.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
