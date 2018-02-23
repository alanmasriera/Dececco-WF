Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Modificacion_arbol
    Inherits Modificacion_arbol_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Modificacion_arbol As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Modificacion_arbol", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_modificacion_arbol", SqlDbType.Int, 4, "id_modificacion_arbol")
        oda.SelectCommand.Parameters("@id_modificacion_arbol").Value = id_Modificacion_arbol

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllPendiente(ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Modificacion_arbol_GetAllPendiente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)
        Return odt
    End Function



End Class
