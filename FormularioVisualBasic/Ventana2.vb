Public Class Ventana2
    Dim registroSel = 0
    Private Sub Ventana2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDatos.Text = ""
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim n = dgPersonas.Rows.Add()
        dgPersonas.Rows(n).Cells(0).Value = txtNombre.Text
        dgPersonas.Rows(n).Cells(1).Value = txtApellido.Text
        dgPersonas.Rows(n).Cells(2).Value = txtEdad.Text
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtEdad.Text = ""
    End Sub

    Private Sub dgPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPersonas.CellClick
        Dim n = dgPersonas.Rows.Count - 1
        registroSel = e.RowIndex
        If registroSel <> -1 And registroSel < n Then
            Dim nombre = dgPersonas.Rows(registroSel).Cells(0).Value.ToString
            Dim apellido = dgPersonas.Rows(registroSel).Cells(1).Value.ToString
            Dim edad = dgPersonas.Rows(registroSel).Cells(2).Value.ToString
            lblDatos.Text = nombre & " " & apellido & " " & edad
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If registroSel <> -1 Then
            dgPersonas.Rows.RemoveAt(registroSel)
            lblDatos.Text = ""
        End If
    End Sub
End Class