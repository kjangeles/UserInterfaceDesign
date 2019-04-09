<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextMonthlySal = New System.Windows.Forms.TextBox()
        Me.TextMonthlyBills = New System.Windows.Forms.TextBox()
        Me.ComboMortgageRate = New System.Windows.Forms.ComboBox()
        Me.ListLoanType = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextDownPay = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(279, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(241, 47)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Mortgage Payment"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(14, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 47)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(672, 564)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 42)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Quit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(526, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "What Can I Afford?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(121, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 32)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Monthly Salary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(120, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total Monthly Bills"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(120, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 32)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Mortgage Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(120, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 32)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Down Payment"
        '
        'TextMonthlySal
        '
        Me.TextMonthlySal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMonthlySal.Location = New System.Drawing.Point(468, 119)
        Me.TextMonthlySal.Name = "TextMonthlySal"
        Me.TextMonthlySal.Size = New System.Drawing.Size(166, 35)
        Me.TextMonthlySal.TabIndex = 17
        '
        'TextMonthlyBills
        '
        Me.TextMonthlyBills.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMonthlyBills.Location = New System.Drawing.Point(467, 177)
        Me.TextMonthlyBills.Name = "TextMonthlyBills"
        Me.TextMonthlyBills.Size = New System.Drawing.Size(166, 35)
        Me.TextMonthlyBills.TabIndex = 18
        '
        'ComboMortgageRate
        '
        Me.ComboMortgageRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMortgageRate.FormattingEnabled = True
        Me.ComboMortgageRate.Items.AddRange(New Object() {"3.50%", "3.75%", "4.00%", "4.25%", "4.50%"})
        Me.ComboMortgageRate.Location = New System.Drawing.Point(468, 230)
        Me.ComboMortgageRate.Name = "ComboMortgageRate"
        Me.ComboMortgageRate.Size = New System.Drawing.Size(165, 37)
        Me.ComboMortgageRate.TabIndex = 19
        '
        'ListLoanType
        '
        Me.ListLoanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListLoanType.FormattingEnabled = True
        Me.ListLoanType.ItemHeight = 25
        Me.ListLoanType.Items.AddRange(New Object() {"30 years", "20 years", "15 years", "10 years"})
        Me.ListLoanType.Location = New System.Drawing.Point(468, 286)
        Me.ListLoanType.Name = "ListLoanType"
        Me.ListLoanType.Size = New System.Drawing.Size(165, 79)
        Me.ListLoanType.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(120, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 32)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Loan Type"
        '
        'TextDownPay
        '
        Me.TextDownPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDownPay.Location = New System.Drawing.Point(467, 386)
        Me.TextDownPay.Name = "TextDownPay"
        Me.TextDownPay.Size = New System.Drawing.Size(166, 35)
        Me.TextDownPay.TabIndex = 22
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(14, 564)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 42)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Calculate
        '
        Me.Calculate.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.ForeColor = System.Drawing.SystemColors.Control
        Me.Calculate.Location = New System.Drawing.Point(266, 442)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(241, 47)
        Me.Calculate.TabIndex = 25
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = False
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.BackColor = System.Drawing.Color.Teal
        Me.AnswerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.AnswerTextBox.Location = New System.Drawing.Point(222, 504)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(316, 44)
        Me.AnswerTextBox.TabIndex = 26
        Me.AnswerTextBox.Text = " What Can I Afford?"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextDownPay)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListLoanType)
        Me.Controls.Add(Me.ComboMortgageRate)
        Me.Controls.Add(Me.TextMonthlyBills)
        Me.Controls.Add(Me.TextMonthlySal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Name = "Form3"
        Me.Text = "Mortgage App/ What Can I Afford?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextMonthlySal As TextBox
    Friend WithEvents TextMonthlyBills As TextBox
    Friend WithEvents ComboMortgageRate As ComboBox
    Friend WithEvents ListLoanType As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextDownPay As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Calculate As Button
    Friend WithEvents AnswerTextBox As TextBox
End Class
