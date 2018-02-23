Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Movimiento_libro
    Inherits Movimiento_libro_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Movimiento_libro As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_libro", cnn.Coneccion)


        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_libro", SqlDbType.Int, 4, "id_movimiento_libro")
        oda.SelectCommand.Parameters("@id_movimiento_libro").Value = id_Movimiento_libro

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub moverAsiento(ByVal numero_asiento_nvo As Integer, ByVal id_Movimiento_libro As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Movimiento_libro_Update_2"
        Command.Parameters.Add("@id_movimiento_libro", SqlDbType.Int, 4, "id_movimiento_libro")
        Command.Parameters("@id_movimiento_libro").Value = id_Movimiento_libro
        Command.Parameters.Add("@numero_asiento", SqlDbType.Int, 4, "numero_asiento")
        Command.Parameters("@numero_asiento").Value = numero_asiento_nvo

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function GetMaxNumeroAsiento() As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_libro_GetMaxNumeroAsiento", cnn.Coneccion)


        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        If odt.Rows.Count > 0 Then
            Return CInt(odt.Rows(0).Item("Total").ToString())
        Else
            Return 0
        End If

    End Function

    Public Function GetAll_2(ByVal fecha_inicio As Date, ByVal fecha_fin As Date) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_libro_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@inicio", SqlDbType.DateTime, 8, "inicio")
        oda.SelectCommand.Parameters("@inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        oda.SelectCommand.Parameters("@fin").Value = fecha_fin
        oda.Fill(odt)

        Return odt
    End Function

End Class
