Public Class Form2
    Public Shared Property area As Decimal


    Private Sub Calculatebutton_Click(sender As Object, e As EventArgs) Handles Calculatebutton.Click
        Dim dblRoomHeight As Double = Val(roomheight.Text)
        Dim dblRoomLength As Double = Val(roomlength.Text)

        'validate input
        If dblRoomHeight < 2 Or dblRoomHeight > 6 Then
            MsgBox("The room height must be between 2-6 meters")
        ElseIf dblRoomLength < 1 Or dblRoomLength > 25 Then
            MsgBox("The room length must be between 1-25 meters")
        Else
            'calulates surface area
            area = dblRoomHeight * dblRoomLength
            AreaCalc.Text = area & " metres squared"
        End If

    End Sub

    Private Sub Nextbutton_Click(sender As Object, e As EventArgs) Handles Nextbutton.Click
        Form3.Show()
    End Sub

End Class