<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbuscarempleado = New System.Windows.Forms.Button()
        Me.txtnomempleado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.CMBtipo_documento = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnum_documento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(455, 77)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(577, 395)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "lista clientes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 29)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Busqueda por # Doc"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(158, 133)
        Me.inexistente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(160, 20)
        Me.inexistente.TabIndex = 17
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(187, 29)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(177, 26)
        Me.txtbuscar.TabIndex = 16
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(54, 133)
        Me.datalistado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersWidth = 51
        Me.datalistado.RowTemplate.Height = 28
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(484, 163)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtbuscarempleado)
        Me.GroupBox1.Controls.Add(Me.txtnomempleado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtidempleado)
        Me.GroupBox1.Controls.Add(Me.CMBtipo_documento)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
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
        Me.GroupBox1.Location = New System.Drawing.Point(26, 63)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(408, 462)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txtbuscarempleado
        '
        Me.txtbuscarempleado.Location = New System.Drawing.Point(274, 166)
        Me.txtbuscarempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbuscarempleado.Name = "txtbuscarempleado"
        Me.txtbuscarempleado.Size = New System.Drawing.Size(40, 18)
        Me.txtbuscarempleado.TabIndex = 24
        Me.txtbuscarempleado.Text = "..."
        Me.txtbuscarempleado.UseVisualStyleBackColor = True
        '
        'txtnomempleado
        '
        Me.txtnomempleado.Location = New System.Drawing.Point(102, 205)
        Me.txtnomempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnomempleado.Name = "txtnomempleado"
        Me.txtnomempleado.ReadOnly = True
        Me.txtnomempleado.Size = New System.Drawing.Size(151, 26)
        Me.txtnomempleado.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 211)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Empleado"
        '
        'txtidempleado
        '
        Me.txtidempleado.Location = New System.Drawing.Point(119, 162)
        Me.txtidempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.ReadOnly = True
        Me.txtidempleado.Size = New System.Drawing.Size(151, 26)
        Me.txtidempleado.TabIndex = 21
        '
        'CMBtipo_documento
        '
        Me.CMBtipo_documento.FormattingEnabled = True
        Me.CMBtipo_documento.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.CMBtipo_documento.Location = New System.Drawing.Point(106, 314)
        Me.CMBtipo_documento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CMBtipo_documento.Name = "CMBtipo_documento"
        Me.CMBtipo_documento.Size = New System.Drawing.Size(177, 28)
        Me.CMBtipo_documento.TabIndex = 20
        Me.CMBtipo_documento.Text = "Factura"
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(76, 256)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(177, 26)
        Me.txtfecha.TabIndex = 19
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(274, 113)
        Me.btnBuscarCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(40, 18)
        Me.btnBuscarCliente.TabIndex = 18
        Me.btnBuscarCliente.Text = "..."
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.Location = New System.Drawing.Point(108, 113)
        Me.txtnombre_cliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.ReadOnly = True
        Me.txtnombre_cliente.Size = New System.Drawing.Size(162, 26)
        Me.txtnombre_cliente.TabIndex = 17
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(698, 493)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(105, 49)
        Me.btnguardar.TabIndex = 16
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = CType(resources.GetObject("btneditar.BackgroundImage"), System.Drawing.Image)
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.Location = New System.Drawing.Point(820, 493)
        Me.btneditar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(91, 49)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackgroundImage = CType(resources.GetObject("btnnuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Location = New System.Drawing.Point(571, 493)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(111, 49)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 363)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero Doc"
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Location = New System.Drawing.Point(116, 360)
        Me.txtnum_documento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnum_documento.MaxLength = 9
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.Size = New System.Drawing.Size(177, 26)
        Me.txtnum_documento.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 317)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo Doc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente"
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(76, 113)
        Me.txtidcliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.ReadOnly = True
        Me.txtidcliente.Size = New System.Drawing.Size(28, 26)
        Me.txtidcliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID venta"
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(85, 65)
        Me.txtidventa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.ReadOnly = True
        Me.txtidventa.Size = New System.Drawing.Size(177, 26)
        Me.txtidventa.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 162)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Id Empleado"
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 612)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btneditar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmVenta"
        Me.Text = "frmVenta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbuscarempleado As Button
    Friend WithEvents txtnomempleado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents CMBtipo_documento As ComboBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtnombre_cliente As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnum_documento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents Label8 As Label
End Class
