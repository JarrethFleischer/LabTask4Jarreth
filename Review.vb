'Jarreth Fleischer Anak Majang
'20DDT21F1017
Imports System.Data.SqlClient

Public Class Review
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Restaurant.Show()
        Me.Hide()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Restaurant.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        About.Show()
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        About.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionstring As String = "Data Source=JARRETH\JARRETH;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionstring)
        connection.Open()

        Dim query As String = "INSERT INTO review(name, review) VALUES(@name, @review)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", tbName.Text)
        command.Parameters.AddWithValue("@review", tbReview.Text)
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("Thank You for your Review!")
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()

    End Sub
End Class