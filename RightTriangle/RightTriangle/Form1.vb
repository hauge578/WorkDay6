Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim aSt As String = txtSideOne.Text
        Dim bSt As String = txtSideTwo.Text

        Dim a As Double = CDbl(aSt)
        Dim b As Double = CDbl(bSt)

        Dim res As Double
        res = Hypotenuse(a, b)



        txtHyp.Text = CStr(res)

    End Sub

    Function Hypotenuse(ByVal x As Double,
                        ByVal y As Double) As Double


        Dim result As Double
        result = Math.Sqrt(x ^ 2 + y ^ 2)
        Return result

    End Function

End Class
