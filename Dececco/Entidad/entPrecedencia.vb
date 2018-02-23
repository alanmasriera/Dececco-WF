Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Precedencia_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_precedencia As Int32
    Public ReadOnly Property id_precedencia() As Int32
        Get
            _id_precedencia = CInt(dr("id_precedencia"))
            Return _id_precedencia
        End Get
    end property

    Private _nombre_precedencia As String
    Public Property nombre_precedencia() As String
        Get
            _nombre_precedencia = CStr(dr("nombre_precedencia"))
            Return _nombre_precedencia
        End Get
        Set(ByVal Value As String)
            dr("nombre_precedencia") = Value
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

    Private _id_actividad_proyecto_precedente As Int32
    Public Property id_actividad_proyecto_precedente() As Int32
        Get
            _id_actividad_proyecto_precedente = CInt(dr("id_actividad_proyecto_precedente"))
            Return _id_actividad_proyecto_precedente
        End Get
        Set(ByVal Value As Int32)
            dr("id_actividad_proyecto_precedente") = Value
        End Set
    end property

    Private _fecha_precedencia As DateTime
    Public Property fecha_precedencia() As DateTime
        Get
            _fecha_precedencia = CDate(dr("fecha_precedencia"))
            Return _fecha_precedencia
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_precedencia") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Precedencia")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Precedencia_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_precedencia", SqlDbType.int, 0, "id_precedencia")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_precedencia", SqlDbType.varchar, 50, "nombre_precedencia")
        da.InsertCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        da.InsertCommand.Parameters.Add("@id_actividad_proyecto_precedente", SqlDbType.int, 4, "id_actividad_proyecto_precedente")
        da.InsertCommand.Parameters.Add("@fecha_precedencia", SqlDbType.datetime, 8, "fecha_precedencia")
        da.InsertCommand.Parameters.Add("@cantidad_hora", SqlDbType.decimal, 9, "cantidad_hora")
        da.InsertCommand.Parameters.Add("@avance", SqlDbType.decimal, 9, "avance")

        dr = dt.NewRow()
        dr("nombre_precedencia") = ""
        dr("id_actividad_proyecto") = 0
        dr("id_actividad_proyecto_precedente") = 0
        dr("fecha_precedencia") = DateTime.Now
        dr("cantidad_hora") = 0
        dr("avance") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idPrecedencia As Integer)
        dt = New DataTable("Precedencia")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Precedencia WHERE id_precedencia = @id_Precedencia", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Precedencia", idPrecedencia)
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
    Public Sub Borrar(ByVal idPrecedencia As Integer)
        dt = New DataTable("Precedencia")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Precedencia WHERE id_precedencia = " & _
        idPrecedencia, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Precedencia_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_precedencia", SqlDbType.Int, 4, "id_precedencia")
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
               Case "id_precedencia"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_precedencia"
                  dc.DataType = Type.GetType("System.String")
               Case "id_actividad_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_actividad_proyecto_precedente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_precedencia"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "cantidad_hora"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "avance"
                  dc.DataType = Type.GetType("System.Decimal")
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
        dt = New DataTable("Precedencia")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Precedencia WHERE id_precedencia = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precedencia_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precedencia_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precedencia_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Precedencia As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precedencia_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_precedencia", SqlDbType.Int, 4, "id_precedencia")
        oda.SelectCommand.Parameters("@id_precedencia").Value = id_Precedencia

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precedencia_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_precedencia", SqlDbType.varchar, 50, "nombre_precedencia")
        oda.SelectCommand.Parameters("@nombre_precedencia").Value = Me.nombre_precedencia
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = Me.id_actividad_proyecto
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto_precedente", SqlDbType.int, 4, "id_actividad_proyecto_precedente")
        oda.SelectCommand.Parameters("@id_actividad_proyecto_precedente").Value = Me.id_actividad_proyecto_precedente
        oda.SelectCommand.Parameters.Add("@fecha_precedencia", SqlDbType.datetime, 8, "fecha_precedencia")
        oda.SelectCommand.Parameters("@fecha_precedencia").Value = Me.fecha_precedencia
        oda.SelectCommand.Parameters.Add("@cantidad_hora", SqlDbType.decimal, 9, "cantidad_hora")
        oda.SelectCommand.Parameters("@cantidad_hora").Value = Me.cantidad_hora
        oda.SelectCommand.Parameters.Add("@avance", SqlDbType.decimal, 9, "avance")
        oda.SelectCommand.Parameters("@avance").Value = Me.avance

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
        Command.CommandText = "DELETE FROM Precedencia"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Precedencia"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Precedencia_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Precedencia")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Precedencia.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
