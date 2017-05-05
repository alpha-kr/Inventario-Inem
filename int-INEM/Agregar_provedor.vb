Public Class Agregar_provedor

   

    Private Sub Agregar_provedor_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
     
        listarcombos(ciudad, "SELECT * FROM `ciudades`", "Nombre", "ciudades")
        cargardatagrid("SELECT * FROM proveedores", DataGridViewX1)
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ciudad.Text <> "" Then

            If MsgBox("¿Estas seguro de agregar una nueva ciudad?", MsgBoxStyle.YesNo
                   ) = 6 Then
                UID("INSERT INTO `ciudades` (`Nombre`) VALUES ('" + ciudad.Text + "');")
                ciudad.Items.Clear()
                listarcombos(ciudad, "SELECT * FROM `ciudades`", "Nombre", "ciudades")
            End If


        Else
            MsgBox("No puede agregar contenido vacio", MsgBoxStyle.Critical
                   )
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If nom.Text <> "" And tel.Text <> "" And direc.Text <> "" And ciudad.Text <> "" And celu.Text <> "" And NIT.Text <> "" And ven.Text <> "" Then
            If MsgBox("¿Estas seguro de Agregar este provedor?", MsgBoxStyle.YesNo
                 ) = 6 Then
                UID("INSERT INTO `proveedores`( `Nombre`, `Vendedor`, `Nit`, `Direccion`, `Telefono`, `celular`, `Ciudad`) VALUES ('" + nom.Text + "','" + ven.Text + "'," + NIT.Text + ",'" + direc.Text + "','" + tel.Text + "','" + celu.Text + "','" + ciudad.Text + "')")
                limipiar(Me)
                ciudad.Text = ""
                tel.Text = ""
                celu.Text = ""

                cargardatagrid("SELECT * FROM proveedores", DataGridViewX1)
            End If


        Else
            MsgBox("Ninguno de los campos pueden estar vacios", MsgBoxStyle.Critical, "Error de proceso")



        End If
    End Sub

    Private Sub TextBoxX8_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX8.TextChanged
        If TextBoxX8.Text <> "" And ComboBox1.Text <> "" Then
            busquedadatagrid("select * from proveedores where " + ComboBox1.Text + " regexp " + "'" + TextBoxX8.Text + "'", DataGridViewX1)
        ElseIf TextBoxX8.Text = "" Then

            MsgBox("Debe Escribir un valor a buscar")
            cargardatagrid("SELECT * FROM proveedores", DataGridViewX1)

        Else

            ComboBox1.Focus()

            MsgBox("Debe selecionar el tipo de valor a buscar", MsgBoxStyle.Exclamation, "Seleccione tipo de busqueda")

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBoxX8.Text <> "" And ComboBox1.Text <> "" Then
            busquedadatagrid("select * from proveedores where " + ComboBox1.Text + " regexp " + "'" + TextBoxX8.Text + "'", DataGridViewX1)
        ElseIf TextBoxX8.Text = "" Then

            MsgBox("Debe Escribir un valor a buscar")
            cargardatagrid("SELECT * FROM proveedores", DataGridViewX1)

        Else


            MsgBox("Debe selecionar el tipo de valor a buscar", MsgBoxStyle.Exclamation, "Seleccione tipo de busqueda")

        End If
    End Sub

    Private Sub DataGridViewX1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX7.Text = DataGridViewX1.Item(0, i).Value.ToString
        nom.Text = DataGridViewX1.Item(1, i).Value.ToString
        ven.Text = DataGridViewX1.Item(2, i).Value.ToString
        NIT.Text = DataGridViewX1.Item(3, i).Value.ToString
        direc.Text = DataGridViewX1.Item(4, i).Value.ToString
        tel.Text = DataGridViewX1.Item(5, i).Value.ToString
        celu.Text = DataGridViewX1.Item(6, i).Value.ToString
        ciudad.Text = DataGridViewX1.Item(7, i).Value.ToString

    End Sub



    Private Sub DataGridViewX1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX7.Text = DataGridViewX1.Item(0, i).Value.ToString
        nom.Text = DataGridViewX1.Item(1, i).Value.ToString
        ven.Text = DataGridViewX1.Item(2, i).Value.ToString
        NIT.Text = DataGridViewX1.Item(3, i).Value.ToString
        direc.Text = DataGridViewX1.Item(4, i).Value.ToString
        tel.Text = DataGridViewX1.Item(5, i).Value.ToString
        celu.Text = DataGridViewX1.Item(6, i).Value.ToString
        ciudad.Text = DataGridViewX1.Item(7, i).Value.ToString


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxX7.Text <> "" Then
            If MsgBox("¿Estas seguro de Eliminar este provedor:" + nom.Text + "?", MsgBoxStyle.YesNo, "Confirmacion "
                  ) = 6 Then

                UID("DELETE FROM `proveedores` WHERE `id_proveedores`=" + TextBoxX7.Text)
                limipiar(Me)
                cargardatagrid("SELECT * FROM proveedores", DataGridViewX1)


            End If
        Else
            MsgBox("Aun no se ha selecionado ningun Proveedor")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBoxX7.Text <> "" And nom.Text <> "" And tel.Text <> "" And direc.Text <> "" And ciudad.Text <> "" And celu.Text <> "" And NIT.Text <> "" And ven.Text <> "" Then
            If MsgBox("¿Estas seguro de Actualizar  provedor:" + nom.Text + "?", MsgBoxStyle.YesNo, "Confirmacion "
                  ) = 6 Then

                UID("UPDATE `proveedores` SET  `Nombre`='" + nom.Text + "',`Vendedor`='" + ven.Text + "',`Nit`='" + NIT.Text + "',`Direccion`='" + direc.Text + "',`Telefono`='" + tel.Text + "',`celular`='" + celu.Text + "',`Ciudad`='" + ciudad.Text + "' WHERE `id_proveedores`=" + TextBoxX7.Text)
                limipiar(Me)
                ciudad.Text = ""

                cargardatagrid("SELECT * FROM proveedores", DataGridViewX1)

            End If
        Else
            MsgBox("Aun no se ha selecionado ningun Proveedor")
        End If
    End Sub

    Private Sub NIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NIT.KeyPress
        onlynumbers(e)
    End Sub

    Private Sub NIT_TextChanged(sender As Object, e As EventArgs) Handles NIT.TextChanged

    End Sub

    Private Sub tel_KeyPress(sender As Object, e As KeyPressEventArgs)
        onlynumbers(e)
    End Sub

    Private Sub tel_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub celu_KeyPress(sender As Object, e As KeyPressEventArgs)
        onlynumbers(e)
    End Sub

    Private Sub celu_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub

    Private Sub Agregar_provedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class