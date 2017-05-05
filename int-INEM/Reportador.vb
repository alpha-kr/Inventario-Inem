Public Class Reportador

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBoxEx1.Text <> "" Then
            If reporte = "pro" Then
                provedoresform.Show()
            End If
            If reporte = "ar" Then
                If ComboBoxEx1.Text = "Lista Todos Articulos sistema" Then
                    articulosistema.Show()
                Else
                    articulossegun.Show()

                End If
            End If
            If reporte = "ca" Then
                categoriasformvb.Show()
            End If
        Else
            MsgBox("Error Seleccione tipo de busqueda", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class