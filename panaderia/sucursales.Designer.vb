<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sucursales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sucursales))
        Me.DGsucursales = New System.Windows.Forms.DataGridView()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Bactualizar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Brefresh = New System.Windows.Forms.Button()
        Me.TbDirSucursal = New System.Windows.Forms.TextBox()
        Me.TbNomSucursal = New System.Windows.Forms.TextBox()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DGsucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGsucursales
        '
        Me.DGsucursales.AllowUserToAddRows = False
        Me.DGsucursales.AllowUserToDeleteRows = False
        Me.DGsucursales.AllowUserToResizeColumns = False
        Me.DGsucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGsucursales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGsucursales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DGsucursales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGsucursales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGsucursales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGsucursales.ColumnHeadersHeight = 40
        Me.DGsucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGsucursales.EnableHeadersVisualStyles = False
        Me.DGsucursales.GridColor = System.Drawing.Color.SteelBlue
        Me.DGsucursales.Location = New System.Drawing.Point(13, 409)
        Me.DGsucursales.Margin = New System.Windows.Forms.Padding(4)
        Me.DGsucursales.Name = "DGsucursales"
        Me.DGsucursales.ReadOnly = True
        Me.DGsucursales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGsucursales.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGsucursales.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DGsucursales.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGsucursales.RowTemplate.Height = 25
        Me.DGsucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGsucursales.Size = New System.Drawing.Size(473, 378)
        Me.DGsucursales.TabIndex = 36
        '
        'Beliminar
        '
        Me.Beliminar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Beliminar.FlatAppearance.BorderSize = 0
        Me.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Beliminar.ForeColor = System.Drawing.Color.White
        Me.Beliminar.Location = New System.Drawing.Point(14, 352)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(150, 50)
        Me.Beliminar.TabIndex = 51
        Me.Beliminar.Text = "Eliminar Datos"
        Me.Beliminar.UseVisualStyleBackColor = False
        '
        'Bactualizar
        '
        Me.Bactualizar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bactualizar.FlatAppearance.BorderSize = 0
        Me.Bactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bactualizar.ForeColor = System.Drawing.Color.White
        Me.Bactualizar.Location = New System.Drawing.Point(170, 352)
        Me.Bactualizar.Name = "Bactualizar"
        Me.Bactualizar.Size = New System.Drawing.Size(150, 50)
        Me.Bactualizar.TabIndex = 50
        Me.Bactualizar.Text = "Actualizar Datos"
        Me.Bactualizar.UseVisualStyleBackColor = False
        '
        'Bagregar
        '
        Me.Bagregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bagregar.FlatAppearance.BorderSize = 0
        Me.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bagregar.ForeColor = System.Drawing.Color.White
        Me.Bagregar.Location = New System.Drawing.Point(14, 296)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(472, 50)
        Me.Bagregar.TabIndex = 49
        Me.Bagregar.Text = "Agregar Datos"
        Me.Bagregar.UseVisualStyleBackColor = False
        '
        'Brefresh
        '
        Me.Brefresh.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Brefresh.FlatAppearance.BorderSize = 0
        Me.Brefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brefresh.ForeColor = System.Drawing.Color.White
        Me.Brefresh.Location = New System.Drawing.Point(326, 352)
        Me.Brefresh.Name = "Brefresh"
        Me.Brefresh.Size = New System.Drawing.Size(161, 50)
        Me.Brefresh.TabIndex = 48
        Me.Brefresh.Text = "Refrescar BD"
        Me.Brefresh.UseVisualStyleBackColor = False
        '
        'TbDirSucursal
        '
        Me.TbDirSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbDirSucursal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TbDirSucursal.Location = New System.Drawing.Point(185, 236)
        Me.TbDirSucursal.Name = "TbDirSucursal"
        Me.TbDirSucursal.Size = New System.Drawing.Size(250, 20)
        Me.TbDirSucursal.TabIndex = 3
        '
        'TbNomSucursal
        '
        Me.TbNomSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNomSucursal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TbNomSucursal.Location = New System.Drawing.Point(185, 198)
        Me.TbNomSucursal.Name = "TbNomSucursal"
        Me.TbNomSucursal.Size = New System.Drawing.Size(250, 20)
        Me.TbNomSucursal.TabIndex = 2
        '
        'TbId
        '
        Me.TbId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbId.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TbId.Location = New System.Drawing.Point(185, 164)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 20)
        Me.TbId.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 21)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Direccion de Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 21)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nombre de Sucursal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(90, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "IdSucursal"
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
        Me.Button1.TabIndex = 59
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
        Me.Button2.TabIndex = 58
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(486, 69)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Santa Monica"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(44, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Pasteleria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(326, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Panaderia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(129, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 27)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Sistema Sucursales"
        '
        'sucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.panaderia.My.Resources.Resources.wp5725952_material_design_phone_wallpapers
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(500, 800)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbDirSucursal)
        Me.Controls.Add(Me.TbNomSucursal)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Bactualizar)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.Brefresh)
        Me.Controls.Add(Me.DGsucursales)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "sucursales"
        Me.Text = "sucursales"
        CType(Me.DGsucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGsucursales As DataGridView
    Friend WithEvents Beliminar As Button
    Friend WithEvents Bactualizar As Button
    Friend WithEvents Bagregar As Button
    Friend WithEvents Brefresh As Button
    Friend WithEvents TbDirSucursal As TextBox
    Friend WithEvents TbNomSucursal As TextBox
    Friend WithEvents TbId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
End Class
