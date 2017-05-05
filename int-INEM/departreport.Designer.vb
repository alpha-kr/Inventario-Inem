<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class departreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(departreport))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.inemDataSet8 = New int_INEM.inemDataSet8()
        Me.departamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.departamentosTableAdapter = New int_INEM.inemDataSet8TableAdapters.departamentosTableAdapter()
        CType(Me.inemDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.departamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.departamentosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "int_INEM.listadepartamentos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(527, 422)
        Me.ReportViewer1.TabIndex = 0
        '
        'inemDataSet8
        '
        Me.inemDataSet8.DataSetName = "inemDataSet8"
        Me.inemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'departamentosBindingSource
        '
        Me.departamentosBindingSource.DataMember = "departamentos"
        Me.departamentosBindingSource.DataSource = Me.inemDataSet8
        '
        'departamentosTableAdapter
        '
        Me.departamentosTableAdapter.ClearBeforeFill = True
        '
        'departreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 422)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "departreport"
        Me.Text = "Reporte Departamento"
        CType(Me.inemDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.departamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents departamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inemDataSet8 As int_INEM.inemDataSet8
    Friend WithEvents departamentosTableAdapter As int_INEM.inemDataSet8TableAdapters.departamentosTableAdapter
End Class
