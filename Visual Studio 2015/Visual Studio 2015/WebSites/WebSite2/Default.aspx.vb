
Partial Class _Default
    Inherits System.Web.UI.Page


    Dim sex As String
    Dim color As String
    Dim date1 As String


    Protected Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        sex = RadioButtonList1.Text
    End Sub

    Protected Sub Brown_CheckedChanged(sender As Object, e As EventArgs) Handles Brown.CheckedChanged
        color = color + ", " + Brown.Text
    End Sub
    Protected Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Black.CheckedChanged
        color = color + ", " + Black.Text
    End Sub
    Protected Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Green.CheckedChanged
        color = color + ", " + Green.Text
    End Sub
    Protected Sub Blue_CheckedChanged(sender As Object, e As EventArgs) Handles Blue.CheckedChanged
        color = color + ", " + Blue.Text
    End Sub
    Protected Sub Pink_CheckedChanged(sender As Object, e As EventArgs) Handles Pink.CheckedChanged
        color = color + ", " + Pink.Text
    End Sub
    Protected Sub Name_TextChanged(sender As Object, e As EventArgs) Handles Name.TextChanged

    End Sub

    Protected Sub DOB_SelectionChanged(sender As Object, e As EventArgs) Handles DOB.SelectionChanged
        date1 = DOB.SelectedDate.Date


    End Sub
    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles datetext.TextChanged
        datetext.Text = date1

    End Sub
    Protected Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        Try
            MsgBox("My name is " + Name.Text + ", my age is " + Age.Text + ", I am a " + sex + " born on " + datetext.Text + ". My Favourite colors are " + color.Substring(1, (color.Length - 1)))
        Catch ex As Exception

        End Try

        Response.Redirect(HttpContext.Current.Request.Url.ToString())
    End Sub




End Class
