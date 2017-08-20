Public Class Form1

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        Dim number1 As Double = CDbl(firstbox.Text)
        Dim number2 As Double = CDbl(secondbox.Text)
        answerbox.Text = number1 + number2
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        Dim number1 As Double = CDbl(firstbox.Text)
        Dim number2 As Double = CDbl(secondbox.Text)
        answerbox.Text = number1 - number2
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        Dim number1 As Double = CDbl(firstbox.Text)
        Dim number2 As Double = CDbl(secondbox.Text)
        answerbox.Text = number1 * number2
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        Dim number1 As Double = CDbl(firstbox.Text)
        Dim number2 As Double = CDbl(secondbox.Text)
        answerbox.Text = number1 / number2
    End Sub

    Private Sub ButtonTax_Click(sender As Object, e As EventArgs) Handles ButtonTax.Click
        Dim number1 As Double = CDbl(firstbox.Text)
        Dim number2 As Double = CDbl(secondbox.Text)
        Dim number3 As Double = number1 * number2
        answerbox.Text = number1 + number3
    End Sub

    Private Sub ButtonTemperatureFC_Click(sender As Object, e As EventArgs) Handles ButtonTemperatureFC.Click
        Dim number1 As Double = CDbl(firstbox.Text)
        answerbox.Text = (number1 - 32) * (5 / 9)
    End Sub

    Private Sub ButtonTemperatureCF_Click(sender As Object, e As EventArgs) Handles ButtonTemperatureCF.Click
        Dim number1 As Double = CDbl(firstbox.Text)
        answerbox.Text = (number1 * (9 / 5)) + 32
    End Sub

    Private Sub ButtonPower_Click(sender As Object, e As EventArgs) Handles ButtonPower.Click
        Dim number1 As Double = CDbl(firstbox.Text)
        Dim number2 As Double = CDbl(secondbox.Text)
        answerbox.Text = number1 ^ number2
    End Sub
End Class
