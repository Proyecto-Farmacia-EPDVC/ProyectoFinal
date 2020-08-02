Imports System.ComponentModel

Public Class frmProductos
    Dim conexion As New conexion()
    Dim dt As New DataTable()

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarProducto()
        txtstock.Text = "0"
        txtprecio_compra.Text = "0"
        txtprecio_venta.Text = "0"
    End Sub

    Public Sub mostrarProducto()
        Try
            Dim func As New conexion
            dt = func.mostrarProducto
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
        txtnombre.Text = ""
        txtidcategoria.Text = ""
        txtdescripcion.Text = ""
        txtnom_categoria.Text = ""
        txtstock.Text = "0"
        txtprecio_compra.Text = "0"
        txtprecio_venta.Text = "0"
        txtidproducto.Text = ""

        imagen.Image = My.Resources.transparente
        imagen.BackgroundImage = My.Resources.transparente
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub buscar()
        Try
            dt = conexion.busqueda(" producto", " nombre like '%" + txtbuscar.Text + "%'")

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                conexion.conexion.Close()
                ocultar_columnas()
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

    Private Sub insertarProducto()
        Dim idcategoria As Integer
        Dim descripcion As String
        Dim stock, precio_compra, precio_venta As Double
        Dim fecha_vencimiento As Date
        Dim imagenD() As Byte
        Dim mayus As String

        idcategoria = txtidcategoria.Text
        mayus = txtnombre.Text
        Dim nombre As String = StrConv(mayus, VbStrConv.ProperCase)

        txtnombre.Text = nombre
        descripcion = txtdescripcion.Text
        stock = txtstock.Text
        precio_compra = txtprecio_compra.Text
        precio_venta = txtprecio_venta.Text
        fecha_vencimiento = txtfecha_vencimiento.Text

        Dim ms As New IO.MemoryStream()
        If Not imagen.Image Is Nothing Then
            imagen.Image.Save(ms, imagen.Image.RawFormat)
            imagen.Image = My.Resources.transparente
        Else
            imagen.Image.Save(ms, imagen.Image.RawFormat)
        End If
        imagenD = ms.GetBuffer

        Try
            If conexion.insertarProducto(idcategoria, nombre, descripcion, stock, precio_compra, precio_venta, fecha_vencimiento, imagenD) Then

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editarProducto()

        Dim idcategoria, idproducto As Integer
        Dim descripcion, mayus As String
        Dim stock, precio_compra, precio_venta As Double
        Dim fecha_vencimiento As Date
        Dim imagenD() As Byte
        idproducto = txtidproducto.Text
        idcategoria = txtidcategoria.Text
        mayus = txtnombre.Text
        Dim nombre As String = StrConv(mayus, VbStrConv.ProperCase)

        txtnombre.Text = nombre
        descripcion = txtdescripcion.Text
        stock = txtstock.Text
        precio_compra = txtprecio_compra.Text
        precio_venta = txtprecio_venta.Text
        fecha_vencimiento = txtfecha_vencimiento.Text

        Dim ms As New IO.MemoryStream()
        If Not imagen.Image Is Nothing Then
            imagen.Image.Save(ms, imagen.Image.RawFormat)
        Else
            imagen.Image.Save(ms, imagen.Image.RawFormat)
        End If
        imagenD = ms.GetBuffer

        Try
            If conexion.editarproducto(idproducto, idcategoria, nombre, descripcion, stock, precio_compra, precio_venta, fecha_vencimiento, imagenD) Then
                MessageBox.Show("Producto modificado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        If DLG.ShowDialog = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(DLG.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        imagen.Image = My.Resources.transparente
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrarProducto()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" Then
            Try
                insertarProducto()
                mostrarProducto()
                limpiar()
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
        result = MessageBox.Show("Realmente desea editar os datos del Producto?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" Then
                Try
                    editarProducto()
                    mostrarProducto()
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

    Private Sub btnbuscarcategoria_Click(sender As Object, e As EventArgs) Handles btnbuscarcategoria.Click
        MostrarCategoria.txtflag.Text = "1"
        MostrarCategoria.ShowDialog()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub txtidproducto_Validating(sender As Object, e As CancelEventArgs) Handles txtidproducto.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtidcategoria_Validating(sender As Object, e As CancelEventArgs) Handles txtidcategoria.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtnom_categoria_Validating(sender As Object, e As CancelEventArgs) Handles txtnom_categoria.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtdescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtdescripcion.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtstock_Validating(sender As Object, e As CancelEventArgs) Handles txtstock.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtprecio_compra_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio_compra.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtprecio_venta_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio_venta.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        txtidproducto.Text = datalistado.Rows(FilaActual).Cells(1).Value
        txtidcategoria.Text = datalistado.Rows(FilaActual).Cells(2).Value
        txtnom_categoria.Text = datalistado.Rows(FilaActual).Cells(3).Value
        txtnombre.Text = datalistado.Rows(FilaActual).Cells(4).Value
        txtdescripcion.Text = datalistado.Rows(FilaActual).Cells(5).Value
        txtstock.Text = datalistado.Rows(FilaActual).Cells(6).Value
        txtprecio_compra.Text = datalistado.Rows(FilaActual).Cells(7).Value
        txtprecio_venta.Text = datalistado.Rows(FilaActual).Cells(8).Value
        txtfecha_vencimiento.Text = datalistado.Rows(FilaActual).Cells(9).Value

        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.Rows(FilaActual).Cells(10).Value
        Dim ms As New IO.MemoryStream(b)
        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        btnguardar.Visible = False
        btneditar.Visible = True
    End Sub
End Class