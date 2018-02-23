Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Grupo_producto
    Inherits Grupo_producto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Grupo_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_producto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_producto", SqlDbType.Int, 4, "id_grupo_producto")
        oda.SelectCommand.Parameters("@id_grupo_producto").Value = id_Grupo_producto

        oda.Fill(odt)
        Return odt
    End Function

    'grilla
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_producto_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function
End Class
