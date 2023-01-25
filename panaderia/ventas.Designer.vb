<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ventas))
        Me.DGventas = New System.Windows.Forms.DataGridView()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Brefresh = New System.Windows.Forms.Button()
        Me.TbTotalTicket = New System.Windows.Forms.TextBox()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.TbPieVendidas = New System.Windows.Forms.TextBox()
        Me.TbPreUnidad = New System.Windows.Forms.TextBox()
        Me.TbProducto = New System.Windows.Forms.TextBox()
        Me.TbFecha = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DGventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGventas
        '
        Me.DGventas.AllowUserToAddRows = False
        Me.DGventas.AllowUserToDeleteRows = False
        Me.DGventas.AllowUserToResizeColumns = False
        Me.DGventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGventas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DGventas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGventas.ColumnHeadersHeight = 40
        Me.DGventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGventas.EnableHeadersVisualStyles = False
        Me.DGventas.GridColor = System.Drawing.Color.SteelBlue
        Me.DGventas.Location = New System.Drawing.Point(13, 577)
        Me.DGventas.Margin = New System.Windows.Forms.Padding(4)
        Me.DGventas.Name = "DGventas"
        Me.DGventas.ReadOnly = True
        Me.DGventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGventas.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DGventas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGventas.RowTemplate.Height = 25
        Me.DGventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGventas.Size = New System.Drawing.Size(574, 260)
        Me.DGventas.TabIndex = 38
        '
        'Bagregar
        '
        Me.Bagregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bagregar.FlatAppearance.BorderSize = 0
        Me.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bagregar.ForeColor = System.Drawing.Color.White
        Me.Bagregar.Location = New System.Drawing.Point(12, 520)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(150, 50)
        Me.Bagregar.TabIndex = 78
        Me.Bagregar.Text = "Agregar Datos"
        Me.Bagregar.UseVisualStyleBackColor = False
        '
        'Brefresh
        '
        Me.Brefresh.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Brefresh.FlatAppearance.BorderSize = 0
        Me.Brefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brefresh.ForeColor = System.Drawing.Color.White
        Me.Brefresh.Location = New System.Drawing.Point(187, 520)
        Me.Brefresh.Name = "Brefresh"
        Me.Brefresh.Size = New System.Drawing.Size(400, 50)
        Me.Brefresh.TabIndex = 79
        Me.Brefresh.Text = "Refrescar BD"
        Me.Brefresh.UseVisualStyleBackColor = False
        '
        'TbTotalTicket
        '
        Me.TbTotalTicket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbTotalTicket.Location = New System.Drawing.Point(217, 442)
        Me.TbTotalTicket.Name = "TbTotalTicket"
        Me.TbTotalTicket.Size = New System.Drawing.Size(250, 20)
        Me.TbTotalTicket.TabIndex = 92
        '
        'TbId
        '
        Me.TbId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbId.Location = New System.Drawing.Point(86, 293)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 20)
        Me.TbId.TabIndex = 91
        '
        'TbPieVendidas
        '
        Me.TbPieVendidas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbPieVendidas.Location = New System.Drawing.Point(217, 400)
        Me.TbPieVendidas.Name = "TbPieVendidas"
        Me.TbPieVendidas.Size = New System.Drawing.Size(250, 20)
        Me.TbPieVendidas.TabIndex = 90
        '
        'TbPreUnidad
        '
        Me.TbPreUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbPreUnidad.Location = New System.Drawing.Point(217, 362)
        Me.TbPreUnidad.Name = "TbPreUnidad"
        Me.TbPreUnidad.Size = New System.Drawing.Size(250, 20)
        Me.TbPreUnidad.TabIndex = 89
        '
        'TbProducto
        '
        Me.TbProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbProducto.Location = New System.Drawing.Point(217, 328)
        Me.TbProducto.Name = "TbProducto"
        Me.TbProducto.Size = New System.Drawing.Size(250, 20)
        Me.TbProducto.TabIndex = 88
        '
        'TbFecha
        '
        Me.TbFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbFecha.Location = New System.Drawing.Point(217, 482)
        Me.TbFecha.Name = "TbFecha"
        Me.TbFecha.Size = New System.Drawing.Size(250, 20)
        Me.TbFecha.TabIndex = 93
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.panaderia.My.Resources.Resources.minimizar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(532, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 96
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
        Me.Button2.Location = New System.Drawing.Point(563, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 95
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(123, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 21)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(93, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 21)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Precio Unidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(78, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 21)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Piezas Vendidas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(113, 441)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "total Ticket"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(102, 482)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Fecha Ticket"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(86, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 21)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Id Ticket"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(407, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 21)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Panaderia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(63, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 21)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Pasteleria"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 57.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(587, 81)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Santa Monica"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(338, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 27)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Sistema Ventas"
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.panaderia.My.Resources.Resources.wp3937417_night_mountains_wallpapers__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 850)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TbFecha)
        Me.Controls.Add(Me.TbTotalTicket)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.TbPieVendidas)
        Me.Controls.Add(Me.TbPreUnidad)
        Me.Controls.Add(Me.TbProducto)
        Me.Controls.Add(Me.Brefresh)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.DGventas)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ventas"
        Me.Text = "ventas"
        CType(Me.DGventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGventas As DataGridView
    Friend WithEvents Bagregar As Button
    Friend WithEvents Brefresh As Button
    Friend WithEvents TbTotalTicket As TextBox
    Friend WithEvents TbId As TextBox
    Friend WithEvents TbPieVendidas As TextBox
    Friend WithEvents TbPreUnidad As TextBox
    Friend WithEvents TbProducto As TextBox
    Friend WithEvents TbFecha As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
End Class
