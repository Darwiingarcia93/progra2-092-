Imports System.Math
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTSALIR.Click
        If MsgBox("¿Esta seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTCALCULAR.Click
        Dim n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 As Double
        Dim prom As Double
        Dim condicion As String
        n1 = Not1.Text
        n2 = Not2.Text
        n3 = Not3.Text
        n4 = Not4.Text
        n5 = Not5.Text
        n6 = not6.Text
        n7 = not7.Text
        n8 = not8.Text
        n9 = not9.Text
        n10 = not10.Text
        prom = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 10

        If prom <= 70 Then
            condicion = "RENDIMIENTO BAJO"
            txtCondicion.Text = condicion
            Resultado.Text = prom

        ElseIf prom >= 71 And prom <= 80 Then
            condicion = "RENDIMIENTO BUENO"
            txtCondicion.Text = condicion
            Resultado.Text = prom
        ElseIf prom >= 81 And prom <= 90 Then
            condicion = "RENDIMIENTO MUY BUENO"
            txtCondicion.Text = condicion
            Resultado.Text = prom
        ElseIf prom >= 90 And prom <= 100 Then
            condicion = "RENDIMIENTO EXCELENTE"
            txtCondicion.Text = condicion
            Resultado.Text = prom
        Else
            condicion = "NOTA FUERA DE RANGO"
            txtCondicion.Text = condicion
            Resultado.Text = prom

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles not6.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles not7.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTLIMPIAR.Click
        Not1.Clear()
        Not2.Clear()
        Not3.Clear()
        Not4.Clear()
        Not5.Clear()
        not6.Clear()
        not7.Clear()
        not8.Clear()
        not9.Clear()
        not10.Clear()
        txtCondicion.Clear()
        Resultado.Clear()
        txtnombre.Clear()
        txtcarnet.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Equivalencia1_CheckedChanged(sender As Object, e As EventArgs) Handles Equivalencia1.CheckedChanged
        If Equivalencia1.Checked = True Then
            Not1.Clear()
        End If
    End Sub
End Class
