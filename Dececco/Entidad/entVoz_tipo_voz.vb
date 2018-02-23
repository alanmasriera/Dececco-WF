Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Voz_tipo_voz_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_voz_tipo_voz As Int32
    Public ReadOnly Property id_voz_tipo_voz() As Int32
        Get
            _id_voz_tipo_voz = CInt(dr("id_voz_tipo_voz"))
            Return _id_voz_tipo_voz
        End Get
    end property

    Private _id_voz As Int32
    Public Property id_voz() As Int32
        Get
            _id_voz = CInt(dr("id_voz"))
            Return _id_voz
        End Get
        Set(ByVal Value As Int32)
            dr("id_voz") = Value
        End Set
    end property

    Private _id_tipo_voz As Int32
    Public Property id_tipo_voz() As Int32
        Get
            _id_tipo_voz = CInt(dr("id_tipo_voz"))
            Return _id_tipo_voz
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_voz") = Value
        End Set
    end property

    Private _porcentaje_voz As Decimal
    Public Property porcentaje_voz() As Decimal
        Get
            _porcentaje_voz = CDec(dr("porcentaje_voz"))
            Return _porcentaje_voz
        End Get
        Set(ByVal Value As Decimal)
            dr("porcentaje_voz") = Value
        End Set
    end property

    Private _porcentaje_tipo_voz As Decimal
    Public Property porcentaje_tipo_voz() As Decimal
        Get
            _porcentaje_tipo_voz = CDec(dr("porcentaje_tipo_voz"))
            Return _porcentaje_tipo_voz
        End Get
        Set(ByVal Value As Decimal)
            dr("porcentaje_tipo_voz") = Value
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
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Voz_tipo_voz")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Voz_tipo_voz_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_voz_tipo_voz", SqlDbType.int, 0, "id_voz_tipo_voz")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_voz", SqlDbType.int, 4, "id_voz")
        da.InsertCommand.Parameters.Add("@id_tipo_voz", SqlDbType.int, 4, "id_tipo_voz")
        da.InsertCommand.Parameters.Add("@porcentaje_voz", SqlDbType.decimal, 9, "porcentaje_voz")
        da.InsertCommand.Parameters.Add("@porcentaje_tipo_voz", SqlDbType.decimal, 9, "porcentaje_tipo_voz")
        da.InsertCommand.Parameters.Add("@indice", SqlDbType.int, 4, "indice")
        da.InsertCommand.Parameters.Add("@nro", SqlDbType.int, 4, "nro")

        dr = dt.NewRow()
        dr("id_voz") = 0
        dr("id_tipo_voz") = 0
        dr("porcentaje_voz") = 0
        dr("porcentaje_tipo_voz") = 0
        dr("indice") = 0
        dr("nro") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idVoz_tipo_voz As Integer)
        dt = New DataTable("Voz_tipo_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Voz_tipo_voz WHERE id_voz_tipo_voz = @id_Voz_tipo_voz", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Voz_tipo_voz", idVoz_tipo_voz)
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
    Public Sub Borrar(ByVal idVoz_tipo_voz As Integer)
        dt = New DataTable("Voz_tipo_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Voz_tipo_voz WHERE id_voz_tipo_voz = " & _
        idVoz_tipo_voz, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Voz_tipo_voz_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_voz_tipo_voz", SqlDbType.Int, 4, "id_voz_tipo_voz")
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
               Case "id_voz_tipo_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_tipo_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "porcentaje_voz"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "porcentaje_tipo_voz"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "indice"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nro"
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
        dt = New DataTable("Voz_tipo_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Voz_tipo_voz WHERE id_voz_tipo_voz = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Voz_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_voz_tipo_voz", SqlDbType.Int, 4, "id_voz_tipo_voz")
        oda.SelectCommand.Parameters("@id_voz_tipo_voz").Value = id_Voz_tipo_voz

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_voz", SqlDbType.int, 4, "id_voz")
        oda.SelectCommand.Parameters("@id_voz").Value = Me.id_voz
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = Me.id_tipo_voz
        oda.SelectCommand.Parameters.Add("@porcentaje_voz", SqlDbType.decimal, 9, "porcentaje_voz")
        oda.SelectCommand.Parameters("@porcentaje_voz").Value = Me.porcentaje_voz
        oda.SelectCommand.Parameters.Add("@porcentaje_tipo_voz", SqlDbType.decimal, 9, "porcentaje_tipo_voz")
        oda.SelectCommand.Parameters("@porcentaje_tipo_voz").Value = Me.porcentaje_tipo_voz
        oda.SelectCommand.Parameters.Add("@indice", SqlDbType.int, 4, "indice")
        oda.SelectCommand.Parameters("@indice").Value = Me.indice
        oda.SelectCommand.Parameters.Add("@nro", SqlDbType.int, 4, "nro")
        oda.SelectCommand.Parameters("@nro").Value = Me.nro

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
        Command.CommandText = "DELETE FROM Voz_tipo_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Voz_tipo_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Voz_tipo_voz_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Voz_tipo_voz")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Voz_tipo_voz.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
