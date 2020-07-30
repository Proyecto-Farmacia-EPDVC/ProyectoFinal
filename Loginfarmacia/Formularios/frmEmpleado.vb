Imports System.ComponentModel
Public Class frmEmpleado
    Dim conexion As New Conexion()
    Dim dt As New DataTable()
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub mostrar()
        Try
            Dim func As New Conexion
            dt = func.mostrarEmpleados
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                ' ocultar_columnas()
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
        txtapellidos.Text = ""
        txtfechaN.Text = ""
        txttelefono.Text = ""
        txtcontra.Text = ""
        txtidempleado.Text = ""
    End Sub
    Private Sub buscar()
        Try

            dt = conexion.busqueda("Empleados", "CONCAT(Nombres,' ',Apellidos) like '%" + txtbuscar.Text + "%'")

            mostrar()
            If dt.Rows.Count <> 0 Then

                datalistado.DataSource = dt
                conexion.conexion.Close()
                ' ocultar_columnas()
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
    End Sub

    Private Sub insertarEmpleado()
        Dim idEmpleado As String
        Dim nombres, apellidos, Tel, estado, contrasena, rol As String
        Dim sexo As Char
        Dim fechanacimiento As Date

        idEmpleado = txtidempleado.Text
        nombres = txtnombre.Text
        apellidos = txtapellidos.Text
        fechanacimiento = txtfechaN.Text
        Tel = txttelefono.Text
        sexo = cmbSexo.Text
        rol = "Auxiliar"
        estado = "Activo"
        contrasena = txtcontra.Text

        Try
            If conexion.insertarEmpleado(idEmpleado, nombres, apellidos, fechanacimiento, Tel, sexo, rol, estado, contrasena) Then

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editarEmpleado()
        Dim idEmpleado As String
        Dim nombres, apellidos, Tel, estado, contrasena, rol As String
        Dim sexo As Char
        Dim fechanacimiento As Date

        idEmpleado = txtidempleado.Text
        nombres = txtnombre.Text
        apellidos = txtapellidos.Text
        fechanacimiento = txtfechaN.Text
        Tel = txttelefono.Text
        sexo = cmbSexo.Text
        rol = "Auxiliar"
        estado = "Activo"
        contrasena = txtcontra.Text

        Try
            If conexion.editarEmpleado(idEmpleado, nombres, apellidos, fechanacimiento, Tel, sexo, rol, estado, contrasena) Then
                MessageBox.Show("Cliente modificado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidempleado.Text <> "" And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtfechaN.Text <> "" And txttelefono.Text <> "" And cmbSexo.Text <> "" And txtcontra.Text <> "" Then
            Try
                insertarEmpleado()
                mostrar()
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
        mostrar()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del Empleado?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidempleado.Text <> "" And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtfechaN.Text <> "" And txttelefono.Text <> "" And cmbSexo.Text <> "" And txtcontra.Text <> "" Then
                Try
                    editarEmpleado()
                    mostrar()
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

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        txtidempleado.Text = datalistado.Rows(FilaActual).Cells(1).Value
        txtnombre.Text = datalistado.Rows(FilaActual).Cells(2).Value
        txtapellidos.Text = datalistado.Rows(FilaActual).Cells(3).Value
        txtfechaN.Text = datalistado.Rows(FilaActual).Cells(4).Value
        txttelefono.Text = datalistado.Rows(FilaActual).Cells(5).Value
        cmbSexo.Text = datalistado.Rows(FilaActual).Cells(6).Value
        btnguardar.Visible = False
        btneditar.Visible = True
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            ' frmVenta.txtidempleado.Text = datalistado.SelectedCells.Item(1).Value
            ' frmVenta.txtnomempleado.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

    End Sub
End Class