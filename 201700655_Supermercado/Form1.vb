Public Class Form1

    Dim packs = New String() {"Juegos", "frituras", "Galletas", "Baterias"}

    'columans = "Juegos", "frituras", "Galletas", "Baterias"
    Public inventario = New Integer() {100, 100, 100, 100}
    Dim total As Double = 0
    Dim sobrante As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each item As String In packs
            ListaDePacks.Items.Add(item)
        Next



    End Sub

    Private Sub ListaDePacks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaDePacks.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Salir.Click

    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Dim cantfilas As Integer

        DataGridView1.Rows.Add()
        cantfilas = DataGridView1.Rows.Count - 1





        If ListaDePacks.SelectedItem.ToString() = "Juegos" Then
            inventario(0) = inventario(0) - 1
            total = total + (8.5 * CantP.Text)
            DataGridView1(0, cantfilas).Value = "juegos"
            DataGridView1(1, cantfilas).Value = "8.5"
            DataGridView1(2, cantfilas).Value = CantP.Text

            Dim packsJ = inventario(0) / CantP.Text
            Label4.Text = packsJ

            Dim SobranteJ = inventario(0) Mod CantP.Text
            Label24.Text = SobranteJ

        End If
        If ListaDePacks.SelectedItem.ToString() = "frituras" Then
            inventario(1) = inventario(1) - 1
            total = total + (11.2 * CantP.Text)
            DataGridView1(0, cantfilas).Value = "frituras"
            DataGridView1(1, cantfilas).Value = "11.20"
            DataGridView1(2, cantfilas).Value = CantP.Text

            Dim packsf = inventario(1) / CantP.Text
            Label4.Text = packsf

            Dim SobranteJ = inventario(1) Mod CantP.Text
            Label19.Text = SobranteJ

        End If
        If ListaDePacks.SelectedItem.ToString() = "Baterias" Then
            inventario(3) = inventario(3) - 1
            total = total + (15 * CantP.Text)
            DataGridView1(0, cantfilas).Value = "Baterias"
            DataGridView1(1, cantfilas).Value = "15"
            DataGridView1(2, cantfilas).Value = CantP.Text

            Dim packsf = inventario(2) / CantP.Text
            Label6.Text = packsf

            Dim SobranteJ = inventario(2) Mod CantP.Text
            Label18.Text = SobranteJ

        End If
        If ListaDePacks.SelectedItem.ToString() = "Galletas" Then
            inventario(2) = inventario(2) - 1
            total = total + (4.25 * CantP.Text)
            DataGridView1(0, cantfilas).Value = "Galletas"
            DataGridView1(1, cantfilas).Value = "4.25"
            DataGridView1(2, cantfilas).Value = CantP.Text

            Dim packsf = inventario(3) / CantP.Text
            Label15.Text = packsf

            Dim SobranteJ = inventario(3) Mod CantP.Text
            Label17.Text = SobranteJ
        End If

        TotalV.Text = total
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

    End Sub

    Private Sub Limpiar_Lista_Click(sender As Object, e As EventArgs) Handles Limpiar_Lista.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click

    End Sub
End Class
