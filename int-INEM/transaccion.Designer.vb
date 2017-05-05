<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaccion))
        Me.dtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inemDataSet = New int_INEM.inemDataSet()
        Me.transaccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtTableAdapter = New int_INEM.inemDataSetTableAdapters.dtTableAdapter()
        Me.transaccionesTableAdapter = New int_INEM.inemDataSetTableAdapters.transaccionesTableAdapter()
        CType(Me.dtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transaccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtBindingSource
        '
        Me.dtBindingSource.DataMember = "dt"
        Me.dtBindingSource.DataSource = Me.inemDataSet
        '
        'inemDataSet
        '
        Me.inemDataSet.DataSetName = "inemDataSet"
        Me.inemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'transaccionesBindingSource
        '
        Me.transaccionesBindingSource.DataMember = "transacciones"
        Me.transaccionesBindingSource.DataSource = Me.inemDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.dtBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.transaccionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "int_INEM.ti.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(491, 544)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtTableAdapter
        '
        Me.dtTableAdapter.ClearBeforeFill = True
        '
        'transaccionesTableAdapter
        '
        Me.transaccionesTableAdapter.ClearBeforeFill = True
        '
        'transaccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 544)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "transaccion"
        Me.Text = "Transaccion"
        CType(Me.dtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transaccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inemDataSet As int_INEM.inemDataSet
    Friend WithEvents dtTableAdapter As int_INEM.inemDataSetTableAdapters.dtTableAdapter
    Friend WithEvents transaccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents transaccionesTableAdapter As int_INEM.inemDataSetTableAdapters.transaccionesTableAdapter
End Class
