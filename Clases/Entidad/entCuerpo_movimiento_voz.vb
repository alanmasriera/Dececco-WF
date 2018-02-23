Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_movimiento_voz_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cuerpo_movimiento_voz As Int32
    Public ReadOnly Property id_cuerpo_movimiento_voz() As Int32
        Get
            _id_cuerpo_movimiento_voz = CInt(dr("id_cuerpo_movimiento_voz"))
            Return _id_cuerpo_movimiento_voz
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

    Private _nc1 As Boolean
    Public Property nc1() As Boolean
        Get
            _nc1 = CBool(dr("nc1"))
            Return _nc1
        End Get
        Set(ByVal Value As Boolean)
            dr("nc1") = Value
        End Set
    end property

    Private _ok1 As Boolean
    Public Property ok1() As Boolean
        Get
            _ok1 = CBool(dr("ok1"))
            Return _ok1
        End Get
        Set(ByVal Value As Boolean)
            dr("ok1") = Value
        End Set
    end property

    Private _corresponde1 As Boolean
    Public Property corresponde1() As Boolean
        Get
            _corresponde1 = CBool(dr("corresponde1"))
            Return _corresponde1
        End Get
        Set(ByVal Value As Boolean)
            dr("corresponde1") = Value
        End Set
    end property

    Private _conforme1 As Boolean
    Public Property conforme1() As Boolean
        Get
            _conforme1 = CBool(dr("conforme1"))
            Return _conforme1
        End Get
        Set(ByVal Value As Boolean)
            dr("conforme1") = Value
        End Set
    end property

    Private _no_conforme1 As Boolean
    Public Property no_conforme1() As Boolean
        Get
            _no_conforme1 = CBool(dr("no_conforme1"))
            Return _no_conforme1
        End Get
        Set(ByVal Value As Boolean)
            dr("no_conforme1") = Value
        End Set
    end property

    Private _tipo1 As String
    Public Property tipo1() As String
        Get
            _tipo1 = CStr(dr("tipo1"))
            Return _tipo1
        End Get
        Set(ByVal Value As String)
            dr("tipo1") = Value
        End Set
    end property

    Private _detalle1 As String
    Public Property detalle1() As String
        Get
            _detalle1 = CStr(dr("detalle1"))
            Return _detalle1
        End Get
        Set(ByVal Value As String)
            dr("detalle1") = Value
        End Set
    end property

    Private _correccion1 As Boolean
    Public Property correccion1() As Boolean
        Get
            _correccion1 = CBool(dr("correccion1"))
            Return _correccion1
        End Get
        Set(ByVal Value As Boolean)
            dr("correccion1") = Value
        End Set
    end property

    Private _id_movimiento_voz As Int32
    Public Property id_movimiento_voz() As Int32
        Get
            _id_movimiento_voz = CInt(dr("id_movimiento_voz"))
            Return _id_movimiento_voz
        End Get
        Set(ByVal Value As Int32)
            dr("id_movimiento_voz") = Value
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

    Private _corresponde2 As Boolean
    Public Property corresponde2() As Boolean
        Get
            _corresponde2 = CBool(dr("corresponde2"))
            Return _corresponde2
        End Get
        Set(ByVal Value As Boolean)
            dr("corresponde2") = Value
        End Set
    end property

    Private _conforme2 As Boolean
    Public Property conforme2() As Boolean
        Get
            _conforme2 = CBool(dr("conforme2"))
            Return _conforme2
        End Get
        Set(ByVal Value As Boolean)
            dr("conforme2") = Value
        End Set
    end property

    Private _no_conforme2 As Boolean
    Public Property no_conforme2() As Boolean
        Get
            _no_conforme2 = CBool(dr("no_conforme2"))
            Return _no_conforme2
        End Get
        Set(ByVal Value As Boolean)
            dr("no_conforme2") = Value
        End Set
    end property

    Private _tipo2 As String
    Public Property tipo2() As String
        Get
            _tipo2 = CStr(dr("tipo2"))
            Return _tipo2
        End Get
        Set(ByVal Value As String)
            dr("tipo2") = Value
        End Set
    end property

    Private _detalle2 As String
    Public Property detalle2() As String
        Get
            _detalle2 = CStr(dr("detalle2"))
            Return _detalle2
        End Get
        Set(ByVal Value As String)
            dr("detalle2") = Value
        End Set
    end property

    Private _correccion2 As Boolean
    Public Property correccion2() As Boolean
        Get
            _correccion2 = CBool(dr("correccion2"))
            Return _correccion2
        End Get
        Set(ByVal Value As Boolean)
            dr("correccion2") = Value
        End Set
    end property

    Private _random As Decimal
    Public Property random() As Decimal
        Get
            _random = CDec(dr("random"))
            Return _random
        End Get
        Set(ByVal Value As Decimal)
            dr("random") = Value
        End Set
    end property

    Private _completado As Boolean
    Public Property completado() As Boolean
        Get
            _completado = CBool(dr("completado"))
            Return _completado
        End Get
        Set(ByVal Value As Boolean)
            dr("completado") = Value
        End Set
    end property

    Private _completado_pm As Boolean
    Public Property completado_pm() As Boolean
        Get
            _completado_pm = CBool(dr("completado_pm"))
            Return _completado_pm
        End Get
        Set(ByVal Value As Boolean)
            dr("completado_pm") = Value
        End Set
    end property

    Private _control1 As Boolean
    Public Property control1() As Boolean
        Get
            _control1 = CBool(dr("control1"))
            Return _control1
        End Get
        Set(ByVal Value As Boolean)
            dr("control1") = Value
        End Set
    end property

    Private _control2 As Boolean
    Public Property control2() As Boolean
        Get
            _control2 = CBool(dr("control2"))
            Return _control2
        End Get
        Set(ByVal Value As Boolean)
            dr("control2") = Value
        End Set
    end property

    Private _control3 As Boolean
    Public Property control3() As Boolean
        Get
            _control3 = CBool(dr("control3"))
            Return _control3
        End Get
        Set(ByVal Value As Boolean)
            dr("control3") = Value
        End Set
    end property

    Private _pedido_segundo_control As Boolean
    Public Property pedido_segundo_control() As Boolean
        Get
            _pedido_segundo_control = CBool(dr("pedido_segundo_control"))
            Return _pedido_segundo_control
        End Get
        Set(ByVal Value As Boolean)
            dr("pedido_segundo_control") = Value
        End Set
    end property

    Private _numero_revision As Decimal
    Public Property numero_revision() As Decimal
        Get
            _numero_revision = CDec(dr("numero_revision"))
            Return _numero_revision
        End Get
        Set(ByVal Value As Decimal)
            dr("numero_revision") = Value
        End Set
    end property

    Private _corresponde As Boolean
    Public Property corresponde() As Boolean
        Get
            _corresponde = CBool(dr("corresponde"))
            Return _corresponde
        End Get
        Set(ByVal Value As Boolean)
            dr("corresponde") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cuerpo_movimiento_voz")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cuerpo_movimiento_voz_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cuerpo_movimiento_voz", SqlDbType.int, 0, "id_cuerpo_movimiento_voz")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_voz", SqlDbType.int, 4, "id_voz")
        da.InsertCommand.Parameters.Add("@nc1", SqlDbType.bit, 1, "nc1")
        da.InsertCommand.Parameters.Add("@ok1", SqlDbType.bit, 1, "ok1")
        da.InsertCommand.Parameters.Add("@corresponde1", SqlDbType.bit, 1, "corresponde1")
        da.InsertCommand.Parameters.Add("@conforme1", SqlDbType.bit, 1, "conforme1")
        da.InsertCommand.Parameters.Add("@no_conforme1", SqlDbType.bit, 1, "no_conforme1")
        da.InsertCommand.Parameters.Add("@tipo1", SqlDbType.varchar, 50, "tipo1")
        da.InsertCommand.Parameters.Add("@detalle1", SqlDbType.varchar, 5000, "detalle1")
        da.InsertCommand.Parameters.Add("@correccion1", SqlDbType.bit, 1, "correccion1")
        da.InsertCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.int, 4, "id_movimiento_voz")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@corresponde2", SqlDbType.bit, 1, "corresponde2")
        da.InsertCommand.Parameters.Add("@conforme2", SqlDbType.bit, 1, "conforme2")
        da.InsertCommand.Parameters.Add("@no_conforme2", SqlDbType.bit, 1, "no_conforme2")
        da.InsertCommand.Parameters.Add("@tipo2", SqlDbType.varchar, 50, "tipo2")
        da.InsertCommand.Parameters.Add("@detalle2", SqlDbType.varchar, 5000, "detalle2")
        da.InsertCommand.Parameters.Add("@correccion2", SqlDbType.bit, 1, "correccion2")
        da.InsertCommand.Parameters.Add("@random", SqlDbType.decimal, 9, "random")
        da.InsertCommand.Parameters.Add("@completado", SqlDbType.bit, 1, "completado")
        da.InsertCommand.Parameters.Add("@completado_pm", SqlDbType.bit, 1, "completado_pm")
        da.InsertCommand.Parameters.Add("@control1", SqlDbType.bit, 1, "control1")
        da.InsertCommand.Parameters.Add("@control2", SqlDbType.bit, 1, "control2")
        da.InsertCommand.Parameters.Add("@control3", SqlDbType.bit, 1, "control3")
        da.InsertCommand.Parameters.Add("@pedido_segundo_control", SqlDbType.bit, 1, "pedido_segundo_control")
        da.InsertCommand.Parameters.Add("@numero_revision", SqlDbType.decimal, 9, "numero_revision")
        da.InsertCommand.Parameters.Add("@corresponde", SqlDbType.bit, 1, "corresponde")

        dr = dt.NewRow()
        dr("id_voz") = 0
        dr("nc1") = False
        dr("ok1") = False
        dr("corresponde1") = False
        dr("conforme1") = False
        dr("no_conforme1") = False
        dr("tipo1") = ""
        dr("detalle1") = ""
        dr("correccion1") = False
        dr("id_movimiento_voz") = 0
        dr("id_usuario") = 0
        dr("corresponde2") = False
        dr("conforme2") = False
        dr("no_conforme2") = False
        dr("tipo2") = ""
        dr("detalle2") = ""
        dr("correccion2") = False
        dr("random") = 0
        dr("completado") = False
        dr("completado_pm") = False
        dr("control1") = False
        dr("control2") = False
        dr("control3") = False
        dr("pedido_segundo_control") = False
        dr("numero_revision") = 0
        dr("corresponde") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCuerpo_movimiento_voz As Integer)
        dt = New DataTable("Cuerpo_movimiento_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_movimiento_voz WHERE id_cuerpo_movimiento_voz = @id_Cuerpo_movimiento_voz", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cuerpo_movimiento_voz", idCuerpo_movimiento_voz)
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
    Public Sub Borrar(ByVal idCuerpo_movimiento_voz As Integer)
        dt = New DataTable("Cuerpo_movimiento_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_movimiento_voz WHERE id_cuerpo_movimiento_voz = " & _
        idCuerpo_movimiento_voz, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cuerpo_movimiento_voz_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cuerpo_movimiento_voz", SqlDbType.Int, 4, "id_cuerpo_movimiento_voz")
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
               Case "id_cuerpo_movimiento_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nc1"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "ok1"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "corresponde1"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "conforme1"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "no_conforme1"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "tipo1"
                  dc.DataType = Type.GetType("System.String")
               Case "detalle1"
                  dc.DataType = Type.GetType("System.String")
               Case "correccion1"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_movimiento_voz"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "corresponde2"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "conforme2"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "no_conforme2"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "tipo2"
                  dc.DataType = Type.GetType("System.String")
               Case "detalle2"
                  dc.DataType = Type.GetType("System.String")
               Case "correccion2"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "random"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "completado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "completado_pm"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "control1"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "control2"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "control3"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "pedido_segundo_control"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "numero_revision"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "corresponde"
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
        dt = New DataTable("Cuerpo_movimiento_voz")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_movimiento_voz WHERE id_cuerpo_movimiento_voz = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cuerpo_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_movimiento_voz", SqlDbType.Int, 4, "id_cuerpo_movimiento_voz")
        oda.SelectCommand.Parameters("@id_cuerpo_movimiento_voz").Value = id_Cuerpo_movimiento_voz

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_voz", SqlDbType.int, 4, "id_voz")
        oda.SelectCommand.Parameters("@id_voz").Value = Me.id_voz
        oda.SelectCommand.Parameters.Add("@nc1", SqlDbType.bit, 1, "nc1")
        oda.SelectCommand.Parameters("@nc1").Value = Me.nc1
        oda.SelectCommand.Parameters.Add("@ok1", SqlDbType.bit, 1, "ok1")
        oda.SelectCommand.Parameters("@ok1").Value = Me.ok1
        oda.SelectCommand.Parameters.Add("@corresponde1", SqlDbType.bit, 1, "corresponde1")
        oda.SelectCommand.Parameters("@corresponde1").Value = Me.corresponde1
        oda.SelectCommand.Parameters.Add("@conforme1", SqlDbType.bit, 1, "conforme1")
        oda.SelectCommand.Parameters("@conforme1").Value = Me.conforme1
        oda.SelectCommand.Parameters.Add("@no_conforme1", SqlDbType.bit, 1, "no_conforme1")
        oda.SelectCommand.Parameters("@no_conforme1").Value = Me.no_conforme1
        oda.SelectCommand.Parameters.Add("@tipo1", SqlDbType.varchar, 50, "tipo1")
        oda.SelectCommand.Parameters("@tipo1").Value = Me.tipo1
        oda.SelectCommand.Parameters.Add("@detalle1", SqlDbType.varchar, 5000, "detalle1")
        oda.SelectCommand.Parameters("@detalle1").Value = Me.detalle1
        oda.SelectCommand.Parameters.Add("@correccion1", SqlDbType.bit, 1, "correccion1")
        oda.SelectCommand.Parameters("@correccion1").Value = Me.correccion1
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = Me.id_movimiento_voz
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@corresponde2", SqlDbType.bit, 1, "corresponde2")
        oda.SelectCommand.Parameters("@corresponde2").Value = Me.corresponde2
        oda.SelectCommand.Parameters.Add("@conforme2", SqlDbType.bit, 1, "conforme2")
        oda.SelectCommand.Parameters("@conforme2").Value = Me.conforme2
        oda.SelectCommand.Parameters.Add("@no_conforme2", SqlDbType.bit, 1, "no_conforme2")
        oda.SelectCommand.Parameters("@no_conforme2").Value = Me.no_conforme2
        oda.SelectCommand.Parameters.Add("@tipo2", SqlDbType.varchar, 50, "tipo2")
        oda.SelectCommand.Parameters("@tipo2").Value = Me.tipo2
        oda.SelectCommand.Parameters.Add("@detalle2", SqlDbType.varchar, 5000, "detalle2")
        oda.SelectCommand.Parameters("@detalle2").Value = Me.detalle2
        oda.SelectCommand.Parameters.Add("@correccion2", SqlDbType.bit, 1, "correccion2")
        oda.SelectCommand.Parameters("@correccion2").Value = Me.correccion2
        oda.SelectCommand.Parameters.Add("@random", SqlDbType.decimal, 9, "random")
        oda.SelectCommand.Parameters("@random").Value = Me.random
        oda.SelectCommand.Parameters.Add("@completado", SqlDbType.bit, 1, "completado")
        oda.SelectCommand.Parameters("@completado").Value = Me.completado
        oda.SelectCommand.Parameters.Add("@completado_pm", SqlDbType.bit, 1, "completado_pm")
        oda.SelectCommand.Parameters("@completado_pm").Value = Me.completado_pm
        oda.SelectCommand.Parameters.Add("@control1", SqlDbType.bit, 1, "control1")
        oda.SelectCommand.Parameters("@control1").Value = Me.control1
        oda.SelectCommand.Parameters.Add("@control2", SqlDbType.bit, 1, "control2")
        oda.SelectCommand.Parameters("@control2").Value = Me.control2
        oda.SelectCommand.Parameters.Add("@control3", SqlDbType.bit, 1, "control3")
        oda.SelectCommand.Parameters("@control3").Value = Me.control3
        oda.SelectCommand.Parameters.Add("@pedido_segundo_control", SqlDbType.bit, 1, "pedido_segundo_control")
        oda.SelectCommand.Parameters("@pedido_segundo_control").Value = Me.pedido_segundo_control
        oda.SelectCommand.Parameters.Add("@numero_revision", SqlDbType.decimal, 9, "numero_revision")
        oda.SelectCommand.Parameters("@numero_revision").Value = Me.numero_revision
        oda.SelectCommand.Parameters.Add("@corresponde", SqlDbType.bit, 1, "corresponde")
        oda.SelectCommand.Parameters("@corresponde").Value = Me.corresponde

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
        Command.CommandText = "DELETE FROM Cuerpo_movimiento_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cuerpo_movimiento_voz"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_movimiento_voz_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cuerpo_movimiento_voz")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cuerpo_movimiento_voz.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
