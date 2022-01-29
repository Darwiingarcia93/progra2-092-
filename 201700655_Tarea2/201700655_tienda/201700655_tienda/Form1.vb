'Se coloca la libreria system.math para redondear los resultados
Imports System.Math
Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Este boton esta configurado para salir del sistema
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Este boton esta configurado para limpiar las celdas y dejar el cursor en la primera celda
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox1.Focus()
        'Esta es para ocultar el menu
        GroupBox2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'En esta area se declaran las variables y el tipo de varibale
        Dim librasdearroz As Byte
        Dim librasdefrijol As Byte
        Dim librasdeazucar As Byte
        Dim pagoantesdeagregariva As Double
        Dim iva As Double
        Dim descuento As Double
        Dim total As Double
        'En esta area se colocaron las variables que vamos a utilizar el iva y el descuento
        Const impuesto = 12 / 100
        Const descuento1 = 25 / 1000
        'En esta area se declara la variable y se le da el valor que se pondra en el textbox del programa val(textbox.text)
        librasdearroz = Val(TextBox1.Text)
        librasdefrijol = Val(TextBox3.Text)
        librasdeazucar = Val(TextBox2.Text)

        pagoantesdeagregariva = librasdearroz * 2 + librasdefrijol * 1.75 + librasdeazucar * 2.5
        'la funcion round funciona con la libreria math para el redondeo 
        iva = Round((impuesto * pagoantesdeagregariva), 2)
        descuento = Round(((pagoantesdeagregariva + iva)) * descuento1, 2)
        total = pagoantesdeagregariva + iva - descuento
        'Se procede a monstrar los resultados en las casillas del formulario se utiliza la función STR que convierte
        'Los datos de las variables numericas a formato string
        TextBox4.Text = Str(pagoantesdeagregariva)
        TextBox6.Text = Str(iva)
        TextBox7.Text = Str(descuento)
        TextBox5.Text = Str(total)

        GroupBox2.Visible = True

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
