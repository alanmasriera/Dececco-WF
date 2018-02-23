Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_movimiento_hora_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cuerpo_movimiento_hora As Int32
    Public ReadOnly Property id_cuerpo_movimiento_hora() As Int32
        Get
            _id_cuerpo_movimiento_hora = CInt(dr("id_cuerpo_movimiento_hora"))
            Return _id_cuerpo_movimiento_hora
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

    Private _entrada As DateTime
    Public Property entrada() As DateTime
        Get
            _entrada = CDate(dr("entrada"))
            Return _entrada
        End Get
        Set(ByVal Value As DateTime)
            dr("entrada") = Value
        End Set
    end property

    Private _salida As DateTime
    Public Property salida() As DateTime
        Get
            _salida = CDate(dr("salida"))
            Return _salida
        End Get
        Set(ByVal Value As DateTime)
            dr("salida") = Value
        End Set
    end property

    Private _id_movimiento_hora As Int32
    Public Property id_movimiento_hora() As Int32
        Get
            _id_movimiento_hora = CInt(dr("id_movimiento_hora"))
            Return _id_movimiento_hora
        End Get
        Set(ByVal Value As Int32)
            dr("id_movimiento_hora") = Value
        End Set
    End Property

    Private _id_tipo_logueo As Int32
    Public Property id_tipo_logueo() As Int32
        Get
            _id_tipo_logueo = CInt(dr("id_tipo_logueo"))
            Return _id_tipo_logueo
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_logueo") = Value
        End Set
    End Property

    Private _id_detalle_recurso As Int32
    Public Property id_detalle_recurso() As Int32
        Get
            _id_detalle_recurso = CInt(dr("id_detalle_recurso"))
            Return _id_detalle_recurso
        End Get
        Set(ByVal Value As Int32)
            dr("id_detalle_recurso") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cuerpo_movimiento_hora")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cuerpo_movimiento_hora_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cuerpo_movimiento_hora", SqlDbType.int, 0, "id_cuerpo_movimiento_hora")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        da.InsertCommand.Parameters.Add("@entrada", SqlDbType.datetime, 8, "entrada")
        da.InsertCommand.Parameters.Add("@salida", SqlDbType.datetime, 8, "salida")
        da.InsertCommand.Parameters.Add("@id_movimiento_hora", SqlDbType.Int, 4, "id_movimiento_hora")
        da.InsertCommand.Parameters.Add("@id_tipo_logueo", SqlDbType.Int, 4, "id_tipo_logueo")
        da.InsertCommand.Parameters.Add("@id_detalle_recurso", SqlDbType.Int, 4, "id_detalle_Recurso")

        dr = dt.NewRow()
        dr("id_actividad_proyecto") = 0
        dr("entrada") = DateTime.Now
        dr("salida") = DateTime.Now
        dr("id_movimiento_hora") = 0
        dr("id_tipo_logueo") = 0
        dr("id_detalle_recurso") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCuerpo_movimiento_hora As Integer)
        dt = New DataTable("Cuerpo_movimiento_hora")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_movimiento_hora WHERE id_cuerpo_movimiento_hora = @id_Cuerpo_movimiento_hora", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cuerpo_movimiento_hora", idCuerpo_movimiento_hora)
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
    Public Sub Borrar(ByVal idCuerpo_movimiento_hora As Integer)
        dt = New DataTable("Cuerpo_movimiento_hora")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_movimiento_hora WHERE id_cuerpo_movimiento_hora = " & _
        idCuerpo_movimiento_hora, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cuerpo_movimiento_hora_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cuerpo_movimiento_hora", SqlDbType.Int, 4, "id_cuerpo_movimiento_hora")
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
               Case "id_cuerpo_movimiento_hora"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_actividad_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "entrada"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "salida"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_movimiento_hora"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_tipo_logueo"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_detalle_recurso"
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
        dt = New DataTable("Cuerpo_movimiento_hora")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_movimiento_hora WHERE id_cuerpo_movimiento_hora = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cuerpo_movimiento_hora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_movimiento_hora", SqlDbType.Int, 4, "id_cuerpo_movimiento_hora")
        oda.SelectCommand.Parameters("@id_cuerpo_movimiento_hora").Value = id_Cuerpo_movimiento_hora

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = Me.id_actividad_proyecto
        oda.SelectCommand.Parameters.Add("@entrada", SqlDbType.datetime, 8, "entrada")
        oda.SelectCommand.Parameters("@entrada").Value = Me.entrada
        oda.SelectCommand.Parameters.Add("@salida", SqlDbType.datetime, 8, "salida")
        oda.SelectCommand.Parameters("@salida").Value = Me.salida
        oda.SelectCommand.Parameters.Add("@id_movimiento_hora", SqlDbType.int, 4, "id_movimiento_hora")
        oda.SelectCommand.Parameters("@id_movimiento_hora").Value = Me.id_movimiento_hora
        oda.SelectCommand.Parameters.Add("@id_tipo_logueo", SqlDbType.Int, 4, "id_tipo_logueo")
        oda.SelectCommand.Parameters("@id_tipo_logueo").Value = Me.id_tipo_logueo
        oda.SelectCommand.Parameters.Add("@id_detalle_recurso", SqlDbType.Int, 4, "id_detalle_recurso")
        oda.SelectCommand.Parameters("@id_detalle_recurso").Value = Me.id_detalle_recurso

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
        Command.CommandText = "DELETE FROM Cuerpo_movimiento_hora"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cuerpo_movimiento_hora"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_movimiento_hora_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cuerpo_movimiento_hora")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cuerpo_movimiento_hora.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
