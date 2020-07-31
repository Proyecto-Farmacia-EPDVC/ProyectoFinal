<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FarmaciaEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FarmaciaEmpleados))
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.btncategoria = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuVertical.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.Label1)
        Me.MenuVertical.Controls.Add(Me.Panel3)
        Me.MenuVertical.Controls.Add(Me.btnReportes)
        Me.MenuVertical.Controls.Add(Me.btnproductos)
        Me.MenuVertical.Controls.Add(Me.btncategoria)
        Me.MenuVertical.Controls.Add(Me.btnclientes)
        Me.MenuVertical.Controls.Add(Me.panel2)
        Me.MenuVertical.Controls.Add(Me.btnventas)
        Me.MenuVertical.Controls.Add(Me.panel1)
        Me.MenuVertical.Controls.Add(Me.panel4)
        Me.MenuVertical.Controls.Add(Me.panel7)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 38)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(220, 574)
        Me.MenuVertical.TabIndex = 4
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1011, 6)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1042, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.BarraTitulo.Controls.Add(Me.btnCerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1080, 38)
        Me.BarraTitulo.TabIndex = 3
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelForms.Location = New System.Drawing.Point(215, 38)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(865, 574)
        Me.PanelForms.TabIndex = 5
        '
        'btnproductos
        '
        Me.btnproductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnproductos.FlatAppearance.BorderSize = 0
        Me.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproductos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproductos.ForeColor = System.Drawing.Color.White
        Me.btnproductos.Image = CType(resources.GetObject("btnproductos.Image"), System.Drawing.Image)
        Me.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproductos.Location = New System.Drawing.Point(5, 160)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(215, 55)
        Me.btnproductos.TabIndex = 15
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.UseVisualStyleBackColor = False
        '
        'btncategoria
        '
        Me.btncategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btncategoria.FlatAppearance.BorderSize = 0
        Me.btncategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btncategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncategoria.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategoria.ForeColor = System.Drawing.Color.White
        Me.btncategoria.Image = CType(resources.GetObject("btncategoria.Image"), System.Drawing.Image)
        Me.btncategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncategoria.Location = New System.Drawing.Point(5, 273)
        Me.btncategoria.Name = "btncategoria"
        Me.btncategoria.Size = New System.Drawing.Size(217, 39)
        Me.btncategoria.TabIndex = 21
        Me.btncategoria.Text = "Categoría"
        Me.btncategoria.UseVisualStyleBackColor = False
        '
        'btnclientes
        '
        Me.btnclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnclientes.FlatAppearance.BorderSize = 0
        Me.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclientes.ForeColor = System.Drawing.Color.White
        Me.btnclientes.Image = CType(resources.GetObject("btnclientes.Image"), System.Drawing.Image)
        Me.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclientes.Location = New System.Drawing.Point(5, 221)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(214, 45)
        Me.btnclientes.TabIndex = 19
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(0, 163)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(10, 50)
        Me.panel2.TabIndex = 18
        '
        'btnventas
        '
        Me.btnventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnventas.FlatAppearance.BorderSize = 0
        Me.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnventas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnventas.ForeColor = System.Drawing.Color.White
        Me.btnventas.Image = CType(resources.GetObject("btnventas.Image"), System.Drawing.Image)
        Me.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnventas.Location = New System.Drawing.Point(6, 102)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(217, 55)
        Me.btnventas.TabIndex = 17
        Me.btnventas.Text = "Ventas"
        Me.btnventas.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 108)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(10, 49)
        Me.panel1.TabIndex = 16
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel4.Location = New System.Drawing.Point(0, 221)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(10, 43)
        Me.panel4.TabIndex = 20
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel7.Location = New System.Drawing.Point(0, 274)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(10, 37)
        Me.panel7.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 318)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 32)
        Me.Panel3.TabIndex = 23
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(3, 318)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(216, 32)
        Me.btnReportes.TabIndex = 24
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 45)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Farmacia La Fe"
        '
        'FarmaciaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 612)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.PanelForms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FarmaciaEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FarmaciaEmpleados"
        Me.MenuVertical.ResumeLayout(False)
        Me.MenuVertical.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraTitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents MenuVertical As Panel
    Private WithEvents btnMinimizar As PictureBox
    Private WithEvents btnCerrar As PictureBox
    Private WithEvents BarraTitulo As Panel
    Private WithEvents PanelForms As Panel
    Private WithEvents btnproductos As Button
    Private WithEvents btncategoria As Button
    Private WithEvents btnclientes As Button
    Private WithEvents panel2 As Panel
    Private WithEvents btnventas As Button
    Private WithEvents panel1 As Panel
    Private WithEvents panel4 As Panel
    Private WithEvents panel7 As Panel
    Private WithEvents Panel3 As Panel
    Private WithEvents btnReportes As Button
    Friend WithEvents Label1 As Label
End Class
