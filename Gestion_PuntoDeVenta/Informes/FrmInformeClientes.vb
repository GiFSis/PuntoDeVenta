Public Class FrmInformeClientes

    Private Sub FrmInformeClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GPdVDataSetClientes.cliente' Puede moverla o quitarla según sea necesario.
        Me.clienteTableAdapter.Fill(Me.G_PdVDataSetClientes.cliente)
        'TODO: esta línea de código carga datos en la tabla 'DataSetClientes.cliente' Puede moverla o quitarla según sea necesario.
        Me.clienteTableAdapter.Fill(Me.G_PdVDataSetClientes.cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class