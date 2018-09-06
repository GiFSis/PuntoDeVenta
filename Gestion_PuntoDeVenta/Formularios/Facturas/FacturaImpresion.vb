Public Class FacturaImpresion

    Private Sub FacturaImpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.get_FacturaTableAdapter.Fill(Me.G_pdVDataSetFactura.get_Factura, Global_numeroVenta)
        Me.misdatosTableAdapter.Fill(Me.G_PdVDataSetMisDatosFactura.misdatos)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class