'Jarreth Fleischer Anak Majang
'20DDT21F1017
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Reservation
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Review.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Review.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionstring As String = "Data Source=JARRETH\JARRETH;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionstring)
        connection.Open()

        Dim query As String = "INSERT INTO reservation(name, email, phone, branch, time) VALUES(@name, @email, @phone, @branch, @time)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", tbName.Text)
        command.Parameters.AddWithValue("@email", tbEmail.Text)
        command.Parameters.AddWithValue("@phone", tbPhone.Text)
        command.Parameters.AddWithValue("@branch", tbBranch.Text)
        command.Parameters.AddWithValue("@time", tbTime.Text)
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("Thank You for your Reservation!")
        Controls.Clear()
        InitializeComponent()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()

    End Sub
End Class