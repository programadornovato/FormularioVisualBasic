Public Class Form1

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text = "programadornovato" And txtPass.Text = "123" Then
            'MessageBox.Show("Usuario valido")
            Dim v2 = New Ventana2()
            v2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario invalido")
            txtUsuario.Text = ""
            txtPass.Text = ""
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
