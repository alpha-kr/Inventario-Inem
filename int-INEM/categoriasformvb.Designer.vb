<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class categoriasformvb
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
        Me.inemDataSet6 = New int_INEM.inemDataSet6()
        Me.cateogriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cateogriaTableAdapter = New int_INEM.inemDataSet6TableAdapters.cateogriaTableAdapter()
        CType(Me.inemDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cateogriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.cateogriaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "int_INEM.cateogrias.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(422, 443)
        Me.ReportViewer1.TabIndex = 0
        '
        'inemDataSet6
        '
        Me.inemDataSet6.DataSetName = "inemDataSet6"
        Me.inemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cateogriaBindingSource
        '
        Me.cateogriaBindingSource.DataMember = "cateogria"
        Me.cateogriaBindingSource.DataSource = Me.inemDataSet6
        '
        'cateogriaTableAdapter
        '
        Me.cateogriaTableAdapter.ClearBeforeFill = True
        '
        'categoriasformvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 443)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "categoriasformvb"
        Me.Text = "categoriasformvb"
        CType(Me.inemDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cateogriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cateogriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inemDataSet6 As int_INEM.inemDataSet6
    Friend WithEvents cateogriaTableAdapter As int_INEM.inemDataSet6TableAdapters.cateogriaTableAdapter
End Class
