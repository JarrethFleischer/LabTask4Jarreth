'Jarreth Fleischer Anak Majang
'20DDT21F1017
Public NotInheritable Class Splash

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load




        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else

            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If


        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Dim timeLeft As Int16 = 300
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        If timeLeft > 0 Then
            timeLeft = timeLeft - 1
        End If
        Timer1.Stop()
        Form1.Show()
        Me.Hide()
    End Sub
End Class
