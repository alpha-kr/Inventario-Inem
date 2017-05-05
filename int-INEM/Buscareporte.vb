Public Class Buscareporte

    Private Sub Buscareporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarcombos(ComboBoxEx2, "SELECT * FROM `departamentos`", "Nombre_departamento", "departamentos")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBoxEx2.Text <> "" Then
            departamento = ComboBoxEx2.Text
            If retornarnummero("SELECT * FROM `d-activos` WHERE `departamento`='" & ComboBoxEx2.Text & "'", "d-activos") > 0 Then
                otroformdereport.Show()
            Else
                MsgBox("No hay Articulos en el departamento seleccionado")
            End If
        Else
            MsgBox("ERROR, DEBE SELECCIONAR DEPARTAMENTO PARA GENERAR REPORTE", MsgBoxStyle.Critical
                   )
        End If
    End Sub
End Class