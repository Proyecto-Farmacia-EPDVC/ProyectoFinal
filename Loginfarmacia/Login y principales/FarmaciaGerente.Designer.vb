<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FarmaciaGerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FarmaciaGerente))
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.btncategoria = New System.Windows.Forms.Button()
        Me.btnempleados = New System.Windows.Forms.Button()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.btncompras = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnproveedor = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.BarraTitulo.Controls.Add(Me.btnCerrar)
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1080, 38)
        Me.BarraTitulo.TabIndex = 6
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
        'panel6
        '
        Me.panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel6.Location = New System.Drawing.Point(0, 371)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(5, 32)
        Me.panel6.TabIndex = 12
        '
        'panel5
        '
        Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel5.Location = New System.Drawing.Point(3, 520)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(5, 36)
        Me.panel5.TabIndex = 10
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
        Me.btnReportes.Location = New System.Drawing.Point(3, 416)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(216, 32)
        Me.btnReportes.TabIndex = 13
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.Label1)
        Me.MenuVertical.Controls.Add(Me.Panel8)
        Me.MenuVertical.Controls.Add(Me.btnproveedor)
        Me.MenuVertical.Controls.Add(Me.Panel3)
        Me.MenuVertical.Controls.Add(Me.btnproductos)
        Me.MenuVertical.Controls.Add(Me.btnReportes)
        Me.MenuVertical.Controls.Add(Me.panel6)
        Me.MenuVertical.Controls.Add(Me.btncategoria)
        Me.MenuVertical.Controls.Add(Me.panel5)
        Me.MenuVertical.Controls.Add(Me.btnempleados)
        Me.MenuVertical.Controls.Add(Me.btncompras)
        Me.MenuVertical.Controls.Add(Me.btnclientes)
        Me.MenuVertical.Controls.Add(Me.panel2)
        Me.MenuVertical.Controls.Add(Me.btnventas)
        Me.MenuVertical.Controls.Add(Me.panel1)
        Me.MenuVertical.Controls.Add(Me.panel4)
        Me.MenuVertical.Controls.Add(Me.panel7)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(220, 612)
        Me.MenuVertical.TabIndex = 7
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel7.Location = New System.Drawing.Point(0, 320)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(10, 37)
        Me.panel7.TabIndex = 14
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
        Me.btncategoria.Location = New System.Drawing.Point(5, 319)
        Me.btncategoria.Name = "btncategoria"
        Me.btncategoria.Size = New System.Drawing.Size(217, 39)
        Me.btncategoria.TabIndex = 11
        Me.btncategoria.Text = "Categoría"
        Me.btncategoria.UseVisualStyleBackColor = False
        '
        'btnempleados
        '
        Me.btnempleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnempleados.FlatAppearance.BorderSize = 0
        Me.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleados.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnempleados.ForeColor = System.Drawing.Color.White
        Me.btnempleados.Image = CType(resources.GetObject("btnempleados.Image"), System.Drawing.Image)
        Me.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnempleados.Location = New System.Drawing.Point(6, 371)
        Me.btnempleados.Name = "btnempleados"
        Me.btnempleados.Size = New System.Drawing.Size(211, 39)
        Me.btnempleados.TabIndex = 9
        Me.btnempleados.Text = "Empleados"
        Me.btnempleados.UseVisualStyleBackColor = False
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel4.Location = New System.Drawing.Point(0, 267)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(10, 43)
        Me.panel4.TabIndex = 8
        '
        'btncompras
        '
        Me.btncompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btncompras.FlatAppearance.BorderSize = 0
        Me.btncompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncompras.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncompras.ForeColor = System.Drawing.Color.White
        Me.btncompras.Image = CType(resources.GetObject("btncompras.Image"), System.Drawing.Image)
        Me.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncompras.Location = New System.Drawing.Point(5, 507)
        Me.btncompras.Name = "btncompras"
        Me.btncompras.Size = New System.Drawing.Size(215, 58)
        Me.btncompras.TabIndex = 7
        Me.btncompras.Text = "Compras"
        Me.btncompras.UseVisualStyleBackColor = False
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
        Me.btnclientes.Location = New System.Drawing.Point(5, 267)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(214, 45)
        Me.btnclientes.TabIndex = 5
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(0, 209)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(10, 50)
        Me.panel2.TabIndex = 4
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
        Me.btnventas.Location = New System.Drawing.Point(6, 148)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(217, 55)
        Me.btnventas.TabIndex = 3
        Me.btnventas.Text = "Ventas"
        Me.btnventas.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 154)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(10, 49)
        Me.panel1.TabIndex = 2
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
        Me.btnproductos.Location = New System.Drawing.Point(5, 206)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(215, 55)
        Me.btnproductos.TabIndex = 1
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.UseVisualStyleBackColor = False
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelForms.Location = New System.Drawing.Point(218, 37)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(862, 575)
        Me.PanelForms.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 416)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 32)
        Me.Panel3.TabIndex = 13
        '
        'btnproveedor
        '
        Me.btnproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnproveedor.FlatAppearance.BorderSize = 0
        Me.btnproveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproveedor.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproveedor.ForeColor = System.Drawing.Color.White
        Me.btnproveedor.Image = CType(resources.GetObject("btnproveedor.Image"), System.Drawing.Image)
        Me.btnproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproveedor.Location = New System.Drawing.Point(4, 456)
        Me.btnproveedor.Name = "btnproveedor"
        Me.btnproveedor.Size = New System.Drawing.Size(214, 45)
        Me.btnproveedor.TabIndex = 15
        Me.btnproveedor.Text = "Proveedor"
        Me.btnproveedor.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(0, 456)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 45)
        Me.Panel8.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 45)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Farmacia La Fe"
        '
        'FarmaciaGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 612)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.PanelForms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FarmaciaGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FarmaciaGerente"
        Me.BarraTitulo.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        Me.MenuVertical.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents BarraTitulo As Panel
    Private WithEvents btnMinimizar As PictureBox
    Private WithEvents btnCerrar As PictureBox
    Private WithEvents panel6 As Panel
    Private WithEvents panel5 As Panel
    Private WithEvents btnReportes As Button
    Private WithEvents MenuVertical As Panel
    Private WithEvents panel7 As Panel
    Private WithEvents btncategoria As Button
    Private WithEvents btnempleados As Button
    Private WithEvents panel4 As Panel
    Private WithEvents btncompras As Button
    Private WithEvents btnclientes As Button
    Private WithEvents panel2 As Panel
    Private WithEvents btnventas As Button
    Private WithEvents panel1 As Panel
    Private WithEvents btnproductos As Button
    Private WithEvents PanelForms As Panel
    Private WithEvents Panel8 As Panel
    Private WithEvents btnproveedor As Button
    Private WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
