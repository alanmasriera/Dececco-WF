Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Movimiento_voz_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_movimiento_voz As Int32
    Public ReadOnly Property id_movimiento_voz() As Int32
        Get
            _id_movimiento_voz = CInt(dr("id_movimiento_voz"))
            Return _id_movimiento_voz
        End Get
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

    Private _fecha As DateTime
    Public Property fecha() As DateTime
        Get
            _fecha = CDate(dr("fecha"))
            Return _fecha
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha") = Value
        End Set
    end property

    Private _ot As String
    Public Property ot() As String
        Get
            _ot = CStr(dr("ot"))
            Return _ot
        End Get
        Set(ByVal Value As String)
            dr("ot") = Value
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

    Private _id_cadista As Int32
    Public Property id_cadista() As Int32
        Get
            _id_cadista = CInt(dr("id_cadista"))
            Return _id_cadista
        End Get
        Set(ByVal Value As Int32)
            dr("id_cadista") = Value
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

    Private _completado As Boolean
    Public Property completado() As Boolean
        Get
            _completado = CBool(dr("completado"))
            Return _completado
        End Get
        Set(ByVal Value As Boolean)
            dr("completado") = Value
        End Set
    end property

    Private _id_usuario_anterior As Int32
    Public Property id_usuario_anterior() As Int32
        Get
            _id_usuario_anterior = CInt(dr("id_usuario_anterior"))
            Return _id_usuario_anterior
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_anterior") = Value
        End Set
    End Property

    Private _id_controlador_asignado As Integer
    Public Property id_controlador_asignado() As Integer
        Get
            id_controlador_asignado = CInt(dr("id_controlador_asignado"))
            Return id_controlador_asignado
        End Get
        Set(ByVal Value As Integer)
            dr("id_controlador_asignado") = Value
        End Set
    End Property

    Private _pedido_segundo_control As Boolean
    Public Property pedido_segundo_control() As Boolean
        Get
            pedido_segundo_control = CBool(dr("pedido_segundo_control"))
            Return pedido_segundo_control
        End Get
        Set(ByVal Value As Boolean)
            dr("pedido_segundo_control") = Value
        End Set
    End Property

    Private _control_prod As Boolean
    Public Property control_prod() As Boolean
        Get
            control_prod = CBool(dr("control_prod"))
            Return control_prod
        End Get
        Set(ByVal Value As Boolean)
            dr("control_prod") = Value
        End Set
    End Property

    Private _control_1 As Boolean
    Public Property control_1() As Boolean
        Get
            control_1 = CBool(dr("control_1"))
            Return control_1
        End Get
        Set(ByVal Value As Boolean)
            dr("control_1") = Value
        End Set
    End Property

    Private _control_corr_1 As Boolean
    Public Property control_corr_1() As Boolean
        Get
            control_corr_1 = CBool(dr("control_corr_1"))
            Return control_corr_1
        End Get
        Set(ByVal Value As Boolean)
            dr("control_corr_1") = Value
        End Set
    End Property

    Private _control_prod_2 As Boolean
    Public Property control_prod_2() As Boolean
        Get
            control_prod_2 = CBool(dr("control_prod_2"))
            Return control_prod_2
        End Get
        Set(ByVal Value As Boolean)
            dr("control_prod_2") = Value
        End Set
    End Property

    Private _control_2 As Boolean
    Public Property control_2() As Boolean
        Get
            control_2 = CBool(dr("control_2"))
            Return control_2
        End Get
        Set(ByVal Value As Boolean)
            dr("control_2") = Value
        End Set
    End Property

    Private _control_corr_2 As Boolean
    Public Property control_corr_2() As Boolean
        Get
            control_corr_2 = CBool(dr("control_corr_2"))
            Return control_corr_2
        End Get
        Set(ByVal Value As Boolean)
            dr("control_corr_2") = Value
        End Set
    End Property

    Private _id_usuario_1 As Int32
    Public Property id_usuario_1() As Int32
        Get
            _id_usuario_1 = CInt(dr("id_usuario_1"))
            Return _id_usuario_1
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_1") = Value
        End Set
    End Property

    Private _id_usuario_2 As Int32
    Public Property id_usuario_2() As Int32
        Get
            _id_usuario_anterior = CInt(dr("id_usuario_2"))
            Return _id_usuario_2
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_2") = Value
        End Set
    End Property

    Private _id_usuario_3 As Int32
    Public Property id_usuario_3() As Int32
        Get
            _id_usuario_3 = CInt(dr("id_usuario_3"))
            Return _id_usuario_3
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_3") = Value
        End Set
    End Property

    Private _id_usuario_4 As Int32
    Public Property id_usuario_4() As Int32
        Get
            _id_usuario_4 = CInt(dr("id_usuario_4"))
            Return _id_usuario_4
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_4") = Value
        End Set
    End Property

    Private _id_usuario_5 As Int32
    Public Property id_usuario_5() As Int32
        Get
            _id_usuario_5 = CInt(dr("id_usuario_5"))
            Return _id_usuario_5
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_5") = Value
        End Set
    End Property

    Private _id_usuario_6 As Int32
    Public Property id_usuario_6() As Int32
        Get
            _id_usuario_6 = CInt(dr("id_usuario_6"))
            Return _id_usuario_6
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_6") = Value
        End Set

    End Property

    Private _anulado As Boolean
    Public Property anulado() As Boolean
        Get
            _anulado = CBool(dr("anulado"))
            Return _anulado
        End Get
        Set(ByVal Value As Boolean)
            dr("anulado") = Value
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
    End Property

    Private _fecha_completado As DateTime
    Public Property fecha_completado() As DateTime
        Get
            _fecha_completado = CDate(dr("fecha_completado"))
            Return _fecha_completado
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_completado") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Movimiento_voz")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Movimiento_voz_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.int, 0, "id_movimiento_voz")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_control", SqlDbType.int, 4, "id_control")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@ot", SqlDbType.varchar, 50, "ot")
        da.InsertCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        da.InsertCommand.Parameters.Add("@id_cadista", SqlDbType.int, 4, "id_cadista")
        da.InsertCommand.Parameters.Add("@id_proyect_manager", SqlDbType.int, 4, "id_proyect_manager")
        da.InsertCommand.Parameters.Add("@id_controlador_1", SqlDbType.int, 4, "id_controlador_1")
        da.InsertCommand.Parameters.Add("@id_controlador_2", SqlDbType.int, 4, "id_controlador_2")
        da.InsertCommand.Parameters.Add("@completado", SqlDbType.bit, 1, "completado")
        da.InsertCommand.Parameters.Add("@id_usuario_anterior", SqlDbType.int, 4, "id_usuario_anterior")
        da.InsertCommand.Parameters.Add("@id_controlador_asignado", SqlDbType.Int, 4, "id_controlador_asignado")
        da.InsertCommand.Parameters.Add("@pedido_segundo_control", SqlDbType.Bit, 1, "pedido_segundo_control")
        da.InsertCommand.Parameters.Add("@control_prod", SqlDbType.Bit, 1, "control_prod")
        da.InsertCommand.Parameters.Add("@control_1", SqlDbType.Bit, 1, "control_1")
        da.InsertCommand.Parameters.Add("@control_corr_1", SqlDbType.Bit, 1, "control_corr_1")
        da.InsertCommand.Parameters.Add("@control_prod_2", SqlDbType.Bit, 1, "control_prod_2")
        da.InsertCommand.Parameters.Add("@control_2", SqlDbType.Bit, 1, "control_2")
        da.InsertCommand.Parameters.Add("@control_corr_2", SqlDbType.Bit, 1, "control_corr_2")
        da.InsertCommand.Parameters.Add("@id_usuario_1", SqlDbType.Int, 4, "id_usuario_1")
        da.InsertCommand.Parameters.Add("@id_usuario_2", SqlDbType.Int, 4, "id_usuario_2")
        da.InsertCommand.Parameters.Add("@id_usuario_3", SqlDbType.Int, 4, "id_usuario_3")
        da.InsertCommand.Parameters.Add("@id_usuario_4", SqlDbType.Int, 4, "id_usuario_4")
        da.InsertCommand.Parameters.Add("@id_usuario_5", SqlDbType.Int, 4, "id_usuario_5")
        da.InsertCommand.Parameters.Add("@id_usuario_6", SqlDbType.Int, 4, "id_usuario_6")
        da.InsertCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        da.InsertCommand.Parameters.Add("@fecha_completado", SqlDbType.DateTime, 8, "fecha_completado")
        da.InsertCommand.Parameters.Add("@anulado", SqlDbType.Bit, 1, "anulado")

        dr = dt.NewRow()
        dr("id_control") = 0
        dr("fecha") = DateTime.Now
        dr("ot") = ""
        dr("id_actividad_proyecto") = 0
        dr("id_cadista") = 0
        dr("id_proyect_manager") = 0
        dr("id_controlador_1") = 0
        dr("id_controlador_2") = 0
        dr("completado") = False
        dr("id_usuario_anterior") = 0
        dr("id_controlador_asignado") = 0
        dr("pedido_segundo_control") = False
        dr("control_prod") = False
        dr("control_1") = False
        dr("control_corr_1") = False
        dr("control_prod_2") = False
        dr("control_2") = False
        dr("control_corr_2") = False
        dr("id_usuario_1") = 0
        dr("id_usuario_2") = 0
        dr("id_usuario_3") = 0
        dr("id_usuario_4") = 0
        dr("id_usuario_5") = 0
        dr("id_usuario_6") = 0
        dr("anulado") = False
        dr("fecha_inicio") = DateTime.Now
        dr("fecha_completado") = DateTime.Now

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idMovimiento_voz As Integer)
        dt = New DataTable("Movimiento_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Movimiento_voz WHERE id_movimiento_voz = @id_Movimiento_voz", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Movimiento_voz", idMovimiento_voz)
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
    Public Sub Borrar(ByVal idMovimiento_voz As Integer)
        dt = New DataTable("Movimiento_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Movimiento_voz WHERE id_movimiento_voz = " & _
        idMovimiento_voz, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Movimiento_voz_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
            dt.Rows(0).Delete()
            CrearComandoUpdate()
            Guardar()
        Catch ex As Exception
            If Err.Number = 5 Then
            End If
        End Try
    End Sub

    Public Sub BorrarConControlesRealizados(ByVal id_movimiento_voz As Integer)

        'Dim oda As New SqlDataAdapter("cop_Movimiento_voz_DeleteAll", cnn.Coneccion)
        Dim ra As Integer

        Dim cmd As New SqlCommand("cop_Movimiento_voz_DeleteAll", cnn.Coneccion)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4)
        cmd.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        cnn.Abrir()
        ra = cmd.ExecuteNonQuery()
        cnn.Cerrar()

    End Sub

    'asigno el tipo de datos a los parametros
    Private Sub AsignarTipos()
        For Each dc As DataColumn In dt.Columns
            Select Case dc.ColumnName
               Case "id_movimiento_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_control"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "ot"
                  dc.DataType = Type.GetType("System.String")
               Case "id_actividad_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cadista"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proyect_manager"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_controlador_1"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_controlador_2"
                  dc.DataType = Type.GetType("System.Int32")
               Case "completado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_usuario_anterior"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_controlador_asignado"
                    dc.DataType = Type.GetType("System.Int32")
                Case "pedido_segundo_control"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "control_prod"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "control_1"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "control_corr_1"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "control_prod_2"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "control_2"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "control_corr_2"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "id_usuario_1"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_usuario_2"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_usuario_3"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_usuario_4"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_usuario_5r"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_usuario_6"
                    dc.DataType = Type.GetType("System.Int32")
                Case "anulado"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "fecha_inicio"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "fecha_completado"
                    dc.DataType = Type.GetType("System.DateTime")

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
        dt = New DataTable("Movimiento_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Movimiento_voz WHERE id_movimiento_voz = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_Movimiento_voz

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = Me.id_control
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@ot", SqlDbType.varchar, 50, "ot")
        oda.SelectCommand.Parameters("@ot").Value = Me.ot
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = Me.id_actividad_proyecto
        oda.SelectCommand.Parameters.Add("@id_cadista", SqlDbType.int, 4, "id_cadista")
        oda.SelectCommand.Parameters("@id_cadista").Value = Me.id_cadista
        oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.int, 4, "id_proyect_manager")
        oda.SelectCommand.Parameters("@id_proyect_manager").Value = Me.id_proyect_manager
        oda.SelectCommand.Parameters.Add("@id_controlador_1", SqlDbType.int, 4, "id_controlador_1")
        oda.SelectCommand.Parameters("@id_controlador_1").Value = Me.id_controlador_1
        oda.SelectCommand.Parameters.Add("@id_controlador_2", SqlDbType.int, 4, "id_controlador_2")
        oda.SelectCommand.Parameters("@id_controlador_2").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@completado", SqlDbType.bit, 1, "completado")
        oda.SelectCommand.Parameters("@completado").Value = Me.completado
        oda.SelectCommand.Parameters.Add("@id_usuario_anterior", SqlDbType.int, 4, "id_usuario_anterior")
        oda.SelectCommand.Parameters("@id_usuario_anterior").Value = Me.id_usuario_anterior
        oda.SelectCommand.Parameters.Add("@id_controlador_asignado", SqlDbType.Int, 4, "id_controlador_asignado")
        oda.SelectCommand.Parameters("@id_controlador_asignado").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@id_controlador_2", SqlDbType.Bit, 1, "id_controlador_2")
        oda.SelectCommand.Parameters("@id_controlador_2").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@control_prod", SqlDbType.Bit, 1, "control_prod")
        oda.SelectCommand.Parameters("@control_prod").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@control_1", SqlDbType.Bit, 1, "control_1")
        oda.SelectCommand.Parameters("@control_1").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@control_corr_1", SqlDbType.Bit, 1, "control_corr_1")
        oda.SelectCommand.Parameters("@control_corr_1").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@control_prod_2", SqlDbType.Bit, 1, "control_prod_2")
        oda.SelectCommand.Parameters("@control_prod_2").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@control_2", SqlDbType.Bit, 1, "control_2")
        oda.SelectCommand.Parameters("@control_2").Value = Me.id_controlador_2
        oda.SelectCommand.Parameters.Add("@control_corr_2", SqlDbType.Bit, 1, "control_corr_2")
        oda.SelectCommand.Parameters("@control_corr_2").Value = Me.id_controlador_2

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
        Command.CommandText = "DELETE FROM Movimiento_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Movimiento_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Movimiento_voz_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Movimiento_voz")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Movimiento_voz.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
