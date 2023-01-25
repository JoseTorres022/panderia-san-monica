<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bienvenida
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bienvenida))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Bbar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bminimizar = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Window
        Me.ProgressBar1.ForeColor = System.Drawing.Color.ForestGreen
        Me.ProgressBar1.Location = New System.Drawing.Point(209, 479)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(705, 40)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 9
        '
        'Bbar
        '
        Me.Bbar.BackColor = System.Drawing.Color.Moccasin
        Me.Bbar.FlatAppearance.BorderSize = 0
        Me.Bbar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip
        Me.Bbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbar.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Bbar.Location = New System.Drawing.Point(360, 538)
        Me.Bbar.Name = "Bbar"
        Me.Bbar.Size = New System.Drawing.Size(400, 60)
        Me.Bbar.TabIndex = 8
        Me.Bbar.Text = "Acceso al sistema"
        Me.Bbar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
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
        Me.Bminimizar.Location = New System.Drawing.Point(1028, 12)
        Me.Bminimizar.Name = "Bminimizar"
        Me.Bminimizar.Size = New System.Drawing.Size(25, 25)
        Me.Bminimizar.TabIndex = 10
        Me.Bminimizar.UseVisualStyleBackColor = False
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
        Me.Bcerrar.Location = New System.Drawing.Point(1063, 12)
        Me.Bcerrar.Name = "Bcerrar"
        Me.Bcerrar.Size = New System.Drawing.Size(25, 25)
        Me.Bcerrar.TabIndex = 11
        Me.Bcerrar.UseVisualStyleBackColor = False
        '
        'bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.panaderia.My.Resources.Resources.Cookie_Love_Twitter_Post
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1100, 610)
        Me.Controls.Add(Me.Bcerrar)
        Me.Controls.Add(Me.Bminimizar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Bbar)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bbar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Bminimizar As Button
    Friend WithEvents Bcerrar As Button
End Class
