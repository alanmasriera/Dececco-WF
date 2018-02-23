Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Modificacion_arbol_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_modificacion_arbol As Int32
    Public ReadOnly Property id_modificacion_arbol() As Int32
        Get
            _id_modificacion_arbol = CInt(dr("id_modificacion_arbol"))
            Return _id_modificacion_arbol
        End Get
    end property

    Private _nombre_modificacion_arbol As String
    Public Property nombre_modificacion_arbol() As String
        Get
            _nombre_modificacion_arbol = CStr(dr("nombre_modificacion_arbol"))
            Return _nombre_modificacion_arbol
        End Get
        Set(ByVal Value As String)
            dr("nombre_modificacion_arbol") = Value
        End Set
    end property

    Private _id_usuario As Int32
    Public Property id_usuario() As Int32
        Get
            _id_usuario = CInt(dr("id_usuario"))
            Return _id_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario") = Value
        End Set
    end property

    Private _realizado As Boolean
    Public Property realizado() As Boolean
        Get
            _realizado = CBool(dr("realizado"))
            Return _realizado
        End Get
        Set(ByVal Value As Boolean)
            dr("realizado") = Value
        End Set
    end property

    Private _id_actividad As Int32
    Public Property id_actividad() As Int32
        Get
            _id_actividad = CInt(dr("id_actividad"))
            Return _id_actividad
        End Get
        Set(ByVal Value As Int32)
            dr("id_actividad") = Value
        End Set
    end property

    Private _id_proyecto As Int32
    Public Property id_proyecto() As Int32
        Get
            _id_proyecto = CInt(dr("id_proyecto"))
            Return _id_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_proyecto") = Value
        End Set
    end property

    Private _id_actividad_proyecto As Int32
    Public Property id_actividad_proyecto() As Int32
        Get
            _id_actividad_proyecto = CInt(dr("id_actividad_proyecto"))
            Return _id_actividad_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_actividad_proyecto") = Value
        End Set
    end property

    Private _tipo_nodo As String
    Public Property tipo_nodo() As String
        Get
            _tipo_nodo = CStr(dr("tipo_nodo"))
            Return _tipo_nodo
        End Get
        Set(ByVal Value As String)
            dr("tipo_nodo") = Value
        End Set
    end property

    Private _nodo As Decimal
    Public Property nodo() As Decimal
        Get
            _nodo = CDec(dr("nodo"))
            Return _nodo
        End Get
        Set(ByVal Value As Decimal)
            dr("nodo") = Value
        End Set
    end property

    Private _nodo_padre As Decimal
    Public Property nodo_padre() As Decimal
        Get
            _nodo_padre = CDec(dr("nodo_padre"))
            Return _nodo_padre
        End Get
        Set(ByVal Value As Decimal)
            dr("nodo_padre") = Value
        End Set
    end property

    Private _nombre As String
    Public Property nombre() As String
        Get
            _nombre = CStr(dr("nombre"))
            Return _nombre
        End Get
        Set(ByVal Value As String)
            dr("nombre") = Value
        End Set
    end property

    Private _id_usuario_modificador As Int32
    Public Property id_usuario_modificador() As Int32
        Get
            _id_usuario_modificador = CInt(dr("id_usuario_modificador"))
            Return _id_usuario_modificador
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_modificador") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Modificacion_arbol")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Modificacion_arbol_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_modificacion_arbol", SqlDbType.int, 0, "id_modificacion_arbol")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_modificacion_arbol", SqlDbType.varchar, 500, "nombre_modificacion_arbol")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@realizado", SqlDbType.bit, 1, "realizado")
        da.InsertCommand.Parameters.Add("@id_actividad", SqlDbType.int, 4, "id_actividad")
        da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")
        da.InsertCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        da.InsertCommand.Parameters.Add("@tipo_nodo", SqlDbType.char, 1, "tipo_nodo")
        da.InsertCommand.Parameters.Add("@nodo", SqlDbType.decimal, 9, "nodo")
        da.InsertCommand.Parameters.Add("@nodo_padre", SqlDbType.decimal, 9, "nodo_padre")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        da.InsertCommand.Parameters.Add("@id_usuario_modificador", SqlDbType.int, 4, "id_usuario_modificador")

        dr = dt.NewRow()
        dr("nombre_modificacion_arbol") = ""
        dr("id_usuario") = 0
        dr("realizado") = False
        dr("id_actividad") = 0
        dr("id_proyecto") = 0
        dr("id_actividad_proyecto") = 0
        dr("tipo_nodo") = ""
        dr("nodo") = 0
        dr("nodo_padre") = 0
        dr("nombre") = ""
        dr("id_usuario_modificador") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idModificacion_arbol As Integer)
        dt = New DataTable("Modificacion_arbol")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Modificacion_arbol WHERE id_modificacion_arbol = @id_Modificacion_arbol", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Modificacion_arbol", idModificacion_arbol)
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
    Public Sub Borrar(ByVal idModificacion_arbol As Integer)
        dt = New DataTable("Modificacion_arbol")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Modificacion_arbol WHERE id_modificacion_arbol = " & _
        idModificacion_arbol, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Modificacion_arbol_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_modificacion_arbol", SqlDbType.Int, 4, "id_modificacion_arbol")
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
               Case "id_modificacion_arbol"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_modificacion_arbol"
                  dc.DataType = Type.GetType("System.String")
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "realizado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_actividad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_actividad_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "tipo_nodo"
                  dc.DataType = Type.GetType("System.String")
               Case "nodo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "nodo_padre"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "nombre"
                  dc.DataType = Type.GetType("System.String")
               Case "id_usuario_modificador"
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
        dt = New DataTable("Modificacion_arbol")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Modificacion_arbol WHERE id_modificacion_arbol = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Modificacion_arbol_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Modificacion_arbol_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Modificacion_arbol_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Modificacion_arbol As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Modificacion_arbol_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_modificacion_arbol", SqlDbType.Int, 4, "id_modificacion_arbol")
        oda.SelectCommand.Parameters("@id_modificacion_arbol").Value = id_Modificacion_arbol

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Modificacion_arbol_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_modificacion_arbol", SqlDbType.varchar, 500, "nombre_modificacion_arbol")
        oda.SelectCommand.Parameters("@nombre_modificacion_arbol").Value = Me.nombre_modificacion_arbol
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@realizado", SqlDbType.bit, 1, "realizado")
        oda.SelectCommand.Parameters("@realizado").Value = Me.realizado
        oda.SelectCommand.Parameters.Add("@id_actividad", SqlDbType.int, 4, "id_actividad")
        oda.SelectCommand.Parameters("@id_actividad").Value = Me.id_actividad
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = Me.id_proyecto
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = Me.id_actividad_proyecto
        oda.SelectCommand.Parameters.Add("@tipo_nodo", SqlDbType.char, 1, "tipo_nodo")
        oda.SelectCommand.Parameters("@tipo_nodo").Value = Me.tipo_nodo
        oda.SelectCommand.Parameters.Add("@nodo", SqlDbType.decimal, 9, "nodo")
        oda.SelectCommand.Parameters("@nodo").Value = Me.nodo
        oda.SelectCommand.Parameters.Add("@nodo_padre", SqlDbType.decimal, 9, "nodo_padre")
        oda.SelectCommand.Parameters("@nodo_padre").Value = Me.nodo_padre
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Me.nombre
        oda.SelectCommand.Parameters.Add("@id_usuario_modificador", SqlDbType.int, 4, "id_usuario_modificador")
        oda.SelectCommand.Parameters("@id_usuario_modificador").Value = Me.id_usuario_modificador

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
        Command.CommandText = "DELETE FROM Modificacion_arbol"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Modificacion_arbol"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Modificacion_arbol_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Modificacion_arbol")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Modificacion_arbol.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
