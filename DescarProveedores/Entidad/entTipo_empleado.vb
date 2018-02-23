Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_empleado_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_tipo_empleado As Int32
    Public ReadOnly Property id_tipo_empleado() As Int32
        Get
            _id_tipo_empleado = CInt(dr("id_tipo_empleado"))
            Return _id_tipo_empleado
        End Get
    end property

    Private _nombre_tipo_empleado As String
    Public Property nombre_tipo_empleado() As String
        Get
            _nombre_tipo_empleado = CStr(dr("nombre_tipo_empleado"))
            Return _nombre_tipo_empleado
        End Get
        Set(ByVal Value As String)
            dr("nombre_tipo_empleado") = Value
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

    Private _porcentaje As Decimal
    Public Property porcentaje() As Decimal
        Get
            _porcentaje = CDec(dr("porcentaje"))
            Return _porcentaje
        End Get
        Set(ByVal Value As Decimal)
            dr("porcentaje") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Tipo_empleado")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Tipo_empleado_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_tipo_empleado", SqlDbType.int, 0, "id_tipo_empleado")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_tipo_empleado", SqlDbType.varchar, 50, "nombre_tipo_empleado")
        da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 50, "descripcion")
        da.InsertCommand.Parameters.Add("@porcentaje", SqlDbType.decimal, 9, "porcentaje")

        dr = dt.NewRow()
        dr("nombre_tipo_empleado") = ""
        dr("descripcion") = ""
        dr("porcentaje") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTipo_empleado As Integer)
        dt = New DataTable("Tipo_empleado")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_empleado WHERE id_tipo_empleado = @id_Tipo_empleado", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Tipo_empleado", idTipo_empleado)
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
    Public Sub Borrar(ByVal idTipo_empleado As Integer)
        dt = New DataTable("Tipo_empleado")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_empleado WHERE id_tipo_empleado = " & _
        idTipo_empleado, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Tipo_empleado_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_tipo_empleado", SqlDbType.Int, 4, "id_tipo_empleado")
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
               Case "id_tipo_empleado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_tipo_empleado"
                  dc.DataType = Type.GetType("System.String")
               Case "descripcion"
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
        dt = New DataTable("Tipo_empleado")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_empleado WHERE id_tipo_empleado = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_empleado_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_empleado_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_empleado_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Tipo_empleado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_empleado_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_empleado", SqlDbType.Int, 4, "id_tipo_empleado")
        oda.SelectCommand.Parameters("@id_tipo_empleado").Value = id_Tipo_empleado

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_empleado_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_tipo_empleado", SqlDbType.varchar, 50, "nombre_tipo_empleado")
        oda.SelectCommand.Parameters("@nombre_tipo_empleado").Value = Me.nombre_tipo_empleado
        oda.SelectCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 50, "descripcion")
        oda.SelectCommand.Parameters("@descripcion").Value = Me.descripcion
        oda.SelectCommand.Parameters.Add("@porcentaje", SqlDbType.decimal, 9, "porcentaje")
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
        Command.CommandText = "DELETE FROM Tipo_empleado"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Tipo_empleado"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Tipo_empleado_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Tipo_empleado")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Tipo_empleado.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
