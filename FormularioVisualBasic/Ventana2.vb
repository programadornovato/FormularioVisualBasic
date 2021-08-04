Public Class Ventana2
    Private Sub Ventana2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResultado.Text = ""
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim total = 0
        Dim pasarela = ""
        Dim conChk = 0
        Dim conRad = 0
        If chk500.Checked = True Then
            total = total + 500
            conChk = conChk + 1
        End If
        If chk1000.Checked = True Then
            total = total + 1000
            conChk = conChk + 1
        End If
        If radPaypal.Checked = True Then
            pasarela = "Pago con paypal "
            conRad = conRad + 1
        End If
        If radTarjeta.Checked = True Then
            pasarela = "Pago con tarjeta "
            conRad = conRad + 1
        End If
        If conChk > 0 And conRad > 0 Then
            lblResultado.Text = pasarela & total
        Else
            lblResultado.Text = "Humano debes seleccionar un producto y una pasarela"
        End If

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim f = New Form1()
        f.Show()
        Me.Hide()
    End Sub
End Class