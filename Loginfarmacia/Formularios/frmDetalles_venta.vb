Imports System.ComponentModel

Public Class frmDetalles_venta
    Dim conexion As New conexion()
    Dim dt As New DataTable()

    Private Sub frmDetalles_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_Dventas()
    End Sub
    Public Sub mostrar_Dventas()
        Try
            Dim func As New conexion
            dt = func.mostrarDetalleVenta
            'datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                ocultar_columnas()
            Else
                datalistado.DataSource = Nothing

                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'buscar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        txtidproducto.Text = ""
        txtnom_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtcantidad.Value = 0
        txtstock.Value = 1

    End Sub


    Private Sub ocultar_columnas()
        datalistado.Columns(0).Visible = False
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub

    Private Sub InsertarDetallesVenta()
        Dim idventa, idproducto As Integer
        Dim cantidad, precio_unitario As Double

        idventa = txtidventa.Text
        idproducto = txtidproducto.Text
        cantidad = txtcantidad.Text
        precio_unitario = txtprecio_unitario.Text


        If conexion.disminuir_stock(idproducto, cantidad) Then

        End If
        Try
            If conexion.insertarDetallesVenta(idventa, idproducto, cantidad, precio_unitario) Then

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" And txtprecio_unitario.Text <> "" Then
            Try
                InsertarDetallesVenta()
                mostrar_Dventas()
                limpiar()
                conexion.conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar_Dventas()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        frmProductos.txtflag.Text = "1"
        frmProductos.ShowDialog()
    End Sub

    Private Sub txtcantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtcantidad.ValueChanged
        Dim cant As Double
        cant = txtcantidad.Text
        If txtcantidad.Value > txtstock.Value Then
            MessageBox.Show("La cantidad de productos supera el Stock", "Error al vender", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnguardar.Visible = 0
            txtcantidad.Value = txtstock.Value
        Else
            btnguardar.Visible = 1
        End If

        If txtcantidad.Text = 0 Then
            btnguardar.Visible = 0
        Else
            btnguardar.Visible = 1
        End If
    End Sub

End Class