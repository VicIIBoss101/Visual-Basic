Public Class Form1

   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResult.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Double = Math.Max(Val(txtboxNum1.Text), Val(txtBoxNum2.Text))
        lblResult.Text = result
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Double = Math.Min(Val(txtboxNum1.Text), Val(txtBoxNum2.Text))
        lblResult.Text = result
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As Double = Val(txtboxNum1.Text) * Val(txtBoxNum2.Text)
        lblResult.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Double = (Val(txtboxNum1.Text) + Val(txtBoxNum2.Text)) / 2
        lblResult.Text = result
    End Sub
End Class
