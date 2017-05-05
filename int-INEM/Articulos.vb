Public Class Articulos

    Private Sub Articulos_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        cargardatagrid("SELECT * FROM `activos`", Me.DataGridViewX1)
        listarcombos(categoria, "SELECT * FROM `cateogria`", "Nombre_categoria", "cateogria")
        For i As Integer = 0 To 5 Step 1
            Me.DataGridViewX1.Columns(i).Width = 120
        Next
    End Sub

    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        listarcombos(tipo, "SELECT * FROM `tipo-activo`", "tipo", "tipo-activo")
        listarcombos(proveedor, "SELECT* FROM `proveedores`", "Nombre", "`proveedores`")
      

    End Sub

    Private Sub TextBoxX1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxX1.KeyPress
        onlynumbers(e)
    End Sub



    Private Sub TextBoxX1_LostFocus(sender As Object, e As EventArgs) Handles TextBoxX1.LostFocus
        TextBoxX1.Text = FormatCurrency(TextBoxX1.Text)

    End Sub










    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If nom.Text <> "" And TextBoxX1.Text <> "" And categoria.Text <> "" And tipo.Text <> "" And proveedor.Text <> "" Then
            If MsgBox("¿Estas seguro de Agregar este Articulo?", MsgBoxStyle.YesNo
                 ) = 6 Then



                UID("INSERT INTO `activos`(`Nombre`, `Categoria`, `tipo`,`proveedor`,`valor_comercial` ) VALUES('" + nom.Text + "','" + categoria.Text + "','" + tipo.Text + "','" + proveedor.Text + "','" & TextBoxX1.Text & "')")
                limipiar(Me)
                proveedor.Text = ""
                categoria.Text = ""
                tipo.Text = ""


                cargardatagrid("SELECT * FROM `activos`", Me.DataGridViewX1)
            End If


        Else
            MsgBox("Ninguno de los campos pueden estar vacios", MsgBoxStyle.Critical, "Error de proceso")



        End If
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.TextChanged

    End Sub

    Private Sub TextBoxX8_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX8.TextChanged
        If TextBoxX8.Text <> "" And ComboBox1.Text <> "" Then
            busquedadatagrid("select * from `activos` where " + ComboBox1.Text + " regexp " + "'" + TextBoxX8.Text + "'", DataGridViewX1)
        ElseIf TextBoxX8.Text = "" Then

            MsgBox("Debe Escribir un valor a buscar")
            cargardatagrid("SELECT * FROM `activos`", Me.DataGridViewX1)

        Else

            ComboBox1.Focus()

            MsgBox("Debe selecionar el tipo de valor a buscar", MsgBoxStyle.Exclamation, "Seleccione tipo de busqueda")

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBoxX8.Text <> "" And ComboBox1.Text <> "" Then
            busquedadatagrid("select * from `activos` where " + ComboBox1.Text + " regexp " + "'" + TextBoxX8.Text + "'", DataGridViewX1)
        ElseIf TextBoxX8.Text = "" Then

            MsgBox("Debe Escribir un valor a buscar")
            cargardatagrid("SELECT * FROM `activos`", Me.DataGridViewX1)

        Else

            ComboBox1.Focus()

            MsgBox("Debe selecionar el tipo de valor a buscar", MsgBoxStyle.Exclamation, "Seleccione tipo de busqueda")

        End If

    End Sub

    Private Sub DataGridViewX1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX7.Text = DataGridViewX1.Item(0, i).Value.ToString
        nom.Text = DataGridViewX1.Item(1, i).Value.ToString
        categoria.Text = DataGridViewX1.Item(2, i).Value.ToString
        tipo.Text = DataGridViewX1.Item(3, i).Value.ToString
        TextBoxX1.Text = DataGridViewX1.Item(4, i).Value.ToString
        proveedor.Text = DataGridViewX1.Item(5, i).Value.ToString
    End Sub

    Private Sub DataGridViewX1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridViewX1.CurrentRow.Index
        TextBoxX7.Text = DataGridViewX1.Item(0, i).Value.ToString
        nom.Text = DataGridViewX1.Item(1, i).Value.ToString
        categoria.Text = DataGridViewX1.Item(2, i).Value.ToString
        tipo.Text = DataGridViewX1.Item(3, i).Value.ToString
        TextBoxX1.Text = DataGridViewX1.Item(4, i).Value.ToString
        proveedor.Text = DataGridViewX1.Item(5, i).Value.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxX7.Text <> "" Then
            If MsgBox("¿Estas seguro de Eliminar este Articulo:" + nom.Text + "?", MsgBoxStyle.YesNo, "Confirmacion "
                  ) = 6 Then

                UID("DELETE FROM `activos` WHERE id_activo=" + TextBoxX7.Text)
                cargardatagrid("SELECT * FROM `activos`", Me.DataGridViewX1)
                limipiar(Me)
                proveedor.Text = ""
                categoria.Text = ""
                tipo.Text = ""
            End If
        Else
            MsgBox("Aun no se ha selecionado ningun Articulo")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBoxX7.Text <> "" And nom.Text <> "" And tipo.Text <> "" And categoria.Text <> "" And proveedor.Text <> "" And TextBoxX1.Text <> "" Then
            If MsgBox("¿Estas seguro de Actualizar  Articulo:" + nom.Text + "?", MsgBoxStyle.YesNo, "Confirmacion "
                  ) = 6 Then

                UID("UPDATE  `activos` SET  `Nombre`='" + nom.Text + "',`Categoria`='" + categoria.Text + "',`tipo`='" + tipo.Text + "',`valor_comercial`='" + TextBoxX1.Text + "',`proveedor`='" + proveedor.Text + "' WHERE id_activo=" & TextBoxX7.Text)
                limipiar(Me)
                proveedor.Text = ""
                categoria.Text = ""
                tipo.Text = ""

                cargardatagrid("SELECT * FROM `activos`", Me.DataGridViewX1)

            End If
        Else
            MsgBox("Aun no se ha selecionado ningun Articulo")
        End If
    End Sub
End Class