﻿Imports System.ComponentModel
Public Class frmVenta
    Dim conexion As New conexion()
    Dim dt As New DataTable()

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_ventas()
    End Sub

    Public Sub mostrar_ventas()
        Try
            Dim func As New conexion
            dt = func.mostrarVenta
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                ocultar_columnas()
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False


    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidcliente.Text = ""
        txtnombre_cliente.Text = ""
        txtnum_documento.Text = ""

        txtidventa.Text = ""
    End Sub
    Private Sub buscar()
        Try
            dt = conexion.busqueda(" ventas ", " idventa like '%" + txtbuscar.Text + "%'")

            If dt.Rows.Count <> 0 Then

                datalistado.DataSource = dt
                conexion.conexion.Close()
            Else
                datalistado.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub

    Private Sub insertarventa()
        Dim idcliente As Integer
        Dim fecha_venta As Date
        Dim tipo_documento, num_documento, idEmpleado As String
        idcliente = txtidcliente.Text
        fecha_venta = txtfecha.Text
        tipo_documento = CMBtipo_documento.Text
        num_documento = txtnum_documento.Text
        idEmpleado = txtidempleado.Text

        Try
            If conexion.insertarVenta(idcliente, fecha_venta, tipo_documento, num_documento, idEmpleado) Then

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editarVenta()
        Dim idventa, idcliente As Integer
        Dim fecha_venta As Date
        Dim tipo_documento, num_documento, idEmpleado As String
        idcliente = txtidcliente.Text
        fecha_venta = txtfecha.Text
        tipo_documento = CMBtipo_documento.Text
        num_documento = txtnum_documento.Text
        idEmpleado = txtidempleado.Text

        Try
            If conexion.editarVenta(idventa, idcliente, fecha_venta, tipo_documento, num_documento, idEmpleado) Then
                MessageBox.Show("Venta modificada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnombre_cliente.Text <> "" And txtnum_documento.Text <> "" Then
            Try
                insertarventa()
                mostrar_ventas()
                limpiar()
                cargar_detalle()
                conexion.conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos de la venta?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidventa.Text <> "" And txtidcliente.Text <> "" And txtnombre_cliente.Text <> "" And txtnum_documento.Text <> "" Then
                Try
                    editarVenta()
                    mostrar_ventas()
                    limpiar()
                    conexion.conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            limpiar()
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        txtidventa.Text = datalistado.Rows(FilaActual).Cells(1).Value
        txtidcliente.Text = datalistado.Rows(FilaActual).Cells(2).Value
        txtnombre_cliente.Text = datalistado.Rows(FilaActual).Cells(3).Value
        txtfecha.Text = datalistado.Rows(FilaActual).Cells(6).Value
        CMBtipo_documento.Text = datalistado.Rows(FilaActual).Cells(7).Value
        txtnum_documento.Text = datalistado.Rows(FilaActual).Cells(8).Value

        btnguardar.Visible = False
        btneditar.Visible = True
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar_ventas()
    End Sub

    Private Sub txtidcliente_Validating(sender As Object, e As CancelEventArgs) Handles txtidcliente.Validating
        'Try
        '    If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
        '        Me.ErrorValidacion.SetError(sender, "")
        '    Else
        '        Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub txtnombre_cliente_TextChanged(sender As Object, e As EventArgs) Handles txtnombre_cliente.TextChanged

    End Sub

    Private Sub txtnombre_cliente_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre_cliente.Validating
        'Try
        '    If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
        '        Me.ErrorValidacion.SetError(sender, "")
        '    Else
        '        Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub txtnum_documento_TextChanged(sender As Object, e As EventArgs) Handles txtnum_documento.TextChanged

    End Sub

    Private Sub txtnum_documento_Validating(sender As Object, e As CancelEventArgs) Handles txtnum_documento.Validating
        'Try
        '    If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
        '        Me.ErrorValidacion.SetError(sender, "")
        '    Else
        '        Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub cargar_detalle()
        frmDetalles_venta.txtidventa.Text = datalistado.SelectedCells.Item(1).Value
        frmDetalles_venta.txtidcliente.Text = datalistado.SelectedCells.Item(2).Value
        frmDetalles_venta.txtnombre_cliente.Text = datalistado.SelectedCells.Item(3).Value
        frmDetalles_venta.txtfecha.Text = datalistado.SelectedCells.Item(6).Value
        frmDetalles_venta.CMBtipo_documento.Text = datalistado.SelectedCells.Item(7).Value
        frmDetalles_venta.txtnum_documento.Text = datalistado.SelectedCells.Item(8).Value

        frmDetalles_venta.ShowDialog()
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        cargar_detalle()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        FrmCliente.txtflag.Text = "1"
        FrmCliente.ShowDialog()
    End Sub

    Private Sub txtbuscarempleado_Click(sender As Object, e As EventArgs) Handles txtbuscarempleado.Click
        frmEmpleado.txtflag.Text = "1"
        frmEmpleado.ShowDialog()
    End Sub
End Class