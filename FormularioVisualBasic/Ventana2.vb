Public Class Ventana2
    Private Sub Ventana2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResultado.Text = ""
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim total = 0
        Dim pasarela = ""
        Dim conProd = 0
        Dim conPasarelas = 0
        If cbProductos.Text = "Camisas 500" Then
            total = total + 500
            conProd = conProd + 1
        End If
        If cbProductos.Text = "Tenis 1000" Then
            total = total + 1000
            conProd = conProd + 1
        End If
        If lbPasarelas.Text = "Paypal" Then
            pasarela = "Pago con paypal "
            conPasarelas = conPasarelas + 1
        End If
        If lbPasarelas.Text = "Tarjeta" Then
            pasarela = "Pago con tarjeta "
            conPasarelas = conPasarelas + 1
        End If
        If conProd > 0 And conPasarelas > 0 Then
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

    Private Sub cbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductos.SelectedIndexChanged
        imgProductos.ImageLocation = "C:/Users/eugenio/Pictures/VB/" & cbProductos.Text & ".png"
    End Sub

    Private Sub lbPasarelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPasarelas.SelectedIndexChanged
        imgPasarelas.ImageLocation = "C:/Users/eugenio/Pictures/VB/" & lbPasarelas.Text & ".png"
    End Sub
End Class