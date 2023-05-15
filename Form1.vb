'Jarreth Fleischer Anak Majang
'20DDT21F1017
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Untuk login
        Dim connectionString As String = "Data Source=JARRETH\JARRETH;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)

        Dim query As String = "SELECT * FROM login WHERE  username = @username AND password = @password"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", tbUsername.Text)
        command.Parameters.AddWithValue("@password", tbPassword.Text)
        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                Dim username As String = reader("username").ToString()
                Dim password As String = reader("password").ToString()

            End While

            MsgBox("Welcome")
            Restaurant.Show()
            Me.Hide()
        Else
            MsgBox("Invalid!")
            Me.Show()
        End If

        connection.Close()

    End Sub

End Class
