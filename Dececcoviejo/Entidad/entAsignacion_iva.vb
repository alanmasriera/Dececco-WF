Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Asignacion_iva_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_asignacion_Iva As Int32
    Public ReadOnly Property id_asignacion_Iva() As Int32
        Get
            _id_asignacion_Iva = CInt(dr("id_asignacion_Iva"))
            Return _id_asignacion_Iva
        End Get
    end property

    Private _id_empresa As Int32
    Public Property id_empresa() As Int32
        Get
            _id_empresa = CInt(dr("id_empresa"))
            Return _id_empresa
        End Get
        Set(ByVal Value As Int32)
            dr("id_empresa") = Value
        End Set
    end property

    Private _id_Iva As Int32
    Public Property id_Iva() As Int32
        Get
            _id_Iva = CInt(dr("id_Iva"))
            Return _id_Iva
        End Get
        Set(ByVal Value As Int32)
            dr("id_Iva") = Value
        End Set
    end property

    Private _sueldo_Iva As Decimal
    Public Property sueldo_Iva() As Decimal
        Get
            _sueldo_Iva = CDec(dr("sueldo_Iva"))
            Return _sueldo_Iva
        End Get
        Set(ByVal Value As Decimal)
            dr("sueldo_Iva") = Value
        End Set
    end property

    Private _fecha_asignacion_Iva As DateTime
    Public Property fecha_asignacion_Iva() As DateTime
        Get
            _fecha_asignacion_Iva = CDate(dr("fecha_asignacion_Iva"))
            Return _fecha_asignacion_Iva
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_asignacion_Iva") = Value
        End Set
    end property

    Private _detalle_asignacion_Iva As String
    Public Property detalle_asignacion_Iva() As String
        Get
            _detalle_asignacion_Iva = CStr(dr("detalle_asignacion_Iva"))
            Return _detalle_asignacion_Iva
        End Get
        Set(ByVal Value As String)
            dr("detalle_asignacion_Iva") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Asignacion_iva")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Asignacion_iva_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_asignacion_Iva", SqlDbType.int, 0, "id_asignacion_Iva")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@id_Iva", SqlDbType.int, 4, "id_Iva")
        da.InsertCommand.Parameters.Add("@sueldo_Iva", SqlDbType.decimal, 9, "sueldo_Iva")
        da.InsertCommand.Parameters.Add("@fecha_asignacion_Iva", SqlDbType.datetime, 8, "fecha_asignacion_Iva")
        da.InsertCommand.Parameters.Add("@detalle_asignacion_Iva", SqlDbType.varchar, 50, "detalle_asignacion_Iva")

        dr = dt.NewRow()
        dr("id_empresa") = 0
        dr("id_Iva") = 0
        dr("sueldo_Iva") = 0
        dr("fecha_asignacion_Iva") = DateTime.Now
        dr("detalle_asignacion_Iva") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idAsignacion_iva As Integer)
        dt = New DataTable("Asignacion_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Asignacion_iva WHERE id_asignacion_Iva = @id_Asignacion_iva", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Asignacion_iva", idAsignacion_iva)
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
    Public Sub Borrar(ByVal idAsignacion_iva As Integer)
        dt = New DataTable("Asignacion_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Asignacion_iva WHERE id_asignacion_Iva = " & _
        idAsignacion_iva, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Asignacion_iva_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_asignacion_Iva", SqlDbType.Int, 4, "id_asignacion_Iva")
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
               Case "id_asignacion_Iva"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_Iva"
                  dc.DataType = Type.GetType("System.Int32")
               Case "sueldo_Iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "fecha_asignacion_Iva"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "detalle_asignacion_Iva"
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
        dt = New DataTable("Asignacion_iva")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Asignacion_iva WHERE id_asignacion_Iva = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asignacion_iva_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asignacion_iva_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asignacion_iva_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Asignacion_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asignacion_iva_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_asignacion_Iva", SqlDbType.Int, 4, "id_asignacion_Iva")
        oda.SelectCommand.Parameters("@id_asignacion_Iva").Value = id_Asignacion_iva

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asignacion_iva_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@id_Iva", SqlDbType.int, 4, "id_Iva")
        oda.SelectCommand.Parameters("@id_Iva").Value = Me.id_Iva
        oda.SelectCommand.Parameters.Add("@sueldo_Iva", SqlDbType.decimal, 9, "sueldo_Iva")
        oda.SelectCommand.Parameters("@sueldo_Iva").Value = Me.sueldo_Iva
        oda.SelectCommand.Parameters.Add("@fecha_asignacion_Iva", SqlDbType.datetime, 8, "fecha_asignacion_Iva")
        oda.SelectCommand.Parameters("@fecha_asignacion_Iva").Value = Me.fecha_asignacion_Iva
        oda.SelectCommand.Parameters.Add("@detalle_asignacion_Iva", SqlDbType.varchar, 50, "detalle_asignacion_Iva")
        oda.SelectCommand.Parameters("@detalle_asignacion_Iva").Value = Me.detalle_asignacion_Iva

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
        Command.CommandText = "DELETE FROM Asignacion_iva"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Asignacion_iva"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Asignacion_iva_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Asignacion_iva")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Asignacion_iva.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
