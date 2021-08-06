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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.dgPersonas = New System.Windows.Forms.DataGridView()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblDatos = New System.Windows.Forms.Label()
        CType(Me.dgPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Edad"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(187, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(227, 33)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(187, 71)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(227, 33)
        Me.txtApellido.TabIndex = 1
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(187, 110)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(227, 33)
        Me.txtEdad.TabIndex = 2
        '
        'dgPersonas
        '
        Me.dgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombre, Me.colApellido, Me.colEdad})
        Me.dgPersonas.Location = New System.Drawing.Point(39, 194)
        Me.dgPersonas.Name = "dgPersonas"
        Me.dgPersonas.RowTemplate.Height = 25
        Me.dgPersonas.Size = New System.Drawing.Size(375, 150)
        Me.dgPersonas.TabIndex = 5
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        '
        'colApellido
        '
        Me.colApellido.HeaderText = "Apellido"
        Me.colApellido.Name = "colApellido"
        '
        'colEdad
        '
        Me.colEdad.HeaderText = "Edad"
        Me.colEdad.Name = "colEdad"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(519, 32)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(127, 44)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(519, 88)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(127, 44)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(39, 381)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(99, 25)
        Me.lblDatos.TabIndex = 4
        Me.lblDatos.Text = "lblDatos"
        '
        'Ventana2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgPersonas)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Ventana2"
        Me.Text = "Ventana2"
        CType(Me.dgPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents dgPersonas As DataGridView
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colApellido As DataGridViewTextBoxColumn
    Friend WithEvents colEdad As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblDatos As Label
End Class
