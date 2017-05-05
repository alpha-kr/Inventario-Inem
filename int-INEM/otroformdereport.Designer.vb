<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class otroformdereport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(otroformdereport))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.inemDataSet4 = New int_INEM.inemDataSet4()
        Me.dactivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dactivosTableAdapter = New int_INEM.inemDataSet4TableAdapters.dactivosTableAdapter()
        CType(Me.inemDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dactivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.dactivosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "int_INEM.pordepartamento.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(447, 334)
        Me.ReportViewer1.TabIndex = 0
        '
        'inemDataSet4
        '
        Me.inemDataSet4.DataSetName = "inemDataSet4"
        Me.inemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dactivosBindingSource
        '
        Me.dactivosBindingSource.DataMember = "dactivos"
        Me.dactivosBindingSource.DataSource = Me.inemDataSet4
        '
        'dactivosTableAdapter
        '
        Me.dactivosTableAdapter.ClearBeforeFill = True
        '
        'otroformdereport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 334)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "otroformdereport"
        Me.Text = "Reporte"
        CType(Me.inemDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dactivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dactivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inemDataSet4 As int_INEM.inemDataSet4
    Friend WithEvents dactivosTableAdapter As int_INEM.inemDataSet4TableAdapters.dactivosTableAdapter
End Class
