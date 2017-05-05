<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class provedoresform
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
        Me.inemDataSet2 = New int_INEM.inemDataSet2()
        Me.proveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.proveedoresTableAdapter = New int_INEM.inemDataSet2TableAdapters.proveedoresTableAdapter()
        CType(Me.inemDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.proveedoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "int_INEM.provedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(416, 463)
        Me.ReportViewer1.TabIndex = 0
        '
        'inemDataSet2
        '
        Me.inemDataSet2.DataSetName = "inemDataSet2"
        Me.inemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'proveedoresBindingSource
        '
        Me.proveedoresBindingSource.DataMember = "proveedores"
        Me.proveedoresBindingSource.DataSource = Me.inemDataSet2
        '
        'proveedoresTableAdapter
        '
        Me.proveedoresTableAdapter.ClearBeforeFill = True
        '
        'provedoresform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 463)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "provedoresform"
        Me.Text = "provedoresform"
        CType(Me.inemDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents proveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inemDataSet2 As int_INEM.inemDataSet2
    Friend WithEvents proveedoresTableAdapter As int_INEM.inemDataSet2TableAdapters.proveedoresTableAdapter
End Class
