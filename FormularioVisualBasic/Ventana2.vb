Public Class Ventana2
    Dim con = 0
    Private Sub imgLogo_Click(sender As Object, e As EventArgs) Handles imgLogo.Click
        carga()
    End Sub

    Private Sub Ventana2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbCarga.Minimum = 0
        pbCarga.Maximum = 100
    End Sub

    Private Sub imgLogo_MouseMove(sender As Object, e As MouseEventArgs) Handles imgLogo.MouseMove
        carga()
        lblPos.Text = "X=" & e.X & " Y=" & e.Y
    End Sub
    Sub carga()
        If con < 100 Then
            con = con + 1
            pbCarga.Value = con
        End If
    End Sub
End Class