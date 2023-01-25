<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class empleados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empleados))
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.Bminimizar = New System.Windows.Forms.Button()
        Me.DGempleado = New System.Windows.Forms.DataGridView()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Bactualizar = New System.Windows.Forms.Button()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbApellidos = New System.Windows.Forms.TextBox()
        Me.TbPuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbSueldo = New System.Windows.Forms.TextBox()
        Me.Brefresh = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DGempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Bcerrar.Location = New System.Drawing.Point(1376, 17)
        Me.Bcerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bcerrar.Name = "Bcerrar"
        Me.Bcerrar.Size = New System.Drawing.Size(36, 35)
        Me.Bcerrar.TabIndex = 15
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
        Me.Bminimizar.Location = New System.Drawing.Point(1331, 17)
        Me.Bminimizar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bminimizar.Name = "Bminimizar"
        Me.Bminimizar.Size = New System.Drawing.Size(36, 35)
        Me.Bminimizar.TabIndex = 14
        Me.Bminimizar.UseVisualStyleBackColor = False
        '
        'DGempleado
        '
        Me.DGempleado.AllowUserToAddRows = False
        Me.DGempleado.AllowUserToDeleteRows = False
        Me.DGempleado.AllowUserToResizeColumns = False
        Me.DGempleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGempleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGempleado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DGempleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGempleado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGempleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGempleado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGempleado.ColumnHeadersHeight = 40
        Me.DGempleado.EnableHeadersVisualStyles = False
        Me.DGempleado.GridColor = System.Drawing.Color.SteelBlue
        Me.DGempleado.Location = New System.Drawing.Point(14, 508)
        Me.DGempleado.Margin = New System.Windows.Forms.Padding(4)
        Me.DGempleado.MultiSelect = False
        Me.DGempleado.Name = "DGempleado"
        Me.DGempleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGempleado.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGempleado.RowHeadersVisible = False
        Me.DGempleado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DGempleado.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGempleado.RowTemplate.Height = 25
        Me.DGempleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGempleado.Size = New System.Drawing.Size(674, 329)
        Me.DGempleado.TabIndex = 16
        '
        'Bagregar
        '
        Me.Bagregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bagregar.FlatAppearance.BorderSize = 0
        Me.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bagregar.ForeColor = System.Drawing.Color.White
        Me.Bagregar.Location = New System.Drawing.Point(487, 272)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(200, 50)
        Me.Bagregar.TabIndex = 17
        Me.Bagregar.Text = "Agregar Datos"
        Me.Bagregar.UseVisualStyleBackColor = False
        '
        'Bactualizar
        '
        Me.Bactualizar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bactualizar.FlatAppearance.BorderSize = 0
        Me.Bactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bactualizar.ForeColor = System.Drawing.Color.White
        Me.Bactualizar.Location = New System.Drawing.Point(487, 328)
        Me.Bactualizar.Name = "Bactualizar"
        Me.Bactualizar.Size = New System.Drawing.Size(200, 50)
        Me.Bactualizar.TabIndex = 18
        Me.Bactualizar.Text = "Actualizar Datos"
        Me.Bactualizar.UseVisualStyleBackColor = False
        '
        'Beliminar
        '
        Me.Beliminar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Beliminar.FlatAppearance.BorderSize = 0
        Me.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Beliminar.ForeColor = System.Drawing.Color.White
        Me.Beliminar.Location = New System.Drawing.Point(488, 384)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(200, 50)
        Me.Beliminar.TabIndex = 19
        Me.Beliminar.Text = "Eliminar Datos"
        Me.Beliminar.UseVisualStyleBackColor = False
        '
        'TbId
        '
        Me.TbId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbId.Location = New System.Drawing.Point(36, 283)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 20)
        Me.TbId.TabIndex = 1
        '
        'TbNombre
        '
        Me.TbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNombre.Location = New System.Drawing.Point(118, 319)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(250, 20)
        Me.TbNombre.TabIndex = 2
        '
        'TbApellidos
        '
        Me.TbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbApellidos.Location = New System.Drawing.Point(118, 353)
        Me.TbApellidos.Name = "TbApellidos"
        Me.TbApellidos.Size = New System.Drawing.Size(250, 20)
        Me.TbApellidos.TabIndex = 3
        '
        'TbPuesto
        '
        Me.TbPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbPuesto.Location = New System.Drawing.Point(118, 391)
        Me.TbPuesto.Name = "TbPuesto"
        Me.TbPuesto.Size = New System.Drawing.Size(250, 20)
        Me.TbPuesto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "idEmpleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(50, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Puesto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(50, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Sueldo"
        '
        'TbSueldo
        '
        Me.TbSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbSueldo.Location = New System.Drawing.Point(118, 440)
        Me.TbSueldo.Name = "TbSueldo"
        Me.TbSueldo.Size = New System.Drawing.Size(250, 20)
        Me.TbSueldo.TabIndex = 5
        '
        'Brefresh
        '
        Me.Brefresh.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Brefresh.FlatAppearance.BorderSize = 0
        Me.Brefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brefresh.ForeColor = System.Drawing.Color.White
        Me.Brefresh.Location = New System.Drawing.Point(488, 440)
        Me.Brefresh.Name = "Brefresh"
        Me.Brefresh.Size = New System.Drawing.Size(200, 50)
        Me.Brefresh.TabIndex = 30
        Me.Brefresh.Text = "Refrescar BD"
        Me.Brefresh.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.panaderia.My.Resources.Resources.minimizar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(632, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 32
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.panaderia.My.Resources.Resources.cerrar__4_
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(663, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 31
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(170, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(486, 69)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Santa Monica"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(210, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 21)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Pasteleria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(494, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Panaderia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(88, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 21)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Pasteleria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(32, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(613, 85)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Santa Monica"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(437, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(250, 27)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Sistema Empleados"
        '
        'empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.panaderia.My.Resources.Resources.wp5275549_design_mobile_wallpapers1
        Me.ClientSize = New System.Drawing.Size(700, 850)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Brefresh)
        Me.Controls.Add(Me.TbSueldo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbPuesto)
        Me.Controls.Add(Me.TbApellidos)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Bactualizar)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.DGempleado)
        Me.Controls.Add(Me.Bcerrar)
        Me.Controls.Add(Me.Bminimizar)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "empleados"
        Me.Text = "Apellidos"
        CType(Me.DGempleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bcerrar As Button
    Friend WithEvents Bminimizar As Button
    Friend WithEvents DGempleado As DataGridView
    Friend WithEvents Bagregar As Button
    Friend WithEvents Bactualizar As Button
    Friend WithEvents Beliminar As Button
    Friend WithEvents TbId As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents TbApellidos As TextBox
    Friend WithEvents TbPuesto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbSueldo As TextBox
    Friend WithEvents Brefresh As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
End Class
