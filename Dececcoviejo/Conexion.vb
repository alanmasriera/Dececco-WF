Public Class Conexion
    Private ocnn As SqlClient.SqlConnection

    Public Function Coneccion() As SqlClient.SqlConnection
        Dim strServer As String
        Dim strDB As String
        Dim strUser As String
        Dim strPass As String

        ocnn = New SqlClient.SqlConnection

        'strServer = Environment.MachineName
        'strServer = strServer & "(local)\SQLExpress"

        'conexion casa
        'strServer = "PCMARIO\SQLExpress"

        'conexion trabajo
        'strServer = "CBA-28\SQLExpress"

        'conexion carlos
        'strServer = "SERVER\SQLExpress"

        'Conexion(notebook)
        ' strServer = "(local)\SQLEXPRESS"

        

        'strServer = "SERVER"
        ' strDB = "SuperTest"

        'strServer = "192.168.1.21,1433"


        'strDB = "Ingesoft"

        'strDB = "Dececco_Descar"

        'strUser = "lucas"
        'strPass = "lucas2011"

        'CONEXIoN DECCECO
        strServer = "SERVER"
        strDB = "Dececco"
        strUser = "usuarios"
        strPass = "usuario"


        ocnn.ConnectionString = "Data Source=" & strServer & ";" & _
                                "Initial Catalog=" & strDB & ";" & _
                                "User ID=" & strUser & ";" & _
                                "Password=" & strPass & ";" & _
                                "Trusted_Connection=false"

        ocnn.ConnectionString = "Data Source=disegno-12;Initial Catalog=Dececco;Integrated Security=True"


        'backup
        ocnn.ConnectionString = "Data Source=disegno-12;Initial Catalog=Database_Backup;Integrated Security=True"

        'NUEVA CONEXIoN DECCECO
        'strServer = "SERVER\SQLExpress"
        strServer = "SERVER"
        strDB = "Dececco_Nuevo"
        strUser = "sa"
        strPass = "esteban"


        'CONEXION NZ
        'strServer = "SERVER\SQLExpress"
        strServer = "ESTEBAN"
        strDB = "Dececco_Nuevo"
        strUser = "sa"
        strPass = "Descar2"


        ocnn.ConnectionString = "Data Source=" & strServer & ";" & _
                                "Initial Catalog=" & strDB & ";" & _
                                "User ID=" & strUser & ";" & _
                                "Password=" & strPass & ";" & _
                                "Trusted_Connection=false"




        'Hamachi
        'strServer = "25.75.255.128,1433"
        '############con hamachi###############
        'strServer = "25.58.219.116,1433"
        'strDB = "Dececco_Nuevo"
        'strUser = "sa"
        'strPass = "esteban"


        'ocnn.ConnectionString = "Data Source=" & strServer & ";" & _
        '                        "Initial Catalog=" & strDB & ";" & _
        '                        "User ID=" & strUser & ";" & _
        '                        "Password=" & strPass & ";" & _
        '                        "Trusted_Connection=false"
        '############con hamachi###############
        'ocnn.ConnectionString = "Server=" & strServer & ";" & _
        '                "DataBase=" & strDB & ";" & _
        '                "Trusted_Connection=true"

        'ocnn.ConnectionString = "Data Source=" & "www.ingesoft.servehttp.com,1433" & ";" & _
        '                "Network Library=" & "DBMSSOCN" & ";" & _
        '                "Initial Catalog=" & strDB & ";" & _
        '                "User ID=" & strUser & ";" & _
        '                "Password=" & strPass & ";" & _
        '                "Trusted_Connection=false"


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
