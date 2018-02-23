Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuentas_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cuenta As Int32
    Public ReadOnly Property id_cuenta() As Int32
        Get
            _id_cuenta = CInt(dr("id_cuenta"))
            Return _id_cuenta
        End Get
    end property

    Private _numero As String
    Public Property numero() As String
        Get
            _numero = CStr(dr("numero"))
            Return _numero
        End Get
        Set(ByVal Value As String)
            dr("numero") = Value
        End Set
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

    Private _id_banco As Int32
    Public Property id_banco() As Int32
        Get
            _id_banco = CInt(dr("id_banco"))
            Return _id_banco
        End Get
        Set(ByVal Value As Int32)
            dr("id_banco") = Value
        End Set
    end property

    Private _cbu As String
    Public Property cbu() As String
        Get
            _cbu = CStr(dr("cbu"))
            Return _cbu
        End Get
        Set(ByVal Value As String)
            dr("cbu") = Value
        End Set
    end property

    Private _moneda As String
    Public Property moneda() As String
        Get
            _moneda = CStr(dr("moneda"))
            Return _moneda
        End Get
        Set(ByVal Value As String)
            dr("moneda") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cuentas")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cuentas_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cuenta", SqlDbType.int, 0, "id_cuenta")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@id_banco", SqlDbType.int, 4, "id_banco")
        da.InsertCommand.Parameters.Add("@cbu", SqlDbType.varchar, 50, "cbu")
        da.InsertCommand.Parameters.Add("@moneda", SqlDbType.varchar, 50, "moneda")

        dr = dt.NewRow()
        dr("numero") = ""
        dr("id_empresa") = 0
        dr("id_banco") = 0
        dr("cbu") = ""
        dr("moneda") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCuentas As Integer)
        dt = New DataTable("Cuentas")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuentas WHERE id_cuenta = @id_Cuentas", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cuentas", idCuentas)
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
    Public Sub Borrar(ByVal idCuentas As Integer)
        dt = New DataTable("Cuentas")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuentas WHERE id_cuenta = " & _
        idCuentas, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cuentas_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
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
               Case "id_cuenta"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero"
                  dc.DataType = Type.GetType("System.String")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_banco"
                  dc.DataType = Type.GetType("System.Int32")
               Case "cbu"
                  dc.DataType = Type.GetType("System.String")
               Case "moneda"
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
        dt = New DataTable("Cuentas")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuentas WHERE id_cuenta = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuentas_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuentas_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuentas_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cuentas As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuentas_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_Cuentas

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuentas_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        oda.SelectCommand.Parameters("@numero").Value = Me.numero
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@id_banco", SqlDbType.int, 4, "id_banco")
        oda.SelectCommand.Parameters("@id_banco").Value = Me.id_banco
        oda.SelectCommand.Parameters.Add("@cbu", SqlDbType.varchar, 50, "cbu")
        oda.SelectCommand.Parameters("@cbu").Value = Me.cbu
        oda.SelectCommand.Parameters.Add("@moneda", SqlDbType.varchar, 50, "moneda")
        oda.SelectCommand.Parameters("@moneda").Value = Me.moneda

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
        Command.CommandText = "DELETE FROM Cuentas"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cuentas"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuentas_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cuentas")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cuentas.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
