Public Class verlista

    Private Sub verlista_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        cargardatagrid("Select*from transacciones", DataGridViewX1)
    End Sub

    Private Sub verlista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewX1.Columns(0).Width = 80
        DataGridViewX1.Columns(1).Width = 170
        DataGridViewX1.Columns(2).Width = 140
        DataGridViewX1.Columns(3).Width = 120
        DataGridViewX1.Columns(4).Width = 220
        DataGridViewX1.Columns(5).Width = 120


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Todos los registros" Then
            cargardatagrid("Select*from transacciones", DataGridViewX1)
        Else
            cargardatagrid("Select*from transacciones where `tipo`='" & ComboBox1.Text & "'", DataGridViewX1)

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBox1.Text <> "" Then
            cargardatagrid("Select*from transacciones where tipo='" & ComboBox1.Text & "' and `fecha`='" & DateTimePicker1.Value.ToShortDateString & "'", DataGridViewX1)

        Else
            MsgBox("Debe llenar el campo tipo", MsgBoxStyle.Critical, "Error")
        End If
            End Sub

   

    Private Sub DataGridViewX1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.RowHeaderMouseDoubleClick
        Dim i As Integer = DataGridViewX1.CurrentRow.Index
        Dim id As Integer = Val(DataGridViewX1.Item(0, i).Value.ToString)
        If id <> 0 Then
            cargardatagrid("SELECT * FROM `dt` where `idt`=" & id, listaarticulos.DataGridViewX1)
            listaarticulos.Label2.Text = "ID transaccion:" & id
            listaarticulos.Show()
        Else
            MsgBox("Contenido vacio, debe selecionar una fila llena", MsgBoxStyle.Information)
        End If

      


    End Sub
End Class