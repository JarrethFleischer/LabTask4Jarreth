'Jarreth Fleischer Anak Majang
'20DDT21F1017
Imports System.Data.SqlClient

Public Class Register
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Untuk register
        Dim connectionString As String = "Data Source=JARRETH\JARRETH;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Dim query As String = "INSERT INTO login(name, username, email, password) VALUES (@name, @username, @email, @password)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", tbName.Text)
        command.Parameters.AddWithValue("@username", tbUsername.Text)
        command.Parameters.AddWithValue("@email", tbEmail.Text)
        command.Parameters.AddWithValue("@password", tbPassword.Text)
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("You have registered!")
        Controls.Clear()
        InitializeComponent()
        Form1.Show()
        Me.Close()

    End Sub
End Class