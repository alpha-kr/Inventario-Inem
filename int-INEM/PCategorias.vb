Public Class PCategorias

    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatagrid("SELECT * FROM `cateogria`", Me.DataGridViewX1)
        DataGridViewX1.Columns(1).Width = 430
    End Sub
    Private Sub DataGridViewX1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX3.Text = DataGridViewX1.Item(0, i).Value.ToString
       
    End Sub

    Private Sub DataGridViewX1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX3.Text = DataGridViewX1.Item(0, i).Value.ToString
        TextBoxX2.Text = DataGridViewX1.Item(1, i).Value.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxX3.Text <> "" Then
            If MsgBox("Estas Seguro de Eliminar Esta categoria" & TextBoxX2.Text, MsgBoxStyle.YesNo) = 6 Then
                UID("DELETE FROM `cateogria` WHERE 	id_categoria=" + TextBoxX3.Text)
                cargardatagrid("SELECT * FROM `cateogria`", Me.DataGridViewX1)
                limipiar(Me)

            End If
        Else
            MsgBox("Debe seleccionar una categoria para luego eliminarla", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

 

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBoxX8.Text <> "" Then
            busquedadatagrid("select * from `cateogria` where Nombre_categoria regexp  '" + TextBoxX8.Text + "'", DataGridViewX1)
        ElseIf TextBoxX8.Text = "" Then

            MsgBox("Debe Escribir un valor a buscar")
            cargardatagrid("SELECT * FROM `cateogria`", Me.DataGridViewX1)

        Else



            MsgBox("Debe selecionar el tipo de valor a buscar", MsgBoxStyle.Exclamation, "Seleccione tipo de busqueda")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBoxX3.Text <> "" And TextBoxX2.Text <> "" Then
            If MsgBox("Estas Seguro de Actualizar Departamento", MsgBoxStyle.YesNo) = 6 Then
                UID("UPDATE `cateogria` SET  `Nombre_categoria`='" + TextBoxX2.Text + "'WHERE `id_categoria`=" + TextBoxX3.Text)
                cargardatagrid("SELECT * FROM `cateogria`", Me.DataGridViewX1)
                limipiar(Me)

            End If
        Else
            MsgBox("Debe seleccionar una categoria y llenar el campo de nombre para actualizar el Nombre", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub TextBoxX8_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX8.TextChanged
        If TextBoxX8.Text = "" Then
            cargardatagrid("SELECT * FROM `cateogria`", Me.DataGridViewX1)
        End If
    End Sub
End Class