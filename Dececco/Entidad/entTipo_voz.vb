Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_voz_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_tipo_voz As Int32
    Public ReadOnly Property id_tipo_voz() As Int32
        Get
            _id_tipo_voz = CInt(dr("id_tipo_voz"))
            Return _id_tipo_voz
        End Get
    end property

    Private _nombre_tipo_voz As String
    Public Property nombre_tipo_voz() As String
        Get
            _nombre_tipo_voz = CStr(dr("nombre_tipo_voz"))
            Return _nombre_tipo_voz
        End Get
        Set(ByVal Value As String)
            dr("nombre_tipo_voz") = Value
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

    Private _id_control As Int32
    Public Property id_control() As Int32
        Get
            _id_control = CInt(dr("id_control"))
            Return _id_control
        End Get
        Set(ByVal Value As Int32)
            dr("id_control") = Value
        End Set
    end property

    Private _nro As Int32
    Public Property nro() As Int32
        Get
            _nro = CInt(dr("nro"))
            Return _nro
        End Get
        Set(ByVal Value As Int32)
            dr("nro") = Value
        End Set
    end property

    Private _indice As Int32
    Public Property indice() As Int32
        Get
            _indice = CInt(dr("indice"))
            Return _indice
        End Get
        Set(ByVal Value As Int32)
            dr("indice") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Tipo_voz")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Tipo_voz_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_tipo_voz", SqlDbType.int, 0, "id_tipo_voz")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_tipo_voz", SqlDbType.varchar, 50, "nombre_tipo_voz")
        da.InsertCommand.Parameters.Add("@codigo", SqlDbType.varchar, 50, "codigo")
        da.InsertCommand.Parameters.Add("@ponderacion", SqlDbType.decimal, 9, "ponderacion")
        da.InsertCommand.Parameters.Add("@id_control", SqlDbType.int, 4, "id_control")
        da.InsertCommand.Parameters.Add("@nro", SqlDbType.int, 4, "nro")
        da.InsertCommand.Parameters.Add("@indice", SqlDbType.Int, 4, "indice")
        da.InsertCommand.Parameters.Add("@pond_manual", SqlDbType.Bit, 4, "pond_manual")

        dr = dt.NewRow()
        dr("nombre_tipo_voz") = ""
        dr("codigo") = ""
        dr("ponderacion") = 0
        dr("id_control") = 0
        dr("nro") = 0
        dr("indice") = 0
        dr("pond_manual") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTipo_voz As Integer)
        dt = New DataTable("Tipo_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_voz WHERE id_tipo_voz = @id_Tipo_voz", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Tipo_voz", idTipo_voz)
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
    Public Sub Borrar(ByVal idTipo_voz As Integer)
        dt = New DataTable("Tipo_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_voz WHERE id_tipo_voz = " & _
        idTipo_voz, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Tipo_voz_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
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
               Case "id_tipo_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_tipo_voz"
                  dc.DataType = Type.GetType("System.String")
               Case "codigo"
                  dc.DataType = Type.GetType("System.String")
               Case "ponderacion"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_control"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nro"
                  dc.DataType = Type.GetType("System.Int32")
               Case "indice"
                    dc.DataType = Type.GetType("System.Int32")
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
        dt = New DataTable("Tipo_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_voz WHERE id_tipo_voz = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Tipo_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_Tipo_voz

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_tipo_voz", SqlDbType.varchar, 50, "nombre_tipo_voz")
        oda.SelectCommand.Parameters("@nombre_tipo_voz").Value = Me.nombre_tipo_voz
        oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.varchar, 50, "codigo")
        oda.SelectCommand.Parameters("@codigo").Value = Me.codigo
        oda.SelectCommand.Parameters.Add("@ponderacion", SqlDbType.decimal, 9, "ponderacion")
        oda.SelectCommand.Parameters("@ponderacion").Value = Me.ponderacion
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = Me.id_control
        oda.SelectCommand.Parameters.Add("@nro", SqlDbType.int, 4, "nro")
        oda.SelectCommand.Parameters("@nro").Value = Me.nro
        oda.SelectCommand.Parameters.Add("@indice", SqlDbType.int, 4, "indice")
        oda.SelectCommand.Parameters("@indice").Value = Me.indice
        oda.SelectCommand.Parameters.Add("@pond_manual", SqlDbType.Bit, 4, "pond_manual")
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
        Command.CommandText = "DELETE FROM Tipo_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Tipo_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Tipo_voz_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Tipo_voz")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Tipo_voz.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
