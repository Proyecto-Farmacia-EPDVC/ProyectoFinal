﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalles_venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalles_venta))
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtstock = New System.Windows.Forms.NumericUpDown()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtprecio_unitario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.txtnom_producto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.CMBtipo_documento = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnum_documento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnimprimir
        '
        Me.btnimprimir.BackgroundImage = CType(resources.GetObject("btnimprimir.BackgroundImage"), System.Drawing.Image)
        Me.btnimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnimprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimir.Location = New System.Drawing.Point(783, 461)
        Me.btnimprimir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(86, 43)
        Me.btnimprimir.TabIndex = 23
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtprecio_unitario)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.txtnom_producto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtidproducto)
        Me.GroupBox1.Controls.Add(Me.CMBtipo_documento)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.txtnombre_cliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnum_documento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidventa)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(78, 97)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(396, 420)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(265, 321)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtstock.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtstock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(80, 26)
        Me.txtstock.TabIndex = 30
        Me.txtstock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(98, 317)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(80, 26)
        Me.txtcantidad.TabIndex = 29
        '
        'txtprecio_unitario
        '
        Me.txtprecio_unitario.Location = New System.Drawing.Point(135, 358)
        Me.txtprecio_unitario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtprecio_unitario.MaxLength = 9
        Me.txtprecio_unitario.Name = "txtprecio_unitario"
        Me.txtprecio_unitario.Size = New System.Drawing.Size(70, 26)
        Me.txtprecio_unitario.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 364)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Precio Unitario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(197, 323)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 323)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Cantidad"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(278, 281)
        Me.btnBuscarProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(40, 18)
        Me.btnBuscarProducto.TabIndex = 24
        Me.btnBuscarProducto.Text = "..."
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'txtnom_producto
        '
        Me.txtnom_producto.Location = New System.Drawing.Point(130, 276)
        Me.txtnom_producto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnom_producto.Name = "txtnom_producto"
        Me.txtnom_producto.ReadOnly = True
        Me.txtnom_producto.Size = New System.Drawing.Size(131, 26)
        Me.txtnom_producto.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 279)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Producto"
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(98, 276)
        Me.txtidproducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.ReadOnly = True
        Me.txtidproducto.Size = New System.Drawing.Size(28, 26)
        Me.txtidproducto.TabIndex = 21
        '
        'CMBtipo_documento
        '
        Me.CMBtipo_documento.FormattingEnabled = True
        Me.CMBtipo_documento.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.CMBtipo_documento.Location = New System.Drawing.Point(116, 185)
        Me.CMBtipo_documento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CMBtipo_documento.Name = "CMBtipo_documento"
        Me.CMBtipo_documento.Size = New System.Drawing.Size(177, 28)
        Me.CMBtipo_documento.TabIndex = 20
        Me.CMBtipo_documento.Text = "Factura"
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(103, 143)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(177, 26)
        Me.txtfecha.TabIndex = 19
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.Location = New System.Drawing.Point(138, 103)
        Me.txtnombre_cliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.ReadOnly = True
        Me.txtnombre_cliente.Size = New System.Drawing.Size(131, 26)
        Me.txtnombre_cliente.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 230)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero Doc"
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Location = New System.Drawing.Point(118, 224)
        Me.txtnum_documento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnum_documento.MaxLength = 9
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.Size = New System.Drawing.Size(177, 26)
        Me.txtnum_documento.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo Doc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente"
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(103, 103)
        Me.txtidcliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.ReadOnly = True
        Me.txtidcliente.Size = New System.Drawing.Size(28, 26)
        Me.txtidcliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID venta"
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(114, 52)
        Me.txtidventa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.ReadOnly = True
        Me.txtidventa.Size = New System.Drawing.Size(177, 26)
        Me.txtidventa.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(489, 116)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(541, 298)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "lista articulos"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(220, 166)
        Me.inexistente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(160, 20)
        Me.inexistente.TabIndex = 17
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(27, 52)
        Me.datalistado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersWidth = 51
        Me.datalistado.RowTemplate.Height = 28
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(484, 207)
        Me.datalistado.TabIndex = 0
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(665, 461)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(84, 43)
        Me.btnguardar.TabIndex = 22
        Me.btnguardar.Text = "Agregar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackgroundImage = CType(resources.GetObject("btnnuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Location = New System.Drawing.Point(549, 461)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(86, 43)
        Me.btnnuevo.TabIndex = 20
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'frmDetalles_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 612)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnnuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmDetalles_venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalles_venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnimprimir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtstock As NumericUpDown
    Friend WithEvents txtcantidad As NumericUpDown
    Friend WithEvents txtprecio_unitario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents txtnom_producto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents CMBtipo_documento As ComboBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents txtnombre_cliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnum_documento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
End Class
