Public Class ingresosproceso
    Dim iva As Double = 0
    Dim descuento As Double = 0
    Dim preciototal As Double = 0
    Dim cantidad As Integer = 0
    Dim totaltransaccion As Double
    Dim indice As DataGridViewRow
    Dim sw As Boolean = False
    Dim idt As Integer
    Dim precioi As Double = 0
    Dim numeroalmacen As Integer

    Private Sub ingresosproceso_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

 
  


    Private Sub ingresosproceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        idt = retornarnummero("Select* from `transacciones`", "transacciones") + 1

        Label15.Text = "Codigo transaccion:" & idt

        listartexbox(TextBoxX3, "SELECT * FROM `cateogria` ", "Nombre_categoria", "cateogria")
        datagridviewx.Columns(0).Width = 170
        datagridviewx.Columns(1).Width = 170
        datagridviewx.Columns(2).Width = 120
        datagridviewx.Columns(3).Width = 120
        datagridviewx.Columns(4).Width = 200
        datagridviewx.Columns(5).Width = 220

    End Sub

    Private Sub TextBoxX3_LostFocus(sender As Object, e As EventArgs) Handles TextBoxX3.LostFocus
        If tt = "ingreso" Then
            ComboBoxEx1.Items.Clear()
            listarcombos(ComboBoxEx1, "Select* from activos where `tipo`='" + ComboBox1.Text + "' and `Categoria`='" + TextBoxX3.Text + "'", "Nombre", "activos")
        End If
        If tt = "egreso" Then
            listarcolumcombobox(ComboBoxEx1, "SELECT `activos`,`d-activos`.`id` FROM `activos`,`d-activos` WHERE `activos`.Nombre=`d-activos`.activos and `activos`.Categoria='" & TextBoxX3.Text & "' and `d-activos`.departamento='ALMACEN OFICINA' AND `activos`.tipo='" & ComboBox1.Text & "'", "activos", "activos", 0, 1)
        End If
        If tt = "orden" Then
            listarcolumcombobox(ComboBoxEx1, "SELECT  `activos`,`d-activos`.`id`  FROM `activos`,`d-activos` WHERE `activos`.Nombre=`d-activos`.activos and `activos`.Categoria='" & TextBoxX3.Text & "' and `d-activos`.departamento='ALMACEN OFICINA' AND `activos`.tipo='" & ComboBox1.Text & "'and `activos`.`proveedor`='" & TextBoxX1.Text & "'", "activos", "activos", 0, 1)
      End If


    End Sub

  

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        If tt = "ingreso" Then
            precioprovedor("Select* from activos where `Nombre`='" + ComboBoxEx1.Text + "'", TextBoxX1, TextBoxX6, "activos")
        ElseIf tt = "egreso" Then
            precioprovedor("Select* from activos where `Nombre`='" + ComboBoxEx1.Text + "'", TextBoxX1, TextBoxX6, "activos")

            idactivos.Text = ComboBoxEx1.SelectedValue.ToString
            numeroalmacen = numerostock("SELECT * FROM `d-activos` WHERE `id`=" & Val(idactivos.Text), "d-activos")


        Else
            precionly("Select* from activos where `Nombre`='" + ComboBoxEx1.Text + "'", TextBoxX1, TextBoxX6, "activos")

            idactivos.Text = ComboBoxEx1.SelectedValue.ToString

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxX1.Text <> "" And TextBoxX3.Text <> "" And ComboBox1.Text <> "" And ComboBoxEx1.Text <> "" Then
            Dim DES As String = InputBox("AGREGUE LA DESCIPCION DEL PRODUCTO: " & ComboBoxEx1.Text, "Descripcion producto", "NINGUNA")
            Dim i As Integer = 0
            Dim j As Integer = 0
            For Each DataGridViewRow In datagridviewx.Rows

                Dim artiulo As String = CStr(datagridviewx.Item(0, i).Value)
                Dim serial As String = CStr(datagridviewx.Item(5, i).Value)
                If artiulo <> ComboBoxEx1.Text Or serial <> DES Then
                    j = j + 1

                End If
                i = i + 1
            Next

            If j = datagridviewx.Rows.Count Then
                sw = True

            End If

            If TextBoxX5.Text <> "" Then
                iva = Val(TextBoxX5.Text) / 100


            Else

                iva = 0.19


            End If

            If TextBoxX2.Text <> "" And Val(TextBoxX2.Text) <> 0 Then
                cantidad = Val(TextBoxX2.Text)

            Else
                cantidad = 1

            End If

            If TextBoxX4.Text <> "" Then
                descuento = Val(TextBoxX4.Text) / 100
            Else
                descuento = 0
            End If
            If sw = True Then


                precioi = CDbl(TextBoxX6.Text)

                preciototal = (precioi * cantidad) + ((precioi * cantidad) * iva) - ((precioi * cantidad) * descuento)
                If tt = "orden" Then
                    datagridviewx.Rows.Add(ComboBoxEx1.Text, TextBoxX6.Text, cantidad, descuento * 100 & "%", FormatCurrency(preciototal), DES, idactivos.Text)
                ElseIf tt = "egreso" Then
                    If numeroalmacen >= Val(TextBoxX2.Text) Then
                        datagridviewx.Rows.Add(ComboBoxEx1.Text, TextBoxX6.Text, cantidad, descuento * 100 & "%", FormatCurrency(preciototal), DES, idactivos.Text)
                    Else
                        MsgBox("Error en el almacen no hay suficiente cantidades de este articulo", MsgBoxStyle.Critical)

                    End If

                   

                Else
                    datagridviewx.Rows.Add(ComboBoxEx1.Text, TextBoxX6.Text, cantidad, descuento * 100 & "%", FormatCurrency(preciototal), DES)
                    TextBoxX1.Text = ""
                End If
                i = 0
                idactivos.Text = ""
                totaltransaccion = 0
                ComboBoxEx1.Text = ""
                TextBoxX6.Text = ""
                TextBoxX5.Text = ""
                TextBoxX2.Text = ""
                TextBoxX4.Text = ""

                TextBoxX3.Text = ""
                For Each DataGridViewRow In datagridviewx.Rows

                    Dim product As Double = CDbl(datagridviewx.Item(4, i).Value)
                    totaltransaccion = product + totaltransaccion
                    i = i + 1
                Next
                Label11.Text = FormatCurrency(totaltransaccion)
                If tt <> "orden" And tt <> "egreso" Then
                    ComboBoxEx1.Items.Clear()


                End If

                sw = False



            Else
                MsgBox("Este producto ya fue agregado, para poder agregarlo debe elminarlo de la tabla", MsgBoxStyle.Critical, "Producto no puede estar Repetido")

            End If

        Else
            MsgBox("Debes Escoger el producto antes de Agregar", MsgBoxStyle.Critical, "Error al agregar")



        End If
    End Sub


    Private Sub TextBoxX6_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX6.TextChanged

    End Sub

    Private Sub TextBoxX4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxX4.KeyPress
        onlynumbers(e)
    End Sub


    Private Sub TextBoxX4_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX4.TextChanged

    End Sub

    Private Sub TextBoxX5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxX5.KeyPress
        onlynumbers(e)
    End Sub

    Private Sub TextBoxX2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxX2.KeyPress
        onlynumbers(e)
    End Sub

    Private Sub datagridviewx_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewx.CellClick
        sw = True
        indice = datagridviewx.CurrentRow
    End Sub






    Private Sub datagridviewx_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewx.RowHeaderMouseClick
        sw = True
        indice = datagridviewx.CurrentRow
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If sw = True Then
            Dim resta As String = datagridviewx.Item(4, indice.Index).Value.ToString()

            datagridviewx.Rows.Remove(indice)
            Label11.Text = "" & FormatCurrency(CDbl(Label11.Text) - CDbl(resta))
        Else
            MsgBox("Debe seleccionar celda o fila al eliminar", MsgBoxStyle.Critical, "Error")


        End If
        sw = False
    End Sub

     
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If datagridviewx.Rows.Count > 0 Then
            If tt = "ingreso" Then
                idtr = idt
                UD2("INSERT INTO `transacciones`(`idtransaccion`, `fecha`, `tipo`, `responsable`, `total`,`Departamento`) VALUES(" & idt & ",'" & DateTimePicker1.Value.ToShortDateString & "','" & Label2.Text & "','" & responsable.Text & "','" & Label11.Text & "','" & TextBoxX7.Text & "')")
                For i As Integer = 0 To datagridviewx.RowCount - 2
                    UD2("INSERT INTO `dt`(`activo`, `precio`, `idt`, `cantidad`, `descuento`, `preciototal`,`Descripcionactivo`) VALUES('" & datagridviewx.Item(0, i).Value.ToString & "','" & datagridviewx.Item(1, i).Value.ToString & "'," & idt & ",'" & datagridviewx.Item(2, i).Value.ToString & "','" & datagridviewx.Item(3, i).Value.ToString & "','" & datagridviewx.Item(4, i).Value.ToString & "','" & datagridviewx.Item(5, i).Value.ToString & "')")

                Next
                For i As Integer = 0 To datagridviewx.RowCount - 2

                    UD3("insert into `d-activos`(`activos`, `cantidad`, `departamento`, `descripcion`) VALUES ('" & datagridviewx.Item(0, i).Value.ToString & "','" & datagridviewx.Item(2, i).Value.ToString & "','ALMACEN OFICINA','" & datagridviewx.Item(5, i).Value.ToString & "' )", datagridviewx.Item(0, i).Value.ToString, datagridviewx.Item(5, i).Value.ToString)
                Next
                Label11.Text = "$0,00"
                idt = retornarnummero("Select* from `transacciones`", "transacciones") + 1
                Label15.Text = "Codigo transaccion:" & idt

                datagridviewx.Rows.Clear()
                cargardatagrid("Select*from transacciones ", verlista.DataGridViewX1)

                If MsgBox("Exito al realizar transaccion ¿Desea generar Reporte? ", MsgBoxStyle.YesNo, "Exito") = 6 Then
                    transaccion.Show()

                End If
            End If
            If tt = "egreso" Then
                idtr = idt
                UD2("INSERT INTO `transacciones`(`idtransaccion`, `fecha`, `tipo`, `responsable`, `total`,`Departamento`,`Proveerdor`) VALUES(" & idt & ",'" & DateTimePicker1.Value.ToShortDateString & "','" & Label2.Text & "','" & responsable.Text & "','" & Label11.Text & "','" & TextBoxX7.Text & "','" & TextBoxX1.Text & "')")
                For i As Integer = 0 To datagridviewx.RowCount - 2
                    UD2("INSERT INTO `dt`(`activo`, `precio`, `idt`, `cantidad`, `descuento`, `preciototal`,`Descripcionactivo`) VALUES('" & datagridviewx.Item(0, i).Value.ToString & "','" & datagridviewx.Item(1, i).Value.ToString & "'," & idt & ",'" & datagridviewx.Item(2, i).Value.ToString & "','" & datagridviewx.Item(3, i).Value.ToString & "','" & datagridviewx.Item(4, i).Value.ToString & "','" & datagridviewx.Item(5, i).Value.ToString & "')")

                Next
                For i As Integer = 0 To datagridviewx.RowCount - 2
                    Dim cantidad As Integer = Val(datagridviewx.Item(2, i).Value.ToString)
                    Dim idd As Integer = Val(datagridviewx.Item(6, i).Value.ToString)
                    Dim sql As String = "UPDATE `d-activos` SET `cantidad`=`cantidad`-" & cantidad & " WHERE `id`=" & idd

                    UD2(sql)
                Next
                For i As Integer = 0 To datagridviewx.RowCount - 2

                    UD3("insert into `d-activos`(`activos`, `cantidad`, `departamento`, `descripcion`) VALUES ('" & datagridviewx.Item(0, i).Value.ToString & "','" & datagridviewx.Item(2, i).Value.ToString & "','" & TextBoxX7.Text & "','" & datagridviewx.Item(5, i).Value.ToString & "' )", datagridviewx.Item(0, i).Value.ToString, datagridviewx.Item(5, i).Value.ToString)
                Next
                Label11.Text = "$0,00"
                idt = retornarnummero("Select* from `transacciones`", "transacciones") + 1
                datagridviewx.Rows.Clear()
                cargardatagrid("Select*from transacciones ", verlista.DataGridViewX1)

                If MsgBox("Exito al realizar transaccion ¿Desea generar Reporte? ", MsgBoxStyle.YesNo, "Exito") = 6 Then
                    transaccion.Show()

                End If
            End If
            If tt = "orden" Then
                idtr = idt
                UD2("INSERT INTO `transacciones`(`idtransaccion`, `fecha`, `tipo`, `responsable`, `total`,`Departamento`,`Proveerdor`) VALUES(" & idt & ",'" & DateTimePicker1.Value.ToShortDateString & "','" & Label2.Text & "','" & responsable.Text & "','" & Label11.Text & "','" & TextBoxX7.Text & "','" & TextBoxX1.Text & "')")
                For i As Integer = 0 To datagridviewx.RowCount - 2
                    UD2("INSERT INTO `dt`(`activo`, `precio`, `idt`, `cantidad`, `descuento`, `preciototal`,`Descripcionactivo`) VALUES('" & datagridviewx.Item(0, i).Value.ToString & "','" & datagridviewx.Item(1, i).Value.ToString & "'," & idt & ",'" & datagridviewx.Item(2, i).Value.ToString & "','" & datagridviewx.Item(3, i).Value.ToString & "','" & datagridviewx.Item(4, i).Value.ToString & "','" & datagridviewx.Item(5, i).Value.ToString & "')")

                Next
                For i As Integer = 0 To datagridviewx.RowCount - 2
                    Dim cantidad As Integer = Val(datagridviewx.Item(2, i).Value.ToString)
                    Dim idd As Integer = Val(datagridviewx.Item(6, i).Value.ToString)
                    Dim sql As String = "UPDATE `d-activos` SET `cantidad`=`cantidad`+" & cantidad & " WHERE `id`=" & idd

                    UD2(sql)
                Next
                Label11.Text = "$0,00"
                idt = retornarnummero("Select* from `transacciones`", "transacciones") + 1
                datagridviewx.Rows.Clear()
                cargardatagrid("Select*from transacciones ", verlista.DataGridViewX1)

                If MsgBox("Exito al realizar transaccion ¿Desea generar Reporte? ", MsgBoxStyle.YesNo, "Exito") = 6 Then
                    ordercompa.Show()

                End If
            End If



        Else
            MsgBox("Debe agregar productos para realizar la transaccion", MsgBoxStyle.Critical, "Error falta agregar productos")
        End If
    End Sub

    Private Sub TextBoxX3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX3.TextChanged

    End Sub
End Class