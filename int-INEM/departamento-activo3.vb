Public Class departamento_activo3

    Private Sub departamento_activo3_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        cargardatagrid("SELECT * FROM `d-activos`", DataGridViewX1)
        listarcombos(ComboBoxEx2, "SELECT * FROM `departamentos`", "Nombre_departamento", "departamentos")
        listartexbox(TextBoxX8, "SELECT * FROM `d-activos`", "activos", "d-activos")
        For I As Integer = 0 To 4
            Me.DataGridViewX1.Columns(I).Width = 150

        Next
    
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBoxEx2.Text <> "" And TextBoxX8.Text <> "" Then
            cargardatagrid("select*from `d-activos` where departamento='" & ComboBoxEx2.Text & "' and  activos='" & TextBoxX8.Text & "'", DataGridViewX1)
        Else
            If ComboBoxEx2.Text <> "" Then
                cargardatagrid("select*from `d-activos` where departamento='" & ComboBoxEx2.Text & "'", DataGridViewX1)

            ElseIf TextBoxX8.Text <> "" Then
                cargardatagrid("select*from `d-activos` where activos='" & TextBoxX8.Text & "'", DataGridViewX1)

            Else
                MsgBox("Debe llenar un campo de busqueda como minimo", MsgBoxStyle.Critical
                       )
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargardatagrid("SELECT * FROM `d-activos`", DataGridViewX1)
    End Sub

    Private Sub DataGridViewX1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX3.Text = DataGridViewX1.Item(0, i).Value
    End Sub

     
    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub

    Private Sub DataGridViewX1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX3.Text = DataGridViewX1.Item(0, i).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxX3.Text <> "" Then
            UID("DELETE FROM `d-activos` WHERE `id`=" & TextBoxX3.Text)
            cargardatagrid("SELECT * FROM `d-activos`", DataGridViewX1)
        Else
            MsgBox("Debe seleccionar un articulo", MsgBoxStyle.Critical
                   )
        End If


    End Sub
End Class