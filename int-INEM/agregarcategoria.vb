Public Class agregarcategoria

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxX1.Text <> "" Then
            If MsgBox("Estas Seguro de Agregar Esta categoria :" + TextBoxX1.Text, MsgBoxStyle.YesNo) = 6 Then
                UID("INSERT INTO `cateogria`( `Nombre_categoria`)VALUES ('" + TextBoxX1.Text + "' )")
                cargardatagrid("SELECT * FROM `cateogria`", PCategorias.DataGridViewX1)
                limipiar(Me)

            End If

        End If
    End Sub

  
End Class