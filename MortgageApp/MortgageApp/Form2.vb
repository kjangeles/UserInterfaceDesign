Public Class Form2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = 100
        Me.Left = 100

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim a, p, d, i, x, y As Double
        Dim t As Integer
        Dim R As Integer

        If IsNumeric(txtHousePrice.Text) Then
            p = Convert.ToDouble(txtHousePrice.Text)
        Else
            MsgBox("invalid input, please re-enter another amount.")
            txtHousePrice.Focus()
            txtHousePrice.SelectAll()
        End If

        If IsNumeric(txtDownPay.Text) Then
            d = Convert.ToDouble(txtDownPay.Text)
        Else
            MsgBox("invalid input, please re-enter another amount.")
            txtDownPay.Focus()
            txtDownPay.SelectAll()
        End If

        If ComboInterest.SelectedItem = "3.50%" Then
            i = 3.5
        ElseIf ComboInterest.SelectedItem = "3.75%" Then
            i = 3.75
        ElseIf ComboInterest.SelectedItem = "4.00%" Then
            i = 4.0
        ElseIf ComboInterest.SelectedItem = "4.25%" Then
            i = 4.25
        ElseIf ComboInterest.SelectedItem = "4.50%" Then
            i = 4.5
        End If

        If ListTerm.SelectedItem = "30 years" Then
            t = 30
        ElseIf ListTerm.SelectedItem = "20 years" Then
            t = 20
        ElseIf ListTerm.SelectedItem = "15 years" Then
            t = 15
        ElseIf ListTerm.SelectedItem = "10 years" Then
            t = 10
        End If

        a = p - d
        x = a * i * (1 + i) ^ t
        y = ((1 + i) ^ t) + 1
        R = (x / y) / (t * 12)

        AnswerTextBox.Text = " Your Monthly Payment is $" + R.ToString

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next
    End Sub


End Class