Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Button1 to Encode 
        TextBox2.Text = Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(TextBox1.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Button2 to Decode  
        TextBox2.Text = New System.Text.ASCIIEncoding().GetString(Convert.FromBase64String(TextBox1.Text))
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("instagram : @ilord4tb " & vbNewLine & "Github : @511j", MsgBoxStyle.OkOnly, "Encode Decode Base64")
    End Sub
End Class
