Public Class buscador

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        onlynumbers(e)
    End Sub
 
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "" Then
            ingresosproceso.datagridviewx.Columns.Remove("idactivo")
            encontrarid(Val(TextBox1.Text))

        End If
    End Sub
End Class