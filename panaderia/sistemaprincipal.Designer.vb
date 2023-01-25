<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sistemaprincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sistemaprincipal))
        Me.Bpedidos = New System.Windows.Forms.Button()
        Me.Bproductos = New System.Windows.Forms.Button()
        Me.Badmin = New System.Windows.Forms.Button()
        Me.Bventas = New System.Windows.Forms.Button()
        Me.Lhora = New System.Windows.Forms.Label()
        Me.Lfecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.Bminimizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bpedidos
        '
        Me.Bpedidos.BackColor = System.Drawing.Color.OldLace
        Me.Bpedidos.FlatAppearance.BorderSize = 0
        Me.Bpedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.Bpedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bpedidos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Bpedidos.Image = Global.panaderia.My.Resources.Resources.caja
        Me.Bpedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bpedidos.Location = New System.Drawing.Point(662, 336)
        Me.Bpedidos.Name = "Bpedidos"
        Me.Bpedidos.Size = New System.Drawing.Size(280, 80)
        Me.Bpedidos.TabIndex = 8
        Me.Bpedidos.Text = "Pedidos"
        Me.Bpedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bpedidos.UseVisualStyleBackColor = False
        '
        'Bproductos
        '
        Me.Bproductos.BackColor = System.Drawing.Color.OldLace
        Me.Bproductos.FlatAppearance.BorderSize = 0
        Me.Bproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.Bproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bproductos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Bproductos.Image = Global.panaderia.My.Resources.Resources.cesta
        Me.Bproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bproductos.Location = New System.Drawing.Point(662, 236)
        Me.Bproductos.Name = "Bproductos"
        Me.Bproductos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Bproductos.Size = New System.Drawing.Size(280, 80)
        Me.Bproductos.TabIndex = 9
        Me.Bproductos.Text = "Productos"
        Me.Bproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bproductos.UseVisualStyleBackColor = False
        '
        'Badmin
        '
        Me.Badmin.BackColor = System.Drawing.Color.Gold
        Me.Badmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Badmin.FlatAppearance.BorderSize = 0
        Me.Badmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Badmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Badmin.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Badmin.ForeColor = System.Drawing.Color.Black
        Me.Badmin.Image = Global.panaderia.My.Resources.Resources.iconfinder_mail_management_4341274_120573
        Me.Badmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Badmin.Location = New System.Drawing.Point(662, 127)
        Me.Badmin.Name = "Badmin"
        Me.Badmin.Size = New System.Drawing.Size(280, 80)
        Me.Badmin.TabIndex = 11
        Me.Badmin.Text = "Administracion"
        Me.Badmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Badmin.UseVisualStyleBackColor = False
        '
        'Bventas
        '
        Me.Bventas.BackColor = System.Drawing.Color.OldLace
        Me.Bventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bventas.FlatAppearance.BorderSize = 0
        Me.Bventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.Bventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bventas.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Bventas.Image = Global.panaderia.My.Resources.Resources.ventas
        Me.Bventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bventas.Location = New System.Drawing.Point(662, 444)
        Me.Bventas.Name = "Bventas"
        Me.Bventas.Size = New System.Drawing.Size(280, 80)
        Me.Bventas.TabIndex = 12
        Me.Bventas.Text = "Ventas"
        Me.Bventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bventas.UseVisualStyleBackColor = False
        '
        'Lhora
        '
        Me.Lhora.AutoSize = True
        Me.Lhora.BackColor = System.Drawing.Color.Transparent
        Me.Lhora.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lhora.ForeColor = System.Drawing.Color.White
        Me.Lhora.Location = New System.Drawing.Point(106, 444)
        Me.Lhora.Name = "Lhora"
        Me.Lhora.Size = New System.Drawing.Size(58, 24)
        Me.Lhora.TabIndex = 14
        Me.Lhora.Text = "Hora"
        '
        'Lfecha
        '
        Me.Lfecha.AutoSize = True
        Me.Lfecha.BackColor = System.Drawing.Color.Transparent
        Me.Lfecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lfecha.ForeColor = System.Drawing.Color.White
        Me.Lfecha.Location = New System.Drawing.Point(108, 470)
        Me.Lfecha.Name = "Lfecha"
        Me.Lfecha.Size = New System.Drawing.Size(56, 21)
        Me.Lfecha.TabIndex = 15
        Me.Lfecha.Text = "fecha"
        '
        'Timer1
        '
        '
        'Bcerrar
        '
        Me.Bcerrar.BackColor = System.Drawing.Color.Transparent
        Me.Bcerrar.BackgroundImage = Global.panaderia.My.Resources.Resources.cerrar__4_
        Me.Bcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bcerrar.FlatAppearance.BorderSize = 0
        Me.Bcerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Bcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcerrar.Location = New System.Drawing.Point(1113, 563)
        Me.Bcerrar.Name = "Bcerrar"
        Me.Bcerrar.Size = New System.Drawing.Size(25, 25)
        Me.Bcerrar.TabIndex = 16
        Me.Bcerrar.UseVisualStyleBackColor = False
        '
        'Bminimizar
        '
        Me.Bminimizar.BackColor = System.Drawing.Color.Transparent
        Me.Bminimizar.BackgroundImage = Global.panaderia.My.Resources.Resources.minimizar
        Me.Bminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bminimizar.FlatAppearance.BorderSize = 0
        Me.Bminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Bminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bminimizar.Location = New System.Drawing.Point(1082, 563)
        Me.Bminimizar.Name = "Bminimizar"
        Me.Bminimizar.Size = New System.Drawing.Size(25, 25)
        Me.Bminimizar.TabIndex = 17
        Me.Bminimizar.UseVisualStyleBackColor = False
        '
        'sistemaprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.panaderia.My.Resources.Resources.Rojo_Foto_Pastel_Tarjeta_de_Presentación
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1150, 600)
        Me.Controls.Add(Me.Bminimizar)
        Me.Controls.Add(Me.Bcerrar)
        Me.Controls.Add(Me.Lfecha)
        Me.Controls.Add(Me.Lhora)
        Me.Controls.Add(Me.Bventas)
        Me.Controls.Add(Me.Badmin)
        Me.Controls.Add(Me.Bproductos)
        Me.Controls.Add(Me.Bpedidos)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "sistemaprincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sistemaprincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bpedidos As Button
    Friend WithEvents Bproductos As Button
    Friend WithEvents Badmin As Button
    Friend WithEvents Bventas As Button
    Friend WithEvents Lhora As Label
    Friend WithEvents Lfecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Bcerrar As Button
    Friend WithEvents Bminimizar As Button
End Class
