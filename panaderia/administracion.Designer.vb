<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class administracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administracion))
        Me.Bempleado = New System.Windows.Forms.Button()
        Me.Bproveedor = New System.Windows.Forms.Button()
        Me.Bsucursales = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.Bminimizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bempleado
        '
        Me.Bempleado.BackColor = System.Drawing.Color.Transparent
        Me.Bempleado.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Bempleado.FlatAppearance.BorderSize = 5
        Me.Bempleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip
        Me.Bempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bempleado.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Bempleado.ForeColor = System.Drawing.Color.White
        Me.Bempleado.Image = Global.panaderia.My.Resources.Resources.celebracion
        Me.Bempleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bempleado.Location = New System.Drawing.Point(60, 67)
        Me.Bempleado.Name = "Bempleado"
        Me.Bempleado.Size = New System.Drawing.Size(400, 150)
        Me.Bempleado.TabIndex = 0
        Me.Bempleado.Text = "Empleados"
        Me.Bempleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bempleado.UseVisualStyleBackColor = False
        '
        'Bproveedor
        '
        Me.Bproveedor.BackColor = System.Drawing.Color.Transparent
        Me.Bproveedor.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Bproveedor.FlatAppearance.BorderSize = 5
        Me.Bproveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip
        Me.Bproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bproveedor.Font = New System.Drawing.Font("Century Gothic", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Bproveedor.ForeColor = System.Drawing.Color.White
        Me.Bproveedor.Image = Global.panaderia.My.Resources.Resources.proveedor
        Me.Bproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bproveedor.Location = New System.Drawing.Point(60, 241)
        Me.Bproveedor.Name = "Bproveedor"
        Me.Bproveedor.Size = New System.Drawing.Size(400, 150)
        Me.Bproveedor.TabIndex = 1
        Me.Bproveedor.Text = "Proveedores"
        Me.Bproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bproveedor.UseVisualStyleBackColor = False
        '
        'Bsucursales
        '
        Me.Bsucursales.BackColor = System.Drawing.Color.Transparent
        Me.Bsucursales.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Bsucursales.FlatAppearance.BorderSize = 5
        Me.Bsucursales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip
        Me.Bsucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsucursales.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Bsucursales.ForeColor = System.Drawing.Color.White
        Me.Bsucursales.Image = Global.panaderia.My.Resources.Resources.panaderia__1_
        Me.Bsucursales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bsucursales.Location = New System.Drawing.Point(60, 429)
        Me.Bsucursales.Name = "Bsucursales"
        Me.Bsucursales.Size = New System.Drawing.Size(400, 150)
        Me.Bsucursales.TabIndex = 2
        Me.Bsucursales.Text = "Sucursales"
        Me.Bsucursales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bsucursales.UseVisualStyleBackColor = False
        '
        'Bcerrar
        '
        Me.Bcerrar.BackColor = System.Drawing.Color.Transparent
        Me.Bcerrar.BackgroundImage = Global.panaderia.My.Resources.Resources.eliminar
        Me.Bcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bcerrar.FlatAppearance.BorderSize = 0
        Me.Bcerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite
        Me.Bcerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Bcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcerrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bcerrar.Location = New System.Drawing.Point(475, 12)
        Me.Bcerrar.Name = "Bcerrar"
        Me.Bcerrar.Size = New System.Drawing.Size(25, 25)
        Me.Bcerrar.TabIndex = 13
        Me.Bcerrar.UseVisualStyleBackColor = False
        '
        'Bminimizar
        '
        Me.Bminimizar.BackColor = System.Drawing.Color.Transparent
        Me.Bminimizar.BackgroundImage = Global.panaderia.My.Resources.Resources.menos
        Me.Bminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bminimizar.FlatAppearance.BorderSize = 0
        Me.Bminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite
        Me.Bminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.Bminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bminimizar.Location = New System.Drawing.Point(440, 12)
        Me.Bminimizar.Name = "Bminimizar"
        Me.Bminimizar.Size = New System.Drawing.Size(25, 25)
        Me.Bminimizar.TabIndex = 12
        Me.Bminimizar.UseVisualStyleBackColor = False
        '
        'administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.panaderia.My.Resources.Resources.cropped_1920_1080_462101
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(512, 600)
        Me.Controls.Add(Me.Bcerrar)
        Me.Controls.Add(Me.Bminimizar)
        Me.Controls.Add(Me.Bsucursales)
        Me.Controls.Add(Me.Bproveedor)
        Me.Controls.Add(Me.Bempleado)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "administracion"
        Me.Text = "administracion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bempleado As Button
    Friend WithEvents Bproveedor As Button
    Friend WithEvents Bsucursales As Button
    Friend WithEvents Bcerrar As Button
    Friend WithEvents Bminimizar As Button
End Class
