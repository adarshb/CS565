
Partial Class Default2
    Inherits System.Web.UI.Page


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Button1.Text = 1
        Result.Text = Result.Text + Button1.Text

    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Button2.Text = 2
        Result.Text = Result.Text + Button2.Text
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Button3.Text = 3
        Result.Text = Result.Text + Button3.Text
    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Button4.Text = 4
        Result.Text = Result.Text + Button4.Text

    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Button5.Text = 5
        Result.Text = Result.Text + Button5.Text
    End Sub
    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Button6.Text = 6
        Result.Text = Result.Text + Button6.Text
    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Button7.Text = 7
        Result.Text = Result.Text + Button7.Text
    End Sub
    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Button8.Text = 8
        Result.Text = Result.Text + Button8.Text
    End Sub
    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Button9.Text = 9
        Result.Text = Result.Text + Button9.Text
    End Sub
    Protected Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Button10.Text = "*"
        Result.Text = Result.Text + Button10.Text
    End Sub
    Protected Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Button11.Text = "/"
        Result.Text = Result.Text + Button11.Text
    End Sub
    Protected Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Button12.Text = "+"
        Result.Text = Result.Text + Button12.Text
    End Sub
    Protected Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Button13.Text = "-"
        Result.Text = Result.Text + Button13.Text
    End Sub
    Protected Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Button14.Text = ""

        Result.Text = Button14.Text
        Button14.Text = "Clear"
    End Sub
    Protected Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim SC As New MSScriptControl.ScriptControl
        'SET LANGUAGE TO VBSCRIPT
        SC.Language = "VBSCRIPT"
        Try
            Result.Text = Convert.ToDouble(SC.Eval(Result.Text))
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Result_TextChanged(sender As Object, e As EventArgs) Handles Result.TextChanged
        Dim SC As New MSScriptControl.ScriptControl
        'SET LANGUAGE TO VBSCRIPT
        SC.Language = "VBSCRIPT"
        Try
            Result.Text = Convert.ToDouble(SC.Eval(Result.Text))
        Catch ex As Exception
        End Try
    End Sub
End Class
