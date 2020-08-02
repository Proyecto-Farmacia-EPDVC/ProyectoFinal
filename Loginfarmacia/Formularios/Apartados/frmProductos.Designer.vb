<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.DLG = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprecio_compra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnom_categoria = New System.Windows.Forms.TextBox()
        Me.txtprecio_venta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.btncargar = New System.Windows.Forms.PictureBox()
        Me.eliminarImg = New System.Windows.Forms.PictureBox()
        Me.btnbuscarcategoria = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eliminarImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DLG
        '
        Me.DLG.FileName = "OpenFileDialog1"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.Location = New System.Drawing.Point(1281, 279)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(164, 105)
        Me.btnnuevo.TabIndex = 19
        Me.btnnuevo.Text = "NUEVO"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(1281, 120)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(164, 105)
        Me.btnguardar.TabIndex = 22
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btneditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.Image = CType(resources.GetObject("btneditar.Image"), System.Drawing.Image)
        Me.btneditar.Location = New System.Drawing.Point(1281, 120)
        Me.btneditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(164, 105)
        Me.btneditar.TabIndex = 20
        Me.btneditar.Text = "EDITAR"
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(335, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "BUSQUEDA POR NOMBRE"
        '
        'txtbuscar
        '
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscar.Location = New System.Drawing.Point(408, 62)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(266, 28)
        Me.txtbuscar.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.btnnuevo)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.btneditar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(425, 518)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1465, 412)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE PRODUCTOS"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(677, 249)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(226, 29)
        Me.inexistente.TabIndex = 24
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datalistado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado.ColumnHeadersHeight = 38
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle4
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.GridColor = System.Drawing.SystemColors.Highlight
        Me.datalistado.Location = New System.Drawing.Point(139, 106)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowTemplate.Height = 28
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(1091, 278)
        Me.datalistado.TabIndex = 23
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 113
        '
        'txtidproducto
        '
        Me.txtidproducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidproducto.Location = New System.Drawing.Point(328, 72)
        Me.txtidproducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(266, 28)
        Me.txtidproducto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID PRODUCTO"
        '
        'txtnombre
        '
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombre.Location = New System.Drawing.Point(328, 131)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(266, 28)
        Me.txtnombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOMBRE"
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(327, 192)
        Me.txtidcategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.ReadOnly = True
        Me.txtidcategoria.Size = New System.Drawing.Size(46, 35)
        Me.txtidcategoria.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CATEGORIA"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(922, 72)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(264, 116)
        Me.txtdescripcion.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(700, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DESCRIPCIÓN"
        '
        'txtstock
        '
        Me.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtstock.Location = New System.Drawing.Point(922, 229)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtstock.MaxLength = 9
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(140, 28)
        Me.txtstock.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(788, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "STOCK"
        '
        'txtprecio_compra
        '
        Me.txtprecio_compra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtprecio_compra.Location = New System.Drawing.Point(922, 292)
        Me.txtprecio_compra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprecio_compra.MaxLength = 5
        Me.txtprecio_compra.Name = "txtprecio_compra"
        Me.txtprecio_compra.Size = New System.Drawing.Size(140, 28)
        Me.txtprecio_compra.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(662, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "PRECIO COMPRA"
        '
        'txtnom_categoria
        '
        Me.txtnom_categoria.Location = New System.Drawing.Point(382, 192)
        Me.txtnom_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnom_categoria.Name = "txtnom_categoria"
        Me.txtnom_categoria.ReadOnly = True
        Me.txtnom_categoria.Size = New System.Drawing.Size(212, 35)
        Me.txtnom_categoria.TabIndex = 17
        '
        'txtprecio_venta
        '
        Me.txtprecio_venta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtprecio_venta.Location = New System.Drawing.Point(922, 346)
        Me.txtprecio_venta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprecio_venta.MaxLength = 5
        Me.txtprecio_venta.Name = "txtprecio_venta"
        Me.txtprecio_venta.Size = New System.Drawing.Size(140, 28)
        Me.txtprecio_venta.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(687, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 29)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "PRECIO VENTA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(116, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 29)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "FECHA VENTA"
        '
        'txtfecha_vencimiento
        '
        Me.txtfecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_vencimiento.Location = New System.Drawing.Point(328, 258)
        Me.txtfecha_vencimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfecha_vencimiento.MaxDate = New Date(2030, 12, 24, 0, 0, 0, 0)
        Me.txtfecha_vencimiento.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.txtfecha_vencimiento.Name = "txtfecha_vencimiento"
        Me.txtfecha_vencimiento.Size = New System.Drawing.Size(267, 35)
        Me.txtfecha_vencimiento.TabIndex = 21
        Me.txtfecha_vencimiento.Value = New Date(2020, 8, 2, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1259, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 29)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "IMAGEN"
        '
        'imagen
        '
        Me.imagen.BackgroundImage = CType(resources.GetObject("imagen.BackgroundImage"), System.Drawing.Image)
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagen.InitialImage = Global.Loginfarmacia.My.Resources.Resources.transparente
        Me.imagen.Location = New System.Drawing.Point(1238, 72)
        Me.imagen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(158, 154)
        Me.imagen.TabIndex = 23
        Me.imagen.TabStop = False
        '
        'btncargar
        '
        Me.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncargar.Image = CType(resources.GetObject("btncargar.Image"), System.Drawing.Image)
        Me.btncargar.Location = New System.Drawing.Point(1328, 272)
        Me.btncargar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(68, 80)
        Me.btncargar.TabIndex = 24
        Me.btncargar.TabStop = False
        '
        'eliminarImg
        '
        Me.eliminarImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.eliminarImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminarImg.Image = CType(resources.GetObject("eliminarImg.Image"), System.Drawing.Image)
        Me.eliminarImg.Location = New System.Drawing.Point(1238, 272)
        Me.eliminarImg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.eliminarImg.Name = "eliminarImg"
        Me.eliminarImg.Size = New System.Drawing.Size(69, 80)
        Me.eliminarImg.TabIndex = 25
        Me.eliminarImg.TabStop = False
        '
        'btnbuscarcategoria
        '
        Me.btnbuscarcategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscarcategoria.Image = CType(resources.GetObject("btnbuscarcategoria.Image"), System.Drawing.Image)
        Me.btnbuscarcategoria.Location = New System.Drawing.Point(609, 188)
        Me.btnbuscarcategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscarcategoria.Name = "btnbuscarcategoria"
        Me.btnbuscarcategoria.Size = New System.Drawing.Size(55, 44)
        Me.btnbuscarcategoria.TabIndex = 18
        Me.btnbuscarcategoria.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btnbuscarcategoria)
        Me.GroupBox1.Controls.Add(Me.btncargar)
        Me.GroupBox1.Controls.Add(Me.eliminarImg)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtfecha_vencimiento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.imagen)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtprecio_venta)
        Me.GroupBox1.Controls.Add(Me.txtnom_categoria)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtprecio_compra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtidcategoria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidproducto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(425, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1459, 422)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL PRODUCTO"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(327, 111)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(267, 10)
        Me.Panel6.TabIndex = 31
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(328, 171)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(267, 10)
        Me.Panel5.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(328, 238)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(267, 10)
        Me.Panel4.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(922, 204)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(143, 10)
        Me.Panel3.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(922, 270)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(143, 10)
        Me.Panel2.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(922, 330)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(143, 10)
        Me.Panel1.TabIndex = 26
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1942, 942)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmProductos"
        Me.Text = "Articulos"
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eliminarImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DLG As OpenFileDialog
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscarcategoria As Button
    Friend WithEvents btncargar As PictureBox
    Friend WithEvents eliminarImg As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfecha_vencimiento As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents imagen As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtprecio_venta As TextBox
    Friend WithEvents txtnom_categoria As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprecio_compra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidcategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents inexistente As LinkLabel
End Class
