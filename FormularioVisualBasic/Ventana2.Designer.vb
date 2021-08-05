<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventana2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.pbCarga = New System.Windows.Forms.ProgressBar()
        Me.lblPos = New System.Windows.Forms.Label()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.FormularioVisualBasic.My.Resources.Resources.logo
        Me.imgLogo.Location = New System.Drawing.Point(291, 106)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(188, 173)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'pbCarga
        '
        Me.pbCarga.Location = New System.Drawing.Point(224, 334)
        Me.pbCarga.Name = "pbCarga"
        Me.pbCarga.Size = New System.Drawing.Size(296, 40)
        Me.pbCarga.TabIndex = 1
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Location = New System.Drawing.Point(224, 392)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(81, 25)
        Me.lblPos.TabIndex = 2
        Me.lblPos.Text = "Label1"
        '
        'Ventana2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPos)
        Me.Controls.Add(Me.pbCarga)
        Me.Controls.Add(Me.imgLogo)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Ventana2"
        Me.Text = "Ventana2"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents pbCarga As ProgressBar
    Friend WithEvents lblPos As Label
End Class
