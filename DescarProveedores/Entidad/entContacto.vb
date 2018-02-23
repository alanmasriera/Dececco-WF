Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Contacto_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_contacto As Int32
    Public ReadOnly Property id_contacto() As Int32
        Get
            _id_contacto = CInt(dr("id_contacto"))
            Return _id_contacto
        End Get
    end property

    Private _nombre_contacto As String
    Public Property nombre_contacto() As String
        Get
            _nombre_contacto = CStr(dr("nombre_contacto"))
            Return _nombre_contacto
        End Get
        Set(ByVal Value As String)
            dr("nombre_contacto") = Value
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

    Private _cargo As String
    Public Property cargo() As String
        Get
            _cargo = CStr(dr("cargo"))
            Return _cargo
        End Get
        Set(ByVal Value As String)
            dr("cargo") = Value
        End Set
    end property

    Private _departamento As String
    Public Property departamento() As String
        Get
            _departamento = CStr(dr("departamento"))
            Return _departamento
        End Get
        Set(ByVal Value As String)
            dr("departamento") = Value
        End Set
    end property

    Private _jefe As String
    Public Property jefe() As String
        Get
            _jefe = CStr(dr("jefe"))
            Return _jefe
        End Get
        Set(ByVal Value As String)
            dr("jefe") = Value
        End Set
    end property

    Private _oficina As String
    Public Property oficina() As String
        Get
            _oficina = CStr(dr("oficina"))
            Return _oficina
        End Get
        Set(ByVal Value As String)
            dr("oficina") = Value
        End Set
    end property

    Private _asistente As String
    Public Property asistente() As String
        Get
            _asistente = CStr(dr("asistente"))
            Return _asistente
        End Get
        Set(ByVal Value As String)
            dr("asistente") = Value
        End Set
    end property

    Private _profesion As String
    Public Property profesion() As String
        Get
            _profesion = CStr(dr("profesion"))
            Return _profesion
        End Get
        Set(ByVal Value As String)
            dr("profesion") = Value
        End Set
    end property

    Private _sobrenombre As String
    Public Property sobrenombre() As String
        Get
            _sobrenombre = CStr(dr("sobrenombre"))
            Return _sobrenombre
        End Get
        Set(ByVal Value As String)
            dr("sobrenombre") = Value
        End Set
    end property

    Private _fecha_nacimiento As DateTime
    Public Property fecha_nacimiento() As DateTime
        Get
            _fecha_nacimiento = CDate(dr("fecha_nacimiento"))
            Return _fecha_nacimiento
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_nacimiento") = Value
        End Set
    end property

    Private _fecha_aniversario As DateTime
    Public Property fecha_aniversario() As DateTime
        Get
            _fecha_aniversario = CDate(dr("fecha_aniversario"))
            Return _fecha_aniversario
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_aniversario") = Value
        End Set
    end property

    Private _web As String
    Public Property web() As String
        Get
            _web = CStr(dr("web"))
            Return _web
        End Get
        Set(ByVal Value As String)
            dr("web") = Value
        End Set
    end property

    Private _detalle As String
    Public Property detalle() As String
        Get
            _detalle = CStr(dr("detalle"))
            Return _detalle
        End Get
        Set(ByVal Value As String)
            dr("detalle") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Contacto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Contacto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_contacto", SqlDbType.int, 0, "id_contacto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_contacto", SqlDbType.varchar, 100, "nombre_contacto")
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@cargo", SqlDbType.varchar, 50, "cargo")
        da.InsertCommand.Parameters.Add("@departamento", SqlDbType.varchar, 50, "departamento")
        da.InsertCommand.Parameters.Add("@jefe", SqlDbType.varchar, 50, "jefe")
        da.InsertCommand.Parameters.Add("@oficina", SqlDbType.varchar, 50, "oficina")
        da.InsertCommand.Parameters.Add("@asistente", SqlDbType.varchar, 50, "asistente")
        da.InsertCommand.Parameters.Add("@profesion", SqlDbType.varchar, 50, "profesion")
        da.InsertCommand.Parameters.Add("@sobrenombre", SqlDbType.varchar, 50, "sobrenombre")
        da.InsertCommand.Parameters.Add("@fecha_nacimiento", SqlDbType.datetime, 8, "fecha_nacimiento")
        da.InsertCommand.Parameters.Add("@fecha_aniversario", SqlDbType.datetime, 8, "fecha_aniversario")
        da.InsertCommand.Parameters.Add("@web", SqlDbType.varchar, 50, "web")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 500, "detalle")

        dr = dt.NewRow()
        dr("nombre_contacto") = ""
        dr("id_cliente") = 0
        dr("cargo") = ""
        dr("departamento") = ""
        dr("jefe") = ""
        dr("oficina") = ""
        dr("asistente") = ""
        dr("profesion") = ""
        dr("sobrenombre") = ""
        dr("fecha_nacimiento") = DateTime.Now
        dr("fecha_aniversario") = DateTime.Now
        dr("web") = ""
        dr("detalle") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idContacto As Integer)
        dt = New DataTable("Contacto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Contacto WHERE id_contacto = @id_Contacto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Contacto", idContacto)
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
    Public Sub Borrar(ByVal idContacto As Integer)
        dt = New DataTable("Contacto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Contacto WHERE id_contacto = " & _
        idContacto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Contacto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_contacto", SqlDbType.Int, 4, "id_contacto")
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
               Case "id_contacto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_contacto"
                  dc.DataType = Type.GetType("System.String")
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "cargo"
                  dc.DataType = Type.GetType("System.String")
               Case "departamento"
                  dc.DataType = Type.GetType("System.String")
               Case "jefe"
                  dc.DataType = Type.GetType("System.String")
               Case "oficina"
                  dc.DataType = Type.GetType("System.String")
               Case "asistente"
                  dc.DataType = Type.GetType("System.String")
               Case "profesion"
                  dc.DataType = Type.GetType("System.String")
               Case "sobrenombre"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_nacimiento"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_aniversario"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "web"
                  dc.DataType = Type.GetType("System.String")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
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
        dt = New DataTable("Contacto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Contacto WHERE id_contacto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Contacto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Contacto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Contacto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Contacto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Contacto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_contacto", SqlDbType.Int, 4, "id_contacto")
        oda.SelectCommand.Parameters("@id_contacto").Value = id_Contacto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Contacto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_contacto", SqlDbType.varchar, 100, "nombre_contacto")
        oda.SelectCommand.Parameters("@nombre_contacto").Value = Me.nombre_contacto
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@cargo", SqlDbType.varchar, 50, "cargo")
        oda.SelectCommand.Parameters("@cargo").Value = Me.cargo
        oda.SelectCommand.Parameters.Add("@departamento", SqlDbType.varchar, 50, "departamento")
        oda.SelectCommand.Parameters("@departamento").Value = Me.departamento
        oda.SelectCommand.Parameters.Add("@jefe", SqlDbType.varchar, 50, "jefe")
        oda.SelectCommand.Parameters("@jefe").Value = Me.jefe
        oda.SelectCommand.Parameters.Add("@oficina", SqlDbType.varchar, 50, "oficina")
        oda.SelectCommand.Parameters("@oficina").Value = Me.oficina
        oda.SelectCommand.Parameters.Add("@asistente", SqlDbType.varchar, 50, "asistente")
        oda.SelectCommand.Parameters("@asistente").Value = Me.asistente
        oda.SelectCommand.Parameters.Add("@profesion", SqlDbType.varchar, 50, "profesion")
        oda.SelectCommand.Parameters("@profesion").Value = Me.profesion
        oda.SelectCommand.Parameters.Add("@sobrenombre", SqlDbType.varchar, 50, "sobrenombre")
        oda.SelectCommand.Parameters("@sobrenombre").Value = Me.sobrenombre
        oda.SelectCommand.Parameters.Add("@fecha_nacimiento", SqlDbType.datetime, 8, "fecha_nacimiento")
        oda.SelectCommand.Parameters("@fecha_nacimiento").Value = Me.fecha_nacimiento
        oda.SelectCommand.Parameters.Add("@fecha_aniversario", SqlDbType.datetime, 8, "fecha_aniversario")
        oda.SelectCommand.Parameters("@fecha_aniversario").Value = Me.fecha_aniversario
        oda.SelectCommand.Parameters.Add("@web", SqlDbType.varchar, 50, "web")
        oda.SelectCommand.Parameters("@web").Value = Me.web
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 500, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle

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
        Command.CommandText = "DELETE FROM Contacto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Contacto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Contacto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Contacto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Contacto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
