Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Orden_compra_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_orden_compra As Int32
    Public ReadOnly Property id_orden_compra() As Int32
        Get
            _id_orden_compra = CInt(dr("id_orden_compra"))
            Return _id_orden_compra
        End Get
    end property

    Private _fecha_orden_compra As DateTime
    Public Property fecha_orden_compra() As DateTime
        Get
            _fecha_orden_compra = CDate(dr("fecha_orden_compra"))
            Return _fecha_orden_compra
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_orden_compra") = Value
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

    Private _acepto_orden_compra As String
    Public Property acepto_orden_compra() As String
        Get
            _acepto_orden_compra = CStr(dr("acepto_orden_compra"))
            Return _acepto_orden_compra
        End Get
        Set(ByVal Value As String)
            dr("acepto_orden_compra") = Value
        End Set
    end property

    Private _total_orden_compra As Decimal
    Public Property total_orden_compra() As Decimal
        Get
            _total_orden_compra = CDec(dr("total_orden_compra"))
            Return _total_orden_compra
        End Get
        Set(ByVal Value As Decimal)
            dr("total_orden_compra") = Value
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

    Private _id_presupuesto As Int32
    Public Property id_presupuesto() As Int32
        Get
            _id_presupuesto = CInt(dr("id_presupuesto"))
            Return _id_presupuesto
        End Get
        Set(ByVal Value As Int32)
            dr("id_presupuesto") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Orden_compra")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Orden_compra_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_orden_compra", SqlDbType.int, 0, "id_orden_compra")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha_orden_compra", SqlDbType.datetime, 8, "fecha_orden_compra")
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.varchar, 5000, "observacion")
        da.InsertCommand.Parameters.Add("@acepto_orden_compra", SqlDbType.varchar, 50, "acepto_orden_compra")
        da.InsertCommand.Parameters.Add("@total_orden_compra", SqlDbType.decimal, 9, "total_orden_compra")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@id_presupuesto", SqlDbType.int, 4, "id_presupuesto")

        dr = dt.NewRow()
        dr("fecha_orden_compra") = DateTime.Now
        dr("id_cliente") = 0
        dr("observacion") = ""
        dr("acepto_orden_compra") = ""
        dr("total_orden_compra") = 0
        dr("id_usuario") = 0
        dr("id_presupuesto") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idOrden_compra As Integer)
        dt = New DataTable("Orden_compra")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Orden_compra WHERE id_orden_compra = @id_Orden_compra", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Orden_compra", idOrden_compra)
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
    Public Sub Borrar(ByVal idOrden_compra As Integer)
        dt = New DataTable("Orden_compra")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Orden_compra WHERE id_orden_compra = " & _
        idOrden_compra, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Orden_compra_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_orden_compra", SqlDbType.Int, 4, "id_orden_compra")
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
               Case "id_orden_compra"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_orden_compra"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "observacion"
                  dc.DataType = Type.GetType("System.String")
               Case "acepto_orden_compra"
                  dc.DataType = Type.GetType("System.String")
               Case "total_orden_compra"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_presupuesto"
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
        dt = New DataTable("Orden_compra")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Orden_compra WHERE id_orden_compra = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Orden_compra_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Orden_compra_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Orden_compra_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Orden_compra As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Orden_compra_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_orden_compra", SqlDbType.Int, 4, "id_orden_compra")
        oda.SelectCommand.Parameters("@id_orden_compra").Value = id_Orden_compra

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Orden_compra_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_orden_compra", SqlDbType.datetime, 8, "fecha_orden_compra")
        oda.SelectCommand.Parameters("@fecha_orden_compra").Value = Me.fecha_orden_compra
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@observacion", SqlDbType.varchar, 5000, "observacion")
        oda.SelectCommand.Parameters("@observacion").Value = Me.observacion
        oda.SelectCommand.Parameters.Add("@acepto_orden_compra", SqlDbType.varchar, 50, "acepto_orden_compra")
        oda.SelectCommand.Parameters("@acepto_orden_compra").Value = Me.acepto_orden_compra
        oda.SelectCommand.Parameters.Add("@total_orden_compra", SqlDbType.decimal, 9, "total_orden_compra")
        oda.SelectCommand.Parameters("@total_orden_compra").Value = Me.total_orden_compra
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@id_presupuesto", SqlDbType.int, 4, "id_presupuesto")
        oda.SelectCommand.Parameters("@id_presupuesto").Value = Me.id_presupuesto

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
        Command.CommandText = "DELETE FROM Orden_compra"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Orden_compra"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Orden_compra_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Orden_compra")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Orden_compra.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
