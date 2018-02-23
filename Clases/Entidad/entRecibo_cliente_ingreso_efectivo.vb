Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_cliente_ingreso_efectivo_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_Recibo_cliente_ingreso_efectivo As Int32
    Public ReadOnly Property id_Recibo_cliente_ingreso_efectivo() As Int32
        Get
            _id_Recibo_cliente_ingreso_efectivo = CInt(dr("id_Recibo_cliente_ingreso_efectivo"))
            Return _id_Recibo_cliente_ingreso_efectivo
        End Get
    end property

    Private _id_pago_cliente As Int32
    Public Property id_pago_cliente() As Int32
        Get
            _id_pago_cliente = CInt(dr("id_pago_cliente"))
            Return _id_pago_cliente
        End Get
        Set(ByVal Value As Int32)
            dr("id_pago_cliente") = Value
        End Set
    end property

    Private _id_ingreso_efectivo As Int32
    Public Property id_ingreso_efectivo() As Int32
        Get
            _id_ingreso_efectivo = CInt(dr("id_ingreso_efectivo"))
            Return _id_ingreso_efectivo
        End Get
        Set(ByVal Value As Int32)
            dr("id_ingreso_efectivo") = Value
        End Set
    end property

    Private _importe_pagado As Decimal
    Public Property importe_pagado() As Decimal
        Get
            _importe_pagado = CDec(dr("importe_pagado"))
            Return _importe_pagado
        End Get
        Set(ByVal Value As Decimal)
            dr("importe_pagado") = Value
        End Set
    End Property

    Private _control As Boolean
    Public Property control() As Boolean
        Get
            _control = CBool(dr("control"))
            Return _control
        End Get
        Set(ByVal Value As Boolean)
            dr("control") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Recibo_cliente_ingreso_efectivo")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Recibo_cliente_ingreso_efectivo_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_Recibo_cliente_ingreso_efectivo", SqlDbType.int, 0, "id_Recibo_cliente_ingreso_efectivo")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_pago_cliente", SqlDbType.int, 4, "id_pago_cliente")
        da.InsertCommand.Parameters.Add("@id_ingreso_efectivo", SqlDbType.int, 4, "id_ingreso_efectivo")
        da.InsertCommand.Parameters.Add("@importe_pagado", SqlDbType.decimal, 9, "importe_pagado")

        dr = dt.NewRow()
        dr("id_pago_cliente") = 0
        dr("id_ingreso_efectivo") = 0
        dr("importe_pagado") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idRecibo_cliente_ingreso_efectivo As Integer)
        dt = New DataTable("Recibo_cliente_ingreso_efectivo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_cliente_ingreso_efectivo WHERE id_Recibo_cliente_ingreso_efectivo = @id_Recibo_cliente_ingreso_efectivo", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Recibo_cliente_ingreso_efectivo", idRecibo_cliente_ingreso_efectivo)
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
    Public Sub Borrar(ByVal idRecibo_cliente_ingreso_efectivo As Integer)
        dt = New DataTable("Recibo_cliente_ingreso_efectivo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_cliente_ingreso_efectivo WHERE id_Recibo_cliente_ingreso_efectivo = " & _
        idRecibo_cliente_ingreso_efectivo, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Recibo_cliente_ingreso_efectivo_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_Recibo_cliente_ingreso_efectivo", SqlDbType.Int, 4, "id_Recibo_cliente_ingreso_efectivo")
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
               Case "id_Recibo_cliente_ingreso_efectivo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_pago_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_ingreso_efectivo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "importe_pagado"
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
        dt = New DataTable("Recibo_cliente_ingreso_efectivo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Recibo_cliente_ingreso_efectivo WHERE id_Recibo_cliente_ingreso_efectivo = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Recibo_cliente_ingreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Recibo_cliente_ingreso_efectivo", SqlDbType.Int, 4, "id_Recibo_cliente_ingreso_efectivo")
        oda.SelectCommand.Parameters("@id_Recibo_cliente_ingreso_efectivo").Value = id_Recibo_cliente_ingreso_efectivo

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = Me.id_pago_cliente
        oda.SelectCommand.Parameters.Add("@id_ingreso_efectivo", SqlDbType.int, 4, "id_ingreso_efectivo")
        oda.SelectCommand.Parameters("@id_ingreso_efectivo").Value = Me.id_ingreso_efectivo
        oda.SelectCommand.Parameters.Add("@importe_pagado", SqlDbType.decimal, 9, "importe_pagado")
        oda.SelectCommand.Parameters("@importe_pagado").Value = Me.importe_pagado

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
        Command.CommandText = "DELETE FROM Recibo_cliente_ingreso_efectivo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Recibo_cliente_ingreso_efectivo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Recibo_cliente_ingreso_efectivo_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Recibo_cliente_ingreso_efectivo")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Recibo_cliente_ingreso_efectivo.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
