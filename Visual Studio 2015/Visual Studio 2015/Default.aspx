
Partial Class _Default
    Inherits Page
    Public Class Form1

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim Gender, date1, name, age, Color1, Color2, Color3, Color4, Color5 As String

            date1 = DateTimePicker1.Text
            name = TextBox1.Text
            age = ComboBox1.Text
            Color1 = CheckBox1.Text
            Color2 = CheckBox2.Text
            Color3 = CheckBox3.Text
            Color4 = CheckBox4.Text
            Color5 = CheckBox5.Text
            If RadioButton1.Checked Then
                Gender = RadioButton1.Text
            ElseIf RadioButton2.Checked Then
                Gender = RadioButton2.Text
            End If

            If CheckBox1.Checked Then
                Color1 = "Black"
            Else
                Color1 = ""

            End If
            If CheckBox2.Checked Then
                Color2 = "Brown"
            Else
                Color2 = ""
            End If

            If CheckBox3.Checked Then
                Color3 = "Pink"
            Else
                Color3 = ""
            End If
            If CheckBox4.Checked Then
                Color4 = "Blue"
            Else
                Color4 = ""
            End If

            If CheckBox5.Checked Then
                Color5 = "Red"
            Else
                Color5 = ""
            End If


            MsgBox("My name is " + name + " " + "I am " + age + "yrs old " + Gender + "" + ". I was born on " + date1 + " " + "My Favorite Colors are " + Color1 + "" + Color2 + "" + Color3 + "" + Color4 + "" + Color5 + "")
        End Sub

    End Class