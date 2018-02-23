Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Nivel3_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_nivel3 As Int32
    Public ReadOnly Property id_nivel3() As Int32
        Get
            _id_nivel3 = CInt(dr("id_nivel3"))
            Return _id_nivel3
        End Get
    end property

    Private _nombre_nivel3 As String
    Public Property nombre_nivel3() As String
        Get
            _nombre_nivel3 = CStr(dr("nombre_nivel3"))
            Return _nombre_nivel3
        End Get
        Set(ByVal Value As String)
            dr("nombre_nivel3") = Value
        End Set
    end property

    Private _saldo_nivel3 As Decimal
    Public Property saldo_nivel3() As Decimal
        Get
            _saldo_nivel3 = CDec(dr("saldo_nivel3"))
            Return _saldo_nivel3
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_nivel3") = Value
        End Set
    end property

    Private _id_nivel2 As Int32
    Public Property id_nivel2() As Int32
        Get
            _id_nivel2 = CInt(dr("id_nivel2"))
            Return _id_nivel2
        End Get
        Set(ByVal Value As Int32)
            dr("id_nivel2") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Nivel3")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Nivel3_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_nivel3", SqlDbType.int, 0, "id_nivel3")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_nivel3", SqlDbType.varchar, 50, "nombre_nivel3")
        da.InsertCommand.Parameters.Add("@saldo_nivel3", SqlDbType.decimal, 9, "saldo_nivel3")
        da.InsertCommand.Parameters.Add("@id_nivel2", SqlDbType.int, 4, "id_nivel2")

        dr = dt.NewRow()
        dr("nombre_nivel3") = ""
        dr("saldo_nivel3") = 0
        dr("id_nivel2") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idNivel3 As Integer)
        dt = New DataTable("Nivel3")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Nivel3 WHERE id_nivel3 = @id_Nivel3", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Nivel3", idNivel3)
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
    Public Sub Borrar(ByVal idNivel3 As Integer)
        dt = New DataTable("Nivel3")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Nivel3 WHERE id_nivel3 = " & _
        idNivel3, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Nivel3_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_nivel3", SqlDbType.Int, 4, "id_nivel3")
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
               Case "id_nivel3"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_nivel3"
                  dc.DataType = Type.GetType("System.String")
               Case "saldo_nivel3"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_nivel2"
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
        dt = New DataTable("Nivel3")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Nivel3 WHERE id_nivel3 = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel3_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel3_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel3_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Nivel3 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel3_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_nivel3", SqlDbType.Int, 4, "id_nivel3")
        oda.SelectCommand.Parameters("@id_nivel3").Value = id_Nivel3

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel3_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_nivel3", SqlDbType.varchar, 50, "nombre_nivel3")
        oda.SelectCommand.Parameters("@nombre_nivel3").Value = Me.nombre_nivel3
        oda.SelectCommand.Parameters.Add("@saldo_nivel3", SqlDbType.decimal, 9, "saldo_nivel3")
        oda.SelectCommand.Parameters("@saldo_nivel3").Value = Me.saldo_nivel3
        oda.SelectCommand.Parameters.Add("@id_nivel2", SqlDbType.int, 4, "id_nivel2")
        oda.SelectCommand.Parameters("@id_nivel2").Value = Me.id_nivel2

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
        Command.CommandText = "DELETE FROM Nivel3"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Nivel3"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Nivel3_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Nivel3")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Nivel3.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
