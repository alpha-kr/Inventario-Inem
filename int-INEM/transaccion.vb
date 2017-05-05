
Imports Microsoft.Reporting.WinForms
Public Class transaccion

    Private Sub transaccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inemDataSet.transacciones' Puede moverla o quitarla según sea necesario.
        Me.transaccionesTableAdapter.Fill(Me.inemDataSet.transacciones)
        'TODO: esta línea de código carga datos en la tabla 'inemDataSet.dt' Puede moverla o quitarla según sea necesario.
        Me.dtTableAdapter.Fill(Me.inemDataSet.dt)

        Dim idtra As New ReportParameter("idt", idtr)
        ReportViewer1.LocalReport.SetParameters(idtra)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class