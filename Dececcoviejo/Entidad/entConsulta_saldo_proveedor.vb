Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Consulta_saldo_proveedor_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_consulta_saldo_proveedor As Int32
    Public ReadOnly Property id_consulta_saldo_proveedor() As Int32
        Get
            _id_consulta_saldo_proveedor = CInt(dr("id_consulta_saldo_proveedor"))
            Return _id_consulta_saldo_proveedor
        End Get
    end property

    Private _nombre_proveedor As String
    Public Property nombre_proveedor() As String
        Get
            _nombre_proveedor = CStr(dr("nombre_proveedor"))
            Return _nombre_proveedor
        End Get
        Set(ByVal Value As String)
            dr("nombre_proveedor") = Value
        End Set
    end property

    Private _saldo_anterior As Decimal
    Public Property saldo_anterior() As Decimal
        Get
            _saldo_anterior = CDec(dr("saldo_anterior"))
            Return _saldo_anterior
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_anterior") = Value
        End Set
    end property

    Private _saldo_actual As Decimal
    Public Property saldo_actual() As Decimal
        Get
            _saldo_actual = CDec(dr("saldo_actual"))
            Return _saldo_actual
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_actual") = Value
        End Set
    end property

    Private _saldo_total As Decimal
    Public Property saldo_total() As Decimal
        Get
            _saldo_total = CDec(dr("saldo_total"))
            Return _saldo_total
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_total") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Consulta_saldo_proveedor")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Consulta_saldo_proveedor_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_consulta_saldo_proveedor", SqlDbType.int, 0, "id_consulta_saldo_proveedor")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_proveedor", SqlDbType.varchar, 50, "nombre_proveedor")
        da.InsertCommand.Parameters.Add("@saldo_anterior", SqlDbType.decimal, 9, "saldo_anterior")
        da.InsertCommand.Parameters.Add("@saldo_actual", SqlDbType.decimal, 9, "saldo_actual")
        da.InsertCommand.Parameters.Add("@saldo_total", SqlDbType.decimal, 9, "saldo_total")

        dr = dt.NewRow()
        dr("nombre_proveedor") = ""
        dr("saldo_anterior") = 0
        dr("saldo_actual") = 0
        dr("saldo_total") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idConsulta_saldo_proveedor As Integer)
        dt = New DataTable("Consulta_saldo_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Consulta_saldo_proveedor WHERE id_consulta_saldo_proveedor = @id_Consulta_saldo_proveedor", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Consulta_saldo_proveedor", idConsulta_saldo_proveedor)
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
    Public Sub Borrar(ByVal idConsulta_saldo_proveedor As Integer)
        dt = New DataTable("Consulta_saldo_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Consulta_saldo_proveedor WHERE id_consulta_saldo_proveedor = " & _
        idConsulta_saldo_proveedor, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Consulta_saldo_proveedor_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_consulta_saldo_proveedor", SqlDbType.Int, 4, "id_consulta_saldo_proveedor")
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
               Case "id_consulta_saldo_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_proveedor"
                  dc.DataType = Type.GetType("System.String")
               Case "saldo_anterior"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "saldo_actual"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "saldo_total"
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
        dt = New DataTable("Consulta_saldo_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Consulta_saldo_proveedor WHERE id_consulta_saldo_proveedor = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_saldo_proveedor_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_saldo_proveedor_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_saldo_proveedor_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Consulta_saldo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_saldo_proveedor_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_consulta_saldo_proveedor", SqlDbType.Int, 4, "id_consulta_saldo_proveedor")
        oda.SelectCommand.Parameters("@id_consulta_saldo_proveedor").Value = id_Consulta_saldo_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_saldo_proveedor_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_proveedor", SqlDbType.varchar, 50, "nombre_proveedor")
        oda.SelectCommand.Parameters("@nombre_proveedor").Value = Me.nombre_proveedor
        oda.SelectCommand.Parameters.Add("@saldo_anterior", SqlDbType.decimal, 9, "saldo_anterior")
        oda.SelectCommand.Parameters("@saldo_anterior").Value = Me.saldo_anterior
        oda.SelectCommand.Parameters.Add("@saldo_actual", SqlDbType.decimal, 9, "saldo_actual")
        oda.SelectCommand.Parameters("@saldo_actual").Value = Me.saldo_actual
        oda.SelectCommand.Parameters.Add("@saldo_total", SqlDbType.decimal, 9, "saldo_total")
        oda.SelectCommand.Parameters("@saldo_total").Value = Me.saldo_total

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
        Command.CommandText = "DELETE FROM Consulta_saldo_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Consulta_saldo_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Consulta_saldo_proveedor_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Consulta_saldo_proveedor")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Consulta_saldo_proveedor.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
