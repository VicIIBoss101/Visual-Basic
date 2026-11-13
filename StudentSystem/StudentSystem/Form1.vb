Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim sName As String
    Dim sub1Name As String
    Dim sub2Name As String
    Dim sub3Name As String

    Dim subject1 As Double
    Dim subject2 As Double
    Dim subject3 As Double
    Dim maxDegre As Double

    Dim avg As Double


    
    Private Sub txtboxSName_TextChanged(sender As Object, e As EventArgs) Handles txtboxSName.Click
        txtboxSName.Text = ""
    End Sub

    Private Sub txtboxDgree1_TextChanged(sender As Object, e As EventArgs) Handles txtboxDgree1.Click
        txtboxDgree1.Text = ""
    End Sub

    Private Sub txtboxDgree2_TextChanged(sender As Object, e As EventArgs) Handles txtboxDgree2.Click
        txtboxDgree2.Text = ""
    End Sub

    Private Sub txtboxDgree3_TextChanged(sender As Object, e As EventArgs) Handles txtboxDgree3.Click
        txtboxDgree3.Text = ""
    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        txtboxInfo.Show()
        txtboxInfo.Clear()
        sName = txtboxSName.Text
        sub1Name = txtBoxSub1Name.Text
        sub2Name = txtBoxSub2Name.Text
        sub3Name = txtBoxSub3Name.Text

        subject1 = Val(txtboxDgree1.Text)
        subject2 = Val(txtboxDgree2.Text)
        subject3 = Val(txtboxDgree3.Text)

        maxDegre = Math.Max(subject1, subject2)
        maxDegre = Math.Max(maxDegre, subject3)

        avg = (subject1 + subject2 + subject3) / 3

        txtboxInfo.Text &= vbCrLf & " الاسم: " + sName
        txtboxInfo.Text &= vbCrLf & " المعدل " + CStr(avg)
        txtboxInfo.Text &= vbCrLf & sub1Name + " : " + CStr(subject1)
        txtboxInfo.Text &= vbCrLf & sub2Name + " : " + CStr(subject2)
        txtboxInfo.Text &= vbCrLf & sub3Name + " : " + CStr(subject3)
        txtboxInfo.Text &= vbCrLf & "اعلى درجة" + " : " + CStr(maxDegre)

        If avg >= 90 Then
            txtboxInfo.Text &= vbCrLf & "التقدير : ممتاز"
        ElseIf avg >= 80 Then
            txtboxInfo.Text &= vbCrLf & "التقدير : جيد جدا"
        ElseIf avg >= 70 Then
            txtboxInfo.Text &= vbCrLf & "التقدير : جيد"
        ElseIf avg >= 60 Then
            txtboxInfo.Text &= vbCrLf & "التقدير : متوسط"
        ElseIf avg >= 50 Then
            txtboxInfo.Text &= vbCrLf & "التقدير : مقبول"
        Else
            txtboxInfo.Text &= vbCrLf & "التقدير : راسب"
        End If


    End Sub

    Private Sub txtBoxSub1Name_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSub1Name.Click
        txtBoxSub1Name.Text = ""
    End Sub

    Private Sub txtBoxSub2Name_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSub2Name.Click
        txtBoxSub2Name.Text = ""
    End Sub

    Private Sub txtBoxSub3Name_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSub3Name.Click
        txtBoxSub3Name.Text = ""
    End Sub
End Class
