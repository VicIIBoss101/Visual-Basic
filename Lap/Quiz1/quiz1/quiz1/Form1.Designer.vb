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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtboxNum1 = New System.Windows.Forms.TextBox()
        Me.txtBoxNum2 = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(186, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(279, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 54)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(382, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 54)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "*"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(480, 320)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 54)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "A"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtboxNum1
        '
        Me.txtboxNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxNum1.Location = New System.Drawing.Point(186, 98)
        Me.txtboxNum1.Name = "txtboxNum1"
        Me.txtboxNum1.Size = New System.Drawing.Size(130, 32)
        Me.txtboxNum1.TabIndex = 4
        '
        'txtBoxNum2
        '
        Me.txtBoxNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxNum2.Location = New System.Drawing.Point(480, 98)
        Me.txtBoxNum2.Name = "txtBoxNum2"
        Me.txtBoxNum2.Size = New System.Drawing.Size(130, 32)
        Me.txtBoxNum2.TabIndex = 5
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(377, 175)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(65, 26)
        Me.lblResult.TabIndex = 6
        Me.lblResult.Text = "result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 469)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtBoxNum2)
        Me.Controls.Add(Me.txtboxNum1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtboxNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxNum2 As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
