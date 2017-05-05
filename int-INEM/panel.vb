Public Class panel

  
    Private Sub ButtonItem4_Click(sender As Object, e As EventArgs) Handles ButtonItem4.Click
        Opciones_de_proceso.Show()

    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click

        mostrar(Agregar_provedor, acceso)



    End Sub

    Private Sub panel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

   

  
 
    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click

        mostrar(Form2, acceso)
    End Sub

    Private Sub ButtonItem10_Click(sender As Object, e As EventArgs) Handles ButtonItem10.Click
        agregarcategoria.Show()
    End Sub

    Private Sub ButtonItem11_Click(sender As Object, e As EventArgs) Handles ButtonItem11.Click
        PCategorias.Show()


    End Sub

    Private Sub ButtonItem12_Click(sender As Object, e As EventArgs) Handles ButtonItem12.Click

        mostrar(Articulos, acceso)
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        tt = "ingreso"
        Menu_ingresos.PictureBox1.Image = Global.int_INEM.My.Resources.add


        Menu_ingresos.Label1.Text = "Tipo de ingreso"
        Menu_ingresos.Label2.Text = "Ingresos"
        Menu_ingresos.ComboBoxEx1.Items.Clear()
        Menu_ingresos.ComboBoxEx1.Items.Add("Ingreso Devolutivo")
        Menu_ingresos.ComboBoxEx1.Items.Add("Ingreso por  Donacion")
        Menu_ingresos.ComboBoxEx1.Items.Add("Ingreso de Consumo")
        Menu_ingresos.ComboBoxEx2.Visible = False
        Menu_ingresos.Label6.Visible = False

        Menu_ingresos.Show()

    End Sub

  
  

     
    Private Sub panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
   
        Me.Size = My.Computer.Screen.WorkingArea.Size
        Me.Location = New System.Drawing.Point(0, 0)
    End Sub


    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        Menu_ingresos.PictureBox1.Image = Global.int_INEM.My.Resources.arrow_regress_128
        tt = "egreso"
        listarcombos(Menu_ingresos.ComboBoxEx2, "SELECT * FROM `departamentos`", "Nombre_departamento", "departamentos")
        Menu_ingresos.ComboBoxEx2.Visible = True
        Menu_ingresos.Label6.Visible = True
        Menu_ingresos.Label1.Text = "Tipo de egreso"
        Menu_ingresos.Label2.Text = "Egresos"
        Menu_ingresos.ComboBoxEx1.Items.Clear()
        Menu_ingresos.ComboBoxEx1.Items.Add("Egreso de Consumo")
        Menu_ingresos.ComboBoxEx1.Items.Add("Egreso por Donacion")
        Menu_ingresos.Show()


    End Sub

    Private Sub ButtonItem7_Click(sender As Object, e As EventArgs) Handles ButtonItem7.Click

        mostrar(verlista, acceso)
    End Sub

    Private Sub ButtonItem8_Click(sender As Object, e As EventArgs) Handles ButtonItem8.Click
        buscador.Show()
    End Sub

    Private Sub ButtonItem6_Click(sender As Object, e As EventArgs) Handles ButtonItem6.Click
        Menu_ingresos.PictureBox1.Image = Global.int_INEM.My.Resources.shop_26_128
        tt = "orden"
        Menu_ingresos.ComboBoxEx1.Items.Clear()
        listarcombos(Menu_ingresos.ComboBoxEx1, "SELECT * FROM `proveedores`", "Nombre", "proveedores")
        Menu_ingresos.ComboBoxEx2.Visible = False
        Menu_ingresos.Label6.Visible = False
        Menu_ingresos.Label1.Text = "Proveedor"
        Menu_ingresos.Label2.Text = "Orden de compra"

       
        Menu_ingresos.Show()
    End Sub

    Private Sub ButtonItem9_Click(sender As Object, e As EventArgs) Handles ButtonItem9.Click
        reporte = "pro"
        Reportador.Label2.Text = "Proveedores"
        Reportador.PictureBox1.Image = My.Resources._03_64
        Reportador.ComboBoxEx1.Items.Clear()

        Reportador.ComboBoxEx1.Items.Add("Lista Todos Proveedores")
        Reportador.Show()
    End Sub

    Private Sub ButtonItem14_Click(sender As Object, e As EventArgs) Handles ButtonItem14.Click
        reporte = "ar"
        Reportador.Label2.Text = "Articulos"
        Reportador.PictureBox1.Image = My.Resources.Product_Code_48
        Reportador.ComboBoxEx1.Items.Clear()

        Reportador.ComboBoxEx1.Items.Add("Lista Todos Articulos sistema")
        Reportador.ComboBoxEx1.Items.Add("Lista Todos Articulos de departamentos")
        Reportador.Show()
    End Sub

    Private Sub ButtonItem15_Click(sender As Object, e As EventArgs) Handles ButtonItem15.Click
        reporte = "ca"
        Reportador.Label2.Text = "Categoria"
        Reportador.PictureBox1.Image = My.Resources.label14_64
        Reportador.ComboBoxEx1.Items.Clear()

        Reportador.ComboBoxEx1.Items.Add("Lista Todas las Categorias")

        Reportador.Show()
    End Sub

    Private Sub ButtonItem16_Click(sender As Object, e As EventArgs) Handles ButtonItem16.Click
        reporteindividual.Show()
    End Sub

    Private Sub botonx_Click(sender As Object, e As EventArgs) Handles botonx.Click
        MsgBox("Int-INEM Programa Realizado" & vbCrLf & "por:Andy Arias Borja" & vbCrLf & "Tel:320-5843122" & vbCrLf & "Barranquilla-Colombia", MsgBoxStyle.Information, "Datos Creador")
    End Sub

    Private Sub ButtonItem18_Click(sender As Object, e As EventArgs) Handles ButtonItem18.Click
        departreport.Show()
    End Sub

    Private Sub ButtonItem17_Click(sender As Object, e As EventArgs) Handles ButtonItem17.Click
        mostrar(departamento_activo3, acceso)
    End Sub

    Private Sub ButtonItem19_Click(sender As Object, e As EventArgs) Handles ButtonItem19.Click
        Buscareporte.Show()
    End Sub
End Class