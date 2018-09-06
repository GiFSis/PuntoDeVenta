
Imports Microsoft.Reporting.WinForms

Public Class PresupuestoImpresion

    Private Sub PresupuestoImpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mipresuTableAdapter.Fill(Me.G_PdVDataSetPresupuesto.mipresu, Global_numeroPresupuesto)
        Me.misdatosTableAdapter.Fill(Me.G_PdVDataSetMisDatosFactura.misdatos)
        Me.ReportPresupuesto.RefreshReport()

        'recargo()

    End Sub

    'Private Sub recargo()
    '    Dim consulta As New GestionMySQL
    '    Dim ds As New DataSet
    '    ds = consulta.Presupuesto(Global_numeroPresupuesto)

    '    Dim rds As New ReportDataSource("DataSetPresupuesto", ds.Tables(0))
    '    Me.ReportPresupuesto.LocalReport.DataSources.Clear()
    '    Me.ReportPresupuesto.LocalReport.DataSources.Add(rds)

    '    Me.ReportPresupuesto.RefreshReport()



    'End Sub

    'Private Sub Inicio()

    '    Dim miGestionMySQL As New GestionMySQL
    '    Dim dtMitabla As New DataTable

    '    dtMitabla = miGestionMySQL.consultarTabla("misdatos")

    '    For Each MiDataRow As DataRow In dtMitabla.Rows

    '        Me.TxtRazonSocial.Text = MiDataRow("razonsocial")
    '        Me.TxtDireccion.Text = MiDataRow("direccion")
    '        Me.TxtCiudad.Text = MiDataRow("ciudad")
    '        Me.TxtTelefono.Text = MiDataRow("telefono")
    '        Me.TxtMail.Text = MiDataRow("email")
    '        Me.TxtCuit.Text = MiDataRow("cuit")

    '    Next

    'End Sub

End Class