Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Voz_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_voz As Int32
    Public ReadOnly Property id_voz() As Int32
        Get
            _id_voz = CInt(dr("id_voz"))
            Return _id_voz
        End Get
    end property

    Private _nombre_voz As String
    Public Property nombre_voz() As String
        Get
            _nombre_voz = CStr(dr("nombre_voz"))
            Return _nombre_voz
        End Get
        Set(ByVal Value As String)
            dr("nombre_voz") = Value
        End Set
    end property

    Private _icono As String
    Public Property icono() As String
        Get
            _icono = CStr(dr("icono"))
            Return _icono
        End Get
        Set(ByVal Value As String)
            dr("icono") = Value
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

    Private _codigo_2 As String
    Public Property codigo_2() As String
        Get
            _codigo_2 = CStr(dr("codigo_2"))
            Return _codigo_2
        End Get
        Set(ByVal Value As String)
            dr("codigo_2") = Value
        End Set
    end property

    Private _ponderacion As Decimal
    Public Property ponderacion() As Decimal
        Get
            _ponderacion = CDec(dr("ponderacion"))
            Return _ponderacion
        End Get
        Set(ByVal Value As Decimal)
            dr("ponderacion") = Value
        End Set
    end property

    Private _random As Decimal
    Public Property random() As Decimal
        Get
            _random = CDec(dr("random"))
            Return _random
        End Get
        Set(ByVal Value As Decimal)
            dr("random") = Value
        End Set
    end property

    Private _corresp As Boolean
    Public Property corresp() As Boolean
        Get
            _corresp = CBool(dr("corresp"))
            Return _corresp
        End Get
        Set(ByVal Value As Boolean)
            dr("corresp") = Value
        End Set
    End Property

    Private _pond_manual As Boolean
    Public Property pond_manual() As Boolean
        Get
            _pond_manual = CBool(dr("pond_manual"))
            Return _pond_manual
        End Get
        Set(ByVal Value As Boolean)
            dr("pond_manual") = Value
        End Set
    End Property

    Private _rango As Decimal
    Public Property rango() As Decimal
        Get
            _rango = CDec(dr("rango"))
            Return _rango
        End Get
        Set(ByVal Value As Decimal)
            dr("rango") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Voz")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Voz_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_voz", SqlDbType.int, 0, "id_voz")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_voz", SqlDbType.varchar, 500, "nombre_voz")
        da.InsertCommand.Parameters.Add("@icono", SqlDbType.varchar, 5000, "icono")
        da.InsertCommand.Parameters.Add("@codigo", SqlDbType.varchar, 50, "codigo")
        da.InsertCommand.Parameters.Add("@codigo_2", SqlDbType.varchar, 50, "codigo_2")
        da.InsertCommand.Parameters.Add("@ponderacion", SqlDbType.decimal, 9, "ponderacion")
        da.InsertCommand.Parameters.Add("@random", SqlDbType.decimal, 9, "random")
        da.InsertCommand.Parameters.Add("@corresp", SqlDbType.Bit, 1, "corresp")
        da.InsertCommand.Parameters.Add("@pond_manual", SqlDbType.Bit, 1, "pond_manual")

        dr = dt.NewRow()
        dr("nombre_voz") = ""
        dr("icono") = ""
        dr("codigo") = ""
        dr("codigo_2") = ""
        dr("ponderacion") = 0
        dr("random") = 0
        dr("corresp") = False
        dr("pond_manual") = False
        dr("rango") = 0
        dr("ponderacion_por_rango") = 0

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idVoz As Integer)
        dt = New DataTable("Voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Voz WHERE id_voz = @id_Voz", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Voz", idVoz)
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
    Public Sub Borrar(ByVal idVoz As Integer)
        dt = New DataTable("Voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Voz WHERE id_voz = " & _
        idVoz, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Voz_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_voz", SqlDbType.Int, 4, "id_voz")
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
               Case "id_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_voz"
                  dc.DataType = Type.GetType("System.String")
               Case "icono"
                  dc.DataType = Type.GetType("System.String")
               Case "codigo"
                  dc.DataType = Type.GetType("System.String")
               Case "codigo_2"
                  dc.DataType = Type.GetType("System.String")
               Case "ponderacion"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "random"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "corresp"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "pond_manual"
                    dc.DataType = Type.GetType("System.Boolean")
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
        dt = New DataTable("Voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Voz WHERE id_voz = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_voz", SqlDbType.Int, 4, "id_voz")
        oda.SelectCommand.Parameters("@id_voz").Value = id_Voz

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_voz", SqlDbType.varchar, 500, "nombre_voz")
        oda.SelectCommand.Parameters("@nombre_voz").Value = Me.nombre_voz
        oda.SelectCommand.Parameters.Add("@icono", SqlDbType.varchar, 5000, "icono")
        oda.SelectCommand.Parameters("@icono").Value = Me.icono
        oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.varchar, 50, "codigo")
        oda.SelectCommand.Parameters("@codigo").Value = Me.codigo
        oda.SelectCommand.Parameters.Add("@codigo_2", SqlDbType.varchar, 50, "codigo_2")
        oda.SelectCommand.Parameters("@codigo_2").Value = Me.codigo_2
        oda.SelectCommand.Parameters.Add("@ponderacion", SqlDbType.decimal, 9, "ponderacion")
        oda.SelectCommand.Parameters("@ponderacion").Value = Me.ponderacion
        oda.SelectCommand.Parameters.Add("@random", SqlDbType.decimal, 9, "random")
        oda.SelectCommand.Parameters("@random").Value = Me.random
        oda.SelectCommand.Parameters.Add("@corresp", SqlDbType.bit, 1, "corresp")
        oda.SelectCommand.Parameters("@corresp").Value = Me.corresp
        oda.SelectCommand.Parameters.Add("@pond_manual", SqlDbType.Bit, 1, "pond_manual")
        oda.SelectCommand.Parameters("@pond_manual").Value = Me.pond_manual

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
        Command.CommandText = "DELETE FROM Voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Voz_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Voz")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Voz.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
