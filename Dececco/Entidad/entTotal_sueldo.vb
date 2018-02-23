Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Total_sueldo_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_total_sueldo As Int32
    Public ReadOnly Property id_total_sueldo() As Int32
        Get
            _id_total_sueldo = CInt(dr("id_total_sueldo"))
            Return _id_total_sueldo
        End Get
    end property

    Private _fecha As DateTime
    Public Property fecha() As DateTime
        Get
            _fecha = CDate(dr("fecha"))
            Return _fecha
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha") = Value
        End Set
    end property

    Private _id_empleado As Int32
    Public Property id_empleado() As Int32
        Get
            _id_empleado = CInt(dr("id_empleado"))
            Return _id_empleado
        End Get
        Set(ByVal Value As Int32)
            dr("id_empleado") = Value
        End Set
    end property

    Private _total_haber As Decimal
    Public Property total_haber() As Decimal
        Get
            _total_haber = CDec(dr("total_haber"))
            Return _total_haber
        End Get
        Set(ByVal Value As Decimal)
            dr("total_haber") = Value
        End Set
    end property

    Private _total_deduccion As Decimal
    Public Property total_deduccion() As Decimal
        Get
            _total_deduccion = CDec(dr("total_deduccion"))
            Return _total_deduccion
        End Get
        Set(ByVal Value As Decimal)
            dr("total_deduccion") = Value
        End Set
    end property

    Private _total_adicional As Decimal
    Public Property total_adicional() As Decimal
        Get
            _total_adicional = CDec(dr("total_adicional"))
            Return _total_adicional
        End Get
        Set(ByVal Value As Decimal)
            dr("total_adicional") = Value
        End Set
    end property

    Private _total_cobrar As Decimal
    Public Property total_cobrar() As Decimal
        Get
            _total_cobrar = CDec(dr("total_cobrar"))
            Return _total_cobrar
        End Get
        Set(ByVal Value As Decimal)
            dr("total_cobrar") = Value
        End Set
    end property

    Private _letra_sueldo As String
    Public Property letra_sueldo() As String
        Get
            _letra_sueldo = CStr(dr("letra_sueldo"))
            Return _letra_sueldo
        End Get
        Set(ByVal Value As String)
            dr("letra_sueldo") = Value
        End Set
    end property

    Private _periodo As String
    Public Property periodo() As String
        Get
            _periodo = CStr(dr("periodo"))
            Return _periodo
        End Get
        Set(ByVal Value As String)
            dr("periodo") = Value
        End Set
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

    Private _adicional_os As Decimal
    Public Property adicional_os() As Decimal
        Get
            _adicional_os = CDec(dr("adicional_os"))
            Return _adicional_os
        End Get
        Set(ByVal Value As Decimal)
            dr("adicional_os") = Value
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

    Private _antiguedad As Decimal
    Public Property antiguedad() As Decimal
        Get
            _antiguedad = CDec(dr("antiguedad"))
            Return _antiguedad
        End Get
        Set(ByVal Value As Decimal)
            dr("antiguedad") = Value
        End Set
    end property

    Private _especialidad As Decimal
    Public Property especialidad() As Decimal
        Get
            _especialidad = CDec(dr("especialidad"))
            Return _especialidad
        End Get
        Set(ByVal Value As Decimal)
            dr("especialidad") = Value
        End Set
    end property

    Private _tipo_sueldo As String
    Public Property tipo_sueldo() As String
        Get
            _tipo_sueldo = CStr(dr("tipo_sueldo"))
            Return _tipo_sueldo
        End Get
        Set(ByVal Value As String)
            dr("tipo_sueldo") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Total_sueldo")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Total_sueldo_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_total_sueldo", SqlDbType.int, 0, "id_total_sueldo")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        da.InsertCommand.Parameters.Add("@total_haber", SqlDbType.decimal, 9, "total_haber")
        da.InsertCommand.Parameters.Add("@total_deduccion", SqlDbType.decimal, 9, "total_deduccion")
        da.InsertCommand.Parameters.Add("@total_adicional", SqlDbType.decimal, 9, "total_adicional")
        da.InsertCommand.Parameters.Add("@total_cobrar", SqlDbType.decimal, 9, "total_cobrar")
        da.InsertCommand.Parameters.Add("@letra_sueldo", SqlDbType.varchar, 500, "letra_sueldo")
        da.InsertCommand.Parameters.Add("@periodo", SqlDbType.varchar, 50, "periodo")
        da.InsertCommand.Parameters.Add("@sueldo_sereno", SqlDbType.decimal, 9, "sueldo_sereno")
        da.InsertCommand.Parameters.Add("@contribucion_extraordinaria", SqlDbType.decimal, 9, "contribucion_extraordinaria")
        da.InsertCommand.Parameters.Add("@aporte_solidario", SqlDbType.decimal, 9, "aporte_solidario")
        da.InsertCommand.Parameters.Add("@ayuda_escolar", SqlDbType.decimal, 9, "ayuda_escolar")
        da.InsertCommand.Parameters.Add("@valor_discapacitado", SqlDbType.decimal, 9, "valor_discapacitado")
        da.InsertCommand.Parameters.Add("@hora_administrativo", SqlDbType.decimal, 9, "hora_administrativo")
        da.InsertCommand.Parameters.Add("@valor_embargo", SqlDbType.decimal, 9, "valor_embargo")
        da.InsertCommand.Parameters.Add("@valor_hora", SqlDbType.decimal, 9, "valor_hora")
        da.InsertCommand.Parameters.Add("@coordinador", SqlDbType.bit, 1, "coordinador")
        da.InsertCommand.Parameters.Add("@hijo", SqlDbType.decimal, 9, "hijo")
        da.InsertCommand.Parameters.Add("@valor_hijo", SqlDbType.decimal, 9, "valor_hijo")
        da.InsertCommand.Parameters.Add("@salario_mvm", SqlDbType.decimal, 9, "salario_mvm")
        da.InsertCommand.Parameters.Add("@adicional_os", SqlDbType.decimal, 9, "adicional_os")
        da.InsertCommand.Parameters.Add("@hijo_discapacitado", SqlDbType.decimal, 9, "hijo_discapacitado")
        da.InsertCommand.Parameters.Add("@antiguedad", SqlDbType.decimal, 9, "antiguedad")
        da.InsertCommand.Parameters.Add("@especialidad", SqlDbType.decimal, 9, "especialidad")
        da.InsertCommand.Parameters.Add("@tipo_sueldo", SqlDbType.char, 1, "tipo_sueldo")

        dr = dt.NewRow()
        dr("fecha") = DateTime.Now
        dr("id_empleado") = 0
        dr("total_haber") = 0
        dr("total_deduccion") = 0
        dr("total_adicional") = 0
        dr("total_cobrar") = 0
        dr("letra_sueldo") = ""
        dr("periodo") = ""
        dr("sueldo_sereno") = 0
        dr("contribucion_extraordinaria") = 0
        dr("aporte_solidario") = 0
        dr("ayuda_escolar") = 0
        dr("valor_discapacitado") = 0
        dr("hora_administrativo") = 0
        dr("valor_embargo") = 0
        dr("valor_hora") = 0
        dr("coordinador") = False
        dr("hijo") = 0
        dr("valor_hijo") = 0
        dr("salario_mvm") = 0
        dr("adicional_os") = 0
        dr("hijo_discapacitado") = 0
        dr("antiguedad") = 0
        dr("especialidad") = 0
        dr("tipo_sueldo") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTotal_sueldo As Integer)
        dt = New DataTable("Total_sueldo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Total_sueldo WHERE id_total_sueldo = @id_Total_sueldo", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Total_sueldo", idTotal_sueldo)
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
    Public Sub Borrar(ByVal idTotal_sueldo As Integer)
        dt = New DataTable("Total_sueldo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Total_sueldo WHERE id_total_sueldo = " & _
        idTotal_sueldo, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Total_sueldo_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_total_sueldo", SqlDbType.Int, 4, "id_total_sueldo")
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
               Case "id_total_sueldo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_empleado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "total_haber"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_deduccion"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_adicional"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_cobrar"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "letra_sueldo"
                  dc.DataType = Type.GetType("System.String")
               Case "periodo"
                  dc.DataType = Type.GetType("System.String")
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
               Case "adicional_os"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "hijo_discapacitado"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "antiguedad"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "especialidad"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "tipo_sueldo"
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
        dt = New DataTable("Total_sueldo")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Total_sueldo WHERE id_total_sueldo = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Total_sueldo_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Total_sueldo_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Total_sueldo_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Total_sueldo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Total_sueldo_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_total_sueldo", SqlDbType.Int, 4, "id_total_sueldo")
        oda.SelectCommand.Parameters("@id_total_sueldo").Value = id_Total_sueldo

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Total_sueldo_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = Me.id_empleado
        oda.SelectCommand.Parameters.Add("@total_haber", SqlDbType.decimal, 9, "total_haber")
        oda.SelectCommand.Parameters("@total_haber").Value = Me.total_haber
        oda.SelectCommand.Parameters.Add("@total_deduccion", SqlDbType.decimal, 9, "total_deduccion")
        oda.SelectCommand.Parameters("@total_deduccion").Value = Me.total_deduccion
        oda.SelectCommand.Parameters.Add("@total_adicional", SqlDbType.decimal, 9, "total_adicional")
        oda.SelectCommand.Parameters("@total_adicional").Value = Me.total_adicional
        oda.SelectCommand.Parameters.Add("@total_cobrar", SqlDbType.decimal, 9, "total_cobrar")
        oda.SelectCommand.Parameters("@total_cobrar").Value = Me.total_cobrar
        oda.SelectCommand.Parameters.Add("@letra_sueldo", SqlDbType.varchar, 500, "letra_sueldo")
        oda.SelectCommand.Parameters("@letra_sueldo").Value = Me.letra_sueldo
        oda.SelectCommand.Parameters.Add("@periodo", SqlDbType.varchar, 50, "periodo")
        oda.SelectCommand.Parameters("@periodo").Value = Me.periodo
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
        oda.SelectCommand.Parameters.Add("@adicional_os", SqlDbType.decimal, 9, "adicional_os")
        oda.SelectCommand.Parameters("@adicional_os").Value = Me.adicional_os
        oda.SelectCommand.Parameters.Add("@hijo_discapacitado", SqlDbType.decimal, 9, "hijo_discapacitado")
        oda.SelectCommand.Parameters("@hijo_discapacitado").Value = Me.hijo_discapacitado
        oda.SelectCommand.Parameters.Add("@antiguedad", SqlDbType.decimal, 9, "antiguedad")
        oda.SelectCommand.Parameters("@antiguedad").Value = Me.antiguedad
        oda.SelectCommand.Parameters.Add("@especialidad", SqlDbType.decimal, 9, "especialidad")
        oda.SelectCommand.Parameters("@especialidad").Value = Me.especialidad
        oda.SelectCommand.Parameters.Add("@tipo_sueldo", SqlDbType.char, 1, "tipo_sueldo")
        oda.SelectCommand.Parameters("@tipo_sueldo").Value = Me.tipo_sueldo

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
        Command.CommandText = "DELETE FROM Total_sueldo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Total_sueldo"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Total_sueldo_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Total_sueldo")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Total_sueldo.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
