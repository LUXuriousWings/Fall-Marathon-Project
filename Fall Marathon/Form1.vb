Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Informations.Click
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label1.Text = "May 30, 2017"
        Label2.Text = "Ryan Park"
        Label3.Text = "Start Time: 8:00 AM"
        Label4.Text = "For more information, view the Fall Marathon Facebook page."
        Button_Informations.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Motto_Half.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub
End Class
