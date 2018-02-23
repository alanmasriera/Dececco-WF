Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_factura
    Inherits Cuerpo_factura_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuerpo_factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_factura", SqlDbType.Int, 4, "id_cuerpo_factura")
        oda.SelectCommand.Parameters("@id_cuerpo_factura").Value = id_Cuerpo_factura

        oda.Fill(odt)
        Return odt
    End Function

    'FUNCION PARA CONSULTAR TODO
    Public Overloads Function ConsultarTodo(ByVal id_factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura

        oda.Fill(odt)

        Return odt
    End Function

    'FUNCION PARA CONSULTAR TODO
    Public Function UpdateFactura(ByVal id_factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_Update_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura

        oda.Fill(odt)

        Return odt
    End Function

    'suma de todos los elementos
    Public Function GetSum(ByVal id_factura As Integer) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_GetSum", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))
        Return Total
    End Function

    'borra el resto de los items
    Public Sub BorrarResto()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_DeleteCuerpo"

        Command.CommandType = CommandType.StoredProcedure
        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub

    'update para modificar la factura
    Public Sub Update_factura(ByVal id_factura As Integer, ByVal cantidad_item As Decimal, ByVal precio_item As Decimal, ByVal descripcion_item As String)

        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_UpdateFactura"
        Command.Parameters.Add("@cantidad_item", SqlDbType.Decimal, 9, "cantidad_item")
        Command.Parameters("@cantidad_item").Value = cantidad_item
        Command.Parameters.Add("@precio_item", SqlDbType.Decimal, 9, "precio_item")
        Command.Parameters("@precio_item").Value = precio_item
        Command.Parameters.Add("@descripcion_item", SqlDbType.VarChar, 5000, "descripcion_item")
        Command.Parameters("@descripcion_item").Value = descripcion_item
        Command.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        Command.Parameters("@id_factura").Value = id_factura

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'get all para la grilla de remitos
    Public Function GetAll_2(ByVal id_factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura

        oda.Fill(odt)

        Return odt
    End Function

    'modificar por numero de factura
    Public Sub ModificarPorFactura(ByVal id_factura As Integer)
        dt = New DataTable("Cuerpo_factura")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_factura WHERE id_factura = " & _
        id_factura, cnn.Coneccion)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se a encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        CrearComandoUpdate()
    End Sub

    Public Function ConsultarTodo_2(ByVal id_factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura

        oda.Fill(odt)

        Return odt
    End Function

End Class
