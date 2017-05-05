<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class articulosistema
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
        Me.inemDataSet3 = New int_INEM.inemDataSet3()
        Me.activosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.activosTableAdapter = New int_INEM.inemDataSet3TableAdapters.activosTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.inemDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.activosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inemDataSet3
        '
        Me.inemDataSet3.DataSetName = "inemDataSet3"
        Me.inemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'activosBindingSource
        '
        Me.activosBindingSource.DataMember = "activos"
        Me.activosBindingSource.DataSource = Me.inemDataSet3
        '
        'activosTableAdapter
        '
        Me.activosTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.activosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "int_INEM.allarti.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(440, 413)
        Me.ReportViewer1.TabIndex = 0
        '
        'articulosistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 413)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "articulosistema"
        Me.Text = "Articulos Sistema"
        CType(Me.inemDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.activosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents activosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inemDataSet3 As int_INEM.inemDataSet3
    Friend WithEvents activosTableAdapter As int_INEM.inemDataSet3TableAdapters.activosTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
