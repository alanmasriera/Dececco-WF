Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Proveedor_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_proveedor As Int32
    Public ReadOnly Property id_proveedor() As Int32
        Get
            _id_proveedor = CInt(dr("id_proveedor"))
            Return _id_proveedor
        End Get
    end property

    Private _nombre_proveedor As String
    Public Property nombre_proveedor() As String
        Get
            _nombre_proveedor = CStr(dr("nombre_proveedor"))
            Return _nombre_proveedor
        End Get
        Set(ByVal Value As String)
            dr("nombre_proveedor") = Value
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

    Private _cuit As String
    Public Property cuit() As String
        Get
            _cuit = CStr(dr("cuit"))
            Return _cuit
        End Get
        Set(ByVal Value As String)
            dr("cuit") = Value
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

    Private _localidad As String
    Public Property localidad() As String
        Get
            _localidad = CStr(dr("localidad"))
            Return _localidad
        End Get
        Set(ByVal Value As String)
            dr("localidad") = Value
        End Set
    end property

    Private _provincia As String
    Public Property provincia() As String
        Get
            _provincia = CStr(dr("provincia"))
            Return _provincia
        End Get
        Set(ByVal Value As String)
            dr("provincia") = Value
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

    Private _id_condicion_iva As Int32
    Public Property id_condicion_iva() As Int32
        Get
            _id_condicion_iva = CInt(dr("id_condicion_iva"))
            Return _id_condicion_iva
        End Get
        Set(ByVal Value As Int32)
            dr("id_condicion_iva") = Value
        End Set
    end property

    Private _id_tipo_proveedor As Int32
    Public Property id_tipo_proveedor() As Int32
        Get
            _id_tipo_proveedor = CInt(dr("id_tipo_proveedor"))
            Return _id_tipo_proveedor
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_proveedor") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Proveedor")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Proveedor_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 0, "id_proveedor")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_proveedor", SqlDbType.varchar, 50, "nombre_proveedor")
        da.InsertCommand.Parameters.Add("@contacto", SqlDbType.varchar, 50, "contacto")
        da.InsertCommand.Parameters.Add("@cuit", SqlDbType.varchar, 50, "cuit")
        da.InsertCommand.Parameters.Add("@ingreso_bruto", SqlDbType.varchar, 50, "ingreso_bruto")
        da.InsertCommand.Parameters.Add("@direccion", SqlDbType.varchar, 100, "direccion")
        da.InsertCommand.Parameters.Add("@localidad", SqlDbType.varchar, 50, "localidad")
        da.InsertCommand.Parameters.Add("@provincia", SqlDbType.varchar, 50, "provincia")
        da.InsertCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        da.InsertCommand.Parameters.Add("@email", SqlDbType.varchar, 50, "email")
        da.InsertCommand.Parameters.Add("@web", SqlDbType.varchar, 50, "web")
        da.InsertCommand.Parameters.Add("@id_condicion_iva", SqlDbType.int, 4, "id_condicion_iva")
        da.InsertCommand.Parameters.Add("@id_tipo_proveedor", SqlDbType.int, 4, "id_tipo_proveedor")

        dr = dt.NewRow()
        dr("nombre_proveedor") = ""
        dr("contacto") = ""
        dr("cuit") = ""
        dr("ingreso_bruto") = ""
        dr("direccion") = ""
        dr("localidad") = ""
        dr("provincia") = ""
        dr("telefono") = ""
        dr("email") = ""
        dr("web") = ""
        dr("id_condicion_iva") = 0
        dr("id_tipo_proveedor") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idProveedor As Integer)
        dt = New DataTable("Proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Proveedor WHERE id_proveedor = @id_Proveedor", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Proveedor", idProveedor)
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
    Public Sub Borrar(ByVal idProveedor As Integer)
        dt = New DataTable("Proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Proveedor WHERE id_proveedor = " & _
        idProveedor, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Proveedor_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
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
               Case "id_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_proveedor"
                  dc.DataType = Type.GetType("System.String")
               Case "contacto"
                  dc.DataType = Type.GetType("System.String")
               Case "cuit"
                  dc.DataType = Type.GetType("System.String")
               Case "ingreso_bruto"
                  dc.DataType = Type.GetType("System.String")
               Case "direccion"
                  dc.DataType = Type.GetType("System.String")
               Case "localidad"
                  dc.DataType = Type.GetType("System.String")
               Case "provincia"
                  dc.DataType = Type.GetType("System.String")
               Case "telefono"
                  dc.DataType = Type.GetType("System.String")
               Case "email"
                  dc.DataType = Type.GetType("System.String")
               Case "web"
                  dc.DataType = Type.GetType("System.String")
               Case "id_condicion_iva"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_tipo_proveedor"
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
        dt = New DataTable("Proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Proveedor WHERE id_proveedor = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proveedor_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proveedor_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proveedor_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proveedor_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_Proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proveedor_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_proveedor", SqlDbType.varchar, 50, "nombre_proveedor")
        oda.SelectCommand.Parameters("@nombre_proveedor").Value = Me.nombre_proveedor
        oda.SelectCommand.Parameters.Add("@contacto", SqlDbType.varchar, 50, "contacto")
        oda.SelectCommand.Parameters("@contacto").Value = Me.contacto
        oda.SelectCommand.Parameters.Add("@cuit", SqlDbType.varchar, 50, "cuit")
        oda.SelectCommand.Parameters("@cuit").Value = Me.cuit
        oda.SelectCommand.Parameters.Add("@ingreso_bruto", SqlDbType.varchar, 50, "ingreso_bruto")
        oda.SelectCommand.Parameters("@ingreso_bruto").Value = Me.ingreso_bruto
        oda.SelectCommand.Parameters.Add("@direccion", SqlDbType.varchar, 100, "direccion")
        oda.SelectCommand.Parameters("@direccion").Value = Me.direccion
        oda.SelectCommand.Parameters.Add("@localidad", SqlDbType.varchar, 50, "localidad")
        oda.SelectCommand.Parameters("@localidad").Value = Me.localidad
        oda.SelectCommand.Parameters.Add("@provincia", SqlDbType.varchar, 50, "provincia")
        oda.SelectCommand.Parameters("@provincia").Value = Me.provincia
        oda.SelectCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        oda.SelectCommand.Parameters("@telefono").Value = Me.telefono
        oda.SelectCommand.Parameters.Add("@email", SqlDbType.varchar, 50, "email")
        oda.SelectCommand.Parameters("@email").Value = Me.email
        oda.SelectCommand.Parameters.Add("@web", SqlDbType.varchar, 50, "web")
        oda.SelectCommand.Parameters("@web").Value = Me.web
        oda.SelectCommand.Parameters.Add("@id_condicion_iva", SqlDbType.int, 4, "id_condicion_iva")
        oda.SelectCommand.Parameters("@id_condicion_iva").Value = Me.id_condicion_iva
        oda.SelectCommand.Parameters.Add("@id_tipo_proveedor", SqlDbType.int, 4, "id_tipo_proveedor")
        oda.SelectCommand.Parameters("@id_tipo_proveedor").Value = Me.id_tipo_proveedor

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
        Command.CommandText = "DELETE FROM Proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Proveedor_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Proveedor")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Proveedor.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
