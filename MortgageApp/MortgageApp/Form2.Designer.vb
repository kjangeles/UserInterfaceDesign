<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HousePrice = New System.Windows.Forms.Label()
        Me.DownPay = New System.Windows.Forms.Label()
        Me.Interest = New System.Windows.Forms.Label()
        Me.Term = New System.Windows.Forms.Label()
        Me.txtHousePrice = New System.Windows.Forms.TextBox()
        Me.txtDownPay = New System.Windows.Forms.TextBox()
        Me.ComboInterest = New System.Windows.Forms.ComboBox()
        Me.ListTerm = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(546, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(241, 47)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "What Can I Afford?"
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.Button4.Location = New System.Drawing.Point(671, 566)
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
        Me.Label1.Location = New System.Drawing.Point(270, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mortgage Payment"
        '
        'HousePrice
        '
        Me.HousePrice.AutoSize = True
        Me.HousePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HousePrice.ForeColor = System.Drawing.SystemColors.Control
        Me.HousePrice.Location = New System.Drawing.Point(141, 139)
        Me.HousePrice.Name = "HousePrice"
        Me.HousePrice.Size = New System.Drawing.Size(201, 37)
        Me.HousePrice.TabIndex = 12
        Me.HousePrice.Text = "House Price"
        '
        'DownPay
        '
        Me.DownPay.AutoSize = True
        Me.DownPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownPay.ForeColor = System.Drawing.SystemColors.Control
        Me.DownPay.Location = New System.Drawing.Point(141, 198)
        Me.DownPay.Name = "DownPay"
        Me.DownPay.Size = New System.Drawing.Size(245, 37)
        Me.DownPay.TabIndex = 13
        Me.DownPay.Text = "Down Payment"
        '
        'Interest
        '
        Me.Interest.AutoSize = True
        Me.Interest.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Interest.ForeColor = System.Drawing.SystemColors.Control
        Me.Interest.Location = New System.Drawing.Point(141, 252)
        Me.Interest.Name = "Interest"
        Me.Interest.Size = New System.Drawing.Size(210, 37)
        Me.Interest.TabIndex = 14
        Me.Interest.Text = "Interest Rate"
        '
        'Term
        '
        Me.Term.AutoSize = True
        Me.Term.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Term.ForeColor = System.Drawing.SystemColors.Control
        Me.Term.Location = New System.Drawing.Point(141, 307)
        Me.Term.Name = "Term"
        Me.Term.Size = New System.Drawing.Size(96, 37)
        Me.Term.TabIndex = 15
        Me.Term.Text = "Term"
        '
        'txtHousePrice
        '
        Me.txtHousePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHousePrice.Location = New System.Drawing.Point(479, 127)
        Me.txtHousePrice.Name = "txtHousePrice"
        Me.txtHousePrice.Size = New System.Drawing.Size(180, 39)
        Me.txtHousePrice.TabIndex = 16
        '
        'txtDownPay
        '
        Me.txtDownPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDownPay.Location = New System.Drawing.Point(480, 182)
        Me.txtDownPay.Name = "txtDownPay"
        Me.txtDownPay.Size = New System.Drawing.Size(180, 39)
        Me.txtDownPay.TabIndex = 17
        '
        'ComboInterest
        '
        Me.ComboInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboInterest.FormattingEnabled = True
        Me.ComboInterest.Items.AddRange(New Object() {"3.50%", "3.75%", "4.00%", "4.25%", "4.50%"})
        Me.ComboInterest.Location = New System.Drawing.Point(479, 243)
        Me.ComboInterest.Name = "ComboInterest"
        Me.ComboInterest.Size = New System.Drawing.Size(180, 40)
        Me.ComboInterest.TabIndex = 18
        '
        'ListTerm
        '
        Me.ListTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListTerm.FormattingEnabled = True
        Me.ListTerm.ItemHeight = 29
        Me.ListTerm.Items.AddRange(New Object() {"30 years", "20 years", "15 years", "10 years"})
        Me.ListTerm.Location = New System.Drawing.Point(479, 307)
        Me.ListTerm.Name = "ListTerm"
        Me.ListTerm.Size = New System.Drawing.Size(179, 91)
        Me.ListTerm.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(14, 566)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 42)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Calculate
        '
        Me.Calculate.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.ForeColor = System.Drawing.SystemColors.Control
        Me.Calculate.Location = New System.Drawing.Point(309, 416)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(147, 67)
        Me.Calculate.TabIndex = 20
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(328, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 32)
        Me.Label6.TabIndex = 22
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.BackColor = System.Drawing.Color.DarkCyan
        Me.AnswerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.AnswerTextBox.Location = New System.Drawing.Point(127, 499)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(533, 39)
        Me.AnswerTextBox.TabIndex = 24
        Me.AnswerTextBox.Text = "How much is your monthly payment?"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(803, 620)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListTerm)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.ComboInterest)
        Me.Controls.Add(Me.txtDownPay)
        Me.Controls.Add(Me.txtHousePrice)
        Me.Controls.Add(Me.Term)
        Me.Controls.Add(Me.Interest)
        Me.Controls.Add(Me.DownPay)
        Me.Controls.Add(Me.HousePrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Name = "Form2"
        Me.Text = "Mortgage App/Mortage Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents HousePrice As Label
    Friend WithEvents DownPay As Label
    Friend WithEvents Interest As Label
    Friend WithEvents Term As Label
    Friend WithEvents txtHousePrice As TextBox
    Friend WithEvents txtDownPay As TextBox
    Friend WithEvents ComboInterest As ComboBox
    Friend WithEvents ListTerm As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Calculate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents AnswerTextBox As TextBox
End Class
