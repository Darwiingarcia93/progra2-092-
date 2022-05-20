Public Class Form1
    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If (F <= 6) Then
            Datos(F, 0) = txtnit.Text
            Datos(F, 1) = TXTNOMBRE.Text
            Datos(F, 2) = Val(TXTEXTRAS.Text)
            If (RDBESTANDAR.Checked) Then
                Datos(F, 3) = "Estandar"
                Datos(F, 4) = 250
            ElseIf (RDBAC.Checked) Then
                Datos(F, 3) = "A/C"
                Datos(F, 4) = 290
            ElseIf (RDBJACUZZI.Checked) Then
                Datos(F, 3) = "Jacuzzi"
                Datos(F, 4) = 370
            Else
                MsgBox("Error, seleccione un tipo de habitación")
                Exit Sub
            End If
            If (Val(TXTEXTRAS.Text) <= 4) Then
                Datos(F, 5) = 0
            ElseIf (Val(TXTEXTRAS.Text >= 5)) Then
                Datos(F, 5) = 60 * (Datos(F, 2) - 4)
            End If
            Datos(F, 6) = Val(Datos(F, 4)) + Val(Datos(F, 5))
            F = F + 1
            limpiar_entradas()
        End If
        If (F = 7) Then
            MsgBox("Error, matriz llena")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Mostrar()
    End Sub

    Private Sub VECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VECTORESToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub MATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MATRIZToolStripMenuItem.Click
        Limpiar_Matriz()
    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        consultar()
    End Sub

    Private Sub DATAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ORDENARDESCENTNDETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARDESCENTNDETEToolStripMenuItem.Click

    End Sub
End Class
