Public Class Form1
    Private Sub enterbutton_Click(sender As Object, e As EventArgs) Handles enterbutton.Click
        If username.Text = "barihamza" And password.Text = "afridi22" Then Form2.Show() Else MsgBox("Sorry, The Username or Password was incorrect.", MsgBoxStyle.Critical, "Information")
    End Sub
End Class
