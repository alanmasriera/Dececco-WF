Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Proyecto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_proyecto As Int32
    Public ReadOnly Property id_proyecto() As Int32
        Get
            _id_proyecto = CInt(dr("id_proyecto"))
            Return _id_proyecto
        End Get
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
    end property

    Private _nombre_proyecto As String
    Public Property nombre_proyecto() As String
        Get
            _nombre_proyecto = CStr(dr("nombre_proyecto"))
            Return _nombre_proyecto
        End Get
        Set(ByVal Value As String)
            dr("nombre_proyecto") = Value
        End Set
    end property

    Private _id_cliente As Int32
    Public Property id_cliente() As Int32
        Get
            _id_cliente = CInt(dr("id_cliente"))
            Return _id_cliente
        End Get
        Set(ByVal Value As Int32)
            dr("id_cliente") = Value
        End Set
    end property

    Private _id_proyecto_padre As Int32
    Public Property id_proyecto_padre() As Int32
        Get
            _id_proyecto_padre = CInt(dr("id_proyecto_padre"))
            Return _id_proyecto_padre
        End Get
        Set(ByVal Value As Int32)
            dr("id_proyecto_padre") = Value
        End Set
    end property

    Private _id_proyect_manager As Int32
    Public Property id_proyect_manager() As Int32
        Get
            _id_proyect_manager = CInt(dr("id_proyect_manager"))
            Return _id_proyect_manager
        End Get
        Set(ByVal Value As Int32)
            dr("id_proyect_manager") = Value
        End Set
    end property

    Private _fecha_inicio As DateTime
    Public Property fecha_inicio() As DateTime
        Get
            _fecha_inicio = CDate(dr("fecha_inicio"))
            Return _fecha_inicio
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_inicio") = Value
        End Set
    end property

    Private _fecha_fin_prevista As DateTime
    Public Property fecha_fin_prevista() As DateTime
        Get
            _fecha_fin_prevista = CDate(dr("fecha_fin_prevista"))
            Return _fecha_fin_prevista
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_fin_prevista") = Value
        End Set
    end property

    Private _fecha_fin_real As DateTime
    Public Property fecha_fin_real() As DateTime
        Get
            _fecha_fin_real = CDate(dr("fecha_fin_real"))
            Return _fecha_fin_real
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_fin_real") = Value
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

    Private _id_estado As Int32
    Public Property id_estado() As Int32
        Get
            _id_estado = CInt(dr("id_estado"))
            Return _id_estado
        End Get
        Set(ByVal Value As Int32)
            dr("id_estado") = Value
        End Set
    end property

    Private _total_hora As Decimal
    Public Property total_hora() As Decimal
        Get
            _total_hora = CDec(dr("total_hora"))
            Return _total_hora
        End Get
        Set(ByVal Value As Decimal)
            dr("total_hora") = Value
        End Set
    end property

    Private _prioridad As Decimal
    Public Property prioridad() As Decimal
        Get
            _prioridad = CDec(dr("prioridad"))
            Return _prioridad
        End Get
        Set(ByVal Value As Decimal)
            dr("prioridad") = Value
        End Set
    end property

    Private _observacion As String
    Public Property observacion() As String
        Get
            _observacion = CStr(dr("observacion"))
            Return _observacion
        End Get
        Set(ByVal Value As String)
            dr("observacion") = Value
        End Set
    end property

    Private _id_controlador_1 As Int32
    Public Property id_controlador_1() As Int32
        Get
            _id_controlador_1 = CInt(dr("id_controlador_1"))
            Return _id_controlador_1
        End Get
        Set(ByVal Value As Int32)
            dr("id_controlador_1") = Value
        End Set
    end property

    Private _id_controlador_2 As Int32
    Public Property id_controlador_2() As Int32
        Get
            _id_controlador_2 = CInt(dr("id_controlador_2"))
            Return _id_controlador_2
        End Get
        Set(ByVal Value As Int32)
            dr("id_controlador_2") = Value
        End Set
    end property

    Private _path As String
    Public Property path() As String
        Get
            _path = CStr(dr("path"))
            Return _path
        End Get
        Set(ByVal Value As String)
            dr("path") = Value
        End Set
    end property

    Private _archivado As Boolean
    Public Property archivado() As Boolean
        Get
            _archivado = CBool(dr("archivado"))
            Return _archivado
        End Get
        Set(ByVal Value As Boolean)
            dr("archivado") = Value
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
    End Property

    Private _id_piloto As Int32
    Public Property id_piloto() As Int32
        Get
            _id_piloto = CInt(dr("id_piloto"))
            Return _id_piloto
        End Get
        Set(ByVal Value As Int32)
            dr("id_piloto") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Proyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Proyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 0, "id_proyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 500, "descripcion")
        da.InsertCommand.Parameters.Add("@nombre_proyecto", SqlDbType.varchar, 500, "nombre_proyecto")
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@id_proyecto_padre", SqlDbType.int, 4, "id_proyecto_padre")
        da.InsertCommand.Parameters.Add("@id_proyect_manager", SqlDbType.int, 4, "id_proyect_manager")
        da.InsertCommand.Parameters.Add("@fecha_inicio", SqlDbType.datetime, 8, "fecha_inicio")
        da.InsertCommand.Parameters.Add("@fecha_fin_prevista", SqlDbType.datetime, 8, "fecha_fin_prevista")
        da.InsertCommand.Parameters.Add("@fecha_fin_real", SqlDbType.datetime, 8, "fecha_fin_real")
        da.InsertCommand.Parameters.Add("@orden", SqlDbType.varchar, 50, "orden")
        da.InsertCommand.Parameters.Add("@id_estado", SqlDbType.int, 4, "id_estado")
        da.InsertCommand.Parameters.Add("@total_hora", SqlDbType.decimal, 9, "total_hora")
        da.InsertCommand.Parameters.Add("@prioridad", SqlDbType.decimal, 9, "prioridad")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.varchar, 500, "observacion")
        da.InsertCommand.Parameters.Add("@id_controlador_1", SqlDbType.int, 4, "id_controlador_1")
        da.InsertCommand.Parameters.Add("@id_controlador_2", SqlDbType.int, 4, "id_controlador_2")
        da.InsertCommand.Parameters.Add("@path", SqlDbType.varchar, 5000, "path")
        da.InsertCommand.Parameters.Add("@archivado", SqlDbType.bit, 1, "archivado")
        da.InsertCommand.Parameters.Add("@indice", SqlDbType.int, 4, "indice")
        da.InsertCommand.Parameters.Add("@nro", SqlDbType.Int, 4, "nro")
        da.InsertCommand.Parameters.Add("@id_piloto", SqlDbType.Int, 4, "id_piloto")

        dr = dt.NewRow()
        dr("descripcion") = ""
        dr("nombre_proyecto") = ""
        dr("id_cliente") = 0
        dr("id_proyecto_padre") = 0
        dr("id_proyect_manager") = 0
        dr("fecha_inicio") = DateTime.Now
        dr("fecha_fin_prevista") = DateTime.Now
        dr("fecha_fin_real") = DateTime.Now
        dr("orden") = ""
        dr("id_estado") = 0
        dr("total_hora") = 0
        dr("prioridad") = 0
        dr("observacion") = ""
        dr("id_controlador_1") = 0
        dr("id_controlador_2") = 0
        dr("path") = ""
        dr("archivado") = False
        dr("indice") = 0
        dr("nro") = 0
        dr("id_piloto") = 0

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idProyecto As Integer)
        dt = New DataTable("Proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Proyecto WHERE id_proyecto = @id_Proyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Proyecto", idProyecto)
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
    Public Sub Borrar(ByVal idProyecto As Integer)
        dt = New DataTable("Proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Proyecto WHERE id_proyecto = " & _
        idProyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Proyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
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
               Case "id_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "descripcion"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre_proyecto"
                  dc.DataType = Type.GetType("System.String")
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proyecto_padre"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proyect_manager"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_inicio"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_fin_prevista"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_fin_real"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "orden"
                  dc.DataType = Type.GetType("System.String")
               Case "id_estado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "total_hora"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "prioridad"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "observacion"
                  dc.DataType = Type.GetType("System.String")
               Case "id_controlador_1"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_controlador_2"
                  dc.DataType = Type.GetType("System.Int32")
               Case "path"
                  dc.DataType = Type.GetType("System.String")
               Case "archivado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "indice"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nro"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_piloto"
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
        dt = New DataTable("Proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Proyecto WHERE id_proyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    Public Function TieneLogueos(ByVal id_proyecto As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_proyecto_verificarLogueo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.Fill(odt)

        If odt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub BorrarConSubproyectoYActividad(ByVal idProyecto As Integer)
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_borrarConSubyAct", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = idProyecto
        oda.Fill(odt)


    End Sub

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 500, "descripcion")
        oda.SelectCommand.Parameters("@descripcion").Value = Me.descripcion
        oda.SelectCommand.Parameters.Add("@nombre_proyecto", SqlDbType.varchar, 500, "nombre_proyecto")
        oda.SelectCommand.Parameters("@nombre_proyecto").Value = Me.nombre_proyecto
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@id_proyecto_padre", SqlDbType.int, 4, "id_proyecto_padre")
        oda.SelectCommand.Parameters("@id_proyecto_padre").Value = Me.id_proyecto_padre
        oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.int, 4, "id_proyect_manager")
        oda.SelectCommand.Parameters("@id_proyect_manager").Value = Me.id_proyect_manager
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.datetime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = Me.fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin_prevista", SqlDbType.datetime, 8, "fecha_fin_prevista")
        oda.SelectCommand.Parameters("@fecha_fin_prevista").Value = Me.fecha_fin_prevista
        oda.SelectCommand.Parameters.Add("@fecha_fin_real", SqlDbType.datetime, 8, "fecha_fin_real")
        oda.SelectCommand.Parameters("@fecha_fin_real").Value = Me.fecha_fin_real
        oda.SelectCommand.Parameters.Add("@orden", SqlDbType.varchar, 50, "orden")
        oda.SelectCommand.Parameters("@orden").Value = Me.orden
        oda.SelectCommand.Parameters.Add("@id_estado", SqlDbType.int, 4, "id_estado")
        oda.SelectCommand.Parameters("@id_estado").Value = Me.id_estado
        oda.SelectCommand.Parameters.Add("@total_hora", SqlDbType.decimal, 9, "total_hora")
        oda.SelectCommand.Parameters("@total_hora").Value = Me.total_hora
        oda.SelectCommand.Parameters.Add("@prioridad", SqlDbType.decimal, 9, "prioridad")
        oda.SelectCommand.Parameters("@prioridad").Value = Me.prioridad
        oda.SelectCommand.Parameters.Add("@observacion", SqlDbType.varchar, 500, "observacion")
        oda.SelectCommand.Parameters("@observacion").Value = Me.observacion
        oda.SelectCommand.Parameters.Add("@id_controlador_1", SqlDbType.int, 4, "id_controlador_1")
        oda.SelectCommand.Parameters("@id_controlador_1").Value = Me.id_controlador_1
        oda.SelectCommand.Parameters.Add("@id_controlador_2", SqlDbType.int, 4, "id_controlador_2")
        oda.SelectCommand.Parameters("@id_controlador_2").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@path", SqlDbType.varchar, 5000, "path")
        oda.SelectCommand.Parameters("@path").Value = Me.path
        oda.SelectCommand.Parameters.Add("@archivado", SqlDbType.bit, 1, "archivado")
        oda.SelectCommand.Parameters("@archivado").Value = Me.archivado
        oda.SelectCommand.Parameters.Add("@indice", SqlDbType.int, 4, "indice")
        oda.SelectCommand.Parameters("@indice").Value = Me.indice
        oda.SelectCommand.Parameters.Add("@nro", SqlDbType.int, 4, "nro")
        oda.SelectCommand.Parameters("@nro").Value = Me.nro
        oda.SelectCommand.Parameters.Add("@id_piloto", SqlDbType.Int, 4, "nro")
        oda.SelectCommand.Parameters("@id_piloto").Value = Me.id_piloto


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
        Command.CommandText = "DELETE FROM Proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Proyecto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Proyecto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Proyecto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function



    Public Function GetAllSubproyectoSinHijos(id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable()
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetAllSubProyectoSinHijos", cnn.Coneccion())

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllDeSubproyectoAsignados(id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable()
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetAllSubProyectoSinHijosHorasRealesActuales", cnn.Coneccion())

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)
        Return odt
    End Function

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by NRefactory.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================

End Class
