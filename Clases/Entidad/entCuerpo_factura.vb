Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_factura_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cuerpo_factura As Int32
    Public ReadOnly Property id_cuerpo_factura() As Int32
        Get
            _id_cuerpo_factura = CInt(dr("id_cuerpo_factura"))
            Return _id_cuerpo_factura
        End Get
    end property

    Private _id_factura As Int32
    Public Property id_factura() As Int32
        Get
            _id_factura = CInt(dr("id_factura"))
            Return _id_factura
        End Get
        Set(ByVal Value As Int32)
            dr("id_factura") = Value
        End Set
    end property

    Private _id_item As Int32
    Public Property id_item() As Int32
        Get
            _id_item = CInt(dr("id_item"))
            Return _id_item
        End Get
        Set(ByVal Value As Int32)
            dr("id_item") = Value
        End Set
    end property

    Private _cantidad_item As Decimal
    Public Property cantidad_item() As Decimal
        Get
            _cantidad_item = CDec(dr("cantidad_item"))
            Return _cantidad_item
        End Get
        Set(ByVal Value As Decimal)
            dr("cantidad_item") = Value
        End Set
    end property

    Private _precio_item As Decimal
    Public Property precio_item() As Decimal
        Get
            _precio_item = CDec(dr("precio_item"))
            Return _precio_item
        End Get
        Set(ByVal Value As Decimal)
            dr("precio_item") = Value
        End Set
    end property

    Private _descripcion_item As String
    Public Property descripcion_item() As String
        Get
            _descripcion_item = CStr(dr("descripcion_item"))
            Return _descripcion_item
        End Get
        Set(ByVal Value As String)
            dr("descripcion_item") = Value
        End Set
    end property

    Private _nro_item As Int32
    Public Property nro_item() As Int32
        Get
            _nro_item = CInt(dr("nro_item"))
            Return _nro_item
        End Get
        Set(ByVal Value As Int32)
            dr("nro_item") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cuerpo_factura")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cuerpo_factura_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cuerpo_factura", SqlDbType.int, 0, "id_cuerpo_factura")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_factura", SqlDbType.int, 4, "id_factura")
        da.InsertCommand.Parameters.Add("@id_item", SqlDbType.int, 4, "id_item")
        da.InsertCommand.Parameters.Add("@cantidad_item", SqlDbType.decimal, 9, "cantidad_item")
        da.InsertCommand.Parameters.Add("@precio_item", SqlDbType.decimal, 9, "precio_item")
        da.InsertCommand.Parameters.Add("@descripcion_item", SqlDbType.varchar, 5000, "descripcion_item")
        da.InsertCommand.Parameters.Add("@nro_item", SqlDbType.int, 4, "nro_item")

        dr = dt.NewRow()
        dr("id_factura") = 0
        dr("id_item") = 0
        dr("cantidad_item") = 0
        dr("precio_item") = 0
        dr("descripcion_item") = ""
        dr("nro_item") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCuerpo_factura As Integer)
        dt = New DataTable("Cuerpo_factura")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_factura WHERE id_cuerpo_factura = @id_Cuerpo_factura", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cuerpo_factura", idCuerpo_factura)
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
    Public Sub Borrar(ByVal idCuerpo_factura As Integer)
        dt = New DataTable("Cuerpo_factura")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_factura WHERE id_cuerpo_factura = " & _
        idCuerpo_factura, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cuerpo_factura_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cuerpo_factura", SqlDbType.Int, 4, "id_cuerpo_factura")
            dt.Rows(0).Delete()
            CrearComandoUpdate()
            Guardar()
        Catch ex As Exception
            If Err.Number = 5 Then
            End If
        End Try
    End Sub

    'asigno el tipo de datos a los parametros
    Friend Sub AsignarTipos()
        For Each dc As DataColumn In dt.Columns
            Select Case dc.ColumnName
                Case "id_cuerpo_factura"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_factura"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_item"
                    dc.DataType = Type.GetType("System.Int32")
                Case "cantidad_item"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "precio_item"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "descripcion_item"
                    dc.DataType = Type.GetType("System.String")
                Case "nro_item"
                    dc.DataType = Type.GetType("System.Int32")
            End Select
        Next
    End Sub

    'creo el commandbuilder
    Friend Sub CrearComandoUpdate()
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
        dt = New DataTable("Cuerpo_factura")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_factura WHERE id_cuerpo_factura = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cuerpo_factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_factura", SqlDbType.Int, 4, "id_cuerpo_factura")
        oda.SelectCommand.Parameters("@id_cuerpo_factura").Value = id_Cuerpo_factura

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = Me.id_factura
        oda.SelectCommand.Parameters.Add("@id_item", SqlDbType.int, 4, "id_item")
        oda.SelectCommand.Parameters("@id_item").Value = Me.id_item
        oda.SelectCommand.Parameters.Add("@cantidad_item", SqlDbType.decimal, 9, "cantidad_item")
        oda.SelectCommand.Parameters("@cantidad_item").Value = Me.cantidad_item
        oda.SelectCommand.Parameters.Add("@precio_item", SqlDbType.decimal, 9, "precio_item")
        oda.SelectCommand.Parameters("@precio_item").Value = Me.precio_item
        oda.SelectCommand.Parameters.Add("@descripcion_item", SqlDbType.varchar, 5000, "descripcion_item")
        oda.SelectCommand.Parameters("@descripcion_item").Value = Me.descripcion_item
        oda.SelectCommand.Parameters.Add("@nro_item", SqlDbType.int, 4, "nro_item")
        oda.SelectCommand.Parameters("@nro_item").Value = Me.nro_item

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
        Command.CommandText = "DELETE FROM Cuerpo_factura"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cuerpo_factura"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cuerpo_factura")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cuerpo_factura.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
