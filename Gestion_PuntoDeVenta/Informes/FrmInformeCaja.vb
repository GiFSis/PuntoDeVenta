Public Class FrmInformeCaja

    Private Sub FrmInformeCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'G_pdVDataSetCajaXdia.get_inf_CajaxDia' Puede moverla o quitarla según sea necesario.
        Me.get_inf_CajaxDiaTableAdapter.Fill(Me.G_pdVDataSetCajaXdia.get_inf_CajaxDia, GlobalDesdeCaja, GlobalHastaCaja)
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Parametro1", GlobalDesdeCaja))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Parametro2", GlobalHastaCaja))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class