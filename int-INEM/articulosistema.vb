Public Class articulosistema

    Private Sub articulosistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inemDataSet3.activos' Puede moverla o quitarla según sea necesario.
        Me.activosTableAdapter.Fill(Me.inemDataSet3.activos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class