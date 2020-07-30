Imports System.Data.SqlClient
Public Class conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source= localhost\SQLEXPRESS;Initial Catalog=BaseFarmacia; Integrated Security=True")
    Private cmba As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader
    Private dv As New DataView
    Public datos As DataSet

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub llenarRol()
        conexion.Open()
        da = New SqlDataAdapter("SELECT * FROM Rol", conexion)
        datos = New DataSet
        datos.Tables.Add("Rol")
        da.Fill(datos.Tables("Rol"))
        conexion.Close()
    End Sub


    Public Function eliminarUsuario(idUsuario As Integer, rol As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idUsuario", idUsuario)
            cmb.Parameters.AddWithValue("@rol", rol)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function validarUsuario(userName As String, psw As String, rol As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("validarUsuario", conexion)
            cmb.CommandType = 4
            cmb.Parameters.AddWithValue("@userName", userName)
            cmb.Parameters.AddWithValue("@psw", psw)
            cmb.Parameters.AddWithValue("@rol", rol)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function

    ' CLIENTE
    Public Function mostrar() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_cliente", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


    Public Function insertarCliente(nombre As String, apellidos As String, direccion As String, telefono As String, dni As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_cliente", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            ' cmb.Parameters.AddWithValue("@idcliente", idcliente)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellidos", apellidos)
            cmb.Parameters.AddWithValue("@direccion", direccion)
            cmb.Parameters.AddWithValue("@telefono", telefono)
            cmb.Parameters.AddWithValue("@dni", dni)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Function busqueda(ByVal tabla, ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from " + tabla + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dv As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dv)
                Return dv
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function editarCliente(idcliente As Integer, nombre As String, apellidos As String, direccion As String, telefono As String, dni As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_cliente", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idcliente", idcliente)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellidos", apellidos)
            cmb.Parameters.AddWithValue("@direccion", direccion)
            cmb.Parameters.AddWithValue("@telefono", telefono)
            cmb.Parameters.AddWithValue("@dni", dni)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    ' Categoria
    Public Function mostrar_categoria() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_categoria", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


    Public Function insertarCategoria(nombre_categoria As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_categoria", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre_categoria", nombre_categoria)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function editarCategoria(idcategoria As Integer, nombre_categoria As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_categoria", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idcategoria", idcategoria)
            cmb.Parameters.AddWithValue("@nombre_categoria", nombre_categoria)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    ' Productos
    Public Function mostrarProducto() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_producto", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


    Public Function insertarProducto(idcategoria As Integer, nombre As String, descripcion As String, stock As Double, precio_compra As Double, precio_venta As Double, fecha_vencimiento As Date, imagen() As Byte)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_producto", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idcategoria", idcategoria)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@descripcion", descripcion)
            cmb.Parameters.AddWithValue("@stock", stock)
            cmb.Parameters.AddWithValue("@precio_compra", precio_compra)
            cmb.Parameters.AddWithValue("@precio_venta", precio_venta)
            cmb.Parameters.AddWithValue("@fecha_vencimiento", fecha_vencimiento)
            cmb.Parameters.AddWithValue("@imagen", imagen)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function editarproducto(idproducto As Integer, idcategoria As Integer, nombre As String, descripcion As String, stock As Double, precio_compra As Double, precio_venta As Double, fecha_vencimiento As Date, imagen() As Byte)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_producto", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idproducto", idproducto)
            cmb.Parameters.AddWithValue("@idcategoria", idcategoria)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@descripcion", descripcion)
            cmb.Parameters.AddWithValue("@stock", stock)
            cmb.Parameters.AddWithValue("@precio_compra", precio_compra)
            cmb.Parameters.AddWithValue("@precio_venta", precio_venta)
            cmb.Parameters.AddWithValue("@fecha_vencimiento", fecha_vencimiento)
            cmb.Parameters.AddWithValue("@imagen", imagen)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    ' VENTAS

    Public Function mostrarVenta() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_venta", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


    Public Function insertarVenta(idcliente As Integer, fecha_venta As Date, tipo_documento As String, num_documento As String, idEmpleado As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_venta", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idcliente", idcliente)
            cmb.Parameters.AddWithValue("@fecha_venta", fecha_venta)
            cmb.Parameters.AddWithValue("@tipo_documento", tipo_documento)
            cmb.Parameters.AddWithValue("@num_documento", num_documento)
            cmb.Parameters.AddWithValue("@idEmpleado", idEmpleado)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function editarVenta(idventa As Integer, idcliente As Integer, fecha_venta As Date, tipo_documento As String, num_documento As String, idEmpleado As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_venta", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idventa", idventa)
            cmb.Parameters.AddWithValue("@idcliente", idcliente)
            cmb.Parameters.AddWithValue("@fecha_venta", fecha_venta)
            cmb.Parameters.AddWithValue("@tipo_documento", tipo_documento)
            cmb.Parameters.AddWithValue("@num_documento", num_documento)
            cmb.Parameters.AddWithValue("@idEmpleado", idEmpleado)


            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    ' DETALLES DE VENTA

    Public Function mostrarDetalleVenta() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_detalle_venta", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


    Public Function insertarDetallesVenta(idventa As Integer, idproducto As Integer, cantidad As Double, precio_unitario As Double)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_detalles_venta", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idventa", idventa)
            cmb.Parameters.AddWithValue("@idproducto", idproducto)
            cmb.Parameters.AddWithValue("@cantidad", cantidad)
            cmb.Parameters.AddWithValue("@precio_unitario", precio_unitario)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function editarDetallesVenta(iddetalle_venta As Integer, idventa As Integer, idproducto As Integer, cantidad As Double, precio_unitario As Double)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_detalles_venta", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@iddetalle_venta ", iddetalle_venta)
            cmb.Parameters.AddWithValue("@idventa", idventa)
            cmb.Parameters.AddWithValue("@idproducto", idproducto)
            cmb.Parameters.AddWithValue("@cantidad", cantidad)
            cmb.Parameters.AddWithValue("@precio_unitario", precio_unitario)


            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    ' AUMENTAR STOCK
    Public Function aumentar_stock(idproducto As Integer, cantidad As Double)
        Try
            conexion.Open()
            cmb = New SqlCommand("aumentar_stock", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idproducto", idproducto)
            cmb.Parameters.AddWithValue("@cantidad", cantidad)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    '   DISMINUIR STOCK
    Public Function disminuir_stock(idproducto As Integer, cantidad As Double)
        Try
            conexion.Open()
            cmb = New SqlCommand("disminuir_stock", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idproducto", idproducto)
            cmb.Parameters.AddWithValue("@cantidad", cantidad)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    'Empleado

    Public Function insertarEmpleado(idEmpleado As String, Nombres As String, Apellidos As String, FechaNacimiento As Date, Tel As String, Sexo As Char, rol As String, Estado As String, contrasena As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_Empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idEmpleado", idEmpleado)
            cmb.Parameters.AddWithValue("@Nombres", Nombres)
            cmb.Parameters.AddWithValue("@Apellidos", Apellidos)
            cmb.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
            cmb.Parameters.AddWithValue("@Tel", Tel)
            cmb.Parameters.AddWithValue("@Sexo", Sexo)
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@Estado", Estado)
            cmb.Parameters.AddWithValue("@contrasenia", contrasena)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function editarEmpleado(idEmpleado As String, Nombres As String, Apellidos As String, FechaNacimiento As Date, Tel As String, Sexo As Char, rol As String, Estado As String, contrasena As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_Empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idEmpleado", idEmpleado)
            cmb.Parameters.AddWithValue("@Nombres", Nombres)
            cmb.Parameters.AddWithValue("@Apellidos", Apellidos)
            cmb.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
            cmb.Parameters.AddWithValue("@Tel", Tel)
            cmb.Parameters.AddWithValue("@Sexo", Sexo)
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@Estado", Estado)
            cmb.Parameters.AddWithValue("@contrasenia", contrasena)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function mostrarEmpleados() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("Mostrar_Empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


    ' PROVEEDOR

    Public Function insertarProveedor(P_descripProv As String, P_ciudad As String, P_Tel As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_Proveedor", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@P_descripProv", P_descripProv)
            cmb.Parameters.AddWithValue("@P_ciudad", P_ciudad)
            cmb.Parameters.AddWithValue("@P_Tel", P_Tel)


            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function editarProveedor(idProveedor As Integer, P_descripProv As String, P_ciudad As String, P_Tel As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_Proveedor", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idProveedor", idProveedor)
            cmb.Parameters.AddWithValue("@P_descripProv", P_descripProv)
            cmb.Parameters.AddWithValue("@P_ciudad", P_ciudad)
            cmb.Parameters.AddWithValue("@P_Tel", P_Tel)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function mostrarProveedor() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_proveedor", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    ' COMPRA DE PRODUCTOS

    Public Function insertarCompraProveedor(idProveedor As Integer, idproducto As Integer, PrecioCompra As Double, cantidad As Integer, fechaCompra As Date)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_CompraProveedor", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idProveedor", idProveedor)
            cmb.Parameters.AddWithValue("@idproducto", idproducto)
            cmb.Parameters.AddWithValue("@P_precio_compra", PrecioCompra)
            cmb.Parameters.AddWithValue("@P_cantidad", cantidad)
            cmb.Parameters.AddWithValue("@fecha_compra", fechaCompra)


            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function mostrarCompraProveedor() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_CompraProveedor", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function
End Class
