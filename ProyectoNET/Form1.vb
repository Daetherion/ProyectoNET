Public Class SuiteApp
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        BusquedaProgramas()
    End Sub
    Private Sub Correo_Click(sender As Object, e As EventArgs) Handles Correo.Click
        IniciarPrograma("")

    End Sub

    Private Sub Periodico_Click(sender As Object, e As EventArgs) Handles Periodico.Click
        IniciarPrograma("C:\Windows\system32\notepad.exe")
    End Sub

    Private Sub IniciarPrograma(arg As String)
        'Función generica para abrir programas segun el boton que se pulse
        Dim inicio As New ProcessStartInfo
        inicio.FileName = arg
        Process.Start(arg)
    End Sub
    Private Sub BusquedaProgramas()
        'Función para que se busquen las direcciones de los programas que se tienen instalados
        Dim listaDirectorios As IReadOnlyCollection(Of String)
        Dim listaFicheros As New List(Of String)
        Dim listaExe As New List(Of String)
        listaDirectorios = (My.Computer.FileSystem.GetDirectories("C:\"))
        For Each directorio As String In listaDirectorios
            listaFicheros.Add(directorio)
        Next
        For Each fichero As String In listaFicheros
            If StrComp(fichero.Substring(fichero.Count - 4), ".exe") = 0 Then
                Console.Write("El fichero " + fichero + " es un .exe")
                listaExe.Add(fichero)
            Else
                Console.Write("El fichero " + fichero + " NO es un .exe")
            End If
        Next


    End Sub
End Class

