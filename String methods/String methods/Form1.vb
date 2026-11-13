Public Class FrmSringMethod

    Private Sub FrmSringMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim userInput As String
    
    Private Sub txtBoxEnterdTxt_TextChanged(sender As Object, e As EventArgs) Handles txtBoxEnterdTxt.Click
        txtBoxEnterdTxt.Text = ""

    End Sub

    Private Sub btnSaveTxt_Click(sender As Object, e As EventArgs) Handles btnSaveTxt.Click
        If checkInput(txtBoxEnterdTxt.Text) Then
            userInput = txtBoxEnterdTxt.Text
            MsgBox("Text Saved!")
        End If
    End Sub

    Private Sub btnCheckTheLength_Click(sender As Object, e As EventArgs) Handles btnCheckTheLength.Click
        If checkInput(userInput) = True Then
            Dim ln As Integer = userInput.Length
            MsgBox("Then length of entered txt: " & ln.ToString, MsgBoxStyle.Information)
        End If
        
    End Sub

    Private Sub btnCheckEndWith_Click(sender As Object, e As EventArgs) Handles btnCheckEndWith.Click
        If checkInput(userInput) = True Then
            Dim checkEnd As String = InputBox("Enter text to search", "", "")
            If userInput.EndsWith(checkEnd) Then
                MsgBox("Your text end with: " & checkEnd, MsgBoxStyle.Information)
            Else
                MsgBox("Your text is not end with: " & checkEnd, MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnCheckIndexOf_Click(sender As Object, e As EventArgs) Handles btnCheckIndexOf.Click


        If checkInput(userInput) Then
            Dim inStr As String = InputBox("Enter the Index", "", "")
            If IsNumeric(inStr) Then
                Dim index As Integer = CInt(inStr)
                MsgBox("The index refer to " & userInput.IndexOf(index))
            ElseIf inStr = "" Then

            Else
                MsgBox("Enter Numbers Only", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
    Private Sub btnIsNullOrEmpty_Click(sender As Object, e As EventArgs) Handles btnIsNullOrEmpty.Click
        If checkInput(userInput) Then
            MsgBox("You Enterd: " & userInput)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If checkInput(userInput) Then
            Dim in_Str As String = InputBox("Enter Index", "", "")
            Dim index As Integer = checkNumber(in_Str)
            If index <> -1 Then
                MsgBox("The txt after remove: " & userInput.Remove(index))
            Else
                MsgBox("Wrong number entered", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Private Sub btnToLowerCase_Click(sender As Object, e As EventArgs) Handles btnToLowerCase.Click
        If checkInput(userInput) Then
            MsgBox("The txt in lowerCase: " & userInput.ToLower)
        End If
    End Sub
    Private Sub btnToUpperCase_Click(sender As Object, e As EventArgs) Handles btnToUpperCase.Click
        If checkInput(userInput) Then
            MsgBox("The txt in uppercase: " & userInput.ToUpper)
        End If
    End Sub

    '================== check function ===============================
    Private Function checkInput(input As String) As Boolean
        If String.IsNullOrEmpty(input) Then
            MsgBox("You haven't Entered any txt", MsgBoxStyle.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Function checkNumber(input As String) As Integer
        If IsNumeric(input) Then
            Return CInt(input)
        Else
            MsgBox("Enter numbers Only", MsgBoxStyle.Critical)
            Return -1
        End If
    End Function

    
   
End Class
