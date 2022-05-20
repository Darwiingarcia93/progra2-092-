Module Module1
    Public Datos(7, 6) As String
    Public X As Byte = 0
    Public F As Byte = 0
    Public personas As Integer
    Public DESC As Integer
    Sub limpiar_entradas()
        Form1.txtnit.Text = ""
        Form1.TXTEXTRAS.Text = ""
        Form1.TXTNOMBRE.Text = ""
        Form1.RDBESTANDAR.Checked = False
        Form1.RDBJACUZZI.Checked = False
        Form1.RDBAC.Checked = False
    End Sub
    Sub Mostrar()
        Form1.DataGridView1.Rows.Clear()
        X = 0
        While (X <= 6)
            If (Datos(X, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Datos(X, 0), Datos(X, 1), Datos(X, 2), Datos(X, 3), Datos(X, 5), Datos(X, 6))
            Else
                Exit While

            End If
            X = X + 1
        End While



    End Sub
    Sub Limpiar_Matriz()
        Form1.DataGridView1.Rows.Clear()
        F = 0
        X = 0
        While (X <= 6)
            Datos(X, 0) = Nothing
            Datos(X, 1) = Nothing
            Datos(X, 2) = Nothing
            Datos(X, 3) = Nothing
            Datos(X, 4) = Nothing
            Datos(X, 5) = Nothing
            Datos(X, 6) = Nothing
            X = X + 1
        End While
    End Sub
    Sub consultar()
        Dim Hay As Boolean = True
        X = 0
        While (X <= 6) And (Hay)
            If (Datos(X, 0) <> Nothing) Then
                If (Val(Datos(X, 0)) = Val(Form1.TXTCONSULTA.Text)) Then
                    Hay = False
                Else
                    X = X + 1
                End If
            Else
                Exit While

            End If

        End While
        If (Hay) Then
            MsgBox("Nit no encontrado")
            Form1.TXTCONSULTA.Focus()
        Else
            MsgBox("Nit encontrado")
            Form1.DataGridView1.Rows.Clear()
            Form1.txtnit.Text = Datos(F, 0)
            Form1.TXTEXTRAS.Text = Datos(F, 2)
            Form1.TXTNOMBRE.Text = Datos(F, 1)
            Form1.DataGridView1.Rows.Add(Datos(X, 0), Datos(X, 1), Datos(X, 2), Datos(X, 3), Datos(X, 5), Datos(X, 6))
        End If
    End Sub
End Module

