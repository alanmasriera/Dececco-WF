Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class entAnotaciones_Proyecto

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_anotacion As Int32
    Public ReadOnly Property id_anotacion() As Int32
        Get
            _id_anotacion = CInt(dr("id_anotacion"))
            Return _id_anotacion
        End Get
    End Property

    Private _id_proyecto As Int32
    Public Property id_proyecto() As Int32
        Get
            _id_proyecto = CInt(dr("id_proyecto"))
            Return _id_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_proyecto") = Value
        End Set
    End Property

    Private _mostrar As Boolean
    Public Property mostrar() As Boolean
        Get
            _mostrar = CBool(dr("mostrar"))
            Return _mostrar
        End Get
        Set(ByVal Value As Boolean)
            dr("mostrar") = Value
        End Set
    End Property

    Private _resaltar As Boolean
    Public Property resaltar() As Boolean
        Get
            _resaltar = CBool(dr("resaltar"))
            Return _resaltar
        End Get
        Set(ByVal Value As Boolean)
            dr("resaltar") = Value
        End Set
    End Property

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            _descripcion = CStr(dr("descripcion"))
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            dr("descripcion") = Value
        End Set
    End Property

    Private _orden As Int32
    Public Property orden() As Int32
        Get
            _orden = CInt(dr("orden"))
            Return _orden
        End Get
        Set(ByVal Value As Int32)
            dr("orden") = Value
        End Set
    End Property

    Private _fecha As DateTime
    Public Property fecha() As DateTime
        Get
            _fecha = CDate(dr("fecha"))
            Return _fecha
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha") = Value
        End Set
    End Property

    Private _id_usuario As Int32
    Public Property id_usuario() As Int32
        Get
            _id_usuario = CInt(dr("id_usuario"))
            Return _id_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario") = Value
        End Set
    End Property

    Private _archivado As Boolean
    Public Property archivado() As Boolean
        Get
            _archivado = CBool(dr("archivado"))
            Return _archivado
        End Get
        Set(ByVal Value As Boolean)
            dr("archivado") = Value
        End Set
    End Property

    Private _id_actividad_proyecto As Int32
    Public Property id_actividad_proyecto() As Int32
        Get
            _id_actividad_proyecto = CInt(dr("id_actividad_proyecto"))
            Return _id_actividad_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_actividad_proyecto") = Value
        End Set
    End Property

    Private _id_subproyecto As Int32
    Public Property id_subproyecto() As Int32
        Get
            _id_subproyecto = CInt(dr("id_subproyecto"))
            Return _id_subproyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_subproyecto") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Anotaciones_Proyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Anotaciones_Proyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_anotacion", SqlDbType.Int, 0, "id_anotacion")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.VarChar, 500, "descripcion")
        da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 6, "id_proyecto")
        da.InsertCommand.Parameters.Add("@mostrar", SqlDbType.Bit, 9, "mostrar")
        da.InsertCommand.Parameters.Add("@resaltar", SqlDbType.Bit, 9, "resaltar")
        da.InsertCommand.Parameters.Add("@orden", SqlDbType.Int, 9, "orden")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 9, "fecha")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 6, "id_usuario")
        da.InsertCommand.Parameters.Add("@archivado", SqlDbType.Bit, 9, "archivado")
        da.InsertCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 6, "id_actividad_proyecto")
        da.InsertCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")


        dr = dt.NewRow()
        dr("descripcion") = ""
        dr("id_proyecto") = 0
        dr("mostrar") = 0
        dr("resaltar") = 0
        dr("orden") = 0
        dr("fecha") = DateTime.Now
        dr("archivado") = 0
        dr("id_usuario") = 0
        dr("id_actividad_proyecto") = 0
        dr("id_subproyecto") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTipo_actividad As Integer)
        dt = New DataTable("Anotaciones_Proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Anotaciones_Proyecto WHERE id_anotacion = @id_anotacion", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_anotacion", idTipo_actividad)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se ha encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        CrearComandoUpdate()
    End Sub

    'procedimiento borrar
    Public Sub Borrar(ByVal idTipo_actividad As Integer)
        dt = New DataTable("Anotaciones_Proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Anotaciones_Proyecto WHERE id_anotacion = " & _
        idTipo_actividad, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Anotaciones_Proyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_anotacion", SqlDbType.Int, 4, "id_anotacion")
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
                Case "id_tipo_actividad"
                    dc.DataType = Type.GetType("System.Int32")
                Case "descripcion"
                    dc.DataType = Type.GetType("System.String")
                Case "id_proyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "mostrar"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "resaltar"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "orden"
                    dc.DataType = Type.GetType("System.Int32")
                Case "fecha"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "archivado"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "id_usuario"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_actividad_proyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_subproyecto"
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
        dt = New DataTable("Anotaciones_Proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Anotaciones_Proyecto WHERE id_anotacion = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    Public Function GetOne(ByVal id_anotacion As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Anotaciones_Proyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_anotacion", SqlDbType.Int, 4, "id_anotacion")
        oda.SelectCommand.Parameters("@id_anotacion").Value = id_anotacion

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetFromProyectoCadista(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Anotaciones_Proyecto_GetFromProyectoCadista", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetFromProyectoAdmin(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Anotaciones_Proyecto_GetFromProyectoAdmin", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function


End Class
