Public Class Form1

    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisplay.Text = "0"
        lblResult.Text = ""
        txtFormula.Text = ""
    End Sub

    Dim num1 As Double
    Dim op As String
    '=================================
    Private Sub AddDig(n As String)
        
        txtFormula.Text &= n
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = n
        Else
            'If op <> "" Then
            '    txtDisplay.Text = ""
            '   txtDisplay.Text &= n
            'Else
                txtDisplay.Text &= n
            'End If
        End If
    End Sub
    '================================

    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        AddDig("0")
    End Sub

    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
     
        AddDig("1")
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
       
        AddDig("2")
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        AddDig("3")
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        AddDig("4")
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        AddDig("5")
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        AddDig("6")
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        AddDig("7")
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        AddDig("8")
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        AddDig("9")
    End Sub
    ' ================================
    Private Sub setOP(opName As String)
        If op <> "" Then
            Dim num2 As Double = CDbl(txtDisplay.Text)
            If op = "+" Then
                num1 = num1 + num2
            ElseIf op = "-" Then
                num1 = num1 - num2
            ElseIf op = "*" Then
                num1 = num1 * num2
            ElseIf op = "/" Then
                If num2 = 0 Then
                    MsgBox("Can't divid on zero!!")
                Else
                    num1 = num1 / num2
                End If
            ElseIf op = "^" Then
                num1 = num1 ^ num2
            ElseIf op = "MOD" Then
                num1 = num1 Mod num2
            End If
            txtDisplay.Text = num1
        Else
            num1 = CDbl(txtDisplay.Text)

        End If
        op = opName
        txtDisplay.Text = "0"
        txtFormula.Text &= " " & op

    End Sub
    ' ================================

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        setOP("+")
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        setOP("-")
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        setOP("*")
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        setOP("/")
    End Sub
    ' ================================
    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        setOP("^")
    End Sub

    Private Sub btnLShift_Click(sender As Object, e As EventArgs) Handles btnLShift.Click
        setOP("<<")
    End Sub

    Private Sub btnRShift_Click(sender As Object, e As EventArgs) Handles btnRShift.Click
        setOP(">>")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnABS.Click
        setOP("ABS")
    End Sub

    Private Sub btnSQRT_Click(sender As Object, e As EventArgs) Handles btnSQRT.Click
        setOP("SQRT")
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        setOP("MOD")
    End Sub

    Private Sub btnRound_Click(sender As Object, e As EventArgs) Handles btnRound.Click
        setOP("Round")
    End Sub
    ' ================================

    ' ================================

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim num2 As Double = CDbl(txtDisplay.Text)
        Dim result As Double = 0
        If op = "+" Then
            result = num1 + num2
        ElseIf op = "-" Then
            result = num1 - num2
        ElseIf op = "*" Then
            result = num1 * num2
        ElseIf op = "/" Then
            If num2 = 0 Then
                MsgBox("Can't divid on zero!!")
            Else
                num1 = num1 / num2
            End If
        ElseIf op = "^" Then
            result = num1 ^ num2
        ElseIf op = "<<" Then
            result = CInt(num1) << CInt(num2)
        ElseIf op = ">>" Then
            result = CInt(num1) >> CInt(num2)
        ElseIf op = "ABS" Then
            result = Math.Abs(num1)
        ElseIf op = "SQRT" Then
            result = Math.Sqrt(num1)
        ElseIf op = "Mod" Then
            result = num1 Mod num2
        ElseIf op = "Round" Then
            result = Math.Round(num1)
        End If

        lblResult.Text = result.ToString()
        txtDisplay.Text = "0"
        txtFormula.Text = ""
        num1 = result
        op = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
        num1 = 0
        op = ""
        lblResult.Text = ""
        txtFormula.Text = ""
    End Sub
End Class
