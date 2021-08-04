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
        Me.chk500 = New System.Windows.Forms.CheckBox()
        Me.chk1000 = New System.Windows.Forms.CheckBox()
        Me.radPaypal = New System.Windows.Forms.RadioButton()
        Me.radTarjeta = New System.Windows.Forms.RadioButton()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chk500
        '
        Me.chk500.AutoSize = True
        Me.chk500.Location = New System.Drawing.Point(34, 26)
        Me.chk500.Name = "chk500"
        Me.chk500.Size = New System.Drawing.Size(153, 29)
        Me.chk500.TabIndex = 0
        Me.chk500.Text = "Camisa 500"
        Me.chk500.UseVisualStyleBackColor = True
        '
        'chk1000
        '
        Me.chk1000.AutoSize = True
        Me.chk1000.Location = New System.Drawing.Point(34, 67)
        Me.chk1000.Name = "chk1000"
        Me.chk1000.Size = New System.Drawing.Size(144, 29)
        Me.chk1000.TabIndex = 1
        Me.chk1000.Text = "Tenis 1000"
        Me.chk1000.UseVisualStyleBackColor = True
        '
        'radPaypal
        '
        Me.radPaypal.AutoSize = True
        Me.radPaypal.Location = New System.Drawing.Point(371, 25)
        Me.radPaypal.Name = "radPaypal"
        Me.radPaypal.Size = New System.Drawing.Size(202, 29)
        Me.radPaypal.TabIndex = 2
        Me.radPaypal.TabStop = True
        Me.radPaypal.Text = "Pago con paypal"
        Me.radPaypal.UseVisualStyleBackColor = True
        '
        'radTarjeta
        '
        Me.radTarjeta.AutoSize = True
        Me.radTarjeta.Location = New System.Drawing.Point(371, 67)
        Me.radTarjeta.Name = "radTarjeta"
        Me.radTarjeta.Size = New System.Drawing.Size(205, 29)
        Me.radTarjeta.TabIndex = 3
        Me.radTarjeta.TabStop = True
        Me.radTarjeta.Text = "Pago con tarjeta"
        Me.radTarjeta.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(34, 136)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(130, 44)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(371, 136)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(130, 44)
        Me.btnPagar.TabIndex = 4
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(34, 230)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(142, 25)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "lblResultado"
        '
        'Ventana2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.radTarjeta)
        Me.Controls.Add(Me.radPaypal)
        Me.Controls.Add(Me.chk1000)
        Me.Controls.Add(Me.chk500)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Ventana2"
        Me.Text = "Ventana2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk500 As CheckBox
    Friend WithEvents chk1000 As CheckBox
    Friend WithEvents radPaypal As RadioButton
    Friend WithEvents radTarjeta As RadioButton
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnPagar As Button
    Friend WithEvents lblResultado As Label
End Class
