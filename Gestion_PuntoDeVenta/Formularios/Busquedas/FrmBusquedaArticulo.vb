Public Class FrmBusquedaArticulo

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = miGestionMySQL.ConsultarTabla("vistaConsultarArticuloStock")
        DataGridViewProductos.DataSource = dt
        DataGridViewProductos.Columns(0).HeaderText = "Codigo"
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub TxtProductos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProductos.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miGestionMySQL.BuscarArtStockDescripcion(TxtProductos.Text)
        DataGridViewProductos.DataSource = tabla
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarVenta.Click

        If DataGridViewProductos.RowCount > 0 Then


            If IsDBNull(DataGridViewProductos.SelectedCells(0).Value) Then
                Articulo.IdArticulo = ""
            Else
                Articulo.IdArticulo = DataGridViewProductos.SelectedCells(0).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(1).Value) Then
                Articulo.Descripcion = ""
            Else
                Articulo.Descripcion = DataGridViewProductos.SelectedCells(1).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(3).Value) Then
                Articulo.PrecioVenta = ""
            Else
                Articulo.PrecioVenta = DataGridViewProductos.SelectedCells(3).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(4).Value) Then
                Articulo.Marca = ""
            Else
                Articulo.Marca = DataGridViewProductos.SelectedCells(4).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(5).Value) Then
                Articulo.Foto = ""
            Else
                Articulo.Foto = DataGridViewProductos.SelectedCells(5).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(7).Value) Then
                Articulo.Stock = ""
            Else
                Articulo.Stock = DataGridViewProductos.SelectedCells(7).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(8).Value) Then
                Articulo.StockMinimo = ""
            Else
                Articulo.StockMinimo = DataGridViewProductos.SelectedCells(8).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            FrmVentas.TxtidProducto.Text = Articulo.IdArticulo
            FrmVentas.Txtdescripcion.Text = Articulo.Descripcion
            FrmVentas.txtprecioUnitario.Text = Articulo.PrecioVenta
            FrmVentas.TxtIdArticulo.Text = Articulo.IdArticulo
            FrmVentas.TxtArticulo.Text = Articulo.Descripcion
            FrmVentas.TxtPrecioVenta.Text = Articulo.PrecioVenta
            FrmVentas.TxtMarca.Text = Articulo.Marca
            FrmVentas.TxtImagen.Text = Articulo.Foto
            FrmVentas.TxtStock.Text = Articulo.Stock
            FrmVentas.TxtStockminimo.Text = Articulo.StockMinimo

            FrmVentas.PictureBox1.ImageLocation = FrmVentas.TxtImagen.Text

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        FrmVentas.Txtcantidad.Text = 1
        FrmVentas.TxtImporte.Text = (FrmVentas.Txtcantidad.Text * FrmVentas.TxtPrecioVenta.Text).ToString("0.00")
        Me.Close()

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        dt = miGestionMySQL.ConsultarTabla("vistaConsultarArticuloStock")
        DataGridViewProductos.DataSource = dt
        DataGridViewProductos.Columns(0).HeaderText = "Codigo"
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub BtnCopiarPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarPresupuesto.Click
        If DataGridViewProductos.RowCount > 0 Then

            If IsDBNull(DataGridViewProductos.SelectedCells(0).Value) Then
                Articulo.IdArticulo = ""
            Else
                Articulo.IdArticulo = DataGridViewProductos.SelectedCells(0).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(1).Value) Then
                Articulo.Descripcion = ""
            Else
                Articulo.Descripcion = DataGridViewProductos.SelectedCells(1).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(3).Value) Then
                Articulo.PrecioVenta = ""
            Else
                Articulo.PrecioVenta = DataGridViewProductos.SelectedCells(3).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(4).Value) Then
                Articulo.Marca = ""
            Else
                Articulo.Marca = DataGridViewProductos.SelectedCells(4).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(5).Value) Then
                Articulo.Foto = ""
            Else
                Articulo.Foto = DataGridViewProductos.SelectedCells(5).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(7).Value) Then
                Articulo.Stock = ""
            Else
                Articulo.Stock = DataGridViewProductos.SelectedCells(7).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(8).Value) Then
                Articulo.StockMinimo = ""
            Else
                Articulo.StockMinimo = DataGridViewProductos.SelectedCells(8).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            FrmPresupuestos.TxtidProducto.Text = Articulo.IdArticulo
            FrmPresupuestos.Txtdescripcion.Text = Articulo.Descripcion
            FrmPresupuestos.txtprecioUnitario.Text = Articulo.PrecioVenta
            FrmPresupuestos.TxtIdArticulo.Text = Articulo.IdArticulo
            FrmPresupuestos.TxtArticulo.Text = Articulo.Descripcion
            FrmPresupuestos.TxtPrecioVenta.Text = Articulo.PrecioVenta
            FrmPresupuestos.TxtMarca.Text = Articulo.Marca
            FrmPresupuestos.TxtImagen.Text = Articulo.Foto
            FrmPresupuestos.TxtStock.Text = Articulo.Stock
            FrmPresupuestos.TxtStockminimo.Text = Articulo.StockMinimo

            FrmPresupuestos.PictureBox1.ImageLocation = FrmPresupuestos.TxtImagen.Text

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        FrmPresupuestos.Txtcantidad.Text = 1
        FrmPresupuestos.TxtImporte.Text = (FrmPresupuestos.Txtcantidad.Text * FrmPresupuestos.TxtPrecioVenta.Text).ToString("0.00")
        Me.Close()
    End Sub
End Class