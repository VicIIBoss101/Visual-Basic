<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtboxSName = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbldgree1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxDgree1 = New System.Windows.Forms.TextBox()
        Me.txtboxDgree2 = New System.Windows.Forms.TextBox()
        Me.txtboxDgree3 = New System.Windows.Forms.TextBox()
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.txtboxInfo = New System.Windows.Forms.TextBox()
        Me.txtBoxSub1Name = New System.Windows.Forms.TextBox()
        Me.txtBoxSub2Name = New System.Windows.Forms.TextBox()
        Me.txtBoxSub3Name = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtboxSName
        '
        Me.txtboxSName.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSName.Location = New System.Drawing.Point(748, 144)
        Me.txtboxSName.Name = "txtboxSName"
        Me.txtboxSName.Size = New System.Drawing.Size(416, 36)
        Me.txtboxSName.TabIndex = 0
        Me.txtboxSName.Text = "ادخل معلومات"
        Me.txtboxSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblStudentName.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.White
        Me.lblStudentName.Location = New System.Drawing.Point(1201, 152)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Padding = New System.Windows.Forms.Padding(60, 0, 60, 0)
        Me.lblStudentName.Size = New System.Drawing.Size(212, 28)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.Text = "اسم الطالب"
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(300, 21)
        Me.Label2.MinimumSize = New System.Drawing.Size(55, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(300, 5, 300, 10)
        Me.Label2.Size = New System.Drawing.Size(773, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "نظام درجات الطلاب"
        '
        'lbldgree1
        '
        Me.lbldgree1.AutoSize = True
        Me.lbldgree1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbldgree1.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldgree1.ForeColor = System.Drawing.Color.White
        Me.lbldgree1.Location = New System.Drawing.Point(1201, 214)
        Me.lbldgree1.Name = "lbldgree1"
        Me.lbldgree1.Padding = New System.Windows.Forms.Padding(30, 0, 40, 0)
        Me.lbldgree1.Size = New System.Drawing.Size(214, 28)
        Me.lbldgree1.TabIndex = 3
        Me.lbldgree1.Text = "درجة المادة الاولى"
        Me.lbldgree1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1201, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(30, 0, 40, 0)
        Me.Label4.Size = New System.Drawing.Size(208, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "درجة المادة الثانية"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1197, 346)
        Me.Label5.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(30, 0, 40, 0)
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(208, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "درجة المادة الثالثة"
        '
        'txtboxDgree1
        '
        Me.txtboxDgree1.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxDgree1.Location = New System.Drawing.Point(748, 206)
        Me.txtboxDgree1.Name = "txtboxDgree1"
        Me.txtboxDgree1.Size = New System.Drawing.Size(201, 36)
        Me.txtboxDgree1.TabIndex = 6
        Me.txtboxDgree1.Text = "ادخل الدرجة"
        Me.txtboxDgree1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxDgree2
        '
        Me.txtboxDgree2.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxDgree2.Location = New System.Drawing.Point(748, 275)
        Me.txtboxDgree2.Name = "txtboxDgree2"
        Me.txtboxDgree2.Size = New System.Drawing.Size(201, 36)
        Me.txtboxDgree2.TabIndex = 7
        Me.txtboxDgree2.Text = "ادخل الدرجة"
        Me.txtboxDgree2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxDgree3
        '
        Me.txtboxDgree3.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxDgree3.Location = New System.Drawing.Point(748, 338)
        Me.txtboxDgree3.Name = "txtboxDgree3"
        Me.txtboxDgree3.Size = New System.Drawing.Size(201, 36)
        Me.txtboxDgree3.TabIndex = 8
        Me.txtboxDgree3.Text = "ادخل الدرجة"
        Me.txtboxDgree3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowInfo.Location = New System.Drawing.Point(855, 433)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(211, 51)
        Me.btnShowInfo.TabIndex = 9
        Me.btnShowInfo.Text = "اعرض المعلومات"
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'txtboxInfo
        '
        Me.txtboxInfo.Enabled = False
        Me.txtboxInfo.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxInfo.Location = New System.Drawing.Point(12, 142)
        Me.txtboxInfo.Multiline = True
        Me.txtboxInfo.Name = "txtboxInfo"
        Me.txtboxInfo.Size = New System.Drawing.Size(695, 448)
        Me.txtboxInfo.TabIndex = 11
        Me.txtboxInfo.Text = "النتيجة"
        Me.txtboxInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtboxInfo.Visible = False
        '
        'txtBoxSub1Name
        '
        Me.txtBoxSub1Name.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSub1Name.Location = New System.Drawing.Point(963, 206)
        Me.txtBoxSub1Name.Name = "txtBoxSub1Name"
        Me.txtBoxSub1Name.Size = New System.Drawing.Size(201, 36)
        Me.txtBoxSub1Name.TabIndex = 12
        Me.txtBoxSub1Name.Text = "ادخل اسم المادة"
        Me.txtBoxSub1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxSub2Name
        '
        Me.txtBoxSub2Name.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSub2Name.Location = New System.Drawing.Point(963, 275)
        Me.txtBoxSub2Name.Name = "txtBoxSub2Name"
        Me.txtBoxSub2Name.Size = New System.Drawing.Size(201, 36)
        Me.txtBoxSub2Name.TabIndex = 13
        Me.txtBoxSub2Name.Text = "ادخل اسم المادة"
        Me.txtBoxSub2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxSub3Name
        '
        Me.txtBoxSub3Name.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSub3Name.Location = New System.Drawing.Point(963, 343)
        Me.txtBoxSub3Name.Name = "txtBoxSub3Name"
        Me.txtBoxSub3Name.Size = New System.Drawing.Size(201, 36)
        Me.txtBoxSub3Name.TabIndex = 14
        Me.txtBoxSub3Name.Text = "ادخل اسم المادة"
        Me.txtBoxSub3Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1456, 631)
        Me.Controls.Add(Me.txtBoxSub3Name)
        Me.Controls.Add(Me.txtBoxSub2Name)
        Me.Controls.Add(Me.txtBoxSub1Name)
        Me.Controls.Add(Me.txtboxInfo)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Controls.Add(Me.txtboxDgree3)
        Me.Controls.Add(Me.txtboxDgree2)
        Me.Controls.Add(Me.txtboxDgree1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbldgree1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.txtboxSName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxSName As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbldgree1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtboxDgree1 As System.Windows.Forms.TextBox
    Friend WithEvents txtboxDgree2 As System.Windows.Forms.TextBox
    Friend WithEvents txtboxDgree3 As System.Windows.Forms.TextBox
    Friend WithEvents btnShowInfo As System.Windows.Forms.Button
    Friend WithEvents txtboxInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxSub1Name As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxSub2Name As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxSub3Name As System.Windows.Forms.TextBox

End Class
