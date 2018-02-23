Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Movimiento_voz
    Inherits Movimiento_voz_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_Movimiento_voz

        oda.Fill(odt)
        Return odt
    End Function

End Class
