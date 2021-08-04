<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.lbPasarelas = New System.Windows.Forms.ListBox()
        Me.imgProductos = New System.Windows.Forms.PictureBox()
        Me.imgPasarelas = New System.Windows.Forms.PictureBox()
        CType(Me.imgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPasarelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(34, 322)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(130, 44)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(371, 322)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(130, 44)
        Me.btnPagar.TabIndex = 4
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(34, 416)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(142, 25)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "lblResultado"
        '
        'cbProductos
        '
        Me.cbProductos.FormattingEnabled = True
        Me.cbProductos.Items.AddRange(New Object() {"Camisas 500", "Tenis 1000"})
        Me.cbProductos.Location = New System.Drawing.Point(34, 47)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(162, 33)
        Me.cbProductos.TabIndex = 6
        '
        'lbPasarelas
        '
        Me.lbPasarelas.FormattingEnabled = True
        Me.lbPasarelas.ItemHeight = 25
        Me.lbPasarelas.Items.AddRange(New Object() {"Paypal", "Tarjeta"})
        Me.lbPasarelas.Location = New System.Drawing.Point(371, 47)
        Me.lbPasarelas.Name = "lbPasarelas"
        Me.lbPasarelas.Size = New System.Drawing.Size(120, 79)
        Me.lbPasarelas.TabIndex = 7
        '
        'imgProductos
        '
        Me.imgProductos.Location = New System.Drawing.Point(34, 164)
        Me.imgProductos.Name = "imgProductos"
        Me.imgProductos.Size = New System.Drawing.Size(156, 114)
        Me.imgProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgProductos.TabIndex = 8
        Me.imgProductos.TabStop = False
        '
        'imgPasarelas
        '
        Me.imgPasarelas.Location = New System.Drawing.Point(371, 164)
        Me.imgPasarelas.Name = "imgPasarelas"
        Me.imgPasarelas.Size = New System.Drawing.Size(156, 114)
        Me.imgPasarelas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPasarelas.TabIndex = 8
        Me.imgPasarelas.TabStop = False
        '
        'Ventana2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.imgPasarelas)
        Me.Controls.Add(Me.imgProductos)
        Me.Controls.Add(Me.lbPasarelas)
        Me.Controls.Add(Me.cbProductos)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Ventana2"
        Me.Text = "Ventana2"
        CType(Me.imgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPasarelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnPagar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents cbProductos As ComboBox
    Friend WithEvents lbPasarelas As ListBox
    Friend WithEvents imgProductos As PictureBox
    Friend WithEvents imgPasarelas As PictureBox
End Class
