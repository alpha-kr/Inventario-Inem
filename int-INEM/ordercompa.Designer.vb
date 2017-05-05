<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ordercompa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ordercompa))
        Me.transaccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inemDataSet1 = New int_INEM.inemDataSet1()
        Me.dtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.transaccionesTableAdapter = New int_INEM.inemDataSet1TableAdapters.transaccionesTableAdapter()
        Me.dtTableAdapter = New int_INEM.inemDataSet1TableAdapters.dtTableAdapter()
        CType(Me.transaccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'transaccionesBindingSource
        '
        Me.transaccionesBindingSource.DataMember = "transacciones"
        Me.transaccionesBindingSource.DataSource = Me.inemDataSet1
        '
        'inemDataSet1
        '
        Me.inemDataSet1.DataSetName = "inemDataSet1"
        Me.inemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtBindingSource
        '
        Me.dtBindingSource.DataMember = "dt"
        Me.dtBindingSource.DataSource = Me.inemDataSet1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.transaccionesBindingSource
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.dtBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "int_INEM.orden.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(457, 472)
        Me.ReportViewer1.TabIndex = 0
        '
        'transaccionesTableAdapter
        '
        Me.transaccionesTableAdapter.ClearBeforeFill = True
        '
        'dtTableAdapter
        '
        Me.dtTableAdapter.ClearBeforeFill = True
        '
        'ordercompa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 472)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ordercompa"
        Me.Text = "Orden de Compra"
        CType(Me.transaccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents transaccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inemDataSet1 As int_INEM.inemDataSet1
    Friend WithEvents dtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents transaccionesTableAdapter As int_INEM.inemDataSet1TableAdapters.transaccionesTableAdapter
    Friend WithEvents dtTableAdapter As int_INEM.inemDataSet1TableAdapters.dtTableAdapter
End Class
