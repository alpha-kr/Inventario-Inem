Public Class Opciones_de_proceso
    Dim claves(4) As String

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click



        If TextBoxX1.Text <> "" And TextBoxX2.Text <> "" And TextBoxX3.Text <> "" Then
            claves = consultarclave()

            If TextBoxX2.Text = TextBoxX3.Text And TextBoxX1.Text = claves(2) Then

                UID("update `procesos` set `clave`='" & TextBoxX3.Text & "' WHERE `Nombre_responsable`='" + claves(1) + "'")
                MsgBox("Clave Actualizada", MsgBoxStyle.Information)

            End If

        Else
            MsgBox("Los Campos no pueden estar Vacios ", MsgBoxStyle.Critical
                   )
        End If




    End Sub

    Private Sub Opciones_de_proceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

 

    End Sub
End Class