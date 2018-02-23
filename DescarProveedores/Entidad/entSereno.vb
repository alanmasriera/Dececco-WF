Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Sereno_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_sereno As Int32
    Public ReadOnly Property id_sereno() As Int32
        Get
            _id_sereno = CInt(dr("id_sereno"))
            Return _id_sereno
        End Get
    end property

    Private _sueldo_sereno As Decimal
    Public Property sueldo_sereno() As Decimal
        Get
            _sueldo_sereno = CDec(dr("sueldo_sereno"))
            Return _sueldo_sereno
        End Get
        Set(ByVal Value As Decimal)
            dr("sueldo_sereno") = Value
        End Set
    end property

    Private _contribucion_extraordinaria As Decimal
    Public Property contribucion_extraordinaria() As Decimal
        Get
            _contribucion_extraordinaria = CDec(dr("contribucion_extraordinaria"))
            Return _contribucion_extraordinaria
        End Get
        Set(ByVal Value As Decimal)
            dr("contribucion_extraordinaria") = Value
        End Set
    end property

    Private _aporte_solidario As Decimal
    Public Property aporte_solidario() As Decimal
        Get
            _aporte_solidario = CDec(dr("aporte_solidario"))
            Return _aporte_solidario
        End Get
        Set(ByVal Value As Decimal)
            dr("aporte_solidario") = Value
        End Set
    end property

    Private _ayuda_escolar As Decimal
    Public Property ayuda_escolar() As Decimal
        Get
            _ayuda_escolar = CDec(dr("ayuda_escolar"))
            Return _ayuda_escolar
        End Get
        Set(ByVal Value As Decimal)
            dr("ayuda_escolar") = Value
        End Set
    end property

    Private _valor_discapacitado As Decimal
    Public Property valor_discapacitado() As Decimal
        Get
            _valor_discapacitado = CDec(dr("valor_discapacitado"))
            Return _valor_discapacitado
        End Get
        Set(ByVal Value As Decimal)
            dr("valor_discapacitado") = Value
        End Set
    end property

    Private _hora_administrativo As Decimal
    Public Property hora_administrativo() As Decimal
        Get
            _hora_administrativo = CDec(dr("hora_administrativo"))
            Return _hora_administrativo
        End Get
        Set(ByVal Value As Decimal)
            dr("hora_administrativo") = Value
        End Set
    end property

    Private _valor_embargo As Decimal
    Public Property valor_embargo() As Decimal
        Get
            _valor_embargo = CDec(dr("valor_embargo"))
            Return _valor_embargo
        End Get
        Set(ByVal Value As Decimal)
            dr("valor_embargo") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Sereno")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Sereno_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_sereno", SqlDbType.int, 0, "id_sereno")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@sueldo_sereno", SqlDbType.decimal, 9, "sueldo_sereno")
        da.InsertCommand.Parameters.Add("@contribucion_extraordinaria", SqlDbType.decimal, 9, "contribucion_extraordinaria")
        da.InsertCommand.Parameters.Add("@aporte_solidario", SqlDbType.decimal, 9, "aporte_solidario")
        da.InsertCommand.Parameters.Add("@ayuda_escolar", SqlDbType.decimal, 9, "ayuda_escolar")
        da.InsertCommand.Parameters.Add("@valor_discapacitado", SqlDbType.decimal, 9, "valor_discapacitado")
        da.InsertCommand.Parameters.Add("@hora_administrativo", SqlDbType.decimal, 9, "hora_administrativo")
        da.InsertCommand.Parameters.Add("@valor_embargo", SqlDbType.decimal, 9, "valor_embargo")

        dr = dt.NewRow()
        dr("sueldo_sereno") = 0
        dr("contribucion_extraordinaria") = 0
        dr("aporte_solidario") = 0
        dr("ayuda_escolar") = 0
        dr("valor_discapacitado") = 0
        dr("hora_administrativo") = 0
        dr("valor_embargo") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idSereno As Integer)
        dt = New DataTable("Sereno")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Sereno WHERE id_sereno = @id_Sereno", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Sereno", idSereno)
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
    Public Sub Borrar(ByVal idSereno As Integer)
        dt = New DataTable("Sereno")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Sereno WHERE id_sereno = " & _
        idSereno, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Sereno_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_sereno", SqlDbType.Int, 4, "id_sereno")
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
               Case "id_sereno"
                  dc.DataType = Type.GetType("System.Int32")
               Case "sueldo_sereno"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "contribucion_extraordinaria"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "aporte_solidario"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "ayuda_escolar"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "valor_discapacitado"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "hora_administrativo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "valor_embargo"
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
        dt = New DataTable("Sereno")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Sereno WHERE id_sereno = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sereno_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sereno_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sereno_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Sereno As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sereno_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_sereno", SqlDbType.Int, 4, "id_sereno")
        oda.SelectCommand.Parameters("@id_sereno").Value = id_Sereno

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sereno_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@sueldo_sereno", SqlDbType.decimal, 9, "sueldo_sereno")
        oda.SelectCommand.Parameters("@sueldo_sereno").Value = Me.sueldo_sereno
        oda.SelectCommand.Parameters.Add("@contribucion_extraordinaria", SqlDbType.decimal, 9, "contribucion_extraordinaria")
        oda.SelectCommand.Parameters("@contribucion_extraordinaria").Value = Me.contribucion_extraordinaria
        oda.SelectCommand.Parameters.Add("@aporte_solidario", SqlDbType.decimal, 9, "aporte_solidario")
        oda.SelectCommand.Parameters("@aporte_solidario").Value = Me.aporte_solidario
        oda.SelectCommand.Parameters.Add("@ayuda_escolar", SqlDbType.decimal, 9, "ayuda_escolar")
        oda.SelectCommand.Parameters("@ayuda_escolar").Value = Me.ayuda_escolar
        oda.SelectCommand.Parameters.Add("@valor_discapacitado", SqlDbType.decimal, 9, "valor_discapacitado")
        oda.SelectCommand.Parameters("@valor_discapacitado").Value = Me.valor_discapacitado
        oda.SelectCommand.Parameters.Add("@hora_administrativo", SqlDbType.decimal, 9, "hora_administrativo")
        oda.SelectCommand.Parameters("@hora_administrativo").Value = Me.hora_administrativo
        oda.SelectCommand.Parameters.Add("@valor_embargo", SqlDbType.decimal, 9, "valor_embargo")
        oda.SelectCommand.Parameters("@valor_embargo").Value = Me.valor_embargo

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
        Command.CommandText = "DELETE FROM Sereno"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Sereno"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Sereno_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Sereno")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Sereno.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
