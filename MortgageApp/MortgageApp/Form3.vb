Public Class Form3
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 100
        Me.Left = 100
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty

            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim MonthlySal As Double
        Dim MonthlyBills As Double
        Dim MortgageRate As Double
        Dim LoanType As Single
        Dim DownPay As Double
        Dim Ans As Single


        If IsNumeric(TextMonthlySal.Text) Then
            MonthlySal = Convert.ToDouble(TextMonthlySal.Text)
        Else
            MsgBox("invalid input, please re-enter another amount.")
            TextMonthlySal.Focus()
            TextMonthlySal.SelectAll()
        End If

        If IsNumeric(TextMonthlyBills.Text) Then
            MonthlyBills = Convert.ToDouble(TextMonthlyBills.Text)
        Else
            MsgBox("invalid input, please re-enter another amount.")
            TextMonthlyBills.Focus()
            TextMonthlyBills.SelectAll()
        End If

        If IsNumeric(TextDownPay.Text) Then
            DownPay = Convert.ToDouble(TextDownPay.Text)
        Else
            MsgBox("invalid input, please re-enter another amount.")
            TextDownPay.Focus()
            TextDownPay.SelectAll()
        End If

        If ComboMortgageRate.SelectedItem = "3.50%" Then
            MortgageRate = 0.035
        ElseIf ComboMortgageRate.SelectedItem = "3.75%" Then
            MortgageRate = 0.0375
        ElseIf ComboMortgageRate.SelectedItem = "4.00%" Then
            MortgageRate = 0.04
        ElseIf ComboMortgageRate.SelectedItem = "4.25%" Then
            MortgageRate = 0.0425
        ElseIf ComboMortgageRate.SelectedItem = "4.50%" Then
            MortgageRate = 0.045
        End If

        If ListLoanType.SelectedItem = "30 years" Then
            LoanType = 30 * 12
        ElseIf ListLoanType.SelectedItem = "20 years" Then
            LoanType = 20 * 12
        ElseIf ListLoanType.SelectedItem = "15 years" Then
            LoanType = 15 * 12
        ElseIf ListLoanType.SelectedItem = "10 years" Then
            LoanType = 10 * 12
        End If

        Dim NetSal, R, Num, Den, x, y As Double

        NetSal = MonthlySal - MonthlyBills
        R = NetSal * 0.29
        x = (R + 1) * (1 + MortgageRate) ^ LoanType
        Num = x
        y = (1 + MortgageRate) ^ LoanType
        Den = MortgageRate * y
        Ans = (Num / Den) + DownPay

        AnswerTextBox.Text = "$" + Ans.ToString

    End Sub
End Class