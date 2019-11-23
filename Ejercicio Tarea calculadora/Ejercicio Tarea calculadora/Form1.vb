Public Class Form1
    Dim operacion As Char
    Dim aux As String



    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        TextBoxvalorunico.Clear()
        aux = 0
    End Sub

    

    Private Sub BtnSiete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiete.Click
        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "7"


    End Sub

    Private Sub BtnOcho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOcho.Click
        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "8"

    End Sub

    Private Sub BtnNueve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNueve.Click
        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "9"

    End Sub

    Private Sub BtnCuatro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCuatro.Click
        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "4"


    End Sub

    Private Sub BtnCinco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCinco.Click
        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "5"

    End Sub

    Private Sub BtnSeis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeis.Click
        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "6"

    End Sub

    Private Sub BtnUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUno.Click

        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "1"


    End Sub

    Private Sub BtnDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDos.Click
        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "2"

    End Sub

    Private Sub BtnTres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTres.Click
        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "3"

    End Sub

    Private Sub BtnCero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCero.Click
        TextBoxvalorunico.Text = TextBoxvalorunico.Text + "0"
    End Sub

    Private Sub BtnIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIgual.Click
        Select Case Operacion
            Case "+"
                TextBoxvalorunico.Text = aux + Val(TextBoxvalorunico.Text)
            Case "-"
                TextBoxvalorunico.Text = aux - Val(TextBoxvalorunico.Text)
            Case "x"
                TextBoxvalorunico.Text = aux * Val(TextBoxvalorunico.Text)
            Case "/"
                TextBoxvalorunico.Text = aux / Val(TextBoxvalorunico.Text)
        End Select


    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        aux = TextBoxvalorunico.Text
        TextBoxvalorunico.Clear()
        operacion = "-"
    End Sub

    Private Sub BtnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMultiplicar.Click
        aux = TextBoxvalorunico.Text
        TextBoxvalorunico.Clear()
        operacion = "x"
    End Sub

    Private Sub BtnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDividir.Click
        aux = TextBoxvalorunico.Text
        TextBoxvalorunico.Clear()
        operacion = "/"
        If aux = 0 Then
            MsgBox("No se puede dividir por 0")
        End If
    End Sub
    Private Sub BtnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSumar.Click
        aux = TextBoxvalorunico.Text
        TextBoxvalorunico.Clear()
        operacion = "sumar"
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.Text = Format(Now)
    End Sub
End Class



