Imports System.ComponentModel

Public Class frmReporte
    Dim conexion As New conexion()
    Dim dt As New DataTable()

    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtidventa.Text = frmDetalles_venta.txtidventa.Text
        mostrar()
    End Sub

    Public Sub mostrar()
        Dim idventa As Integer

        idventa = txtidventa.Text
        Try
            Dim func As New conexion
            dt = func.mostrarReporte(idventa)

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True

            Else
                datalistado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub
End Class