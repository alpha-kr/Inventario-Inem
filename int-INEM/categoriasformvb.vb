Public Class categoriasformvb

    Private Sub categoriasformvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inemDataSet6.cateogria' Puede moverla o quitarla según sea necesario.
        Me.cateogriaTableAdapter.Fill(Me.inemDataSet6.cateogria)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class