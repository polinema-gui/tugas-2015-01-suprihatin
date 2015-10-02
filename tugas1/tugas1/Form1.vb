Public Class Form1
    Private Sub ubahButton_Click(sender As Object, e As EventArgs) Handles ubahButton.Click
        If Me.BackColor = Color.Yellow Then
            Me.BackColor = Color.Blue
        Else
            Me.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Yellow
    End Sub
End Class
