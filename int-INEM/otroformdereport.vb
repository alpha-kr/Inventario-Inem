Imports Microsoft.Reporting.WinForms
Public Class otroformdereport

    Private Sub otroformdereport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inemDataSet4.dactivos' Puede moverla o quitarla según sea necesario.
        Me.dactivosTableAdapter.Fill(Me.inemDataSet4.dactivos)


        Dim idtra As New ReportParameter("departamento", departamento)
        ReportViewer1.LocalReport.SetParameters(idtra)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class