Imports MySql.Data
Imports MySql.Data.MySqlClient


Module funciones

    Public registrar As New MySqlCommand
    Public con As New MySqlConnection("Server=localhost;Database=inem; User id= root;")
    Public idtr As Integer
    Public tt As String
    Public reporte As String
    Public departamento As String

    Public Sub mostrar(ByRef form As Form, ByVal container As System.Windows.Forms.Panel)


        form.TopLevel = False
        form.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        form.Dock = DockStyle.Fill
        container.Controls.Clear()
 

        container.Controls.Add(form)
        form.Show()

    End Sub

    Public Sub UID(ByVal consulta_sql As String)

        Try

            con.Close()
            con.Open()
            registrar = New MySqlCommand(consulta_sql, con)
            registrar.ExecuteNonQuery()
            MsgBox("Proceso realizado correctamente", MsgBoxStyle.Information, "Exito")




        Catch ex As MySqlException

            If ex.ErrorCode.ToString = "-2147467259" Then
                MsgBox(ex.ToString)
                MsgBox("Ya existe este Registro")

            Else

            End If

        End Try

    End Sub
    Public Sub UD3(ByVal consulta_sql As String, ByVal nombre As String, des As String)

        Try

            con.Close()
            con.Open()
            registrar = New MySqlCommand(consulta_sql, con)
            registrar.ExecuteNonQuery()





        Catch ex As MySqlException

            If ex.ErrorCode.ToString = "-2147467259" Then
                MsgBox(ex.ToString)
                MsgBox("Ya existe este Registro Nombre: " & nombre & "Descripcion: " & des)

            Else

            End If

        End Try

    End Sub
    Public Sub UD2(ByVal consulta_sql As String)

        Try

            con.Close()
            con.Open()
            registrar = New MySqlCommand(consulta_sql, con)
            registrar.ExecuteNonQuery()





        Catch ex As MySqlException

            If ex.ErrorCode.ToString = "-2147467259" Then
                MsgBox(ex.ToString)
                MsgBox("Ya existe este Registro ")

            Else

            End If

        End Try

    End Sub
    Public Function limipiar(ByVal fom As Form)
        For Each c As Control In fom.Controls
            If TypeOf c Is TextBox Then
                c.Text = "" ' eliminar el texto  
            End If
        Next
        Return Nothing

    End Function




    Public Sub listarcombos(ByVal combo As ComboBox, ByRef consulta As String, ByVal columna As String, ByVal tabla As String)
        Try
            con.Close()
            con.Open()
            Dim adacter As New MySqlDataAdapter(consulta, con)
            Dim dataset As New DataSet
            Dim datatable As New DataTable

            adacter.Fill(dataset, tabla)
            datatable = dataset.Tables(tabla)
            Dim fila As DataRow
            For Each fila In datatable.Rows
                '
                ' mostrar los datos mediante un objeto de fila
                combo.Items.Add(fila.Item(columna))
            Next





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub
    Public Sub listarcolumcombobox(ByVal combo As ComboBox, ByRef consulta As String, ByVal columna As String, ByVal tabla As String, ByVal indice1 As Integer, ByVal indice2 As Integer)
        Try
            con.Close()
            con.Open()
            Dim adacter As New MySqlDataAdapter(consulta, con)
            Dim dataset As New DataSet
            Dim datatable As New DataTable

            adacter.Fill(dataset, tabla)
            datatable = dataset.Tables(tabla)
            combo.DataSource = datatable
     
            combo.DisplayMember = datatable.Columns(indice1).ColumnName.ToString
            combo.ValueMember = datatable.Columns(indice2).ColumnName.ToString





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub
    Public Sub listartexbox(ByVal textbox As TextBox, ByRef consulta As String, ByVal columna As String, ByVal tabla As String)
        Try
            con.Close()
            con.Open()
            Dim adacter As New MySqlDataAdapter(consulta, con)
            Dim dataset As New DataSet
            Dim datatable As New DataTable

            adacter.Fill(dataset, tabla)
            datatable = dataset.Tables(tabla)
            Dim fila As DataRow
            For Each fila In datatable.Rows
                '
                ' mostrar los datos mediante un objeto de fila
                textbox.AutoCompleteCustomSource.Add(fila.Item(columna))
            Next





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Public Sub cargardatagrid(ByVal sql As String, ByVal datagrid As DataGridView)
        con.Close()
        con.Open()
        Try

            Dim consultar As New MySqlDataAdapter(sql, con)

            Dim dt As New DataTable
            consultar.Fill(dt)
            datagrid.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try

    End Sub
    Public Sub busquedadatagrid(ByVal sql As String, ByVal datagrid As DataGridView)
        con.Close()
        con.Open()
        Try

            Dim consultar As New MySqlDataAdapter(sql, con)

            Dim dt As New DataTable
            consultar.Fill(dt)
            datagrid.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try

    End Sub
    Public Sub onlynumbers(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox(" Solo numeros en este campo", MsgBoxStyle.Critical)


        End If
    End Sub
    Public Sub onlychar(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox(" Solo Letras en este campo", MsgBoxStyle.Critical)

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False

        End If
    End Sub

    Public Function consultarclave()
        Dim procedimientos(3) As String
        con.Close()
        con.Open()
        Try
            Dim consultar As New MySqlDataAdapter("SELECT * FROM `procesos`", con)
            Dim dataset As New DataSet

            consultar.Fill(dataset, "procesos")
            Dim numero As Integer
            numero = dataset.Tables("procesos").Rows.Count
            If numero > 0 Then
                procedimientos(1) = dataset.Tables("procesos").Rows(0).Item("Nombre_responsable")
                procedimientos(2) = dataset.Tables("procesos").Rows(0).Item("clave")



            Else
                MsgBox("Aun No se ha registrado una clave, se nesecita una clave para las transacciones", MsgBoxStyle.Exclamation, "No existe clave")
            End If




        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        Return procedimientos
    End Function
 
    Public Sub precioprovedor(ByRef consulta As String, ByVal provedor As TextBox, ByVal precio As TextBox, ByVal tabla As String)
        con.Close()
        con.Open()
        Try
            Dim consul As New MySqlDataAdapter(consulta, con)
            Dim dataset As New DataSet
            consul.Fill(dataset, tabla)
            Dim numero As Integer = dataset.Tables(tabla).Rows.Count
            If numero > 0 Then
                provedor.Text = dataset.Tables(tabla).Rows(0).Item("proveedor")
                precio.Text = dataset.Tables(tabla).Rows(0).Item("valor_comercial")

            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub precionly(ByRef consulta As String, ByVal provedor As TextBox, ByVal precio As TextBox, ByVal tabla As String)
        con.Close()
        con.Open()
        Try
            Dim consul As New MySqlDataAdapter(consulta, con)
            Dim dataset As New DataSet
            consul.Fill(dataset, tabla)
            Dim numero As Integer = dataset.Tables(tabla).Rows.Count
            If numero > 0 Then

                precio.Text = dataset.Tables(tabla).Rows(0).Item("valor_comercial")

            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Function numerostock(ByRef consulta As String, ByVal tabla As String)
        con.Close()
        con.Open()
        Dim cantidadde As Integer
        Try
            Dim consul As New MySqlDataAdapter(consulta, con)
            Dim dataset As New DataSet

            consul.Fill(dataset, tabla)
            Dim numero As Integer = dataset.Tables(tabla).Rows.Count
            If numero > 0 Then

                cantidadde = dataset.Tables(tabla).Rows(0).Item("cantidad")

            End If

        Catch ex As Exception

        End Try
        Return cantidadde
    End Function

    Public Sub encontrarid(ByVal id As Integer)
        con.Close()
        con.Open()
        Try
            Dim onsu As New MySqlDataAdapter("select* from `transacciones` WHERE `idtransaccion`=" & id, con)
            Dim dataset As New DataSet
            onsu.Fill(dataset, "transacciones")
            Dim fila As Integer = dataset.Tables("transacciones").Rows.Count
            If fila > 0 Then
                buscadoencontrado.Label5.Text = "Transaccion ID:" & id
                buscadoencontrado.responsable.Text = dataset.Tables("transacciones").Rows(0).Item("responsable")

                buscadoencontrado.TextBoxX1.Text = dataset.Tables("transacciones").Rows(0).Item("tipo")
                buscadoencontrado.TextBoxX7.Text = dataset.Tables("transacciones").Rows(0).Item("Departamento")
                buscadoencontrado.TextBoxX2.Text = dataset.Tables("transacciones").Rows(0).Item("fecha")
                buscadoencontrado.Label6.Text = dataset.Tables("transacciones").Rows(0).Item("total")
                cargardatagrid("SELECT * FROM `dt` where `idt`=" & id, buscadoencontrado.DataGridViewX1)
                mostrar(buscadoencontrado, panel.acceso)




            Else
                MsgBox("No hay ninguna transaccion con ese ID,por favor escriba una valido", MsgBoxStyle.Exclamation)

            End If

        Catch ex As Exception

        End Try

    End Sub











    Public Function retornarnummero(ByVal consulta As String, ByVal tabla As String)
        con.Close()
        con.Open()
        Dim numero As Integer
        Try
            Dim consul As New MySqlDataAdapter(consulta, con)
            Dim dataset As New DataSet
            consul.Fill(dataset, tabla)
            numero = dataset.Tables(tabla).Rows.Count


        Catch ex As Exception

        End Try
        Return numero

    End Function

End Module
