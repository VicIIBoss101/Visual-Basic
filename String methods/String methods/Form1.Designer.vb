<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSringMethod
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCheckTheLength = New System.Windows.Forms.Button()
        Me.btnCheckEndWith = New System.Windows.Forms.Button()
        Me.btnCheckEqualTo = New System.Windows.Forms.Button()
        Me.btnCheckIndexOf = New System.Windows.Forms.Button()
        Me.btnInsertFunction = New System.Windows.Forms.Button()
        Me.btnIsNullOrEmpty = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnSpilt = New System.Windows.Forms.Button()
        Me.btnStartWith = New System.Windows.Forms.Button()
        Me.btnToLowerCase = New System.Windows.Forms.Button()
        Me.btnToUpperCase = New System.Windows.Forms.Button()
        Me.btnTrim = New System.Windows.Forms.Button()
        Me.btnElementAt = New System.Windows.Forms.Button()
        Me.txtBoxEnterdTxt = New System.Windows.Forms.TextBox()
        Me.btnSaveTxt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(455, 27)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(405, 39)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "String Function All In One"
        '
        'btnCheckTheLength
        '
        Me.btnCheckTheLength.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCheckTheLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckTheLength.Location = New System.Drawing.Point(518, 398)
        Me.btnCheckTheLength.Name = "btnCheckTheLength"
        Me.btnCheckTheLength.Size = New System.Drawing.Size(250, 79)
        Me.btnCheckTheLength.TabIndex = 2
        Me.btnCheckTheLength.Text = "Check the length"
        Me.btnCheckTheLength.UseVisualStyleBackColor = False
        '
        'btnCheckEndWith
        '
        Me.btnCheckEndWith.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCheckEndWith.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckEndWith.Location = New System.Drawing.Point(518, 483)
        Me.btnCheckEndWith.Name = "btnCheckEndWith"
        Me.btnCheckEndWith.Size = New System.Drawing.Size(250, 79)
        Me.btnCheckEndWith.TabIndex = 3
        Me.btnCheckEndWith.Text = "Check End with"
        Me.btnCheckEndWith.UseVisualStyleBackColor = False
        '
        'btnCheckEqualTo
        '
        Me.btnCheckEqualTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckEqualTo.Location = New System.Drawing.Point(6, 483)
        Me.btnCheckEqualTo.Name = "btnCheckEqualTo"
        Me.btnCheckEqualTo.Size = New System.Drawing.Size(506, 79)
        Me.btnCheckEqualTo.TabIndex = 4
        Me.btnCheckEqualTo.Text = "Check Equal to"
        Me.btnCheckEqualTo.UseVisualStyleBackColor = True
        '
        'btnCheckIndexOf
        '
        Me.btnCheckIndexOf.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCheckIndexOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIndexOf.Location = New System.Drawing.Point(518, 568)
        Me.btnCheckIndexOf.Name = "btnCheckIndexOf"
        Me.btnCheckIndexOf.Size = New System.Drawing.Size(250, 79)
        Me.btnCheckIndexOf.TabIndex = 5
        Me.btnCheckIndexOf.Text = "Check Index of"
        Me.btnCheckIndexOf.UseVisualStyleBackColor = False
        '
        'btnInsertFunction
        '
        Me.btnInsertFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertFunction.Location = New System.Drawing.Point(262, 398)
        Me.btnInsertFunction.Name = "btnInsertFunction"
        Me.btnInsertFunction.Size = New System.Drawing.Size(250, 79)
        Me.btnInsertFunction.TabIndex = 6
        Me.btnInsertFunction.Text = "Insert Function"
        Me.btnInsertFunction.UseVisualStyleBackColor = True
        '
        'btnIsNullOrEmpty
        '
        Me.btnIsNullOrEmpty.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIsNullOrEmpty.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIsNullOrEmpty.Location = New System.Drawing.Point(1036, 568)
        Me.btnIsNullOrEmpty.Name = "btnIsNullOrEmpty"
        Me.btnIsNullOrEmpty.Size = New System.Drawing.Size(250, 79)
        Me.btnIsNullOrEmpty.TabIndex = 7
        Me.btnIsNullOrEmpty.Text = "Is Null Or Empty"
        Me.btnIsNullOrEmpty.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(1036, 398)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(250, 79)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnReplace
        '
        Me.btnReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplace.Location = New System.Drawing.Point(1036, 483)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(250, 79)
        Me.btnReplace.TabIndex = 9
        Me.btnReplace.Text = "Repalce"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnSpilt
        '
        Me.btnSpilt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpilt.Location = New System.Drawing.Point(780, 398)
        Me.btnSpilt.Name = "btnSpilt"
        Me.btnSpilt.Size = New System.Drawing.Size(250, 79)
        Me.btnSpilt.TabIndex = 10
        Me.btnSpilt.Text = "Spilt"
        Me.btnSpilt.UseVisualStyleBackColor = True
        '
        'btnStartWith
        '
        Me.btnStartWith.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartWith.Location = New System.Drawing.Point(6, 568)
        Me.btnStartWith.Name = "btnStartWith"
        Me.btnStartWith.Size = New System.Drawing.Size(250, 79)
        Me.btnStartWith.TabIndex = 11
        Me.btnStartWith.Text = "Start With"
        Me.btnStartWith.UseVisualStyleBackColor = True
        '
        'btnToLowerCase
        '
        Me.btnToLowerCase.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnToLowerCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToLowerCase.Location = New System.Drawing.Point(780, 483)
        Me.btnToLowerCase.Name = "btnToLowerCase"
        Me.btnToLowerCase.Size = New System.Drawing.Size(250, 79)
        Me.btnToLowerCase.TabIndex = 12
        Me.btnToLowerCase.Text = "To lowercase"
        Me.btnToLowerCase.UseVisualStyleBackColor = False
        '
        'btnToUpperCase
        '
        Me.btnToUpperCase.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnToUpperCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToUpperCase.Location = New System.Drawing.Point(780, 568)
        Me.btnToUpperCase.Name = "btnToUpperCase"
        Me.btnToUpperCase.Size = New System.Drawing.Size(250, 79)
        Me.btnToUpperCase.TabIndex = 13
        Me.btnToUpperCase.Text = "To Uppercase"
        Me.btnToUpperCase.UseVisualStyleBackColor = False
        '
        'btnTrim
        '
        Me.btnTrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrim.Location = New System.Drawing.Point(262, 568)
        Me.btnTrim.Name = "btnTrim"
        Me.btnTrim.Size = New System.Drawing.Size(250, 79)
        Me.btnTrim.TabIndex = 14
        Me.btnTrim.Text = "Trim"
        Me.btnTrim.UseVisualStyleBackColor = True
        '
        'btnElementAt
        '
        Me.btnElementAt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElementAt.Location = New System.Drawing.Point(6, 398)
        Me.btnElementAt.Name = "btnElementAt"
        Me.btnElementAt.Size = New System.Drawing.Size(250, 79)
        Me.btnElementAt.TabIndex = 15
        Me.btnElementAt.Text = "Element At"
        Me.btnElementAt.UseVisualStyleBackColor = True
        '
        'txtBoxEnterdTxt
        '
        Me.txtBoxEnterdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxEnterdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxEnterdTxt.Location = New System.Drawing.Point(397, 101)
        Me.txtBoxEnterdTxt.Name = "txtBoxEnterdTxt"
        Me.txtBoxEnterdTxt.Size = New System.Drawing.Size(519, 31)
        Me.txtBoxEnterdTxt.TabIndex = 17
        Me.txtBoxEnterdTxt.Text = "Enter text"
        Me.txtBoxEnterdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSaveTxt
        '
        Me.btnSaveTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTxt.Location = New System.Drawing.Point(569, 138)
        Me.btnSaveTxt.Name = "btnSaveTxt"
        Me.btnSaveTxt.Size = New System.Drawing.Size(154, 31)
        Me.btnSaveTxt.TabIndex = 18
        Me.btnSaveTxt.Text = "save "
        Me.btnSaveTxt.UseVisualStyleBackColor = True
        '
        'FrmSringMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 659)
        Me.Controls.Add(Me.btnSaveTxt)
        Me.Controls.Add(Me.txtBoxEnterdTxt)
        Me.Controls.Add(Me.btnElementAt)
        Me.Controls.Add(Me.btnTrim)
        Me.Controls.Add(Me.btnToUpperCase)
        Me.Controls.Add(Me.btnToLowerCase)
        Me.Controls.Add(Me.btnStartWith)
        Me.Controls.Add(Me.btnSpilt)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnIsNullOrEmpty)
        Me.Controls.Add(Me.btnInsertFunction)
        Me.Controls.Add(Me.btnCheckIndexOf)
        Me.Controls.Add(Me.btnCheckEqualTo)
        Me.Controls.Add(Me.btnCheckEndWith)
        Me.Controls.Add(Me.btnCheckTheLength)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "FrmSringMethod"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCheckTheLength As System.Windows.Forms.Button
    Friend WithEvents btnCheckEndWith As System.Windows.Forms.Button
    Friend WithEvents btnCheckEqualTo As System.Windows.Forms.Button
    Friend WithEvents btnCheckIndexOf As System.Windows.Forms.Button
    Friend WithEvents btnInsertFunction As System.Windows.Forms.Button
    Friend WithEvents btnIsNullOrEmpty As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnSpilt As System.Windows.Forms.Button
    Friend WithEvents btnStartWith As System.Windows.Forms.Button
    Friend WithEvents btnToLowerCase As System.Windows.Forms.Button
    Friend WithEvents btnToUpperCase As System.Windows.Forms.Button
    Friend WithEvents btnTrim As System.Windows.Forms.Button
    Friend WithEvents btnElementAt As System.Windows.Forms.Button
    Friend WithEvents txtBoxEnterdTxt As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveTxt As System.Windows.Forms.Button

End Class
