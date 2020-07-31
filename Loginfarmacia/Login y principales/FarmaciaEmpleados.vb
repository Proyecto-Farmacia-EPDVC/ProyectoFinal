Imports System.Runtime.InteropServices
Public Class FarmaciaEmpleados
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirFormulario(frmhora)
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub panelSuperior_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub panelSuperior_MouseHover(sender As Object, e As EventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelForms.Controls.Count > 0 Then
            Me.PanelForms.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelForms.Controls.Add(frm)
        Me.PanelForms.Tag = frm
        frm.Show()
    End Sub
    Private Sub PanelLateral_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PanelForms_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub panelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelForms.Paint

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnMinimizar_Click_1(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BarraTitulo_Paint(sender As Object, e As PaintEventArgs) Handles BarraTitulo.Paint

    End Sub

    Private Sub btnhora_Click(sender As Object, e As EventArgs) 
        abrirFormulario(frmhora)
    End Sub

    Private Sub BarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class