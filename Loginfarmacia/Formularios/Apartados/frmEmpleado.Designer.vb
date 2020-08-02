<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpleado
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfechaN = New System.Windows.Forms.DateTimePicker()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btndespedir = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(834, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 29)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "SEXO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(155, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 29)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "FECHA N"
        '
        'txtfechaN
        '
        Me.txtfechaN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechaN.Location = New System.Drawing.Point(301, 304)
        Me.txtfechaN.MaxDate = New Date(2000, 12, 31, 0, 0, 0, 0)
        Me.txtfechaN.Name = "txtfechaN"
        Me.txtfechaN.Size = New System.Drawing.Size(349, 35)
        Me.txtfechaN.TabIndex = 20
        Me.txtfechaN.Value = New Date(2000, 12, 31, 0, 0, 0, 0)
        '
        'cmbSexo
        '
        Me.cmbSexo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexo.Location = New System.Drawing.Point(937, 166)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(94, 37)
        Me.cmbSexo.TabIndex = 21
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(1329, 149)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(178, 118)
        Me.btnguardar.TabIndex = 16
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btndespedir
        '
        Me.btndespedir.BackColor = System.Drawing.Color.SteelBlue
        Me.btndespedir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndespedir.Image = CType(resources.GetObject("btndespedir.Image"), System.Drawing.Image)
        Me.btndespedir.Location = New System.Drawing.Point(1329, 278)
        Me.btndespedir.Name = "btndespedir"
        Me.btndespedir.Size = New System.Drawing.Size(178, 120)
        Me.btndespedir.TabIndex = 15
        Me.btndespedir.Text = "DESPEDIR"
        Me.btndespedir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndespedir.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btneditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditar.Image = CType(resources.GetObject("btneditar.Image"), System.Drawing.Image)
        Me.btneditar.Location = New System.Drawing.Point(1329, 149)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(178, 120)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "EDITAR"
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.Location = New System.Drawing.Point(1329, 23)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(176, 120)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "NUEVO"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(1895, 61)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(22, 26)
        Me.txtflag.TabIndex = 29
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(363, 524)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1513, 406)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA EMPLEADO"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(702, 212)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(226, 29)
        Me.inexistente.TabIndex = 21
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.ColumnHeadersHeight = 38
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.GridColor = System.Drawing.SystemColors.Highlight
        Me.datalistado.Location = New System.Drawing.Point(97, 100)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowTemplate.Height = 28
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(1341, 278)
        Me.datalistado.TabIndex = 20
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 113
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(335, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "BUSQUEDA POR NOMBRE"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(373, 43)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(277, 35)
        Me.txtbuscar.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(729, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CONTRASEÑA"
        '
        'txtcontra
        '
        Me.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcontra.Location = New System.Drawing.Point(937, 245)
        Me.txtcontra.MaxLength = 8
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(349, 28)
        Me.txtcontra.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(766, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "TELEFONO"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'txttelefono
        '
        Me.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttelefono.Location = New System.Drawing.Point(937, 110)
        Me.txttelefono.MaxLength = 8
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(349, 28)
        Me.txttelefono.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "APELLIDOS"
        '
        'txtapellidos
        '
        Me.txtapellidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtapellidos.Location = New System.Drawing.Point(301, 246)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(349, 28)
        Me.txtapellidos.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOMBRE"
        '
        'txtnombre
        '
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombre.Location = New System.Drawing.Point(301, 174)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(349, 28)
        Me.txtnombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IDENTIDAD"
        '
        'txtidempleado
        '
        Me.txtidempleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidempleado.Location = New System.Drawing.Point(301, 110)
        Me.txtidempleado.MaxLength = 13
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.Size = New System.Drawing.Size(349, 28)
        Me.txtidempleado.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btndespedir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtfechaN)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.cmbSexo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.txtcontra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtapellidos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidempleado)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(363, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1513, 417)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MANTENIMIENTO"
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1946, 942)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarEmpleado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtfechaN As DateTimePicker
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btndespedir As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtflag As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents inexistente As LinkLabel
End Class
