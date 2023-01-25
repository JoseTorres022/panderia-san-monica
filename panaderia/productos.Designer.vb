<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productos))
        Me.DGproductos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Bactualizar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Brefresh = New System.Windows.Forms.Button()
        Me.TbPreparacion = New System.Windows.Forms.TextBox()
        Me.TbPrecioUni = New System.Windows.Forms.TextBox()
        Me.TbNomProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DGproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGproductos
        '
        Me.DGproductos.AllowUserToAddRows = False
        Me.DGproductos.AllowUserToDeleteRows = False
        Me.DGproductos.AllowUserToResizeColumns = False
        Me.DGproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGproductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGproductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DGproductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGproductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGproductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGproductos.ColumnHeadersHeight = 40
        Me.DGproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGproductos.EnableHeadersVisualStyles = False
        Me.DGproductos.GridColor = System.Drawing.Color.SteelBlue
        Me.DGproductos.Location = New System.Drawing.Point(13, 472)
        Me.DGproductos.Margin = New System.Windows.Forms.Padding(4)
        Me.DGproductos.Name = "DGproductos"
        Me.DGproductos.ReadOnly = True
        Me.DGproductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGproductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGproductos.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DGproductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGproductos.RowTemplate.Height = 25
        Me.DGproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGproductos.Size = New System.Drawing.Size(475, 215)
        Me.DGproductos.TabIndex = 36
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
        Me.Button1.TabIndex = 38
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
        Me.Button2.TabIndex = 37
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(324, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Panaderia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(31, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 21)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Pasteleria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(2, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(486, 69)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Santa Monica"
        '
        'Beliminar
        '
        Me.Beliminar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Beliminar.FlatAppearance.BorderSize = 0
        Me.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Beliminar.ForeColor = System.Drawing.Color.White
        Me.Beliminar.Location = New System.Drawing.Point(13, 415)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(150, 50)
        Me.Beliminar.TabIndex = 75
        Me.Beliminar.Text = "Eliminar Datos"
        Me.Beliminar.UseVisualStyleBackColor = False
        '
        'Bactualizar
        '
        Me.Bactualizar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bactualizar.FlatAppearance.BorderSize = 0
        Me.Bactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bactualizar.ForeColor = System.Drawing.Color.White
        Me.Bactualizar.Location = New System.Drawing.Point(176, 415)
        Me.Bactualizar.Name = "Bactualizar"
        Me.Bactualizar.Size = New System.Drawing.Size(150, 50)
        Me.Bactualizar.TabIndex = 74
        Me.Bactualizar.Text = "Actualizar Datos"
        Me.Bactualizar.UseVisualStyleBackColor = False
        '
        'Bagregar
        '
        Me.Bagregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bagregar.FlatAppearance.BorderSize = 0
        Me.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bagregar.ForeColor = System.Drawing.Color.White
        Me.Bagregar.Location = New System.Drawing.Point(13, 359)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(475, 50)
        Me.Bagregar.TabIndex = 73
        Me.Bagregar.Text = "Agregar Datos"
        Me.Bagregar.UseVisualStyleBackColor = False
        '
        'Brefresh
        '
        Me.Brefresh.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Brefresh.FlatAppearance.BorderSize = 0
        Me.Brefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brefresh.ForeColor = System.Drawing.Color.White
        Me.Brefresh.Location = New System.Drawing.Point(338, 415)
        Me.Brefresh.Name = "Brefresh"
        Me.Brefresh.Size = New System.Drawing.Size(150, 50)
        Me.Brefresh.TabIndex = 72
        Me.Brefresh.Text = "Refrescar BD"
        Me.Brefresh.UseVisualStyleBackColor = False
        '
        'TbPreparacion
        '
        Me.TbPreparacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbPreparacion.Location = New System.Drawing.Point(162, 302)
        Me.TbPreparacion.Name = "TbPreparacion"
        Me.TbPreparacion.Size = New System.Drawing.Size(250, 20)
        Me.TbPreparacion.TabIndex = 4
        '
        'TbPrecioUni
        '
        Me.TbPrecioUni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbPrecioUni.Location = New System.Drawing.Point(162, 264)
        Me.TbPrecioUni.Name = "TbPrecioUni"
        Me.TbPrecioUni.Size = New System.Drawing.Size(250, 20)
        Me.TbPrecioUni.TabIndex = 3
        '
        'TbNomProducto
        '
        Me.TbNomProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNomProducto.Location = New System.Drawing.Point(162, 230)
        Me.TbNomProducto.Name = "TbNomProducto"
        Me.TbNomProducto.Size = New System.Drawing.Size(250, 20)
        Me.TbNomProducto.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Preparacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 21)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Precio Unidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "IdProducto"
        '
        'TbId
        '
        Me.TbId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbId.Location = New System.Drawing.Point(31, 195)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 20)
        Me.TbId.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(238, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(250, 27)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Sistema Productos"
        '
        'productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.panaderia.My.Resources.Resources.wp5590864_dark_mobile_wallpapers
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(500, 700)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbPreparacion)
        Me.Controls.Add(Me.TbPrecioUni)
        Me.Controls.Add(Me.TbNomProducto)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Bactualizar)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.Brefresh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DGproductos)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "productos"
        Me.Text = "productos"
        CType(Me.DGproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGproductos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Beliminar As Button
    Friend WithEvents Bactualizar As Button
    Friend WithEvents Bagregar As Button
    Friend WithEvents Brefresh As Button
    Friend WithEvents TbPreparacion As TextBox
    Friend WithEvents TbPrecioUni As TextBox
    Friend WithEvents TbNomProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbId As TextBox
    Friend WithEvents Label11 As Label
End Class
