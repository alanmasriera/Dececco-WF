Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Detalle_recurso_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_detalle_recurso As Int32
    Public ReadOnly Property id_detalle_recurso() As Int32
        Get
            _id_detalle_recurso = CInt(dr("id_detalle_recurso"))
            Return _id_detalle_recurso
        End Get
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

    Private _porcentaje_avance As Decimal
    Public Property porcentaje_avance() As Decimal
        Get
            _porcentaje_avance = CDec(dr("porcentaje_avance"))
            Return _porcentaje_avance
        End Get
        Set(ByVal Value As Decimal)
            dr("porcentaje_avance") = Value
        End Set
    end property

    Private _motivo As String
    Public Property motivo() As String
        Get
            _motivo = CStr(dr("motivo"))
            Return _motivo
        End Get
        Set(ByVal Value As String)
            dr("motivo") = Value
        End Set
    end property

    Private _tipo As String
    Public Property tipo() As String
        Get
            _tipo = CStr(dr("tipo"))
            Return _tipo
        End Get
        Set(ByVal Value As String)
            dr("tipo") = Value
        End Set
    end property

    Private _realizada As Boolean
    Public Property realizada() As Boolean
        Get
            _realizada = CBool(dr("realizada"))
            Return _realizada
        End Get
        Set(ByVal Value As Boolean)
            dr("realizada") = Value
        End Set
    end property

    Private _forzada As Boolean
    Public Property forzada() As Boolean
        Get
            _forzada = CBool(dr("forzada"))
            Return _forzada
        End Get
        Set(ByVal Value As Boolean)
            dr("forzada") = Value
        End Set
    End Property

    Private _fecha_inicio As Date
    Public Property fecha_inicio() As Date
        Get
            _fecha_inicio = CDate(dr("fecha_inicio"))
            Return _fecha_inicio
        End Get
        Set(ByVal value As Date)
            dr("fecha_inicio") = value
        End Set
    End Property

    Private _fecha_fin As Date
    Public Property fecha_fin() As Date
        Get
            _fecha_fin = CDate(dr("fecha_fin"))
            Return _fecha_fin
        End Get
        Set(ByVal value As Date)
            dr("fecha_fin") = value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Detalle_recurso")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Detalle_recurso_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_detalle_recurso", SqlDbType.int, 0, "id_detalle_recurso")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@cantidad_hora", SqlDbType.decimal, 9, "cantidad_hora")
        da.InsertCommand.Parameters.Add("@porcentaje_avance", SqlDbType.decimal, 9, "porcentaje_avance")
        da.InsertCommand.Parameters.Add("@motivo", SqlDbType.varchar, 500, "motivo")
        da.InsertCommand.Parameters.Add("@tipo", SqlDbType.varchar, 50, "tipo")
        da.InsertCommand.Parameters.Add("@realizada", SqlDbType.Bit, 1, "realizada")
        da.InsertCommand.Parameters.Add("@forzada", SqlDbType.Bit, 1, "forzada")
        da.InsertCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        da.InsertCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")

        dr = dt.NewRow()
        dr("id_actividad_proyecto") = 0
        dr("id_usuario") = 0
        dr("cantidad_hora") = 0
        dr("porcentaje_avance") = 0
        dr("motivo") = ""
        dr("tipo") = ""
        dr("realizada") = 0
        dr("forzada") = 0
        dr("fecha_inicio") = Date.Today
        dr("fecha_fin") = Date.Today
        dr("id_estado") = 2

        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idDetalle_recurso As Integer)
        dt = New DataTable("Detalle_recurso")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Detalle_recurso WHERE id_detalle_recurso = @id_Detalle_recurso", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Detalle_recurso", idDetalle_recurso)
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
    Public Sub Borrar(ByVal idDetalle_recurso As Integer)
        dt = New DataTable("Detalle_recurso")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Detalle_recurso WHERE id_detalle_recurso = " & _
        idDetalle_recurso, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Detalle_recurso_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_detalle_recurso", SqlDbType.Int, 4, "id_detalle_recurso")
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
               Case "id_detalle_recurso"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_actividad_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "cantidad_hora"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "porcentaje_avance"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "motivo"
                  dc.DataType = Type.GetType("System.String")
               Case "tipo"
                  dc.DataType = Type.GetType("System.String")
               Case "realizada"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "forzada"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "fecha_inicio"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "fecha_fin"
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
        dt = New DataTable("Detalle_recurso")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Detalle_recurso WHERE id_detalle_recurso = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Detalle_recurso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_detalle_recurso", SqlDbType.Int, 4, "id_detalle_recurso")
        oda.SelectCommand.Parameters("@id_detalle_recurso").Value = id_Detalle_recurso

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = Me.id_actividad_proyecto
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@cantidad_hora", SqlDbType.decimal, 9, "cantidad_hora")
        oda.SelectCommand.Parameters("@cantidad_hora").Value = Me.cantidad_hora
        oda.SelectCommand.Parameters.Add("@porcentaje_avance", SqlDbType.decimal, 9, "porcentaje_avance")
        oda.SelectCommand.Parameters("@porcentaje_avance").Value = Me.porcentaje_avance
        oda.SelectCommand.Parameters.Add("@motivo", SqlDbType.varchar, 500, "motivo")
        oda.SelectCommand.Parameters("@motivo").Value = Me.motivo
        oda.SelectCommand.Parameters.Add("@tipo", SqlDbType.varchar, 50, "tipo")
        oda.SelectCommand.Parameters("@tipo").Value = Me.tipo
        oda.SelectCommand.Parameters.Add("@realizada", SqlDbType.bit, 1, "realizada")
        oda.SelectCommand.Parameters("@realizada").Value = Me.realizada
        oda.SelectCommand.Parameters.Add("@forzada", SqlDbType.Bit, 1, "forzada")
        oda.SelectCommand.Parameters("@forzada").Value = Me.forzada

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
        Command.CommandText = "DELETE FROM Detalle_recurso"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Detalle_recurso"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Detalle_recurso_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Detalle_recurso")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Detalle_recurso.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
