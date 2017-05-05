Public Class departreport

    Private Sub departreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inemDataSet8.departamentos' Puede moverla o quitarla según sea necesario.
        Me.departamentosTableAdapter.Fill(Me.inemDataSet8.departamentos)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class