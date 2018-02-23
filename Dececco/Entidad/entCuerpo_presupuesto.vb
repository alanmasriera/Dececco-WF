Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_presupuesto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cuerpo_presupuesto As Int32
    Public ReadOnly Property id_cuerpo_presupuesto() As Int32
        Get
            _id_cuerpo_presupuesto = CInt(dr("id_cuerpo_presupuesto"))
            Return _id_cuerpo_presupuesto
        End Get
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

    Private _item As String
    Public Property item() As String
        Get
            _item = CStr(dr("item"))
            Return _item
        End Get
        Set(ByVal Value As String)
            dr("item") = Value
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

    Private _importe As Decimal
    Public Property importe() As Decimal
        Get
            _importe = CDec(dr("importe"))
            Return _importe
        End Get
        Set(ByVal Value As Decimal)
            dr("importe") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cuerpo_presupuesto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cuerpo_presupuesto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cuerpo_presupuesto", SqlDbType.int, 0, "id_cuerpo_presupuesto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_presupuesto", SqlDbType.int, 4, "id_presupuesto")
        da.InsertCommand.Parameters.Add("@item", SqlDbType.varchar, 5000, "item")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")

        dr = dt.NewRow()
        dr("id_presupuesto") = 0
        dr("item") = ""
        dr("id_usuario") = 0
        dr("importe") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCuerpo_presupuesto As Integer)
        dt = New DataTable("Cuerpo_presupuesto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_presupuesto WHERE id_cuerpo_presupuesto = @id_Cuerpo_presupuesto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cuerpo_presupuesto", idCuerpo_presupuesto)
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
    Public Sub Borrar(ByVal idCuerpo_presupuesto As Integer)
        dt = New DataTable("Cuerpo_presupuesto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_presupuesto WHERE id_cuerpo_presupuesto = " & _
        idCuerpo_presupuesto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cuerpo_presupuesto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cuerpo_presupuesto", SqlDbType.Int, 4, "id_cuerpo_presupuesto")
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
               Case "id_cuerpo_presupuesto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_presupuesto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "item"
                  dc.DataType = Type.GetType("System.String")
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "importe"
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
        dt = New DataTable("Cuerpo_presupuesto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_presupuesto WHERE id_cuerpo_presupuesto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_presupuesto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_presupuesto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_presupuesto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cuerpo_presupuesto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_presupuesto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_presupuesto", SqlDbType.Int, 4, "id_cuerpo_presupuesto")
        oda.SelectCommand.Parameters("@id_cuerpo_presupuesto").Value = id_Cuerpo_presupuesto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_presupuesto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_presupuesto", SqlDbType.int, 4, "id_presupuesto")
        oda.SelectCommand.Parameters("@id_presupuesto").Value = Me.id_presupuesto
        oda.SelectCommand.Parameters.Add("@item", SqlDbType.varchar, 5000, "item")
        oda.SelectCommand.Parameters("@item").Value = Me.item
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        oda.SelectCommand.Parameters("@importe").Value = Me.importe

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
        Command.CommandText = "DELETE FROM Cuerpo_presupuesto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cuerpo_presupuesto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_presupuesto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cuerpo_presupuesto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cuerpo_presupuesto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
