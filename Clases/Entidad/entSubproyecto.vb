Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class entSubproyecto

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    '''

    ''' Gets or Sets id_suproyecto
    '''

    Public ReadOnly Property id_suproyecto() As Integer
        Get
            _id_suproyecto = CInt(dr("id_subproyecto"))
            Return _id_suproyecto
        End Get
    End Property
    Private _id_suproyecto As Integer

    '''

    ''' Gets or Sets id_proyecto
    '''

    Public Property id_proyecto() As Integer
        Get
            _id_proyecto = CInt(dr("id_proyecto"))
            Return _id_proyecto
        End Get
        Set(value As Integer)
            dr("id_proyecto") = value
        End Set
    End Property
    Private _id_proyecto As Integer

    '''

    ''' Gets or Sets id_tipo_subproyecto
    '''

    Public Property id_tipo_subproyecto() As Integer
        Get
            _id_tipo_subproyecto = CInt(dr("id_tipo_subproyecto"))
            Return _id_tipo_subproyecto
        End Get
        Set(value As Integer)
            dr("id_tipo_subproyecto") = value
        End Set
    End Property
    Private _id_tipo_subproyecto As Integer

    '''

    ''' Gets or Sets id_subproyecto_padre
    '''

    Public Property id_subproyecto_padre() As Integer
        Get
            _id_subproyecto_padre = CInt(dr("id_subproyecto_padre"))
            Return _id_subproyecto_padre
        End Get
        Set(value As Integer)
            dr("id_subproyecto_padre") = value
        End Set
    End Property
    Private _id_subproyecto_padre As Integer

    '''

    ''' Gets or Sets nombre
    '''

    Public Property nombre() As String
        Get
            _nombre = CStr(dr("nombre"))
            Return _nombre
        End Get
        Set(value As String)
            dr("nombre") = value
        End Set
    End Property
    Private _nombre As String

    '''

    ''' Gets or Sets fecha_inicio_estimada
    '''

    Public Property fecha_inicio_estimada() As Date
        Get
            _fecha_inicio_estimada = CDate(dr("fecha_inicio_estimada"))
            Return _fecha_inicio_estimada
        End Get
        Set(value As Date)
            dr("fecha_inicio_estimada") = value
        End Set
    End Property
    Private _fecha_inicio_estimada As Date

    '''

    ''' Gets or Sets fecha_inicio_real
    '''

    Public Property fecha_inicio_real() As Date
        Get
            _fecha_inicio_real = CDate(dr("fecha_inicio_real"))
            Return _fecha_inicio_real
        End Get
        Set(value As Date)
            dr("fecha_inicio_real") = value
        End Set
    End Property
    Private _fecha_inicio_real As Date

    '''

    ''' Gets or Sets fecha_fin_estimada
    '''

    Public Property fecha_fin_estimada() As Date
        Get
            _fecha_fin_estimada = CDate(dr("fecha_fin_estimada"))
            Return _fecha_fin_estimada
        End Get
        Set(value As Date)
            dr("fecha_fin_estimada") = value
        End Set
    End Property
    Private _fecha_fin_estimada As Date

    '''

    ''' Gets or Sets fecha_fin_real
    '''

    Public Property fecha_fin_real() As Date
        Get
            _fecha_fin_real = CDate(dr("fecha_fin_real"))
            Return _fecha_fin_real
        End Get
        Set(value As Date)
            dr("fecha_fin_real") = value
        End Set
    End Property
    Private _fecha_fin_real As Date

    '''

    ''' Gets or Sets id_prioridad
    '''

    Public Property id_prioridad() As Integer
        Get
            _id_prioridad = CInt(dr("id_prioridad"))
            Return _id_prioridad
        End Get
        Set(value As Integer)
            dr("id_prioridad") = value
        End Set
    End Property
    Private _id_prioridad As Integer

    '''

    ''' Gets or Sets horas_estimadas
    '''

    Public Property horas_estimadas() As Integer
        Get
            _horas_estimadas = CInt(dr("horas_estimadas"))
            Return _horas_estimadas
        End Get
        Set(value As Integer)
            dr("horas_estimadas") = value
        End Set
    End Property
    Private _horas_estimadas As Integer

    '''

    ''' Gets or Sets id_estado_proyecto
    '''

    Public Property id_estado_proyecto() As Integer
        Get
            _id_estado_proyecto = CInt(dr("id_estado_proyecto"))
            Return _id_estado_proyecto
        End Get
        Set(value As Integer)
            dr("id_estado_proyecto") = value
        End Set
    End Property
    Private _id_estado_proyecto As Integer

    '''

    ''' Gets or Sets id_hora_tipo_subproyecto
    '''

    Public Property id_hora_tipo_subproyecto() As Integer
        Get
            _id_hora_tipo_subproyecto = CInt(dr("id_hora_tipo_subproyecto"))
            Return _id_hora_tipo_subproyecto
        End Get
        Set(value As Integer)
            dr("id_hora_tipo_subproyecto") = value
        End Set
    End Property
    Private _id_hora_tipo_subproyecto As Integer

    '''

    ''' Gets or Sets observaciones
    '''

    Public Property observaciones() As String
        Get
            _observaciones = CStr(dr("observaciones"))
            Return _observaciones
        End Get
        Set(value As String)
            dr("observaciones") = value
        End Set
    End Property
    Private _observaciones As String

    '''

    ''' Gets or Sets ot
    '''

    Public Property ot() As Integer
        Get
            _ot = CInt(dr("ot"))
            Return _ot
        End Get
        Set(value As Integer)
            dr("ot") = value
        End Set
    End Property
    Private _ot As Integer


    ''' Gets or Sets genera_ot
    '''
    Public Property genera_ot() As Boolean
        Get
            _genera_ot = CBool(dr("genera_ot"))
            Return _genera_ot
        End Get
        Set(value As Boolean)
            dr("genera_ot") = value
        End Set
    End Property
    Private _genera_ot As Boolean



    Public Property ot_cliente() As String
        Get
            _ot_cliente = CStr(dr("ot_cliente"))
            Return _ot_cliente
        End Get
        Set(value As String)
            dr("ot_cliente") = value
        End Set
    End Property
    Private _ot_cliente As String

    Public Property orden() As Integer
        Get
            _orden = CInt(dr("orden"))
            Return _orden
        End Get
        Set(value As Integer)
            dr("orden") = value
        End Set
    End Property
    Private _orden As Integer

    Public Property asignacion_automatica() As Boolean
        Get
            _asignacion_automatica = CBool(dr("asignacion_automatica"))
            Return _asignacion_automatica
        End Get
        Set(value As Boolean)
            dr("asignacion_automatica") = value
        End Set
    End Property
    Private _asignacion_automatica As Boolean



    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("SUBPROYECTO")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("usp_subproyectoInsert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 0, "id_proyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 6, "id_proyecto")
        da.InsertCommand.Parameters.Add("@id_tipo_subproyecto", SqlDbType.Int, 6, "id_tipo_subproyecto")
        da.InsertCommand.Parameters.Add("@id_subproyecto_padre", SqlDbType.Int, 6, "id_subproyecto_padre")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre")
        da.InsertCommand.Parameters.Add("@fecha_inicio_estimada", SqlDbType.DateTime, 8, "fecha_inicio_estimada")
        da.InsertCommand.Parameters.Add("@fecha_inicio_real", SqlDbType.DateTime, 8, "fecha_inicio_real")
        da.InsertCommand.Parameters.Add("@fecha_fin_estimada", SqlDbType.DateTime, 8, "fecha_fin_estimada")
        da.InsertCommand.Parameters.Add("@fecha_fin_real", SqlDbType.DateTime, 8, "fecha_fin_real")
        da.InsertCommand.Parameters.Add("@id_prioridad", SqlDbType.Int, 6, "id_prioridad")
        da.InsertCommand.Parameters.Add("@horas_estimadas", SqlDbType.Int, 6, "horas_estimadas")
        da.InsertCommand.Parameters.Add("@id_estado_proyecto", SqlDbType.Int, 6, "id_estado_proyecto")
        da.InsertCommand.Parameters.Add("@id_hora_tipo_subproyecto", SqlDbType.Int, 6, "id_hora_tipo_subproyecto")
        da.InsertCommand.Parameters.Add("@observaciones", SqlDbType.VarChar, 500, "observaciones")
        da.InsertCommand.Parameters.Add("@ot", SqlDbType.Int, 6, "ot")
        da.InsertCommand.Parameters.Add("@genera_ot", SqlDbType.Bit, 1, "genera_ot")
        da.InsertCommand.Parameters.Add("@ot_cliente", SqlDbType.VarChar, 100, "ot_cliente")
        da.InsertCommand.Parameters.Add("@orden", SqlDbType.Int, 6, "orden")
        da.InsertCommand.Parameters.Add("@asignacion_automatica", SqlDbType.Bit, 1, "asignacion_automatica")

        dr = dt.NewRow()
        dr("id_proyecto") = 0
        dr("id_tipo_subproyecto") = 0
        dr("id_subproyecto_padre") = 0
        dr("nombre") = 0
        dr("fecha_inicio_estimada") = DateTime.Now
        dr("fecha_inicio_real") = DateTime.Now
        dr("fecha_fin_estimada") = DateTime.Now
        dr("fecha_fin_real") = DateTime.Now
        dr("id_prioridad") = 0
        dr("horas_estimadas") = 0
        dr("id_estado_proyecto") = 0
        dr("id_hora_tipo_subproyecto") = 0
        dr("observaciones") = ""
        dr("ot") = 0
        dr("genera_ot") = 1
        dr("ot_cliente") = ""
        dr("orden") = 0
        dr("asignacion_automatica") = 0

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal id_subproyecto As Integer)
        dt = New DataTable("SUBPROYECTO")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM SUBPROYECTO WHERE id_subproyecto = @id_subproyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_subproyecto", id_subproyecto)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se ha encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        CrearComandoUpdate()
    End Sub

    Public Function ObtenerPorProyecto(ByVal id_proyecto As Integer, ByVal id_subproyecto_padre As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_subproyecto_getFromProyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 6, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_subproyecto_padre", SqlDbType.Int, 6, "id_subproyecto_padre")
        oda.SelectCommand.Parameters("@id_subproyecto_padre").Value = id_subproyecto_padre

        oda.Fill(odt)

        Return odt
    End Function

    Public Sub AgregarOT(ByVal id_subproyecto As Integer)
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_subproyecto_agregarOT", cnn.Coneccion)

        oda.InsertCommand = New SqlCommand("cop_subproyecto_agregarOT", cnn.Coneccion)
        oda.InsertCommand.CommandType = CommandType.StoredProcedure
        oda.InsertCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")
        oda.InsertCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        cnn.Abrir()
        oda.InsertCommand.ExecuteNonQuery()
        cnn.Cerrar()

    End Sub

    Public Function ObtenerOTPadre(ByVal id_subproyecto As Integer) As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerOTPadre", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        If odt.Rows.Count = 0 Then
            dt = New DataTable
            da = New SqlClient.SqlDataAdapter("SELECT ot.nro_orden_trabajo FROM ORDEN_TRABAJO ot, Proyecto p, Subproyecto s WHERE  s.id_subproyecto = @id_subproyecto and s.id_proyecto = p.id_proyecto and p.orden = ot.id_orden_trabajo", cnn.Coneccion)
            da.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")
            da.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Return 0
            Else
                Return CInt(dt.Rows(0).Item("nro_orden_trabajo"))
            End If
        Else
            Return CInt(odt.Rows(0).Item("ot"))
        End If

    End Function
    

    'procedimiento borrar
    Public Sub Borrar(ByVal id_subproyecto As Integer)
        dt = New DataTable("SUBPROYECTO")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM SUBPROYECTO WHERE id_subproyecto = " & _
        id_subproyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("usp_SUBPROYECTODelete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
            prm.Value = id_subproyecto
            cnn.Abrir()
            cmddel.ExecuteNonQuery()
            CrearComandoUpdate()
            Guardar()
            cnn.Cerrar()
        Catch ex As Exception
            If Err.Number = 5 Then
            End If
        End Try
    End Sub
    Public Function hayLogueos(ByVal id_subproyecto As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_subproyecto_hayHoras", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        If odt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'asigno el tipo de datos a los parametros
    Private Sub AsignarTipos()
        For Each dc As DataColumn In dt.Columns
            Select Case dc.ColumnName
                Case "id_subproyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_proyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_tipo_subproyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_subproyecto_padre"
                    dc.DataType = Type.GetType("System.Int32")
                Case "nombre"
                    dc.DataType = Type.GetType("System.String")
                Case "fecha_inicio_estimada"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "fecha_inicio_real"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "fecha_fin_estimada"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "fecha_fin_real"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "id_prioridad"
                    dc.DataType = Type.GetType("System.Int32")
                Case "horas_estimadas"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_estado_proyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_hora_tipo_subproyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "observaciones"
                    dc.DataType = Type.GetType("System.String")
                Case "ot"
                    dc.DataType = Type.GetType("System.Int32")
                Case "genera_ot"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "ot_cliente"
                    dc.DataType = Type.GetType("System.String")
                Case "orden"
                    dc.DataType = Type.GetType("System.Int32")
                Case "asignacion_automatica"
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
        dt = New DataTable("Subproyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Subproyecto WHERE id_subproyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    Public Function ObtenerNroOrdenTrabajo(ByVal id_subproyecto As Integer) As Integer
        dt = New DataTable("Subproyecto")
        da = New SqlClient.SqlDataAdapter("SELECT ot.nro_orden_trabajo FROM ORDEN_TRABAJO ot, Subproyecto s WHERE s.ot = ot.id_orden_trabajo and s.id_subproyecto = @id_subproyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")
        da.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            da = New SqlClient.SqlDataAdapter("SELECT ot.nro_orden_trabajo FROM ORDEN_TRABAJO ot, Proyecto p, Subproyecto s WHERE  s.id_subproyecto = @id_subproyecto and s.id_proyecto = p.id_proyecto and p.orden = ot.id_orden_trabajo", cnn.Coneccion)
            da.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")
            da.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Return 0
            End If
        End If

        Return CInt(dt.Rows(0).Item("nro_orden_trabajo"))
    End Function

    ''funcion de busqueda
    'Public Function Buscar(ByVal Nombre As String) As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Proyecto_Find", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
    '    oda.SelectCommand.Parameters("@nombre").Value = Nombre

    '    oda.Fill(odt)

    '    Return odt
    'End Function

    ''funcion de consulta
    'Public Function ConsultarTodo() As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Proyecto_GetAll", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.Fill(odt)

    '    Return odt
    'End Function

    ''funcion para llenar el combo
    'Public Function GetCmb() As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Proyecto_GetCmb", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.Fill(odt)

    '    Return odt
    'End Function

    ''funcion que trae un registro poniendo el id
    'Public Function GetOne(ByVal id_Proyecto As Integer) As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Proyecto_GetOne", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
    '    oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

    '    oda.Fill(odt)

    '    Return odt
    'End Function

    'controla si existe el registro en la base de datos
    'Public Function Exist() As Boolean
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Proyecto_Exist", cnn.Coneccion)
    '    Dim Total As Integer

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@descripcion", SqlDbType.VarChar, 500, "descripcion")
    '    oda.SelectCommand.Parameters("@descripcion").Value = Me.descripcion
    '    oda.SelectCommand.Parameters.Add("@nombre_proyecto", SqlDbType.VarChar, 500, "nombre_proyecto")
    '    oda.SelectCommand.Parameters("@nombre_proyecto").Value = Me.nombre_proyecto
    '    oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
    '    oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
    '    oda.SelectCommand.Parameters.Add("@id_proyecto_padre", SqlDbType.Int, 4, "id_proyecto_padre")
    '    oda.SelectCommand.Parameters("@id_proyecto_padre").Value = Me.id_proyecto_padre
    '    oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.Int, 4, "id_proyect_manager")
    '    oda.SelectCommand.Parameters("@id_proyect_manager").Value = Me.id_proyect_manager
    '    oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
    '    oda.SelectCommand.Parameters("@fecha_inicio").Value = Me.fecha_inicio
    '    oda.SelectCommand.Parameters.Add("@fecha_fin_prevista", SqlDbType.DateTime, 8, "fecha_fin_prevista")
    '    oda.SelectCommand.Parameters("@fecha_fin_prevista").Value = Me.fecha_fin_prevista
    '    oda.SelectCommand.Parameters.Add("@fecha_fin_real", SqlDbType.DateTime, 8, "fecha_fin_real")
    '    oda.SelectCommand.Parameters("@fecha_fin_real").Value = Me.fecha_fin_real
    '    oda.SelectCommand.Parameters.Add("@orden", SqlDbType.VarChar, 50, "orden")
    '    oda.SelectCommand.Parameters("@orden").Value = Me.orden
    '    oda.SelectCommand.Parameters.Add("@id_estado", SqlDbType.Int, 4, "id_estado")
    '    oda.SelectCommand.Parameters("@id_estado").Value = Me.id_estado
    '    oda.SelectCommand.Parameters.Add("@total_hora", SqlDbType.Decimal, 9, "total_hora")
    '    oda.SelectCommand.Parameters("@total_hora").Value = Me.total_hora
    '    oda.SelectCommand.Parameters.Add("@prioridad", SqlDbType.Decimal, 9, "prioridad")
    '    oda.SelectCommand.Parameters("@prioridad").Value = Me.prioridad
    '    oda.SelectCommand.Parameters.Add("@observacion", SqlDbType.VarChar, 500, "observacion")
    '    oda.SelectCommand.Parameters("@observacion").Value = Me.observacion
    '    oda.SelectCommand.Parameters.Add("@id_controlador_1", SqlDbType.Int, 4, "id_controlador_1")
    '    oda.SelectCommand.Parameters("@id_controlador_1").Value = Me.id_controlador_1
    '    oda.SelectCommand.Parameters.Add("@id_controlador_2", SqlDbType.Int, 4, "id_controlador_2")
    '    oda.SelectCommand.Parameters("@id_controlador_2").Value = Me.id_controlador_2
    '    oda.SelectCommand.Parameters.Add("@path", SqlDbType.VarChar, 5000, "path")
    '    oda.SelectCommand.Parameters("@path").Value = Me.path
    '    oda.SelectCommand.Parameters.Add("@archivado", SqlDbType.Bit, 1, "archivado")
    '    oda.SelectCommand.Parameters("@archivado").Value = Me.archivado
    '    oda.SelectCommand.Parameters.Add("@indice", SqlDbType.Int, 4, "indice")
    '    oda.SelectCommand.Parameters("@indice").Value = Me.indice
    '    oda.SelectCommand.Parameters.Add("@nro", SqlDbType.Int, 4, "nro")
    '    oda.SelectCommand.Parameters("@nro").Value = Me.nro
    '    oda.SelectCommand.Parameters.Add("@id_piloto", SqlDbType.Int, 4, "nro")
    '    oda.SelectCommand.Parameters("@id_piloto").Value = Me.id_piloto

    '    oda.Fill(odt)
    '    Total = CInt(odt.Rows(0).Item("Total").ToString)
    '    If Total = 0 Then
    '        Return False  'NO EXISTE
    '    Else
    '        Return True 'SI EXISTE
    '    End If
    'End Function

    'borra todos los datos de la tabla
    Public Sub BorrarTodo()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "DELETE FROM Subproyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Subproyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function ObtenerPorOT(ByVal ot_interna As String, ByVal ot_cliente As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerPorOT", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@ot_interna", SqlDbType.VarChar, 50, "ot_interna")
        oda.SelectCommand.Parameters("@ot_interna").Value = ot_interna
        oda.SelectCommand.Parameters.Add("@ot_cliente", SqlDbType.VarChar, 50, "ot_cliente")
        oda.SelectCommand.Parameters("@ot_cliente").Value = ot_cliente

        oda.Fill(odt)

        If odt.Rows.Count > 0 Then
            Return odt
        Else
            Return Nothing
        End If

    End Function

    Public Function ObtenerPadres(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerPadres", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        If odt.Rows.Count > 0 Then
            Return odt
        Else
            Return Nothing
        End If

    End Function

    Public Function ObtenerAvanceConcepto(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_proyecto_obtenerAvanceConcepto", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerAvanceConcepto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ObtenerActividadesControl(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerActividadesControles", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ObtenerProycetoYPath(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerProyectopath", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ObtenerHijos(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_subproyecto_obtenerHijos", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 6, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)

        Return odt
    End Function

End Class

