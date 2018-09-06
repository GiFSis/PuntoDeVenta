<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestoImpresion
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportPresupuesto = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.G_PdVDataSetPresupuesto = New Gestion_PuntoDeVenta.G_PdVDataSetPresupuesto()
        Me.mipresuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mipresuTableAdapter = New Gestion_PuntoDeVenta.G_PdVDataSetPresupuestoTableAdapters.mipresuTableAdapter()
        Me.G_PdVDataSetMisDatosFactura = New Gestion_PuntoDeVenta.G_PdVDataSetMisDatosFactura()
        Me.misdatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.misdatosTableAdapter = New Gestion_PuntoDeVenta.G_PdVDataSetMisDatosFacturaTableAdapters.misdatosTableAdapter()
        CType(Me.G_PdVDataSetPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mipresuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G_PdVDataSetMisDatosFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportPresupuesto
        '
        Me.ReportPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetpre"
        ReportDataSource1.Value = Me.mipresuBindingSource
        ReportDataSource2.Name = "DataSetMisDatos"
        ReportDataSource2.Value = Me.misdatosBindingSource
        Me.ReportPresupuesto.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportPresupuesto.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportPresupuesto.LocalReport.ReportEmbeddedResource = "Gestion_PuntoDeVenta.ReportPresu.rdlc"
        Me.ReportPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.ReportPresupuesto.Name = "ReportPresupuesto"
        Me.ReportPresupuesto.Size = New System.Drawing.Size(694, 621)
        Me.ReportPresupuesto.TabIndex = 0
        '
        'G_PdVDataSetPresupuesto
        '
        Me.G_PdVDataSetPresupuesto.DataSetName = "G_PdVDataSetPresupuesto"
        Me.G_PdVDataSetPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mipresuBindingSource
        '
        Me.mipresuBindingSource.DataMember = "mipresu"
        Me.mipresuBindingSource.DataSource = Me.G_PdVDataSetPresupuesto
        '
        'mipresuTableAdapter
        '
        Me.mipresuTableAdapter.ClearBeforeFill = True
        '
        'G_PdVDataSetMisDatosFactura
        '
        Me.G_PdVDataSetMisDatosFactura.DataSetName = "G_PdVDataSetMisDatosFactura"
        Me.G_PdVDataSetMisDatosFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'misdatosBindingSource
        '
        Me.misdatosBindingSource.DataMember = "misdatos"
        Me.misdatosBindingSource.DataSource = Me.G_PdVDataSetMisDatosFactura
        '
        'misdatosTableAdapter
        '
        Me.misdatosTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 621)
        Me.Controls.Add(Me.ReportPresupuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PresupuestoImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PresupuestoImpresion"
        CType(Me.G_PdVDataSetPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mipresuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G_PdVDataSetMisDatosFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportPresupuesto As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mipresuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents G_PdVDataSetPresupuesto As Gestion_PuntoDeVenta.G_PdVDataSetPresupuesto
    Friend WithEvents misdatosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents G_PdVDataSetMisDatosFactura As Gestion_PuntoDeVenta.G_PdVDataSetMisDatosFactura
    Friend WithEvents mipresuTableAdapter As Gestion_PuntoDeVenta.G_PdVDataSetPresupuestoTableAdapters.mipresuTableAdapter
    Friend WithEvents misdatosTableAdapter As Gestion_PuntoDeVenta.G_PdVDataSetMisDatosFacturaTableAdapters.misdatosTableAdapter
End Class
