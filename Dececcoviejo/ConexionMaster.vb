Public Class ConexionMaster
    Private ocnn As SqlClient.SqlConnection

    Public Function Coneccion() As SqlClient.SqlConnection
        Dim strServer As String
        Dim strDB As String
        Dim strUser As String
        Dim strPass As String

        'strServer = Environment.MachineName
        'strServer = strServer & "(local)\SQLExpress"

        'conexion casa
        'strServer = "PCMARIO\SQLExpress"

        'conexion trabajo
        'strServer = "CBA-28\SQLExpress"

        'conexion carlos
        'strServer = "Desktop\SQLExpress"

        'Conexion(notebook)
        strServer = "(local)"


        'strDB = "SuperTest"

        strDB = "master"

        strUser = "carlos"
        strPass = "carlos2008"

        ocnn = New SqlClient.SqlConnection
        'ocnn.ConnectionString = "Server=" & strServer & ";" & _
        '                        "DataBase=" & strDB & ";" & _
        '                        "User ID=" & strUser & ";" & _
        '                        "Password=" & strPass & ";" & _
        '                        "Trusted_Connection=true"

        ocnn.ConnectionString = "Server=" & strServer & ";" & _
                        "DataBase=" & strDB & ";" & _
                        "Trusted_Connection=true"
        Return ocnn
    End Function

    Public Sub Abrir()
        ocnn.Open()
    End Sub

    Public Sub Cerrar()
        ocnn.Close()
    End Sub

    Public Function Verificar() As Boolean
        Try
            ocnn.Open()
        Catch ex As Exception
            Return False
        End Try
        ocnn.Close()
        Return True
    End Function


End Class
