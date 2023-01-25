<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pedidos))
        Me.DGpedidos = New System.Windows.Forms.DataGridView()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Bactualizar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Brefresh = New System.Windows.Forms.Button()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.TbUnidades = New System.Windows.Forms.TextBox()
        Me.TbProductos = New System.Windows.Forms.TextBox()
        Me.TbCliente = New System.Windows.Forms.TextBox()
        Me.TbTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DGpedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGpedidos
        '
        Me.DGpedidos.AllowUserToAddRows = False
        Me.DGpedidos.AllowUserToDeleteRows = False
        Me.DGpedidos.AllowUserToResizeColumns = False
        Me.DGpedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGpedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGpedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DGpedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGpedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGpedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGpedidos.ColumnHeadersHeight = 40
        Me.DGpedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGpedidos.EnableHeadersVisualStyles = False
        Me.DGpedidos.GridColor = System.Drawing.Color.SteelBlue
        Me.DGpedidos.Location = New System.Drawing.Point(12, 527)
        Me.DGpedidos.Margin = New System.Windows.Forms.Padding(4)
        Me.DGpedidos.Name = "DGpedidos"
        Me.DGpedidos.ReadOnly = True
        Me.DGpedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGpedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGpedidos.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DGpedidos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGpedidos.RowTemplate.Height = 25
        Me.DGpedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGpedidos.Size = New System.Drawing.Size(475, 260)
        Me.DGpedidos.TabIndex = 37
        '
        'Beliminar
        '
        Me.Beliminar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Beliminar.FlatAppearance.BorderSize = 0
        Me.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Beliminar.ForeColor = System.Drawing.Color.White
        Me.Beliminar.Location = New System.Drawing.Point(12, 455)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(150, 50)
        Me.Beliminar.TabIndex = 79
        Me.Beliminar.Text = "Eliminar Datos"
        Me.Beliminar.UseVisualStyleBackColor = False
        '
        'Bactualizar
        '
        Me.Bactualizar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bactualizar.FlatAppearance.BorderSize = 0
        Me.Bactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bactualizar.ForeColor = System.Drawing.Color.White
        Me.Bactualizar.Location = New System.Drawing.Point(175, 455)
        Me.Bactualizar.Name = "Bactualizar"
        Me.Bactualizar.Size = New System.Drawing.Size(150, 50)
        Me.Bactualizar.TabIndex = 78
        Me.Bactualizar.Text = "Actualizar Datos"
        Me.Bactualizar.UseVisualStyleBackColor = False
        '
        'Bagregar
        '
        Me.Bagregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bagregar.FlatAppearance.BorderSize = 0
        Me.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bagregar.ForeColor = System.Drawing.Color.White
        Me.Bagregar.Location = New System.Drawing.Point(12, 399)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(475, 50)
        Me.Bagregar.TabIndex = 77
        Me.Bagregar.Text = "Agregar Datos"
        Me.Bagregar.UseVisualStyleBackColor = False
        '
        'Brefresh
        '
        Me.Brefresh.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Brefresh.FlatAppearance.BorderSize = 0
        Me.Brefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brefresh.ForeColor = System.Drawing.Color.White
        Me.Brefresh.Location = New System.Drawing.Point(337, 455)
        Me.Brefresh.Name = "Brefresh"
        Me.Brefresh.Size = New System.Drawing.Size(150, 50)
        Me.Brefresh.TabIndex = 76
        Me.Brefresh.Text = "Refrescar BD"
        Me.Brefresh.UseVisualStyleBackColor = False
        '
        'TbId
        '
        Me.TbId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbId.Location = New System.Drawing.Point(52, 205)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 20)
        Me.TbId.TabIndex = 1
        '
        'TbUnidades
        '
        Me.TbUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbUnidades.Location = New System.Drawing.Point(183, 312)
        Me.TbUnidades.Name = "TbUnidades"
        Me.TbUnidades.Size = New System.Drawing.Size(250, 20)
        Me.TbUnidades.TabIndex = 4
        '
        'TbProductos
        '
        Me.TbProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbProductos.Location = New System.Drawing.Point(183, 274)
        Me.TbProductos.Name = "TbProductos"
        Me.TbProductos.Size = New System.Drawing.Size(250, 20)
        Me.TbProductos.TabIndex = 3
        '
        'TbCliente
        '
        Me.TbCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbCliente.Location = New System.Drawing.Point(183, 240)
        Me.TbCliente.Name = "TbCliente"
        Me.TbCliente.Size = New System.Drawing.Size(250, 20)
        Me.TbCliente.TabIndex = 2
        '
        'TbTotal
        '
        Me.TbTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbTotal.Location = New System.Drawing.Point(183, 354)
        Me.TbTotal.Name = "TbTotal"
        Me.TbTotal.Size = New System.Drawing.Size(250, 20)
        Me.TbTotal.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "IdPedidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(54, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(54, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Productos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(54, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Unidades"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 21)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Total"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.panaderia.My.Resources.Resources.minimizar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(432, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 94
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
        Me.Button2.Location = New System.Drawing.Point(463, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 93
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(334, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Panaderia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(41, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 21)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Pasteleria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(486, 69)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Santa Monica"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(266, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(222, 27)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Sistema Pedidos"
        '
        'pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.panaderia.My.Resources.Resources.wp5725852_material_design_phone_wallpapers
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(500, 800)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbTotal)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.TbUnidades)
        Me.Controls.Add(Me.TbProductos)
        Me.Controls.Add(Me.TbCliente)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Bactualizar)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.Brefresh)
        Me.Controls.Add(Me.DGpedidos)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pedidos"
        Me.Text = "pedidos"
        CType(Me.DGpedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGpedidos As DataGridView
    Friend WithEvents Beliminar As Button
    Friend WithEvents Bactualizar As Button
    Friend WithEvents Bagregar As Button
    Friend WithEvents Brefresh As Button
    Friend WithEvents TbId As TextBox
    Friend WithEvents TbUnidades As TextBox
    Friend WithEvents TbProductos As TextBox
    Friend WithEvents TbCliente As TextBox
    Friend WithEvents TbTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
End Class
