<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhora
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhora))
        Me.labelhora = New System.Windows.Forms.Label()
        Me.timerhora = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelfecha = New System.Windows.Forms.Label()
        Me.timerfecha = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelhora
        '
        Me.labelhora.AutoSize = True
        Me.labelhora.Font = New System.Drawing.Font("Dubai", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelhora.ForeColor = System.Drawing.Color.White
        Me.labelhora.Location = New System.Drawing.Point(65, 1)
        Me.labelhora.Name = "labelhora"
        Me.labelhora.Size = New System.Drawing.Size(220, 108)
        Me.labelhora.TabIndex = 0
        Me.labelhora.Text = "Label1"
        '
        'timerhora
        '
        Me.timerhora.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.labelfecha)
        Me.Panel1.Controls.Add(Me.labelhora)
        Me.Panel1.Location = New System.Drawing.Point(27, 229)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 182)
        Me.Panel1.TabIndex = 1
        '
        'labelfecha
        '
        Me.labelfecha.AutoSize = True
        Me.labelfecha.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelfecha.Location = New System.Drawing.Point(39, 86)
        Me.labelfecha.Name = "labelfecha"
        Me.labelfecha.Size = New System.Drawing.Size(95, 45)
        Me.labelfecha.TabIndex = 1
        Me.labelfecha.Text = "Label1"
        '
        'timerfecha
        '
        Me.timerfecha.Enabled = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(44, 534)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(477, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 393)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmhora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(861, 574)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmhora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmhora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelhora As Label
    Friend WithEvents timerhora As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelfecha As Label
    Friend WithEvents timerfecha As Timer
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
End Class
