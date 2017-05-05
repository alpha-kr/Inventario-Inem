Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatagrid("SELECT * FROM `departamentos`", Me.DataGridViewX1)
        Me.DataGridViewX1.Columns(1).Width = 320
        Me.DataGridViewX1.Columns(2).Width = 320
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxX1.Text <> "" And TextBoxX2.Text <> "" Then
            If MsgBox("Estas Seguro de Agregar Departamento ", MsgBoxStyle.YesNo) = 6 Then
                UID("INSERT INTO `departamentos`(  `Nombre_departamento`, `Jefe_departamento`) VALUES ('" + TextBoxX1.Text + "','" + TextBoxX2.Text + "')")
                cargardatagrid("SELECT * FROM `departamentos`", Me.DataGridViewX1)
                limipiar(Me)

            End If



        Else

            MsgBox("Deben estar los campos llenos para agregar", MsgBoxStyle.Critical, "Error Campos vacios")

        End If
    End Sub

    Private Sub TextBoxX2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxX2.KeyPress
        onlychar(e)
    End Sub

    Private Sub DataGridViewX1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX1.Text = DataGridViewX1.Item(1, i).Value.ToString
        TextBoxX2.Text = DataGridViewX1.Item(2, i).Value.ToString
        TextBoxX3.Text = DataGridViewX1.Item(0, i).Value.ToString
    End Sub

    Private Sub DataGridViewX1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX1.Text = DataGridViewX1.Item(1, i).Value.ToString
        TextBoxX2.Text = DataGridViewX1.Item(2, i).Value.ToString
        TextBoxX3.Text = DataGridViewX1.Item(0, i).Value.ToString
         

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxX3.Text <> "" Then

            If MsgBox("Estas Seguro de Eliminar Departamento", MsgBoxStyle.YesNo) = 6 Then
                UID("DELETE FROM `departamentos` WHERE id_departamento=" + TextBoxX3.Text)
                cargardatagrid("SELECT * FROM `departamentos`", Me.DataGridViewX1)
                limipiar(Me)

            End If






        Else
            MsgBox("Deben Selecionar un departamento para eliminarlo ", MsgBoxStyle.Critical, "Error Sin seleccion")
        End If
    End Sub

    Private Sub TextBoxX8_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX8.TextChanged
        If TextBoxX8.Text <> "" And ComboBox1.Text <> "" Then
            busquedadatagrid("select * from `departamentos` where " + ComboBox1.Text + " regexp " + "'" + TextBoxX8.Text + "'", DataGridViewX1)
        ElseIf TextBoxX8.Text = "" Then

            MsgBox("Debe Escribir un valor a buscar")
            cargardatagrid("SELECT * FROM `departamentos`", Me.DataGridViewX1)

        Else

            ComboBox1.Focus()

            MsgBox("Debe selecionar el tipo de valor a buscar", MsgBoxStyle.Exclamation, "Seleccione tipo de busqueda")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBoxX1.Text <> "" And TextBoxX2.Text <> "" And TextBoxX3.Text <> "" Then
            If MsgBox("Estas Seguro de Actualizar  Departamento ", MsgBoxStyle.YesNo) = 6 Then
                UID("UPDATE `departamentos` SET  `Nombre_departamento`='" + TextBoxX1.Text + "',`Jefe_departamento`='" + TextBoxX2.Text + "'WHERE `id_departamento`=" + TextBoxX3.Text)
                cargardatagrid("SELECT * FROM `departamentos`", Me.DataGridViewX1)
                limipiar(Me)

            End If



        Else

            MsgBox("Deben estar los campos llenos para Actualizar", MsgBoxStyle.Critical, "Error Campos vacios")

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBoxX8.Text <> "" And ComboBox1.Text <> "" Then
            busquedadatagrid("select * from `departamentos` where " + ComboBox1.Text + " regexp " + "'" + TextBoxX8.Text + "'", DataGridViewX1)
        ElseIf TextBoxX8.Text = "" Then

            MsgBox("Debe Escribir un valor a buscar")
            cargardatagrid("SELECT * FROM `departamentos`", Me.DataGridViewX1)

        Else

            ComboBox1.Focus()

            MsgBox("Debe selecionar el tipo de valor a buscar", MsgBoxStyle.Exclamation, "Seleccione tipo de busqueda")

        End If
    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub
End Class