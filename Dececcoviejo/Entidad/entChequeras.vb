Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Chequeras_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_chequera As Int32
    Public ReadOnly Property id_chequera() As Int32
        Get
            _id_chequera = CInt(dr("id_chequera"))
            Return _id_chequera
        End Get
    end property

    Private _numero_cheque As String
    Public Property numero_cheque() As String
        Get
            _numero_cheque = CStr(dr("numero_cheque"))
            Return _numero_cheque
        End Get
        Set(ByVal Value As String)
            dr("numero_cheque") = Value
        End Set
    end property

    Private _tipo_cheque As Boolean
    Public Property tipo_cheque() As Boolean
        Get
            _tipo_cheque = CBool(dr("tipo_cheque"))
            Return _tipo_cheque
        End Get
        Set(ByVal Value As Boolean)
            dr("tipo_cheque") = Value
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

    Private _id_cuenta As Int32
    Public Property id_cuenta() As Int32
        Get
            _id_cuenta = CInt(dr("id_cuenta"))
            Return _id_cuenta
        End Get
        Set(ByVal Value As Int32)
            dr("id_cuenta") = Value
        End Set
    end property

    Private _inicio As Decimal
    Public Property inicio() As Decimal
        Get
            _inicio = CDec(dr("inicio"))
            Return _inicio
        End Get
        Set(ByVal Value As Decimal)
            dr("inicio") = Value
        End Set
    end property

    Private _fin As Decimal
    Public Property fin() As Decimal
        Get
            _fin = CDec(dr("fin"))
            Return _fin
        End Get
        Set(ByVal Value As Decimal)
            dr("fin") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Chequeras")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Chequeras_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_chequera", SqlDbType.int, 0, "id_chequera")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@numero_cheque", SqlDbType.char, 20, "numero_cheque")
        da.InsertCommand.Parameters.Add("@tipo_cheque", SqlDbType.bit, 1, "tipo_cheque")
        da.InsertCommand.Parameters.Add("@id_banco", SqlDbType.int, 4, "id_banco")
        da.InsertCommand.Parameters.Add("@id_cuenta", SqlDbType.int, 4, "id_cuenta")
        da.InsertCommand.Parameters.Add("@inicio", SqlDbType.decimal, 9, "inicio")
        da.InsertCommand.Parameters.Add("@fin", SqlDbType.decimal, 9, "fin")

        dr = dt.NewRow()
        dr("numero_cheque") = ""
        dr("tipo_cheque") = False
        dr("id_banco") = 0
        dr("id_cuenta") = 0
        dr("inicio") = 0
        dr("fin") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idChequeras As Integer)
        dt = New DataTable("Chequeras")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Chequeras WHERE id_chequera = @id_Chequeras", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Chequeras", idChequeras)
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
    Public Sub Borrar(ByVal idChequeras As Integer)
        dt = New DataTable("Chequeras")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Chequeras WHERE id_chequera = " & _
        idChequeras, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Chequeras_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_chequera", SqlDbType.Int, 4, "id_chequera")
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
               Case "id_chequera"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero_cheque"
                  dc.DataType = Type.GetType("System.String")
               Case "tipo_cheque"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_banco"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cuenta"
                  dc.DataType = Type.GetType("System.Int32")
               Case "inicio"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "fin"
                  dc.DataType = Type.GetType("System.Decimal")
            End Select
        Next
    End Sub

    'creo el commandbuilder
    Friend Sub CrearComandoUpdate()
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
        dt = New DataTable("Chequeras")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Chequeras WHERE id_chequera = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequeras_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequeras_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequeras_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Chequeras As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequeras_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_chequera", SqlDbType.Int, 4, "id_chequera")
        oda.SelectCommand.Parameters("@id_chequera").Value = id_Chequeras

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequeras_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero_cheque", SqlDbType.char, 20, "numero_cheque")
        oda.SelectCommand.Parameters("@numero_cheque").Value = Me.numero_cheque
        oda.SelectCommand.Parameters.Add("@tipo_cheque", SqlDbType.bit, 1, "tipo_cheque")
        oda.SelectCommand.Parameters("@tipo_cheque").Value = Me.tipo_cheque
        oda.SelectCommand.Parameters.Add("@id_banco", SqlDbType.int, 4, "id_banco")
        oda.SelectCommand.Parameters("@id_banco").Value = Me.id_banco
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = Me.id_cuenta
        oda.SelectCommand.Parameters.Add("@inicio", SqlDbType.decimal, 9, "inicio")
        oda.SelectCommand.Parameters("@inicio").Value = Me.inicio
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.decimal, 9, "fin")
        oda.SelectCommand.Parameters("@fin").Value = Me.fin

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
        Command.CommandText = "DELETE FROM Chequeras"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Chequeras"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Chequeras_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Chequeras")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Chequeras.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
