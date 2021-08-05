<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.menuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNuevo, Me.menuAbrir, Me.menuCerrar})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(895, 24)
        Me.Menu.TabIndex = 1
        Me.Menu.Text = "MenuStrip1"
        '
        'menuNuevo
        '
        Me.menuNuevo.Name = "menuNuevo"
        Me.menuNuevo.Size = New System.Drawing.Size(54, 20)
        Me.menuNuevo.Text = "Nuevo"
        '
        'menuAbrir
        '
        Me.menuAbrir.Name = "menuAbrir"
        Me.menuAbrir.Size = New System.Drawing.Size(45, 20)
        Me.menuAbrir.Text = "Abrir"
        '
        'menuCerrar
        '
        Me.menuCerrar.Name = "menuCerrar"
        Me.menuCerrar.Size = New System.Drawing.Size(51, 20)
        Me.menuCerrar.Text = "Cerrar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.FormularioVisualBasic.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(895, 644)
        Me.Controls.Add(Me.Menu)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(100, 100)
        Me.MainMenuStrip = Me.Menu
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "Form1"
        Me.Text = "Formulario 1"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents menuNuevo As ToolStripMenuItem
    Friend WithEvents menuAbrir As ToolStripMenuItem
    Friend WithEvents menuCerrar As ToolStripMenuItem
End Class
