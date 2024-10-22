Imports System.Drawing.Drawing2D


Public Class Login
    Private Sub btn_inicio_MouseHover(sender As Object, e As EventArgs) Handles btn_inicio.MouseHover
        btn_inicio.BackColor = Color.Tomato
    End Sub

    Private Sub btn_inicio_MouseLeave(sender As Object, e As EventArgs) Handles btn_inicio.MouseLeave
        btn_inicio.BackColor = Color.RoyalBlue

    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click

    End Sub


    Module CustomButton
        Public Sub RoundButton(btn As Button)
            Dim path As New GraphicsPath()
            path.AddEllipse(New Rectangle(0, 0, btn.Width, btn.Height))
            btn.Region = New Region(path)
        End Sub
    End Module

End Class
