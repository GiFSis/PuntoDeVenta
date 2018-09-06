Public Class FrmInformeProveedores

    Private Sub FrmInformeProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'G_PdVDataSetProveedores.proveedores' Puede moverla o quitarla según sea necesario.
        Me.proveedoresTableAdapter.Fill(Me.G_PdVDataSetProveedores.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'DataSetProveedores.proveedores' Puede moverla o quitarla según sea necesario.
        Me.proveedoresTableAdapter.Fill(Me.G_PdVDataSetProveedores.proveedores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class