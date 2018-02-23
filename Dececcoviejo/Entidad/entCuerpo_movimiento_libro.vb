Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_movimiento_libro_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cuerpo_movimiento_libro As Int32
    Public ReadOnly Property id_cuerpo_movimiento_libro() As Int32
        Get
            _id_cuerpo_movimiento_libro = CInt(dr("id_cuerpo_movimiento_libro"))
            Return _id_cuerpo_movimiento_libro
        End Get
    end property

    Private _id_cuenta_imputable As Int32
    Public Property id_cuenta_imputable() As Int32
        Get
            _id_cuenta_imputable = CInt(dr("id_cuenta_imputable"))
            Return _id_cuenta_imputable
        End Get
        Set(ByVal Value As Int32)
            dr("id_cuenta_imputable") = Value
        End Set
    end property

    Private _debe As Decimal
    Public Property debe() As Decimal
        Get
            _debe = CDec(dr("debe"))
            Return _debe
        End Get
        Set(ByVal Value As Decimal)
            dr("debe") = Value
        End Set
    end property

    Private _haber As Decimal
    Public Property haber() As Decimal
        Get
            _haber = CDec(dr("haber"))
            Return _haber
        End Get
        Set(ByVal Value As Decimal)
            dr("haber") = Value
        End Set
    end property

    Private _id_movimiento_libro As Int32
    Public Property id_movimiento_libro() As Int32
        Get
            _id_movimiento_libro = CInt(dr("id_movimiento_libro"))
            Return _id_movimiento_libro
        End Get
        Set(ByVal Value As Int32)
            dr("id_movimiento_libro") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cuerpo_movimiento_libro")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cuerpo_movimiento_libro_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cuerpo_movimiento_libro", SqlDbType.int, 0, "id_cuerpo_movimiento_libro")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.int, 4, "id_cuenta_imputable")
        da.InsertCommand.Parameters.Add("@debe", SqlDbType.decimal, 9, "debe")
        da.InsertCommand.Parameters.Add("@haber", SqlDbType.decimal, 9, "haber")
        da.InsertCommand.Parameters.Add("@id_movimiento_libro", SqlDbType.int, 4, "id_movimiento_libro")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")

        dr = dt.NewRow()
        dr("id_cuenta_imputable") = 0
        dr("debe") = 0
        dr("haber") = 0
        dr("id_movimiento_libro") = 0
        dr("id_usuario") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCuerpo_movimiento_libro As Integer)
        dt = New DataTable("Cuerpo_movimiento_libro")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_movimiento_libro WHERE id_cuerpo_movimiento_libro = @id_Cuerpo_movimiento_libro", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cuerpo_movimiento_libro", idCuerpo_movimiento_libro)
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
    Public Sub Borrar(ByVal idCuerpo_movimiento_libro As Integer)
        dt = New DataTable("Cuerpo_movimiento_libro")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_movimiento_libro WHERE id_cuerpo_movimiento_libro = " & _
        idCuerpo_movimiento_libro, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cuerpo_movimiento_libro_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cuerpo_movimiento_libro", SqlDbType.Int, 4, "id_cuerpo_movimiento_libro")
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
               Case "id_cuerpo_movimiento_libro"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cuenta_imputable"
                  dc.DataType = Type.GetType("System.Int32")
               Case "debe"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "haber"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_movimiento_libro"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_usuario"
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
        dt = New DataTable("Cuerpo_movimiento_libro")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_movimiento_libro WHERE id_cuerpo_movimiento_libro = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_libro_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_libro_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_libro_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cuerpo_movimiento_libro As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_libro_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_movimiento_libro", SqlDbType.Int, 4, "id_cuerpo_movimiento_libro")
        oda.SelectCommand.Parameters("@id_cuerpo_movimiento_libro").Value = id_Cuerpo_movimiento_libro

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_libro_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.int, 4, "id_cuenta_imputable")
        oda.SelectCommand.Parameters("@id_cuenta_imputable").Value = Me.id_cuenta_imputable
        oda.SelectCommand.Parameters.Add("@debe", SqlDbType.decimal, 9, "debe")
        oda.SelectCommand.Parameters("@debe").Value = Me.debe
        oda.SelectCommand.Parameters.Add("@haber", SqlDbType.decimal, 9, "haber")
        oda.SelectCommand.Parameters("@haber").Value = Me.haber
        oda.SelectCommand.Parameters.Add("@id_movimiento_libro", SqlDbType.int, 4, "id_movimiento_libro")
        oda.SelectCommand.Parameters("@id_movimiento_libro").Value = Me.id_movimiento_libro
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario

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
        Command.CommandText = "DELETE FROM Cuerpo_movimiento_libro"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cuerpo_movimiento_libro"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_movimiento_libro_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cuerpo_movimiento_libro")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cuerpo_movimiento_libro.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
