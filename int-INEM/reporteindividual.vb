Public Class reporteindividual

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "" Then

            If retornarnummero("SELECT*FROM `transacciones` WHERE `idtransaccion`=" & TextBox1.Text, "transacciones") > 0 Then
                idtr = Val(TextBox1.Text)
                transaccion.Show()
            Else
                MsgBox("No existe transaccion con esta ID", MsgBoxStyle.Information)


            End If


        Else
            MsgBox("Error", MsgBoxStyle.Critical, "Campo vacio")
        End If
    End Sub
End Class