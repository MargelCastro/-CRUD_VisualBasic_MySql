﻿Public Class Login
    Private Sub btn_inicio_MouseHover(sender As Object, e As EventArgs) Handles btn_inicio.MouseHover
        btn_inicio.BackColor = Color.Tomato
    End Sub

    Private Sub btn_inicio_MouseLeave(sender As Object, e As EventArgs) Handles btn_inicio.MouseLeave
        btn_inicio.BackColor = Color.RoyalBlue

    End Sub
End Class