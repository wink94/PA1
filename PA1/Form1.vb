


Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim side1, side2, side3, angle1_2, angle2_3, angle3_1 As Double
        Dim displayString As String

        If (String.IsNullOrEmpty(txtAngle.Text) = True Or String.IsNullOrEmpty(txtSide1.Text) = True Or String.IsNullOrEmpty(txtSide2.Text) = True) Then

            lblDisplay.Text = "PLease enter values"

        Else

            Try
                side1 = Convert.ToDouble(txtSide1.Text)
                side2 = Convert.ToDouble(txtSide2.Text)
                angle1_2 = Convert.ToDouble(txtAngle.Text)

                side3 = Math.Sqrt(-2 * side1 * side2 * Math.Cos(angle1_2 * Math.PI / 180) + side1 ^ 2 + side2 ^ 2)  'calculate front

                If Double.NaN <> side3 Then

                    angle2_3 = (Math.Asin(side1 * Math.Sin(angle1_2 * Math.PI / 180) / side3)) * 180 / Math.PI
                    angle3_1 = 180 - (angle2_3 + angle1_2)

                    displayString = "angles " + FormatNumber(angle1_2, 2) + " , " + FormatNumber(angle2_3, 2) + " , " + FormatNumber(angle3_1, 2) + ",,,, sides  " + FormatNumber(side1, 2) + " , " + FormatNumber(side2, 2) + " , " + FormatNumber(side3, 2)

                    lblDisplay.Text = displayString


                End If


            Catch ex As FormatException

                lblDisplay.Text = "Numerical inputs only"


            End Try

            If lblDisplay.Visible = False Then
                lblDisplay.Visible = True
            End If


        End If


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dispose()
    End Sub
End Class
