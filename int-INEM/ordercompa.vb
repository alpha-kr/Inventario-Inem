Imports Microsoft.Reporting.WinForms
Public Class ordercompa

    Private Sub ordercompa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inemDataSet1.transacciones' Puede moverla o quitarla según sea necesario.
        Me.transaccionesTableAdapter.Fill(Me.inemDataSet1.transacciones)
        'TODO: esta línea de código carga datos en la tabla 'inemDataSet1.dt' Puede moverla o quitarla según sea necesario.
        Me.dtTableAdapter.Fill(Me.inemDataSet1.dt)
        Dim idtra As New ReportParameter("idt", idtr)
        ReportViewer1.LocalReport.SetParameters(idtra)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class