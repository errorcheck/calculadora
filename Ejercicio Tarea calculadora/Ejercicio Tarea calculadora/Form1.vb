Public Class Form1
    Dim operacion As String
    Dim aux As Double



    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        TextBoxvalorunico.Clear()
        TextBoxvalorunico.Text = "0"
        aux = 0
        operacion = String.Empty
        Label1.Text = String.Empty
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
        ' Validación de división por cero
        If operacion = "/" AndAlso Val(TextBoxvalorunico.Text) = 0 Then
            MsgBox("No se puede dividir por 0")
            Exit Sub
        End If

        Select Case operacion
            Case "+"
                TextBoxvalorunico.Text = (aux + Val(TextBoxvalorunico.Text)).ToString()
            Case "-"
                TextBoxvalorunico.Text = (aux - Val(TextBoxvalorunico.Text)).ToString()
            Case "*"
                TextBoxvalorunico.Text = (aux * Val(TextBoxvalorunico.Text)).ToString()
            Case "/"
                TextBoxvalorunico.Text = (aux / Val(TextBoxvalorunico.Text)).ToString()
        End Select

        operacion = String.Empty
        Label1.Text = String.Empty

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        aux = Val(TextBoxvalorunico.Text)
        TextBoxvalorunico.Clear()
        operacion = "-"
        Label1.Text = aux & " -"
    End Sub

    Private Sub BtnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMultiplicar.Click
        aux = Val(TextBoxvalorunico.Text)
        TextBoxvalorunico.Clear()
        operacion = "*"
        Label1.Text = aux & " *"
    End Sub

    Private Sub BtnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDividir.Click
        aux = Val(TextBoxvalorunico.Text)
        TextBoxvalorunico.Clear()
        operacion = "/"
        Label1.Text = aux & " /"
    End Sub
    Private Sub BtnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSumar.Click
        aux = Val(TextBoxvalorunico.Text)
        TextBoxvalorunico.Clear()
        operacion = "+"
        Label1.Text = aux & " +"
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.Text = Format(Now)
    End Sub
End Class



