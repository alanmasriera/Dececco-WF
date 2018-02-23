Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Temp1_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_temp1 As Int32
    Public ReadOnly Property id_temp1() As Int32
        Get
            _id_temp1 = CInt(dr("id_temp1"))
            Return _id_temp1
        End Get
    end property

    Private _legajo As String
    Public Property legajo() As String
        Get
            _legajo = CStr(dr("legajo"))
            Return _legajo
        End Get
        Set(ByVal Value As String)
            dr("legajo") = Value
        End Set
    end property

    Private _nombre_empleado As String
    Public Property nombre_empleado() As String
        Get
            _nombre_empleado = CStr(dr("nombre_empleado"))
            Return _nombre_empleado
        End Get
        Set(ByVal Value As String)
            dr("nombre_empleado") = Value
        End Set
    end property

    Private _normal As Decimal
    Public Property normal() As Decimal
        Get
            _normal = CDec(dr("normal"))
            Return _normal
        End Get
        Set(ByVal Value As Decimal)
            dr("normal") = Value
        End Set
    end property

    Private _extra_50 As Decimal
    Public Property extra_50() As Decimal
        Get
            _extra_50 = CDec(dr("extra_50"))
            Return _extra_50
        End Get
        Set(ByVal Value As Decimal)
            dr("extra_50") = Value
        End Set
    end property

    Private _extra_100 As Decimal
    Public Property extra_100() As Decimal
        Get
            _extra_100 = CDec(dr("extra_100"))
            Return _extra_100
        End Get
        Set(ByVal Value As Decimal)
            dr("extra_100") = Value
        End Set
    end property

    Private _normal_30 As Decimal
    Public Property normal_30() As Decimal
        Get
            _normal_30 = CDec(dr("normal_30"))
            Return _normal_30
        End Get
        Set(ByVal Value As Decimal)
            dr("normal_30") = Value
        End Set
    end property

    Private _extra_50_30 As Decimal
    Public Property extra_50_30() As Decimal
        Get
            _extra_50_30 = CDec(dr("extra_50_30"))
            Return _extra_50_30
        End Get
        Set(ByVal Value As Decimal)
            dr("extra_50_30") = Value
        End Set
    end property

    Private _extra_100_30 As Decimal
    Public Property extra_100_30() As Decimal
        Get
            _extra_100_30 = CDec(dr("extra_100_30"))
            Return _extra_100_30
        End Get
        Set(ByVal Value As Decimal)
            dr("extra_100_30") = Value
        End Set
    end property

    Private _nocturna As Decimal
    Public Property nocturna() As Decimal
        Get
            _nocturna = CDec(dr("nocturna"))
            Return _nocturna
        End Get
        Set(ByVal Value As Decimal)
            dr("nocturna") = Value
        End Set
    end property

    Private _enfermedad As Decimal
    Public Property enfermedad() As Decimal
        Get
            _enfermedad = CDec(dr("enfermedad"))
            Return _enfermedad
        End Get
        Set(ByVal Value As Decimal)
            dr("enfermedad") = Value
        End Set
    end property

    Private _accidente As Decimal
    Public Property accidente() As Decimal
        Get
            _accidente = CDec(dr("accidente"))
            Return _accidente
        End Get
        Set(ByVal Value As Decimal)
            dr("accidente") = Value
        End Set
    end property

    Private _feriado As Decimal
    Public Property feriado() As Decimal
        Get
            _feriado = CDec(dr("feriado"))
            Return _feriado
        End Get
        Set(ByVal Value As Decimal)
            dr("feriado") = Value
        End Set
    end property

    Private _especial As Decimal
    Public Property especial() As Decimal
        Get
            _especial = CDec(dr("especial"))
            Return _especial
        End Get
        Set(ByVal Value As Decimal)
            dr("especial") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Temp1")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Temp1_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_temp1", SqlDbType.int, 0, "id_temp1")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@legajo", SqlDbType.varchar, 50, "legajo")
        da.InsertCommand.Parameters.Add("@nombre_empleado", SqlDbType.varchar, 50, "nombre_empleado")
        da.InsertCommand.Parameters.Add("@normal", SqlDbType.decimal, 9, "normal")
        da.InsertCommand.Parameters.Add("@extra_50", SqlDbType.decimal, 9, "extra_50")
        da.InsertCommand.Parameters.Add("@extra_100", SqlDbType.decimal, 9, "extra_100")
        da.InsertCommand.Parameters.Add("@normal_30", SqlDbType.decimal, 9, "normal_30")
        da.InsertCommand.Parameters.Add("@extra_50_30", SqlDbType.decimal, 9, "extra_50_30")
        da.InsertCommand.Parameters.Add("@extra_100_30", SqlDbType.decimal, 9, "extra_100_30")
        da.InsertCommand.Parameters.Add("@nocturna", SqlDbType.decimal, 9, "nocturna")
        da.InsertCommand.Parameters.Add("@enfermedad", SqlDbType.decimal, 9, "enfermedad")
        da.InsertCommand.Parameters.Add("@accidente", SqlDbType.decimal, 9, "accidente")
        da.InsertCommand.Parameters.Add("@feriado", SqlDbType.decimal, 9, "feriado")
        da.InsertCommand.Parameters.Add("@especial", SqlDbType.decimal, 9, "especial")

        dr = dt.NewRow()
        dr("legajo") = ""
        dr("nombre_empleado") = ""
        dr("normal") = 0
        dr("extra_50") = 0
        dr("extra_100") = 0
        dr("normal_30") = 0
        dr("extra_50_30") = 0
        dr("extra_100_30") = 0
        dr("nocturna") = 0
        dr("enfermedad") = 0
        dr("accidente") = 0
        dr("feriado") = 0
        dr("especial") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTemp1 As Integer)
        dt = New DataTable("Temp1")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Temp1 WHERE id_temp1 = @id_Temp1", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Temp1", idTemp1)
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
    Public Sub Borrar(ByVal idTemp1 As Integer)
        dt = New DataTable("Temp1")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Temp1 WHERE id_temp1 = " & _
        idTemp1, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Temp1_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_temp1", SqlDbType.Int, 4, "id_temp1")
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
               Case "id_temp1"
                  dc.DataType = Type.GetType("System.Int32")
               Case "legajo"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre_empleado"
                  dc.DataType = Type.GetType("System.String")
               Case "normal"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "extra_50"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "extra_100"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "normal_30"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "extra_50_30"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "extra_100_30"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "nocturna"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "enfermedad"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "accidente"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "feriado"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "especial"
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
        dt = New DataTable("Temp1")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Temp1 WHERE id_temp1 = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp1_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp1_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp1_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Temp1 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp1_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_temp1", SqlDbType.Int, 4, "id_temp1")
        oda.SelectCommand.Parameters("@id_temp1").Value = id_Temp1

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp1_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@legajo", SqlDbType.varchar, 50, "legajo")
        oda.SelectCommand.Parameters("@legajo").Value = Me.legajo
        oda.SelectCommand.Parameters.Add("@nombre_empleado", SqlDbType.varchar, 50, "nombre_empleado")
        oda.SelectCommand.Parameters("@nombre_empleado").Value = Me.nombre_empleado
        oda.SelectCommand.Parameters.Add("@normal", SqlDbType.decimal, 9, "normal")
        oda.SelectCommand.Parameters("@normal").Value = Me.normal
        oda.SelectCommand.Parameters.Add("@extra_50", SqlDbType.decimal, 9, "extra_50")
        oda.SelectCommand.Parameters("@extra_50").Value = Me.extra_50
        oda.SelectCommand.Parameters.Add("@extra_100", SqlDbType.decimal, 9, "extra_100")
        oda.SelectCommand.Parameters("@extra_100").Value = Me.extra_100
        oda.SelectCommand.Parameters.Add("@normal_30", SqlDbType.decimal, 9, "normal_30")
        oda.SelectCommand.Parameters("@normal_30").Value = Me.normal_30
        oda.SelectCommand.Parameters.Add("@extra_50_30", SqlDbType.decimal, 9, "extra_50_30")
        oda.SelectCommand.Parameters("@extra_50_30").Value = Me.extra_50_30
        oda.SelectCommand.Parameters.Add("@extra_100_30", SqlDbType.decimal, 9, "extra_100_30")
        oda.SelectCommand.Parameters("@extra_100_30").Value = Me.extra_100_30
        oda.SelectCommand.Parameters.Add("@nocturna", SqlDbType.decimal, 9, "nocturna")
        oda.SelectCommand.Parameters("@nocturna").Value = Me.nocturna
        oda.SelectCommand.Parameters.Add("@enfermedad", SqlDbType.decimal, 9, "enfermedad")
        oda.SelectCommand.Parameters("@enfermedad").Value = Me.enfermedad
        oda.SelectCommand.Parameters.Add("@accidente", SqlDbType.decimal, 9, "accidente")
        oda.SelectCommand.Parameters("@accidente").Value = Me.accidente
        oda.SelectCommand.Parameters.Add("@feriado", SqlDbType.decimal, 9, "feriado")
        oda.SelectCommand.Parameters("@feriado").Value = Me.feriado
        oda.SelectCommand.Parameters.Add("@especial", SqlDbType.decimal, 9, "especial")
        oda.SelectCommand.Parameters("@especial").Value = Me.especial

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
        Command.CommandText = "DELETE FROM Temp1"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Temp1"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Temp1_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Temp1")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Temp1.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
