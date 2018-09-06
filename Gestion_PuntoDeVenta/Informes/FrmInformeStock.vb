Public Class FrmInformeStock

    Private Sub FrmInformeStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'G_PdVDataSetStock.vistaarticulosystockyprecio' Puede moverla o quitarla según sea necesario.
        Me.vistaarticulosystockyprecioTableAdapter.Fill(Me.G_PdVDataSetStock.vistaarticulosystockyprecio)
        'TODO: esta línea de código carga datos en la tabla 'DataSetStock.vistaarticulosystockyprecio' Puede moverla o quitarla según sea necesario.
        Me.vistaarticulosystockyprecioTableAdapter.Fill(Me.G_PdVDataSetStock.vistaarticulosystockyprecio)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class