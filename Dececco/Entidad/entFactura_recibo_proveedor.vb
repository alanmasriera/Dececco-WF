Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Factura_recibo_proveedor_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_factura_recibo_proveedor As Int32
    Public ReadOnly Property id_factura_recibo_proveedor() As Int32
        Get
            _id_factura_recibo_proveedor = CInt(dr("id_factura_recibo_proveedor"))
            Return _id_factura_recibo_proveedor
        End Get
    end property

    Private _id_factura_proveedor As Int32
    Public Property id_factura_proveedor() As Int32
        Get
            _id_factura_proveedor = CInt(dr("id_factura_proveedor"))
            Return _id_factura_proveedor
        End Get
        Set(ByVal Value As Int32)
            dr("id_factura_proveedor") = Value
        End Set
    end property

    Private _id_recibo_proveedor As Int32
    Public Property id_recibo_proveedor() As Int32
        Get
            _id_recibo_proveedor = CInt(dr("id_recibo_proveedor"))
            Return _id_recibo_proveedor
        End Get
        Set(ByVal Value As Int32)
            dr("id_recibo_proveedor") = Value
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
    end property

    Private _efectivo As Boolean
    Public Property efectivo() As Boolean
        Get
            _efectivo = CBool(dr("efectivo"))
            Return _efectivo
        End Get
        Set(ByVal Value As Boolean)
            dr("efectivo") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Factura_recibo_proveedor")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Factura_recibo_proveedor_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_factura_recibo_proveedor", SqlDbType.int, 0, "id_factura_recibo_proveedor")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.int, 4, "id_factura_proveedor")
        da.InsertCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.int, 4, "id_recibo_proveedor")
        da.InsertCommand.Parameters.Add("@importe_pagado", SqlDbType.decimal, 9, "importe_pagado")
        da.InsertCommand.Parameters.Add("@efectivo", SqlDbType.bit, 1, "efectivo")

        dr = dt.NewRow()
        dr("id_factura_proveedor") = 0
        dr("id_recibo_proveedor") = 0
        dr("importe_pagado") = 0
        dr("efectivo") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idFactura_recibo_proveedor As Integer)
        dt = New DataTable("Factura_recibo_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura_recibo_proveedor WHERE id_factura_recibo_proveedor = @id_Factura_recibo_proveedor", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Factura_recibo_proveedor", idFactura_recibo_proveedor)
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
    Public Sub Borrar(ByVal idFactura_recibo_proveedor As Integer)
        dt = New DataTable("Factura_recibo_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura_recibo_proveedor WHERE id_factura_recibo_proveedor = " & _
        idFactura_recibo_proveedor, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Factura_recibo_proveedor_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_factura_recibo_proveedor", SqlDbType.Int, 4, "id_factura_recibo_proveedor")
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
               Case "id_factura_recibo_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_factura_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_recibo_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "importe_pagado"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "efectivo"
                  dc.DataType = Type.GetType("System.Boolean")
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
        dt = New DataTable("Factura_recibo_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura_recibo_proveedor WHERE id_factura_recibo_proveedor = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Factura_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_recibo_proveedor", SqlDbType.Int, 4, "id_factura_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_factura_recibo_proveedor").Value = id_Factura_recibo_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = Me.id_factura_proveedor
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = Me.id_recibo_proveedor
        oda.SelectCommand.Parameters.Add("@importe_pagado", SqlDbType.decimal, 9, "importe_pagado")
        oda.SelectCommand.Parameters("@importe_pagado").Value = Me.importe_pagado
        oda.SelectCommand.Parameters.Add("@efectivo", SqlDbType.bit, 1, "efectivo")
        oda.SelectCommand.Parameters("@efectivo").Value = Me.efectivo

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
        Command.CommandText = "DELETE FROM Factura_recibo_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Factura_recibo_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_recibo_proveedor_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Factura_recibo_proveedor")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Factura_recibo_proveedor.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
