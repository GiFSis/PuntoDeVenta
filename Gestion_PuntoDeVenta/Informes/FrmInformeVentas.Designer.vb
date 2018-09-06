<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.G_PdVDataSetVentaXdias = New Gestion_PuntoDeVenta.G_PdVDataSetVentaXdias()
        Me.get_inf_Venta_4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.get_inf_Venta_4TableAdapter = New Gestion_PuntoDeVenta.G_PdVDataSetVentaXdiasTableAdapters.get_inf_Venta_4TableAdapter()
        CType(Me.G_PdVDataSetVentaXdias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.get_inf_Venta_4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetVentasXdias"
        ReportDataSource1.Value = Me.get_inf_Venta_4BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Gestion_PuntoDeVenta.ReportVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(669, 571)
        Me.ReportViewer1.TabIndex = 0
        '
        'G_PdVDataSetVentaXdias
        '
        Me.G_PdVDataSetVentaXdias.DataSetName = "G_PdVDataSetVentaXdias"
        Me.G_PdVDataSetVentaXdias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'get_inf_Venta_4BindingSource
        '
        Me.get_inf_Venta_4BindingSource.DataMember = "get_inf_Venta_4"
        Me.get_inf_Venta_4BindingSource.DataSource = Me.G_PdVDataSetVentaXdias
        '
        'get_inf_Venta_4TableAdapter
        '
        Me.get_inf_Venta_4TableAdapter.ClearBeforeFill = True
        '
        'FrmInformeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformeVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInformeVentas"
        CType(Me.G_PdVDataSetVentaXdias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.get_inf_Venta_4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents get_inf_Venta_4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents G_PdVDataSetVentaXdias As Gestion_PuntoDeVenta.G_PdVDataSetVentaXdias
    Friend WithEvents get_inf_Venta_4TableAdapter As Gestion_PuntoDeVenta.G_PdVDataSetVentaXdiasTableAdapters.get_inf_Venta_4TableAdapter
End Class
