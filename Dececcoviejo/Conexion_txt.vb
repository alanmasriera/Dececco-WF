Imports System.Data.OleDb

Public Class Conexion_txt
    Private ocnntxt As OleDbConnection

    Public Function Coneccion(ByVal path As String) As OleDbConnection
        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" & path & ";" & _
        "Extended Properties=""Text;HDR=YES;FMT=Delimited"""

        ocnntxt = New OleDbConnection
        ocnntxt.ConnectionString = ConnectionString

        Return ocnntxt
    End Function

    Public Sub Abrir()
        ocnntxt.Open()
    End Sub

    Public Sub Cerrar()
        ocnntxt.Close()
    End Sub

    Public Function Verificar() As Boolean
        Try
            ocnntxt.Open()
        Catch ex As Exception
            Return False
        End Try
        ocnntxt.Close()
        Return True
    End Function

End Class
