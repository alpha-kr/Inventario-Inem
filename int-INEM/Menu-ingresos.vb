Public Class Menu_ingresos



    Dim clave(4) As String

    Private Sub Menu_ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Visible = False

    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.TextChanged
        clave = consultarclave()
        If clave(2) = TextBoxX1.Text Then
            Button1.Visible = True
            TextBoxX2.Text = clave(1)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ingresosproceso.datagridviewx.Rows.Clear()
        ingresosproceso.Label11.Text = "$0,00"
        If tt = "ingreso" Then
            Dim i As Integer = 0
            Dim j As Integer = 0

            For Each DataGridViewColumn In ingresosproceso.datagridviewx.Columns
                If ingresosproceso.datagridviewx.Columns(i).Name = "idactivo" Then
                    j = j + 1

                End If
                i = i + 1
            Next
            If j = 1 Then

                ingresosproceso.datagridviewx.Columns.Remove("idactivo")
            End If

            ingresosproceso.idactivos.Visible = False
            ingresosproceso.Label17.Visible = False
            ingresosproceso.PictureBox1.Image = My.Resources.add
            If ComboBoxEx1.Text = "Ingreso de Consumo" Then
                ingresosproceso.ComboBox1.Items.Clear()
                ingresosproceso.ComboBox1.Text = "Consumo"
                ingresosproceso.ComboBox1.Items.Add("Consumo")
            End If
            If ComboBoxEx1.Text = "Ingreso Devolutivo" Then
                ingresosproceso.ComboBox1.Items.Clear()
                ingresosproceso.ComboBox1.Text = "Devolutivo"
                ingresosproceso.ComboBox1.Items.Add("Devolutivo")
            End If
            If ComboBoxEx1.Text = "Ingreso por  Donacion" Then
                ingresosproceso.ComboBox1.Items.Clear()
                ingresosproceso.ComboBox1.Text = ""
                ingresosproceso.ComboBox1.Items.Add("Consumo")
                ingresosproceso.ComboBox1.Items.Add("Devolutivo")

            End If
            If ComboBoxEx1.Text <> "" And TextBoxX1.Text <> "" And TextBoxX2.Text <> "" Then
                limipiar(ingresosproceso)
                ingresosproceso.TextBoxX7.Text = "ALMACEN OFICINA"

                ingresosproceso.responsable.Text = clave(1)
                ingresosproceso.Label2.Text = ComboBoxEx1.Text
                Me.Close()
                ingresosproceso.ComboBoxEx1.DataSource = Nothing
                mostrar(ingresosproceso, panel.acceso)
            Else
                MsgBox("Debes completar todos los campos")

            End If



        End If
        If tt = "egreso" Then
            Dim i As Integer = 0
            Dim j As Integer = 0

            For Each DataGridViewColumn In ingresosproceso.datagridviewx.Columns
                If ingresosproceso.datagridviewx.Columns(i).Name = "idactivo" Then
                    j = j + 1

                End If
                i = i + 1
            Next
            If j <> 1 Then


                ingresosproceso.datagridviewx.Columns.Add("idactivo", "ID Articulo")
            End If

            ingresosproceso.idactivos.Visible = True
            ingresosproceso.Label17.Visible = True
            ingresosproceso.PictureBox1.Image = My.Resources.arrow_regress_128
            If ComboBoxEx1.Text = "Egreso de Consumo" Then
                ingresosproceso.ComboBox1.Items.Clear()
                ingresosproceso.ComboBox1.Items.Add("Consumo")
            End If
            If ComboBoxEx1.Text = "Egreso por Donacion" Then
                ingresosproceso.ComboBox1.Items.Clear()
                ingresosproceso.ComboBox1.Items.Add("Devolutivo")
            End If
            If ComboBoxEx1.Text <> "" And TextBoxX1.Text <> "" And TextBoxX2.Text <> "" And ComboBoxEx2.Text <> "" Then
                limipiar(ingresosproceso)
                ingresosproceso.TextBoxX7.Text = ComboBoxEx2.Text
                ingresosproceso.responsable.Text = clave(1)
                ingresosproceso.Label2.Text = ComboBoxEx1.Text
                Me.Close()
                ingresosproceso.Label11.Text = "$0,00"
                mostrar(ingresosproceso, panel.acceso)
            Else
                MsgBox("Debes completar todos los campos")

            End If
        End If
        If tt = "orden" Then
            ingresosproceso.Label11.Text = "$0,00"
            Dim i As Integer = 0
            Dim j As Integer = 0

            For Each DataGridViewColumn In ingresosproceso.datagridviewx.Columns
                If ingresosproceso.datagridviewx.Columns(i).Name = "idactivo" Then
                    j = j + 1

                End If
                i = i + 1
            Next
            If j <> 1 Then
             
                ingresosproceso.datagridviewx.Columns.Add("idactivo", "ID Articulo")
            End If
            ingresosproceso.PictureBox1.Image = My.Resources.shop_26_128
            If ComboBoxEx1.Text <> "" And TextBoxX1.Text <> "" And TextBoxX2.Text <> "" Then
                limipiar(ingresosproceso)
                ingresosproceso.idactivos.Visible = True
                ingresosproceso.Label17.Visible = True


                ingresosproceso.responsable.Text = clave(1)
                ingresosproceso.TextBoxX1.Text = ComboBoxEx1.Text
                ingresosproceso.ComboBox1.Items.Clear()
                ingresosproceso.TextBoxX7.Text = "ALMACEN OFICINA"
                ingresosproceso.ComboBox1.Text = "Consumo"

                ingresosproceso.ComboBox1.Items.Add("Consumo")
                ingresosproceso.Label2.Text = Me.Label2.Text

                Me.Close()

                mostrar(ingresosproceso, panel.acceso)
            Else
                MsgBox("Debes completar todos los campos")

            End If

        End If


    End Sub
End Class