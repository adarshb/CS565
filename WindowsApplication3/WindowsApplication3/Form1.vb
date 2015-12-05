Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, result As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        If RadioButton1.Checked = True Then
            result = num1 + num2
            MessageBox.Show("Sum is " & result)
        ElseIf RadioButton2.Checked = True Then
            result = num1 - num2
            MessageBox.Show("Difference  is " & result)
        ElseIf RadioButton3.Checked = True Then
            result = num1 * num2
            MessageBox.Show("Product is " & result)
        ElseIf RadioButton4.Checked = True Then
            result = num1 / num2
            MessageBox.Show("Result is " & result)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2, sumN, result2 As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        If Val(num1) < Val(num2) Then
            For a = (Val(num1) + 1) To (Val(num2) - 1)
                sumN = sumN + a
            Next a

        Else
            For a = (Val(num2) + 1) To (Val(num1) - 1)
                sumN = sumN + a
            Next a

        End If
        result2 = sumN
        MessageBox.Show("Result is " & result2)

    End Sub
End Class
