Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Empresa_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_empresa As Int32
    Public ReadOnly Property id_empresa() As Int32
        Get
            _id_empresa = CInt(dr("id_empresa"))
            Return _id_empresa
        End Get
    end property

    Private _nombre_empresa As String
    Public Property nombre_empresa() As String
        Get
            _nombre_empresa = CStr(dr("nombre_empresa"))
            Return _nombre_empresa
        End Get
        Set(ByVal Value As String)
            dr("nombre_empresa") = Value
        End Set
    end property

    Private _contacto As String
    Public Property contacto() As String
        Get
            _contacto = CStr(dr("contacto"))
            Return _contacto
        End Get
        Set(ByVal Value As String)
            dr("contacto") = Value
        End Set
    end property

    Private _cuit_empresa As String
    Public Property cuit_empresa() As String
        Get
            _cuit_empresa = CStr(dr("cuit_empresa"))
            Return _cuit_empresa
        End Get
        Set(ByVal Value As String)
            dr("cuit_empresa") = Value
        End Set
    end property

    Private _direccion As String
    Public Property direccion() As String
        Get
            _direccion = CStr(dr("direccion"))
            Return _direccion
        End Get
        Set(ByVal Value As String)
            dr("direccion") = Value
        End Set
    end property

    Private _telefono As String
    Public Property telefono() As String
        Get
            _telefono = CStr(dr("telefono"))
            Return _telefono
        End Get
        Set(ByVal Value As String)
            dr("telefono") = Value
        End Set
    end property

    Private _email As String
    Public Property email() As String
        Get
            _email = CStr(dr("email"))
            Return _email
        End Get
        Set(ByVal Value As String)
            dr("email") = Value
        End Set
    end property

    Private _pagina_web As String
    Public Property pagina_web() As String
        Get
            _pagina_web = CStr(dr("pagina_web"))
            Return _pagina_web
        End Get
        Set(ByVal Value As String)
            dr("pagina_web") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Empresa")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Empresa_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 0, "id_empresa")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_empresa", SqlDbType.varchar, 50, "nombre_empresa")
        da.InsertCommand.Parameters.Add("@contacto", SqlDbType.varchar, 50, "contacto")
        da.InsertCommand.Parameters.Add("@cuit_empresa", SqlDbType.varchar, 50, "cuit_empresa")
        da.InsertCommand.Parameters.Add("@direccion", SqlDbType.varchar, 500, "direccion")
        da.InsertCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        da.InsertCommand.Parameters.Add("@email", SqlDbType.varchar, 50, "email")
        da.InsertCommand.Parameters.Add("@pagina_web", SqlDbType.varchar, 50, "pagina_web")

        dr = dt.NewRow()
        dr("nombre_empresa") = ""
        dr("contacto") = ""
        dr("cuit_empresa") = ""
        dr("direccion") = ""
        dr("telefono") = ""
        dr("email") = ""
        dr("pagina_web") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idEmpresa As Integer)
        dt = New DataTable("Empresa")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Empresa WHERE id_empresa = @id_Empresa", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Empresa", idEmpresa)
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
    Public Sub Borrar(ByVal idEmpresa As Integer)
        dt = New DataTable("Empresa")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Empresa WHERE id_empresa = " & _
        idEmpresa, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Empresa_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
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
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_empresa"
                  dc.DataType = Type.GetType("System.String")
               Case "contacto"
                  dc.DataType = Type.GetType("System.String")
               Case "cuit_empresa"
                  dc.DataType = Type.GetType("System.String")
               Case "direccion"
                  dc.DataType = Type.GetType("System.String")
               Case "telefono"
                  dc.DataType = Type.GetType("System.String")
               Case "email"
                  dc.DataType = Type.GetType("System.String")
               Case "pagina_web"
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
        dt = New DataTable("Empresa")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Empresa WHERE id_empresa = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Empresa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_Empresa

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_empresa", SqlDbType.varchar, 50, "nombre_empresa")
        oda.SelectCommand.Parameters("@nombre_empresa").Value = Me.nombre_empresa
        oda.SelectCommand.Parameters.Add("@contacto", SqlDbType.varchar, 50, "contacto")
        oda.SelectCommand.Parameters("@contacto").Value = Me.contacto
        oda.SelectCommand.Parameters.Add("@cuit_empresa", SqlDbType.varchar, 50, "cuit_empresa")
        oda.SelectCommand.Parameters("@cuit_empresa").Value = Me.cuit_empresa
        oda.SelectCommand.Parameters.Add("@direccion", SqlDbType.varchar, 500, "direccion")
        oda.SelectCommand.Parameters("@direccion").Value = Me.direccion
        oda.SelectCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        oda.SelectCommand.Parameters("@telefono").Value = Me.telefono
        oda.SelectCommand.Parameters.Add("@email", SqlDbType.varchar, 50, "email")
        oda.SelectCommand.Parameters("@email").Value = Me.email
        oda.SelectCommand.Parameters.Add("@pagina_web", SqlDbType.varchar, 50, "pagina_web")
        oda.SelectCommand.Parameters("@pagina_web").Value = Me.pagina_web

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
        Command.CommandText = "DELETE FROM Empresa"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Empresa"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Empresa_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Empresa")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Empresa.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
