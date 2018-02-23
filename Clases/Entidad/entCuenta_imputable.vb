Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuenta_imputable_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cuenta_imputable As Int32
    Public ReadOnly Property id_cuenta_imputable() As Int32
        Get
            _id_cuenta_imputable = CInt(dr("id_cuenta_imputable"))
            Return _id_cuenta_imputable
        End Get
    end property

    Private _nombre_cuenta_imputable As String
    Public Property nombre_cuenta_imputable() As String
        Get
            _nombre_cuenta_imputable = CStr(dr("nombre_cuenta_imputable"))
            Return _nombre_cuenta_imputable
        End Get
        Set(ByVal Value As String)
            dr("nombre_cuenta_imputable") = Value
        End Set
    end property

    Private _orden As String
    Public Property orden() As String
        Get
            _orden = CStr(dr("orden"))
            Return _orden
        End Get
        Set(ByVal Value As String)
            dr("orden") = Value
        End Set
    end property

    Private _saldo_cuenta_imputable As Decimal
    Public Property saldo_cuenta_imputable() As Decimal
        Get
            _saldo_cuenta_imputable = CDec(dr("saldo_cuenta_imputable"))
            Return _saldo_cuenta_imputable
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_cuenta_imputable") = Value
        End Set
    end property

    Private _ajuste As Boolean
    Public Property ajuste() As Boolean
        Get
            _ajuste = CBool(dr("ajuste"))
            Return _ajuste
        End Get
        Set(ByVal Value As Boolean)
            dr("ajuste") = Value
        End Set
    end property

    Private _id_nivel3 As Int32
    Public Property id_nivel3() As Int32
        Get
            _id_nivel3 = CInt(dr("id_nivel3"))
            Return _id_nivel3
        End Get
        Set(ByVal Value As Int32)
            dr("id_nivel3") = Value
        End Set
    end property

    Private _codigo As String
    Public Property codigo() As String
        Get
            _codigo = CStr(dr("codigo"))
            Return _codigo
        End Get
        Set(ByVal Value As String)
            dr("codigo") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cuenta_imputable")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cuenta_imputable_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.int, 0, "id_cuenta_imputable")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_cuenta_imputable", SqlDbType.varchar, 50, "nombre_cuenta_imputable")
        da.InsertCommand.Parameters.Add("@orden", SqlDbType.varchar, 50, "orden")
        da.InsertCommand.Parameters.Add("@saldo_cuenta_imputable", SqlDbType.decimal, 9, "saldo_cuenta_imputable")
        da.InsertCommand.Parameters.Add("@ajuste", SqlDbType.bit, 1, "ajuste")
        da.InsertCommand.Parameters.Add("@id_nivel3", SqlDbType.int, 4, "id_nivel3")
        da.InsertCommand.Parameters.Add("@codigo", SqlDbType.varchar, 50, "codigo")

        dr = dt.NewRow()
        dr("nombre_cuenta_imputable") = ""
        dr("orden") = ""
        dr("saldo_cuenta_imputable") = 0
        dr("ajuste") = False
        dr("id_nivel3") = 0
        dr("codigo") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCuenta_imputable As Integer)
        dt = New DataTable("Cuenta_imputable")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuenta_imputable WHERE id_cuenta_imputable = @id_Cuenta_imputable", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cuenta_imputable", idCuenta_imputable)
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
    Public Sub Borrar(ByVal idCuenta_imputable As Integer)
        dt = New DataTable("Cuenta_imputable")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuenta_imputable WHERE id_cuenta_imputable = " & _
        idCuenta_imputable, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cuenta_imputable_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.Int, 4, "id_cuenta_imputable")
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
               Case "id_cuenta_imputable"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_cuenta_imputable"
                  dc.DataType = Type.GetType("System.String")
               Case "orden"
                  dc.DataType = Type.GetType("System.String")
               Case "saldo_cuenta_imputable"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "ajuste"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_nivel3"
                  dc.DataType = Type.GetType("System.Int32")
               Case "codigo"
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
        dt = New DataTable("Cuenta_imputable")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuenta_imputable WHERE id_cuenta_imputable = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuenta_imputable_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuenta_imputable_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuenta_imputable_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cuenta_imputable As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuenta_imputable_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.Int, 4, "id_cuenta_imputable")
        oda.SelectCommand.Parameters("@id_cuenta_imputable").Value = id_Cuenta_imputable

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuenta_imputable_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_cuenta_imputable", SqlDbType.varchar, 50, "nombre_cuenta_imputable")
        oda.SelectCommand.Parameters("@nombre_cuenta_imputable").Value = Me.nombre_cuenta_imputable
        oda.SelectCommand.Parameters.Add("@orden", SqlDbType.varchar, 50, "orden")
        oda.SelectCommand.Parameters("@orden").Value = Me.orden
        oda.SelectCommand.Parameters.Add("@saldo_cuenta_imputable", SqlDbType.decimal, 9, "saldo_cuenta_imputable")
        oda.SelectCommand.Parameters("@saldo_cuenta_imputable").Value = Me.saldo_cuenta_imputable
        oda.SelectCommand.Parameters.Add("@ajuste", SqlDbType.bit, 1, "ajuste")
        oda.SelectCommand.Parameters("@ajuste").Value = Me.ajuste
        oda.SelectCommand.Parameters.Add("@id_nivel3", SqlDbType.int, 4, "id_nivel3")
        oda.SelectCommand.Parameters("@id_nivel3").Value = Me.id_nivel3
        oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.varchar, 50, "codigo")
        oda.SelectCommand.Parameters("@codigo").Value = Me.codigo

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
        Command.CommandText = "DELETE FROM Cuenta_imputable"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cuenta_imputable"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuenta_imputable_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cuenta_imputable")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cuenta_imputable.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
