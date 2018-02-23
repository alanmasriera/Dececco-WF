Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Actividad_proyecto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_actividad_proyecto As Int32
    Public ReadOnly Property id_actividad_proyecto() As Int32
        Get
            _id_actividad_proyecto = CInt(dr("id_actividad_proyecto"))
            Return _id_actividad_proyecto
        End Get
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
    End Property
    

    Private _id_actividad As Int32
    Public Property id_actividad() As Int32
        Get
            _id_actividad = CInt(dr("id_actividad"))
            Return _id_actividad
        End Get
        Set(ByVal Value As Int32)
            dr("id_actividad") = Value
        End Set
    End Property

    Private _fecha_inicio_real As DateTime
    Public Property fecha_inicio_real() As DateTime
        Get
            Try
                _fecha_inicio_real = CDate(dr("fecha_inicio_real"))
            Catch ex As Exception

            End Try
            Return _fecha_inicio_real
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_inicio_real") = Value
        End Set
    End Property


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

    Private _fecha_fin_previsto As DateTime
    Public Property fecha_fin_previsto() As DateTime
        Get
            _fecha_fin_previsto = CDate(dr("fecha_fin_previsto"))
            Return _fecha_fin_previsto
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_fin_previsto") = Value
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

    Private _cantidad_hora As Decimal
    Public Property cantidad_hora() As Decimal
        Get
            _cantidad_hora = CDec(dr("cantidad_hora"))
            Return _cantidad_hora
        End Get
        Set(ByVal Value As Decimal)
            dr("cantidad_hora") = Value
        End Set
    end property

    Private _objetivo As String
    Public Property objetivo() As String
        Get
            _objetivo = CStr(dr("objetivo"))
            Return _objetivo
        End Get
        Set(ByVal Value As String)
            dr("objetivo") = Value
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

    Private _complejidad As Decimal
    Public Property complejidad() As Decimal
        Get
            _complejidad = CDec(dr("complejidad"))
            Return _complejidad
        End Get
        Set(ByVal Value As Decimal)
            dr("complejidad") = Value
        End Set
    end property

    Private _avance As Decimal
    Public Property avance() As Decimal
        Get
            _avance = CDec(dr("avance"))
            Return _avance
        End Get
        Set(ByVal Value As Decimal)
            dr("avance") = Value
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

    Private _orden As Decimal
    Public Property orden() As Decimal
        Get
            _orden = CDec(dr("orden"))
            Return _orden
        End Get
        Set(ByVal Value As Decimal)
            dr("orden") = Value
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

    Private _id_cliente As Int32
    Public Property id_cliente() As Int32
        Get
            _id_cliente = CInt(dr("id_cliente"))
            Return _id_cliente
        End Get
        Set(ByVal Value As Int32)
            dr("id_cliente") = Value
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

    Private _horas As Int32
    Public Property horas() As Int32
        Get
            _horas = CInt(dr("horas"))
            Return _horas
        End Get
        Set(ByVal Value As Int32)
            dr("horas") = Value
        End Set
    End Property

    Private _id_estado_proyecto As Int32
    Public Property id_estado_proyecto() As Int32
        Get
            _id_estado_proyecto = CInt(dr("id_estado_proyecto"))
            Return _id_estado_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_estado_proyecto") = Value
        End Set
    End Property

    Private _porcentaje_avance As Decimal
    Public Property porcentaje_avance() As Decimal
        Get
            _porcentaje_avance = CDec(dr("porcentaje_avance"))
            Return _porcentaje_avance
        End Get
        Set(ByVal Value As Decimal)
            dr("porcentaje_avance") = Value
        End Set
    End Property

    Private _asignada As Boolean
    Public Property asignada() As Boolean
        Get
            _asignada = CBool(dr("asignada"))
            Return _asignada
        End Get
        Set(ByVal Value As Boolean)
            dr("asignada") = Value
        End Set
    End Property

    Private _id_control As Int32
    Public Property id_control() As Int32
        Get
            _id_control = CInt(dr("id_control"))
            Return _id_control
        End Get
        Set(ByVal Value As Int32)
            dr("id_control") = Value
        End Set
    End Property

    Private _id_proveedor As Int32
    Public Property id_proveedor() As Int32
        Get
            _id_proveedor = CInt(dr("id_proveedor"))
            Return _id_proveedor
        End Get
        Set(ByVal Value As Int32)
            dr("id_proveedor") = Value
        End Set
    End Property

    Private _forzada_fecha_inicio As Boolean
    Public Property forzada_fecha_inicio() As Boolean
        Get
            _forzada_fecha_inicio = CBool(dr("forzada_fecha_inicio"))
            Return _forzada_fecha_inicio
        End Get
        Set(ByVal Value As Boolean)
            dr("forzada_fecha_inicio") = Value
        End Set
    End Property

    Private _forzada_fecha_fin As Boolean
    Public Property forzada_fecha_fin() As Boolean
        Get
            _forzada_fecha_fin = CBool(dr("forzada_fecha_fin"))
            Return _forzada_fecha_fin
        End Get
        Set(ByVal Value As Boolean)
            dr("forzada_fecha_fin") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Actividad_proyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Actividad_proyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 0, "id_actividad_proyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")
        da.InsertCommand.Parameters.Add("@id_actividad", SqlDbType.int, 4, "id_actividad")
        da.InsertCommand.Parameters.Add("@fecha_inicio", SqlDbType.datetime, 8, "fecha_inicio")
        da.InsertCommand.Parameters.Add("@fecha_fin_previsto", SqlDbType.datetime, 8, "fecha_fin_previsto")
        da.InsertCommand.Parameters.Add("@fecha_fin_real", SqlDbType.datetime, 8, "fecha_fin_real")
        da.InsertCommand.Parameters.Add("@cantidad_hora", SqlDbType.decimal, 9, "cantidad_hora")
        da.InsertCommand.Parameters.Add("@objetivo", SqlDbType.varchar, 200, "objetivo")
        da.InsertCommand.Parameters.Add("@prioridad", SqlDbType.decimal, 9, "prioridad")
        da.InsertCommand.Parameters.Add("@complejidad", SqlDbType.decimal, 9, "complejidad")
        da.InsertCommand.Parameters.Add("@avance", SqlDbType.decimal, 9, "avance")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.varchar, 500, "observacion")
        da.InsertCommand.Parameters.Add("@orden", SqlDbType.decimal, 9, "orden")
        da.InsertCommand.Parameters.Add("@id_controlador_1", SqlDbType.int, 4, "id_controlador_1")
        da.InsertCommand.Parameters.Add("@id_controlador_2", SqlDbType.int, 4, "id_controlador_2")
        da.InsertCommand.Parameters.Add("@nro", SqlDbType.Int, 4, "nro")
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        da.InsertCommand.Parameters.Add("@horas", SqlDbType.Int, 4, "horas")
        da.InsertCommand.Parameters.Add("@id_estado_proyecto", SqlDbType.Int, 6, "id_estado_proyecto")
        da.InsertCommand.Parameters.Add("@porcentaje_avance", SqlDbType.Decimal, 6, "porcentaje_avance")
        da.InsertCommand.Parameters.Add("@fecha_inicio_real", SqlDbType.DateTime, 8, "fecha_inicio_real")
        da.InsertCommand.Parameters.Add("@asignada", SqlDbType.Bit, 4, "asignada")
        da.InsertCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        da.InsertCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        da.InsertCommand.Parameters.Add("@forzada_fecha_inicio", SqlDbType.Bit, 4, "forzada_fecha_inicio")
        da.InsertCommand.Parameters.Add("@forzada_fecha_fin", SqlDbType.Bit, 4, "forzada_fecha_fin")

        dr = dt.NewRow()
        dr("id_proyecto") = 0
        dr("id_actividad") = 0
        dr("fecha_inicio") = DateTime.Now
        dr("fecha_fin_previsto") = DateTime.Now
        dr("fecha_fin_real") = DateTime.Now
        dr("cantidad_hora") = 0
        dr("objetivo") = ""
        dr("prioridad") = 0
        dr("complejidad") = 0
        dr("avance") = 0
        dr("observacion") = ""
        dr("orden") = 0
        dr("id_controlador_1") = 0
        dr("id_controlador_2") = 0
        dr("nro") = 0
        dr("id_cliente") = 0
        dr("id_subproyecto") = 0
        dr("horas") = 0
        dr("id_estado_proyecto") = 0
        dr("porcentaje_avance") = 0D
        dr("fecha_inicio_real") = DateTime.Now
        dr("asignada") = 0
        dr("id_control") = 0
        dr("id_proveedor") = 0
        dr("forzada_fecha_inicio") = 0
        dr("forzada_fecha_fin") = 0

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idActividad_proyecto As Integer)
        dt = New DataTable("Actividad_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Actividad_proyecto WHERE id_actividad_proyecto = @id_Actividad_proyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Actividad_proyecto", idActividad_proyecto)
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
    Public Sub Borrar(ByVal idActividad_proyecto As Integer)
        dt = New DataTable("Actividad_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Actividad_proyecto WHERE id_actividad_proyecto = " & _
        idActividad_proyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Actividad_proyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
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
               Case "id_actividad_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_actividad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_inicio"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_fin_previsto"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_fin_real"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "cantidad_hora"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "objetivo"
                  dc.DataType = Type.GetType("System.String")
               Case "prioridad"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "complejidad"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "avance"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "observacion"
                  dc.DataType = Type.GetType("System.String")
               Case "orden"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_controlador_1"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_controlador_2"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nro"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_cliente"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_subproyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "horas"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_estado_proyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "porcentaje_avance"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "fecha_inicio_real"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "asignada"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "id_control"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_proveedor"
                    dc.DataType = Type.GetType("System.Int32")
                Case "forzada_fecha_inicio"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "forzada_fecha_fin"
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
        dt = New DataTable("Actividad_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Actividad_proyecto WHERE id_actividad_proyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_Actividad_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = Me.id_proyecto
        oda.SelectCommand.Parameters.Add("@id_actividad", SqlDbType.int, 4, "id_actividad")
        oda.SelectCommand.Parameters("@id_actividad").Value = Me.id_actividad
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.datetime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = Me.fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin_previsto", SqlDbType.datetime, 8, "fecha_fin_previsto")
        oda.SelectCommand.Parameters("@fecha_fin_previsto").Value = Me.fecha_fin_previsto
        oda.SelectCommand.Parameters.Add("@fecha_fin_real", SqlDbType.datetime, 8, "fecha_fin_real")
        oda.SelectCommand.Parameters("@fecha_fin_real").Value = Me.fecha_fin_real
        oda.SelectCommand.Parameters.Add("@cantidad_hora", SqlDbType.decimal, 9, "cantidad_hora")
        oda.SelectCommand.Parameters("@cantidad_hora").Value = Me.cantidad_hora
        oda.SelectCommand.Parameters.Add("@objetivo", SqlDbType.varchar, 200, "objetivo")
        oda.SelectCommand.Parameters("@objetivo").Value = Me.objetivo
        oda.SelectCommand.Parameters.Add("@prioridad", SqlDbType.decimal, 9, "prioridad")
        oda.SelectCommand.Parameters("@prioridad").Value = Me.prioridad
        oda.SelectCommand.Parameters.Add("@complejidad", SqlDbType.decimal, 9, "complejidad")
        oda.SelectCommand.Parameters("@complejidad").Value = Me.complejidad
        oda.SelectCommand.Parameters.Add("@avance", SqlDbType.decimal, 9, "avance")
        oda.SelectCommand.Parameters("@avance").Value = Me.avance
        oda.SelectCommand.Parameters.Add("@observacion", SqlDbType.varchar, 500, "observacion")
        oda.SelectCommand.Parameters("@observacion").Value = Me.observacion
        oda.SelectCommand.Parameters.Add("@orden", SqlDbType.decimal, 9, "orden")
        oda.SelectCommand.Parameters("@orden").Value = Me.orden
        oda.SelectCommand.Parameters.Add("@id_controlador_1", SqlDbType.int, 4, "id_controlador_1")
        oda.SelectCommand.Parameters("@id_controlador_1").Value = Me.id_controlador_1
        oda.SelectCommand.Parameters.Add("@id_controlador_2", SqlDbType.int, 4, "id_controlador_2")
        oda.SelectCommand.Parameters("@id_controlador_2").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@nro", SqlDbType.int, 4, "nro")
        oda.SelectCommand.Parameters("@nro").Value = Me.nro
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "nro")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.nro
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = Me.id_subproyecto
        oda.SelectCommand.Parameters.Add("@horas", SqlDbType.Int, 4, "horas")
        oda.SelectCommand.Parameters.Add("@id_estado_proyecto", SqlDbType.Int, 6, "id_estado_proyecto")
        oda.SelectCommand.Parameters.Add("@porcentaje_avance", SqlDbType.Decimal, 6, "porcentaje_avance")
        oda.SelectCommand.Parameters.Add("@fecha_inicio_real", SqlDbType.DateTime, 8, "fecha_inicio_real")
        oda.SelectCommand.Parameters.Add("@asignada", SqlDbType.Bit, 4, "asignada")
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")

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
        Command.CommandText = "DELETE FROM Actividad_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Actividad_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Actividad_proyecto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Actividad_proyecto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Actividad_proyecto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
