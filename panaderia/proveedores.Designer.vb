<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(proveedores))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGproveedores = New System.Windows.Forms.DataGridView()
        Me.TbUnidad = New System.Windows.Forms.TextBox()
        Me.TbRepartidor = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Brefresh = New System.Windows.Forms.Button()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Bactualizar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DGproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.panaderia.My.Resources.Resources.minimizar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(458, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 34
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
        Me.Button2.Location = New System.Drawing.Point(489, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 33
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DGproveedores
        '
        Me.DGproveedores.AllowUserToAddRows = False
        Me.DGproveedores.AllowUserToDeleteRows = False
        Me.DGproveedores.AllowUserToResizeColumns = False
        Me.DGproveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGproveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGproveedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DGproveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGproveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGproveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGproveedores.ColumnHeadersHeight = 40
        Me.DGproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGproveedores.EnableHeadersVisualStyles = False
        Me.DGproveedores.GridColor = System.Drawing.Color.SteelBlue
        Me.DGproveedores.Location = New System.Drawing.Point(11, 472)
        Me.DGproveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.DGproveedores.Name = "DGproveedores"
        Me.DGproveedores.ReadOnly = True
        Me.DGproveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGproveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGproveedores.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DGproveedores.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGproveedores.RowTemplate.Height = 25
        Me.DGproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGproveedores.Size = New System.Drawing.Size(500, 215)
        Me.DGproveedores.TabIndex = 35
        '
        'TbUnidad
        '
        Me.TbUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbUnidad.Location = New System.Drawing.Point(129, 310)
        Me.TbUnidad.Name = "TbUnidad"
        Me.TbUnidad.Size = New System.Drawing.Size(250, 20)
        Me.TbUnidad.TabIndex = 4
        '
        'TbRepartidor
        '
        Me.TbRepartidor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbRepartidor.Location = New System.Drawing.Point(129, 272)
        Me.TbRepartidor.Name = "TbRepartidor"
        Me.TbRepartidor.Size = New System.Drawing.Size(250, 20)
        Me.TbRepartidor.TabIndex = 3
        '
        'TbNombre
        '
        Me.TbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNombre.Location = New System.Drawing.Point(129, 238)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(250, 20)
        Me.TbNombre.TabIndex = 2
        '
        'TbId
        '
        Me.TbId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbId.Location = New System.Drawing.Point(30, 202)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 20)
        Me.TbId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(30, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "IdProveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(30, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(30, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Repartidor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(29, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Unidad"
        '
        'Brefresh
        '
        Me.Brefresh.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Brefresh.FlatAppearance.BorderSize = 0
        Me.Brefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brefresh.ForeColor = System.Drawing.Color.White
        Me.Brefresh.Location = New System.Drawing.Point(361, 412)
        Me.Brefresh.Name = "Brefresh"
        Me.Brefresh.Size = New System.Drawing.Size(150, 50)
        Me.Brefresh.TabIndex = 44
        Me.Brefresh.Text = "Refrescar BD"
        Me.Brefresh.UseVisualStyleBackColor = False
        '
        'Beliminar
        '
        Me.Beliminar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Beliminar.FlatAppearance.BorderSize = 0
        Me.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Beliminar.ForeColor = System.Drawing.Color.White
        Me.Beliminar.Location = New System.Drawing.Point(10, 412)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(150, 50)
        Me.Beliminar.TabIndex = 47
        Me.Beliminar.Text = "Eliminar Datos"
        Me.Beliminar.UseVisualStyleBackColor = False
        '
        'Bactualizar
        '
        Me.Bactualizar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bactualizar.FlatAppearance.BorderSize = 0
        Me.Bactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bactualizar.ForeColor = System.Drawing.Color.White
        Me.Bactualizar.Location = New System.Drawing.Point(185, 412)
        Me.Bactualizar.Name = "Bactualizar"
        Me.Bactualizar.Size = New System.Drawing.Size(150, 50)
        Me.Bactualizar.TabIndex = 46
        Me.Bactualizar.Text = "Actualizar Datos"
        Me.Bactualizar.UseVisualStyleBackColor = False
        '
        'Bagregar
        '
        Me.Bagregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bagregar.FlatAppearance.BorderSize = 0
        Me.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bagregar.ForeColor = System.Drawing.Color.White
        Me.Bagregar.Location = New System.Drawing.Point(11, 356)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(500, 50)
        Me.Bagregar.TabIndex = 45
        Me.Bagregar.Text = "Agregar Datos"
        Me.Bagregar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(352, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Panaderia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(59, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 21)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Pasteleria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(30, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(486, 69)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Santa Monica"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(238, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(278, 27)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Sistema Proveedores"
        '
        'proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.panaderia.My.Resources.Resources.wp5275540_design_mobile_wallpapers
        Me.ClientSize = New System.Drawing.Size(526, 700)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Bactualizar)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.Brefresh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbUnidad)
        Me.Controls.Add(Me.TbRepartidor)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.DGproveedores)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "proveedores"
        Me.Text = "proveedores"
        CType(Me.DGproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DGproveedores As DataGridView
    Friend WithEvents TbUnidad As TextBox
    Friend WithEvents TbRepartidor As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents TbId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Brefresh As Button
    Friend WithEvents Beliminar As Button
    Friend WithEvents Bactualizar As Button
    Friend WithEvents Bagregar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
End Class
