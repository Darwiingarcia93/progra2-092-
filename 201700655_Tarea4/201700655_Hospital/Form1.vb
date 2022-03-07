Public Class Hospital
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub ListBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox6.SelectedIndexChanged

    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged

    End Sub

    Private Sub ListBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox7.SelectedIndexChanged

    End Sub

    Private Sub ListBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox8.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub BOTON_CALCULAR_Click(sender As Object, e As EventArgs) Handles BOTON_CALCULAR.Click
        If (posicion <= 4) Then
            If (TextBox1.Text <> "") And (TextBox2.Text <> "") Then
                nombrepaciente(posicion) = TextBox1.Text + "" + TextBox2.Text

            Else
                MsgBox("ERROR, DATO DE NOMBRE O NIT ES INCORRECTO")
                TextBox1.Focus()
                Exit Sub
            End If
            If (ComboBox1.SelectedIndex > -1) Then
                tipohabitacion(posicion) = ComboBox1.Text
            Else
                MsgBox("ERROR; NO SELECCIONO TIPO DE HABITACION")
                ComboBox1.Focus()
                Exit Sub
            End If
        End If
        Select Case ComboBox1.SelectedIndex
            Case 0
                ListBox4.Items.Add("Privada")
            Case 1
                ListBox4.Items.Add("Semi privada")
            Case 2
                ListBox4.Items.Add("No privada")
        End Select
        ListBox1.Items.Add(TextBox1.Text + " " + TextBox2.Text)
        ListBox2.Items.Add(TextBox3.Text)
        ListBox3.Items.Add(TextBox4.Text)

        If RadioButton1.Checked Then
            ListBox5.Items.Add("Efectivo")
        End If
        If RadioButton2.Checked Then
            ListBox5.Items.Add("Cheque")
        End If
        If RadioButton3.Checked Then
            ListBox5.Items.Add("Tarjeta de credito")
        End If
        If RadioButton4.Checked Then
            ListBox5.Items.Add("Tarjeta de debito")
        End If


    End Sub

    Private Sub BOTON_LIMPIAR2_Click(sender As Object, e As EventArgs) Handles BOTON_LIMPIAR2.Click
        posicion = 0


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Privada")
        ComboBox1.Items.Add("Semi privada")
        ComboBox1.Items.Add("No privada")
    End Sub

    Private Sub BOTON_SALIR_Click(sender As Object, e As EventArgs) Handles BOTON_SALIR.Click
        If MsgBox("Realmente desea salir?", vbQuestion + vbYesNo, "Pregunta") + vbYes Then
            End
        End If
    End Sub
End Class
