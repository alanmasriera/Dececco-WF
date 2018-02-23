Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Empleado_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_empleado As Int32
    Public ReadOnly Property id_empleado() As Int32
        Get
            _id_empleado = CInt(dr("id_empleado"))
            Return _id_empleado
        End Get
    end property

    Private _legajo As String
    Public Property legajo() As String
        Get
            _legajo = CStr(dr("legajo"))
            Return _legajo
        End Get
        Set(ByVal Value As String)
            dr("legajo") = Value
        End Set
    end property

    Private _apellido As String
    Public Property apellido() As String
        Get
            _apellido = CStr(dr("apellido"))
            Return _apellido
        End Get
        Set(ByVal Value As String)
            dr("apellido") = Value
        End Set
    end property

    Private _nombre As String
    Public Property nombre() As String
        Get
            _nombre = CStr(dr("nombre"))
            Return _nombre
        End Get
        Set(ByVal Value As String)
            dr("nombre") = Value
        End Set
    end property

    Private _cuil As String
    Public Property cuil() As String
        Get
            _cuil = CStr(dr("cuil"))
            Return _cuil
        End Get
        Set(ByVal Value As String)
            dr("cuil") = Value
        End Set
    end property

    Private _nacimiento As DateTime
    Public Property nacimiento() As DateTime
        Get
            _nacimiento = CDate(dr("nacimiento"))
            Return _nacimiento
        End Get
        Set(ByVal Value As DateTime)
            dr("nacimiento") = Value
        End Set
    end property

    Private _domicilio As String
    Public Property domicilio() As String
        Get
            _domicilio = CStr(dr("domicilio"))
            Return _domicilio
        End Get
        Set(ByVal Value As String)
            dr("domicilio") = Value
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

    Private _cp As String
    Public Property cp() As String
        Get
            _cp = CStr(dr("cp"))
            Return _cp
        End Get
        Set(ByVal Value As String)
            dr("cp") = Value
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

    Private _nacionalidad As String
    Public Property nacionalidad() As String
        Get
            _nacionalidad = CStr(dr("nacionalidad"))
            Return _nacionalidad
        End Get
        Set(ByVal Value As String)
            dr("nacionalidad") = Value
        End Set
    end property

    Private _estado_civil As String
    Public Property estado_civil() As String
        Get
            _estado_civil = CStr(dr("estado_civil"))
            Return _estado_civil
        End Get
        Set(ByVal Value As String)
            dr("estado_civil") = Value
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

    Private _casamiento As DateTime
    Public Property casamiento() As DateTime
        Get
            _casamiento = CDate(dr("casamiento"))
            Return _casamiento
        End Get
        Set(ByVal Value As DateTime)
            dr("casamiento") = Value
        End Set
    end property

    Private _lugar_nacimiento As String
    Public Property lugar_nacimiento() As String
        Get
            _lugar_nacimiento = CStr(dr("lugar_nacimiento"))
            Return _lugar_nacimiento
        End Get
        Set(ByVal Value As String)
            dr("lugar_nacimiento") = Value
        End Set
    end property

    Private _apellido_conyugue As String
    Public Property apellido_conyugue() As String
        Get
            _apellido_conyugue = CStr(dr("apellido_conyugue"))
            Return _apellido_conyugue
        End Get
        Set(ByVal Value As String)
            dr("apellido_conyugue") = Value
        End Set
    end property

    Private _nombre_conyugue As String
    Public Property nombre_conyugue() As String
        Get
            _nombre_conyugue = CStr(dr("nombre_conyugue"))
            Return _nombre_conyugue
        End Get
        Set(ByVal Value As String)
            dr("nombre_conyugue") = Value
        End Set
    end property

    Private _apellido_casado As String
    Public Property apellido_casado() As String
        Get
            _apellido_casado = CStr(dr("apellido_casado"))
            Return _apellido_casado
        End Get
        Set(ByVal Value As String)
            dr("apellido_casado") = Value
        End Set
    end property

    Private _dni_conyugue As String
    Public Property dni_conyugue() As String
        Get
            _dni_conyugue = CStr(dr("dni_conyugue"))
            Return _dni_conyugue
        End Get
        Set(ByVal Value As String)
            dr("dni_conyugue") = Value
        End Set
    end property

    Private _apellido_beneficiario As String
    Public Property apellido_beneficiario() As String
        Get
            _apellido_beneficiario = CStr(dr("apellido_beneficiario"))
            Return _apellido_beneficiario
        End Get
        Set(ByVal Value As String)
            dr("apellido_beneficiario") = Value
        End Set
    end property

    Private _nombre_beneficiario As String
    Public Property nombre_beneficiario() As String
        Get
            _nombre_beneficiario = CStr(dr("nombre_beneficiario"))
            Return _nombre_beneficiario
        End Get
        Set(ByVal Value As String)
            dr("nombre_beneficiario") = Value
        End Set
    end property

    Private _dni_beneficiario As String
    Public Property dni_beneficiario() As String
        Get
            _dni_beneficiario = CStr(dr("dni_beneficiario"))
            Return _dni_beneficiario
        End Get
        Set(ByVal Value As String)
            dr("dni_beneficiario") = Value
        End Set
    end property

    Private _ingreso As DateTime
    Public Property ingreso() As DateTime
        Get
            _ingreso = CDate(dr("ingreso"))
            Return _ingreso
        End Get
        Set(ByVal Value As DateTime)
            dr("ingreso") = Value
        End Set
    end property

    Private _reviza As DateTime
    Public Property reviza() As DateTime
        Get
            _reviza = CDate(dr("reviza"))
            Return _reviza
        End Get
        Set(ByVal Value As DateTime)
            dr("reviza") = Value
        End Set
    end property

    Private _desabilitado As Boolean
    Public Property desabilitado() As Boolean
        Get
            _desabilitado = CBool(dr("desabilitado"))
            Return _desabilitado
        End Get
        Set(ByVal Value As Boolean)
            dr("desabilitado") = Value
        End Set
    end property

    Private _id_tipo_empleado As Int32
    Public Property id_tipo_empleado() As Int32
        Get
            _id_tipo_empleado = CInt(dr("id_tipo_empleado"))
            Return _id_tipo_empleado
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_empleado") = Value
        End Set
    end property

    Private _sexo As String
    Public Property sexo() As String
        Get
            _sexo = CStr(dr("sexo"))
            Return _sexo
        End Get
        Set(ByVal Value As String)
            dr("sexo") = Value
        End Set
    end property

    Private _pais As String
    Public Property pais() As String
        Get
            _pais = CStr(dr("pais"))
            Return _pais
        End Get
        Set(ByVal Value As String)
            dr("pais") = Value
        End Set
    end property

    Private _dni As String
    Public Property dni() As String
        Get
            _dni = CStr(dr("dni"))
            Return _dni
        End Get
        Set(ByVal Value As String)
            dr("dni") = Value
        End Set
    end property

    Private _tipo_dni As String
    Public Property tipo_dni() As String
        Get
            _tipo_dni = CStr(dr("tipo_dni"))
            Return _tipo_dni
        End Get
        Set(ByVal Value As String)
            dr("tipo_dni") = Value
        End Set
    end property

    Private _egreso As DateTime
    Public Property egreso() As DateTime
        Get
            _egreso = CDate(dr("egreso"))
            Return _egreso
        End Get
        Set(ByVal Value As DateTime)
            dr("egreso") = Value
        End Set
    end property

    Private _modalidad_trabajo As String
    Public Property modalidad_trabajo() As String
        Get
            _modalidad_trabajo = CStr(dr("modalidad_trabajo"))
            Return _modalidad_trabajo
        End Get
        Set(ByVal Value As String)
            dr("modalidad_trabajo") = Value
        End Set
    end property

    Private _id_obra_social As Int32
    Public Property id_obra_social() As Int32
        Get
            _id_obra_social = CInt(dr("id_obra_social"))
            Return _id_obra_social
        End Get
        Set(ByVal Value As Int32)
            dr("id_obra_social") = Value
        End Set
    end property

    Private _tarea As String
    Public Property tarea() As String
        Get
            _tarea = CStr(dr("tarea"))
            Return _tarea
        End Get
        Set(ByVal Value As String)
            dr("tarea") = Value
        End Set
    end property

    Private _valor_hora As Decimal
    Public Property valor_hora() As Decimal
        Get
            _valor_hora = CDec(dr("valor_hora"))
            Return _valor_hora
        End Get
        Set(ByVal Value As Decimal)
            dr("valor_hora") = Value
        End Set
    end property

    Private _coordinador As Boolean
    Public Property coordinador() As Boolean
        Get
            _coordinador = CBool(dr("coordinador"))
            Return _coordinador
        End Get
        Set(ByVal Value As Boolean)
            dr("coordinador") = Value
        End Set
    end property

    Private _hijo As Decimal
    Public Property hijo() As Decimal
        Get
            _hijo = CDec(dr("hijo"))
            Return _hijo
        End Get
        Set(ByVal Value As Decimal)
            dr("hijo") = Value
        End Set
    end property

    Private _valor_hijo As Decimal
    Public Property valor_hijo() As Decimal
        Get
            _valor_hijo = CDec(dr("valor_hijo"))
            Return _valor_hijo
        End Get
        Set(ByVal Value As Decimal)
            dr("valor_hijo") = Value
        End Set
    end property

    Private _salario_mvm As Decimal
    Public Property salario_mvm() As Decimal
        Get
            _salario_mvm = CDec(dr("salario_mvm"))
            Return _salario_mvm
        End Get
        Set(ByVal Value As Decimal)
            dr("salario_mvm") = Value
        End Set
    end property

    Private _adicional_obra_social As Decimal
    Public Property adicional_obra_social() As Decimal
        Get
            _adicional_obra_social = CDec(dr("adicional_obra_social"))
            Return _adicional_obra_social
        End Get
        Set(ByVal Value As Decimal)
            dr("adicional_obra_social") = Value
        End Set
    end property

    Private _hijo_discapacitado As Decimal
    Public Property hijo_discapacitado() As Decimal
        Get
            _hijo_discapacitado = CDec(dr("hijo_discapacitado"))
            Return _hijo_discapacitado
        End Get
        Set(ByVal Value As Decimal)
            dr("hijo_discapacitado") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Empleado")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Empleado_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_empleado", SqlDbType.int, 0, "id_empleado")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@legajo", SqlDbType.varchar, 50, "legajo")
        da.InsertCommand.Parameters.Add("@apellido", SqlDbType.varchar, 50, "apellido")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        da.InsertCommand.Parameters.Add("@cuil", SqlDbType.varchar, 50, "cuil")
        da.InsertCommand.Parameters.Add("@nacimiento", SqlDbType.datetime, 8, "nacimiento")
        da.InsertCommand.Parameters.Add("@domicilio", SqlDbType.varchar, 50, "domicilio")
        da.InsertCommand.Parameters.Add("@localidad", SqlDbType.varchar, 50, "localidad")
        da.InsertCommand.Parameters.Add("@cp", SqlDbType.varchar, 50, "cp")
        da.InsertCommand.Parameters.Add("@provincia", SqlDbType.varchar, 50, "provincia")
        da.InsertCommand.Parameters.Add("@nacionalidad", SqlDbType.varchar, 50, "nacionalidad")
        da.InsertCommand.Parameters.Add("@estado_civil", SqlDbType.varchar, 50, "estado_civil")
        da.InsertCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        da.InsertCommand.Parameters.Add("@casamiento", SqlDbType.datetime, 8, "casamiento")
        da.InsertCommand.Parameters.Add("@lugar_nacimiento", SqlDbType.varchar, 50, "lugar_nacimiento")
        da.InsertCommand.Parameters.Add("@apellido_conyugue", SqlDbType.varchar, 50, "apellido_conyugue")
        da.InsertCommand.Parameters.Add("@nombre_conyugue", SqlDbType.varchar, 50, "nombre_conyugue")
        da.InsertCommand.Parameters.Add("@apellido_casado", SqlDbType.varchar, 50, "apellido_casado")
        da.InsertCommand.Parameters.Add("@dni_conyugue", SqlDbType.varchar, 50, "dni_conyugue")
        da.InsertCommand.Parameters.Add("@apellido_beneficiario", SqlDbType.varchar, 50, "apellido_beneficiario")
        da.InsertCommand.Parameters.Add("@nombre_beneficiario", SqlDbType.varchar, 50, "nombre_beneficiario")
        da.InsertCommand.Parameters.Add("@dni_beneficiario", SqlDbType.varchar, 50, "dni_beneficiario")
        da.InsertCommand.Parameters.Add("@ingreso", SqlDbType.datetime, 8, "ingreso")
        da.InsertCommand.Parameters.Add("@reviza", SqlDbType.datetime, 8, "reviza")
        da.InsertCommand.Parameters.Add("@desabilitado", SqlDbType.bit, 1, "desabilitado")
        da.InsertCommand.Parameters.Add("@id_tipo_empleado", SqlDbType.int, 4, "id_tipo_empleado")
        da.InsertCommand.Parameters.Add("@sexo", SqlDbType.char, 1, "sexo")
        da.InsertCommand.Parameters.Add("@pais", SqlDbType.char, 1, "pais")
        da.InsertCommand.Parameters.Add("@dni", SqlDbType.varchar, 50, "dni")
        da.InsertCommand.Parameters.Add("@tipo_dni", SqlDbType.varchar, 50, "tipo_dni")
        da.InsertCommand.Parameters.Add("@egreso", SqlDbType.datetime, 8, "egreso")
        da.InsertCommand.Parameters.Add("@modalidad_trabajo", SqlDbType.varchar, 50, "modalidad_trabajo")
        da.InsertCommand.Parameters.Add("@id_obra_social", SqlDbType.int, 4, "id_obra_social")
        da.InsertCommand.Parameters.Add("@tarea", SqlDbType.varchar, 50, "tarea")
        da.InsertCommand.Parameters.Add("@valor_hora", SqlDbType.decimal, 9, "valor_hora")
        da.InsertCommand.Parameters.Add("@coordinador", SqlDbType.bit, 1, "coordinador")
        da.InsertCommand.Parameters.Add("@hijo", SqlDbType.decimal, 9, "hijo")
        da.InsertCommand.Parameters.Add("@valor_hijo", SqlDbType.decimal, 9, "valor_hijo")
        da.InsertCommand.Parameters.Add("@salario_mvm", SqlDbType.decimal, 9, "salario_mvm")
        da.InsertCommand.Parameters.Add("@adicional_obra_social", SqlDbType.decimal, 9, "adicional_obra_social")
        da.InsertCommand.Parameters.Add("@hijo_discapacitado", SqlDbType.decimal, 9, "hijo_discapacitado")

        dr = dt.NewRow()
        dr("legajo") = ""
        dr("apellido") = ""
        dr("nombre") = ""
        dr("cuil") = ""
        dr("nacimiento") = DateTime.Now
        dr("domicilio") = ""
        dr("localidad") = ""
        dr("cp") = ""
        dr("provincia") = ""
        dr("nacionalidad") = ""
        dr("estado_civil") = ""
        dr("telefono") = ""
        dr("casamiento") = DateTime.Now
        dr("lugar_nacimiento") = ""
        dr("apellido_conyugue") = ""
        dr("nombre_conyugue") = ""
        dr("apellido_casado") = ""
        dr("dni_conyugue") = ""
        dr("apellido_beneficiario") = ""
        dr("nombre_beneficiario") = ""
        dr("dni_beneficiario") = ""
        dr("ingreso") = DateTime.Now
        dr("reviza") = DateTime.Now
        dr("desabilitado") = False
        dr("id_tipo_empleado") = 0
        dr("sexo") = ""
        dr("pais") = ""
        dr("dni") = ""
        dr("tipo_dni") = ""
        dr("egreso") = DateTime.Now
        dr("modalidad_trabajo") = ""
        dr("id_obra_social") = 0
        dr("tarea") = ""
        dr("valor_hora") = 0
        dr("coordinador") = False
        dr("hijo") = 0
        dr("valor_hijo") = 0
        dr("salario_mvm") = 0
        dr("adicional_obra_social") = 0
        dr("hijo_discapacitado") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idEmpleado As Integer)
        dt = New DataTable("Empleado")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Empleado WHERE id_empleado = @id_Empleado", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Empleado", idEmpleado)
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
    Public Sub Borrar(ByVal idEmpleado As Integer)
        dt = New DataTable("Empleado")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Empleado WHERE id_empleado = " & _
        idEmpleado, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Empleado_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
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
               Case "id_empleado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "legajo"
                  dc.DataType = Type.GetType("System.String")
               Case "apellido"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre"
                  dc.DataType = Type.GetType("System.String")
               Case "cuil"
                  dc.DataType = Type.GetType("System.String")
               Case "nacimiento"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "domicilio"
                  dc.DataType = Type.GetType("System.String")
               Case "localidad"
                  dc.DataType = Type.GetType("System.String")
               Case "cp"
                  dc.DataType = Type.GetType("System.String")
               Case "provincia"
                  dc.DataType = Type.GetType("System.String")
               Case "nacionalidad"
                  dc.DataType = Type.GetType("System.String")
               Case "estado_civil"
                  dc.DataType = Type.GetType("System.String")
               Case "telefono"
                  dc.DataType = Type.GetType("System.String")
               Case "casamiento"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "lugar_nacimiento"
                  dc.DataType = Type.GetType("System.String")
               Case "apellido_conyugue"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre_conyugue"
                  dc.DataType = Type.GetType("System.String")
               Case "apellido_casado"
                  dc.DataType = Type.GetType("System.String")
               Case "dni_conyugue"
                  dc.DataType = Type.GetType("System.String")
               Case "apellido_beneficiario"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre_beneficiario"
                  dc.DataType = Type.GetType("System.String")
               Case "dni_beneficiario"
                  dc.DataType = Type.GetType("System.String")
               Case "ingreso"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "reviza"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "desabilitado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_tipo_empleado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "sexo"
                  dc.DataType = Type.GetType("System.String")
               Case "pais"
                  dc.DataType = Type.GetType("System.String")
               Case "dni"
                  dc.DataType = Type.GetType("System.String")
               Case "tipo_dni"
                  dc.DataType = Type.GetType("System.String")
               Case "egreso"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "modalidad_trabajo"
                  dc.DataType = Type.GetType("System.String")
               Case "id_obra_social"
                  dc.DataType = Type.GetType("System.Int32")
               Case "tarea"
                  dc.DataType = Type.GetType("System.String")
               Case "valor_hora"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "coordinador"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "hijo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "valor_hijo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "salario_mvm"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "adicional_obra_social"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "hijo_discapacitado"
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
        dt = New DataTable("Empleado")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Empleado WHERE id_empleado = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Empleado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_Empleado

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@legajo", SqlDbType.varchar, 50, "legajo")
        oda.SelectCommand.Parameters("@legajo").Value = Me.legajo
        oda.SelectCommand.Parameters.Add("@apellido", SqlDbType.varchar, 50, "apellido")
        oda.SelectCommand.Parameters("@apellido").Value = Me.apellido
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Me.nombre
        oda.SelectCommand.Parameters.Add("@cuil", SqlDbType.varchar, 50, "cuil")
        oda.SelectCommand.Parameters("@cuil").Value = Me.cuil
        oda.SelectCommand.Parameters.Add("@nacimiento", SqlDbType.datetime, 8, "nacimiento")
        oda.SelectCommand.Parameters("@nacimiento").Value = Me.nacimiento
        oda.SelectCommand.Parameters.Add("@domicilio", SqlDbType.varchar, 50, "domicilio")
        oda.SelectCommand.Parameters("@domicilio").Value = Me.domicilio
        oda.SelectCommand.Parameters.Add("@localidad", SqlDbType.varchar, 50, "localidad")
        oda.SelectCommand.Parameters("@localidad").Value = Me.localidad
        oda.SelectCommand.Parameters.Add("@cp", SqlDbType.varchar, 50, "cp")
        oda.SelectCommand.Parameters("@cp").Value = Me.cp
        oda.SelectCommand.Parameters.Add("@provincia", SqlDbType.varchar, 50, "provincia")
        oda.SelectCommand.Parameters("@provincia").Value = Me.provincia
        oda.SelectCommand.Parameters.Add("@nacionalidad", SqlDbType.varchar, 50, "nacionalidad")
        oda.SelectCommand.Parameters("@nacionalidad").Value = Me.nacionalidad
        oda.SelectCommand.Parameters.Add("@estado_civil", SqlDbType.varchar, 50, "estado_civil")
        oda.SelectCommand.Parameters("@estado_civil").Value = Me.estado_civil
        oda.SelectCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        oda.SelectCommand.Parameters("@telefono").Value = Me.telefono
        oda.SelectCommand.Parameters.Add("@casamiento", SqlDbType.datetime, 8, "casamiento")
        oda.SelectCommand.Parameters("@casamiento").Value = Me.casamiento
        oda.SelectCommand.Parameters.Add("@lugar_nacimiento", SqlDbType.varchar, 50, "lugar_nacimiento")
        oda.SelectCommand.Parameters("@lugar_nacimiento").Value = Me.lugar_nacimiento
        oda.SelectCommand.Parameters.Add("@apellido_conyugue", SqlDbType.varchar, 50, "apellido_conyugue")
        oda.SelectCommand.Parameters("@apellido_conyugue").Value = Me.apellido_conyugue
        oda.SelectCommand.Parameters.Add("@nombre_conyugue", SqlDbType.varchar, 50, "nombre_conyugue")
        oda.SelectCommand.Parameters("@nombre_conyugue").Value = Me.nombre_conyugue
        oda.SelectCommand.Parameters.Add("@apellido_casado", SqlDbType.varchar, 50, "apellido_casado")
        oda.SelectCommand.Parameters("@apellido_casado").Value = Me.apellido_casado
        oda.SelectCommand.Parameters.Add("@dni_conyugue", SqlDbType.varchar, 50, "dni_conyugue")
        oda.SelectCommand.Parameters("@dni_conyugue").Value = Me.dni_conyugue
        oda.SelectCommand.Parameters.Add("@apellido_beneficiario", SqlDbType.varchar, 50, "apellido_beneficiario")
        oda.SelectCommand.Parameters("@apellido_beneficiario").Value = Me.apellido_beneficiario
        oda.SelectCommand.Parameters.Add("@nombre_beneficiario", SqlDbType.varchar, 50, "nombre_beneficiario")
        oda.SelectCommand.Parameters("@nombre_beneficiario").Value = Me.nombre_beneficiario
        oda.SelectCommand.Parameters.Add("@dni_beneficiario", SqlDbType.varchar, 50, "dni_beneficiario")
        oda.SelectCommand.Parameters("@dni_beneficiario").Value = Me.dni_beneficiario
        oda.SelectCommand.Parameters.Add("@ingreso", SqlDbType.datetime, 8, "ingreso")
        oda.SelectCommand.Parameters("@ingreso").Value = Me.ingreso
        oda.SelectCommand.Parameters.Add("@reviza", SqlDbType.datetime, 8, "reviza")
        oda.SelectCommand.Parameters("@reviza").Value = Me.reviza
        oda.SelectCommand.Parameters.Add("@desabilitado", SqlDbType.bit, 1, "desabilitado")
        oda.SelectCommand.Parameters("@desabilitado").Value = Me.desabilitado
        oda.SelectCommand.Parameters.Add("@id_tipo_empleado", SqlDbType.int, 4, "id_tipo_empleado")
        oda.SelectCommand.Parameters("@id_tipo_empleado").Value = Me.id_tipo_empleado
        oda.SelectCommand.Parameters.Add("@sexo", SqlDbType.char, 1, "sexo")
        oda.SelectCommand.Parameters("@sexo").Value = Me.sexo
        oda.SelectCommand.Parameters.Add("@pais", SqlDbType.char, 1, "pais")
        oda.SelectCommand.Parameters("@pais").Value = Me.pais
        oda.SelectCommand.Parameters.Add("@dni", SqlDbType.varchar, 50, "dni")
        oda.SelectCommand.Parameters("@dni").Value = Me.dni
        oda.SelectCommand.Parameters.Add("@tipo_dni", SqlDbType.varchar, 50, "tipo_dni")
        oda.SelectCommand.Parameters("@tipo_dni").Value = Me.tipo_dni
        oda.SelectCommand.Parameters.Add("@egreso", SqlDbType.datetime, 8, "egreso")
        oda.SelectCommand.Parameters("@egreso").Value = Me.egreso
        oda.SelectCommand.Parameters.Add("@modalidad_trabajo", SqlDbType.varchar, 50, "modalidad_trabajo")
        oda.SelectCommand.Parameters("@modalidad_trabajo").Value = Me.modalidad_trabajo
        oda.SelectCommand.Parameters.Add("@id_obra_social", SqlDbType.int, 4, "id_obra_social")
        oda.SelectCommand.Parameters("@id_obra_social").Value = Me.id_obra_social
        oda.SelectCommand.Parameters.Add("@tarea", SqlDbType.varchar, 50, "tarea")
        oda.SelectCommand.Parameters("@tarea").Value = Me.tarea
        oda.SelectCommand.Parameters.Add("@valor_hora", SqlDbType.decimal, 9, "valor_hora")
        oda.SelectCommand.Parameters("@valor_hora").Value = Me.valor_hora
        oda.SelectCommand.Parameters.Add("@coordinador", SqlDbType.bit, 1, "coordinador")
        oda.SelectCommand.Parameters("@coordinador").Value = Me.coordinador
        oda.SelectCommand.Parameters.Add("@hijo", SqlDbType.decimal, 9, "hijo")
        oda.SelectCommand.Parameters("@hijo").Value = Me.hijo
        oda.SelectCommand.Parameters.Add("@valor_hijo", SqlDbType.decimal, 9, "valor_hijo")
        oda.SelectCommand.Parameters("@valor_hijo").Value = Me.valor_hijo
        oda.SelectCommand.Parameters.Add("@salario_mvm", SqlDbType.decimal, 9, "salario_mvm")
        oda.SelectCommand.Parameters("@salario_mvm").Value = Me.salario_mvm
        oda.SelectCommand.Parameters.Add("@adicional_obra_social", SqlDbType.decimal, 9, "adicional_obra_social")
        oda.SelectCommand.Parameters("@adicional_obra_social").Value = Me.adicional_obra_social
        oda.SelectCommand.Parameters.Add("@hijo_discapacitado", SqlDbType.decimal, 9, "hijo_discapacitado")
        oda.SelectCommand.Parameters("@hijo_discapacitado").Value = Me.hijo_discapacitado

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
        Command.CommandText = "DELETE FROM Empleado"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Empleado"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Empleado_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Empleado")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Empleado.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
