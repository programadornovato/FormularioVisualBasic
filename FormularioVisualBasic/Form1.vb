Public Class Form1
    Private Sub Menu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Menu.ItemClicked
        'MessageBox.Show(e.ClickedItem.Text)
        If e.ClickedItem.Text = "Nuevo" Then
            Dim v2 = New Ventana2()
            v2.MdiParent = Me
            v2.Show()
        ElseIf e.ClickedItem.Text = "Cerrar" Then
            Me.Close()
        End If
    End Sub
End Class
