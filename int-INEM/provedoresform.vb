Public Class provedoresform

    Private Sub provedoresform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inemDataSet2.proveedores' Puede moverla o quitarla según sea necesario.
        Me.proveedoresTableAdapter.Fill(Me.inemDataSet2.proveedores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class