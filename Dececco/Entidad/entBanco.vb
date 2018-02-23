Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Banco_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_banco As Int32
    Public ReadOnly Property id_banco() As Int32
        Get
            _id_banco = CInt(dr("id_banco"))
            Return _id_banco
        End Get
    end property

    Private _nombre_banco As String
    Public Property nombre_banco() As String
        Get
            _nombre_banco = CStr(dr("nombre_banco"))
            Return _nombre_banco
        End Get
        Set(ByVal Value As String)
            dr("nombre_banco") = Value
        End Set
    end property

    Private _cuit_banco As String
    Public Property cuit_banco() As String
        Get
            _cuit_banco = CStr(dr("cuit_banco"))
            Return _cuit_banco
        End Get
        Set(ByVal Value As String)
            dr("cuit_banco") = Value
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

    Private _nombre_fantasia As String
    Public Property nombre_fantasia() As String
        Get
            _nombre_fantasia = CStr(dr("nombre_fantasia"))
            Return _nombre_fantasia
        End Get
        Set(ByVal Value As String)
            dr("nombre_fantasia") = Value
        End Set
    end property

    Private _id_calle As Int32
    Public Property id_calle() As Int32
        Get
            _id_calle = CInt(dr("id_calle"))
            Return _id_calle
        End Get
        Set(ByVal Value As Int32)
            dr("id_calle") = Value
        End Set
    end property

    Private _numero As String
    Public Property numero() As String
        Get
            _numero = CStr(dr("numero"))
            Return _numero
        End Get
        Set(ByVal Value As String)
            dr("numero") = Value
        End Set
    end property

    Private _id_localidad As Int32
    Public Property id_localidad() As Int32
        Get
            _id_localidad = CInt(dr("id_localidad"))
            Return _id_localidad
        End Get
        Set(ByVal Value As Int32)
            dr("id_localidad") = Value
        End Set
    end property

    Private _id_provincia As Int32
    Public Property id_provincia() As Int32
        Get
            _id_provincia = CInt(dr("id_provincia"))
            Return _id_provincia
        End Get
        Set(ByVal Value As Int32)
            dr("id_provincia") = Value
        End Set
    end property

    Private _iva As String
    Public Property iva() As String
        Get
            _iva = CStr(dr("iva"))
            Return _iva
        End Get
        Set(ByVal Value As String)
            dr("iva") = Value
        End Set
    end property

    Private _ingreso_bruto As String
    Public Property ingreso_bruto() As String
        Get
            _ingreso_bruto = CStr(dr("ingreso_bruto"))
            Return _ingreso_bruto
        End Get
        Set(ByVal Value As String)
            dr("ingreso_bruto") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Banco")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Banco_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_banco", SqlDbType.int, 0, "id_banco")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_banco", SqlDbType.varchar, 50, "nombre_banco")
        da.InsertCommand.Parameters.Add("@cuit_banco", SqlDbType.varchar, 50, "cuit_banco")
        da.InsertCommand.Parameters.Add("@direccion", SqlDbType.varchar, 500, "direccion")
        da.InsertCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        da.InsertCommand.Parameters.Add("@email", SqlDbType.varchar, 50, "email")
        da.InsertCommand.Parameters.Add("@pagina_web", SqlDbType.varchar, 50, "pagina_web")
        da.InsertCommand.Parameters.Add("@nombre_fantasia", SqlDbType.varchar, 50, "nombre_fantasia")
        da.InsertCommand.Parameters.Add("@id_calle", SqlDbType.int, 4, "id_calle")
        da.InsertCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        da.InsertCommand.Parameters.Add("@id_localidad", SqlDbType.int, 4, "id_localidad")
        da.InsertCommand.Parameters.Add("@id_provincia", SqlDbType.int, 4, "id_provincia")
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.varchar, 50, "iva")
        da.InsertCommand.Parameters.Add("@ingreso_bruto", SqlDbType.varchar, 50, "ingreso_bruto")
        da.InsertCommand.Parameters.Add("@contacto", SqlDbType.varchar, 50, "contacto")

        dr = dt.NewRow()
        dr("nombre_banco") = ""
        dr("cuit_banco") = ""
        dr("direccion") = ""
        dr("telefono") = ""
        dr("email") = ""
        dr("pagina_web") = ""
        dr("nombre_fantasia") = ""
        dr("id_calle") = 0
        dr("numero") = ""
        dr("id_localidad") = 0
        dr("id_provincia") = 0
        dr("iva") = ""
        dr("ingreso_bruto") = ""
        dr("contacto") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idBanco As Integer)
        dt = New DataTable("Banco")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Banco WHERE id_banco = @id_Banco", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Banco", idBanco)
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
    Public Sub Borrar(ByVal idBanco As Integer)
        dt = New DataTable("Banco")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Banco WHERE id_banco = " & _
        idBanco, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Banco_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_banco", SqlDbType.Int, 4, "id_banco")
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
               Case "id_banco"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_banco"
                  dc.DataType = Type.GetType("System.String")
               Case "cuit_banco"
                  dc.DataType = Type.GetType("System.String")
               Case "direccion"
                  dc.DataType = Type.GetType("System.String")
               Case "telefono"
                  dc.DataType = Type.GetType("System.String")
               Case "email"
                  dc.DataType = Type.GetType("System.String")
               Case "pagina_web"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre_fantasia"
                  dc.DataType = Type.GetType("System.String")
               Case "id_calle"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero"
                  dc.DataType = Type.GetType("System.String")
               Case "id_localidad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_provincia"
                  dc.DataType = Type.GetType("System.Int32")
               Case "iva"
                  dc.DataType = Type.GetType("System.String")
               Case "ingreso_bruto"
                  dc.DataType = Type.GetType("System.String")
               Case "contacto"
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
        dt = New DataTable("Banco")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Banco WHERE id_banco = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Banco_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Banco_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Banco_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Banco As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Banco_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@id_banco").Value = id_Banco

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Banco_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_banco", SqlDbType.varchar, 50, "nombre_banco")
        oda.SelectCommand.Parameters("@nombre_banco").Value = Me.nombre_banco
        oda.SelectCommand.Parameters.Add("@cuit_banco", SqlDbType.varchar, 50, "cuit_banco")
        oda.SelectCommand.Parameters("@cuit_banco").Value = Me.cuit_banco
        oda.SelectCommand.Parameters.Add("@direccion", SqlDbType.varchar, 500, "direccion")
        oda.SelectCommand.Parameters("@direccion").Value = Me.direccion
        oda.SelectCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        oda.SelectCommand.Parameters("@telefono").Value = Me.telefono
        oda.SelectCommand.Parameters.Add("@email", SqlDbType.varchar, 50, "email")
        oda.SelectCommand.Parameters("@email").Value = Me.email
        oda.SelectCommand.Parameters.Add("@pagina_web", SqlDbType.varchar, 50, "pagina_web")
        oda.SelectCommand.Parameters("@pagina_web").Value = Me.pagina_web
        oda.SelectCommand.Parameters.Add("@nombre_fantasia", SqlDbType.varchar, 50, "nombre_fantasia")
        oda.SelectCommand.Parameters("@nombre_fantasia").Value = Me.nombre_fantasia
        oda.SelectCommand.Parameters.Add("@id_calle", SqlDbType.int, 4, "id_calle")
        oda.SelectCommand.Parameters("@id_calle").Value = Me.id_calle
        oda.SelectCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        oda.SelectCommand.Parameters("@numero").Value = Me.numero
        oda.SelectCommand.Parameters.Add("@id_localidad", SqlDbType.int, 4, "id_localidad")
        oda.SelectCommand.Parameters("@id_localidad").Value = Me.id_localidad
        oda.SelectCommand.Parameters.Add("@id_provincia", SqlDbType.int, 4, "id_provincia")
        oda.SelectCommand.Parameters("@id_provincia").Value = Me.id_provincia
        oda.SelectCommand.Parameters.Add("@iva", SqlDbType.varchar, 50, "iva")
        oda.SelectCommand.Parameters("@iva").Value = Me.iva
        oda.SelectCommand.Parameters.Add("@ingreso_bruto", SqlDbType.varchar, 50, "ingreso_bruto")
        oda.SelectCommand.Parameters("@ingreso_bruto").Value = Me.ingreso_bruto
        oda.SelectCommand.Parameters.Add("@contacto", SqlDbType.varchar, 50, "contacto")
        oda.SelectCommand.Parameters("@contacto").Value = Me.contacto

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
        Command.CommandText = "DELETE FROM Banco"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Banco"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Banco_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Banco")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Banco.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
