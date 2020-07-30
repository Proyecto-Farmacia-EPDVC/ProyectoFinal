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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarcategoria = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btncargar = New System.Windows.Forms.PictureBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtfecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtprecio_venta = New System.Windows.Forms.TextBox()
        Me.txtnom_categoria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprecio_compra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.DLG = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(302, 12)
        Me.txtflag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(34, 22)
        Me.txtflag.TabIndex = 26
        Me.txtflag.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtflag)
        Me.GroupBox1.Controls.Add(Me.btnbuscarcategoria)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btncargar)
        Me.GroupBox1.Controls.Add(Me.imagen)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtfecha_vencimiento)
        Me.GroupBox1.Controls.Add(Me.Label9)
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
        Me.GroupBox1.Location = New System.Drawing.Point(32, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(365, 436)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interaccion"
        '
        'btnbuscarcategoria
        '
        Me.btnbuscarcategoria.Location = New System.Drawing.Point(327, 122)
        Me.btnbuscarcategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscarcategoria.Name = "btnbuscarcategoria"
        Me.btnbuscarcategoria.Size = New System.Drawing.Size(34, 22)
        Me.btnbuscarcategoria.TabIndex = 18
        Me.btnbuscarcategoria.Text = "..."
        Me.btnbuscarcategoria.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(229, 348)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 57)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'btncargar
        '
        Me.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncargar.Image = CType(resources.GetObject("btncargar.Image"), System.Drawing.Image)
        Me.btncargar.Location = New System.Drawing.Point(296, 348)
        Me.btncargar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(60, 64)
        Me.btncargar.TabIndex = 24
        Me.btncargar.TabStop = False
        '
        'imagen
        '
        Me.imagen.BackgroundImage = CType(resources.GetObject("imagen.BackgroundImage"), System.Drawing.Image)
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.InitialImage = Global.Loginfarmacia.My.Resources.Resources.transparente
        Me.imagen.Location = New System.Drawing.Point(84, 331)
        Me.imagen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(140, 96)
        Me.imagen.TabIndex = 23
        Me.imagen.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Imagen"
        '
        'txtfecha_vencimiento
        '
        Me.txtfecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_vencimiento.Location = New System.Drawing.Point(101, 293)
        Me.txtfecha_vencimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfecha_vencimiento.Name = "txtfecha_vencimiento"
        Me.txtfecha_vencimiento.Size = New System.Drawing.Size(123, 22)
        Me.txtfecha_vencimiento.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fecha V" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(-4, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Precio Venta"
        '
        'txtprecio_venta
        '
        Me.txtprecio_venta.Location = New System.Drawing.Point(101, 260)
        Me.txtprecio_venta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprecio_venta.MaxLength = 8
        Me.txtprecio_venta.Name = "txtprecio_venta"
        Me.txtprecio_venta.Size = New System.Drawing.Size(123, 22)
        Me.txtprecio_venta.TabIndex = 18
        '
        'txtnom_categoria
        '
        Me.txtnom_categoria.Location = New System.Drawing.Point(199, 114)
        Me.txtnom_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnom_categoria.Name = "txtnom_categoria"
        Me.txtnom_categoria.ReadOnly = True
        Me.txtnom_categoria.Size = New System.Drawing.Size(123, 22)
        Me.txtnom_categoria.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-4, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Precio Compra"
        '
        'txtprecio_compra
        '
        Me.txtprecio_compra.Location = New System.Drawing.Point(101, 224)
        Me.txtprecio_compra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprecio_compra.MaxLength = 8
        Me.txtprecio_compra.Name = "txtprecio_compra"
        Me.txtprecio_compra.Size = New System.Drawing.Size(123, 22)
        Me.txtprecio_compra.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Stock"
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(101, 196)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtstock.MaxLength = 9
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(123, 22)
        Me.txtstock.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripcion"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(101, 150)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(235, 42)
        Me.txtdescripcion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoria"
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(101, 114)
        Me.txtidcategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.ReadOnly = True
        Me.txtidcategoria.Size = New System.Drawing.Size(92, 22)
        Me.txtidcategoria.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(101, 74)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(235, 22)
        Me.txtnombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Producto"
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(101, 46)
        Me.txtidproducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(235, 22)
        Me.txtidproducto.TabIndex = 0
        '
        'DLG
        '
        Me.DLG.FileName = "OpenFileDialog1"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(805, 334)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(105, 46)
        Me.btneliminar.TabIndex = 21
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(670, 334)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(114, 46)
        Me.btnnuevo.TabIndex = 19
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(549, 334)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(105, 46)
        Me.btnguardar.TabIndex = 22
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(549, 334)
        Me.btneditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(105, 46)
        Me.btneditar.TabIndex = 20
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Busqueda por producto"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(211, 164)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(123, 17)
        Me.inexistente.TabIndex = 17
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(174, 36)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(235, 22)
        Me.txtbuscar.TabIndex = 16
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(11, 76)
        Me.datalistado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersWidth = 51
        Me.datalistado.RowTemplate.Height = 28
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(528, 201)
        Me.datalistado.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Location = New System.Drawing.Point(404, 14)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(539, 302)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "lista productos"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(975, 459)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmProductos"
        Me.Text = "Articulos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtflag As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscarcategoria As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btncargar As PictureBox
    Friend WithEvents imagen As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfecha_vencimiento As DateTimePicker
    Friend WithEvents Label9 As Label
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
    Friend WithEvents DLG As OpenFileDialog
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
End Class
