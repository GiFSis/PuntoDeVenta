<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeClientes
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
        Me.G_PdVDataSetClientes = New Gestion_PuntoDeVenta.G_PdVDataSetClientes()
        Me.clienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clienteTableAdapter = New Gestion_PuntoDeVenta.G_PdVDataSetClientesTableAdapters.clienteTableAdapter()
        CType(Me.G_PdVDataSetClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetClientes"
        ReportDataSource1.Value = Me.clienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Gestion_PuntoDeVenta.ReportClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(994, 571)
        Me.ReportViewer1.TabIndex = 0
        '
        'G_PdVDataSetClientes
        '
        Me.G_PdVDataSetClientes.DataSetName = "G_PdVDataSetClientes"
        Me.G_PdVDataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clienteBindingSource
        '
        Me.clienteBindingSource.DataMember = "cliente"
        Me.clienteBindingSource.DataSource = Me.G_PdVDataSetClientes
        '
        'clienteTableAdapter
        '
        Me.clienteTableAdapter.ClearBeforeFill = True
        '
        'FrmInformeClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformeClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInformeClientes"
        CType(Me.G_PdVDataSetClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents G_PdVDataSetClientes As Gestion_PuntoDeVenta.G_PdVDataSetClientes
    Friend WithEvents clienteTableAdapter As Gestion_PuntoDeVenta.G_PdVDataSetClientesTableAdapters.clienteTableAdapter
End Class
