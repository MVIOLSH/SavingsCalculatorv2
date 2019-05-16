Public Class Form1
    Private Sub BtnCalcWage_Click(sender As Object, e As EventArgs) Handles btnCalcWage.Click
        Dim NetIncome As Double
        Dim Tax As Double
        Dim NIC As Double
        Dim Var As Double
        Dim Type As String

        If txtwage.Text = String.Empty Then
            MessageBox.Show("I am sorry, but you forgot to provide your income! Please do so and press the button again.") 'Safety loop to check if there its different from null
        ElseIf IsNumeric(txtwage.Text) Then
            Var = Convert.ToDouble(txtwage.Text)
        Else
            MessageBox.Show("It have to be a number only value")
        End If

        Type = Convert.ToString(cmbType.Text)

        Select Case Type

            Case "Annual"
                If Var > 12500 Or Var = 12500 Then
                    Tax = (Var - 12500) * 0.2
                    NIC = (Var - 12500) * 0.1
                    txtTax.Text = FormatNumber(Tax, 2)
                    txtNIC.Text = FormatNumber(NIC, 2)
                    NetIncome = Var - Tax - NIC
                    txtNetIncome.Text = FormatNumber(NetIncome, 2)

                ElseIf Var < 12500 Then

                    NetIncome = Var
                    txtNetIncome.Text = FormatNumber(NetIncome, 2)

                End If

            Case "Monthly"

                If Var > (12500 / 12) Or Var = (12500 / 12) Then
                    Tax = (Var - (12500 / 12)) * 0.2
                    NIC = (Var - (12500 / 12)) * 0.1
                    txtTax.Text = FormatNumber(Tax, 2)
                    txtNIC.Text = FormatNumber(NIC, 2)
                    NetIncome = (Var - Tax - NIC)
                    txtNetIncome.Text = FormatNumber(NetIncome, 2)

                ElseIf Var < (12500 / 12) Then

                    NetIncome = Var
                    txtTax.Text = 0
                    txtNIC.Text = 0
                    txtNetIncome.Text = FormatNumber(NetIncome, 2)

                End If

            Case "Weekly"

                If Var > (12500 / 52) Or Var = (12500 / 52) Then
                    Tax = (Var - (12500 / 52)) * 0.2
                    NIC = (Var - (12500 / 52)) * 0.1
                    txtTax.Text = FormatNumber(Tax, 2)
                    txtNIC.Text = FormatNumber(NIC, 2)
                    NetIncome = (Var - Tax - NIC)
                    txtNetIncome.Text = FormatNumber(NetIncome, 2)

                ElseIf Var < (12500 / 52) Then

                    NetIncome = Var
                    txtTax.Text = 0
                    txtNIC.Text = 0
                    txtNetIncome.Text = FormatNumber(NetIncome, 2)

                End If
            Case Else
                MessageBox.Show("Please choose one of the options")

        End Select

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ExpName As String = 0
        Dim ExpAmount As Double = 0

        If txtAmount.Text = String.Empty Then
            MessageBox.Show("I am sorry, but you forgot to provide the amount Please do so and press the button again.") 'Safety loop to check if there its different from null
        ElseIf IsNumeric(txtAmount.Text) Then
            ExpAmount = Convert.ToDouble(txtAmount.Text)
        Else
            MessageBox.Show("It have to be a number only value")
        End If

        If txtExpenseName.Text = String.Empty Then
            MessageBox.Show("I am sorry, but you forgot to provide a type of your expense! Please do so and press the button again.") 'Safety loop to check if there its different from null
        ElseIf IsNumeric(txtExpenseName.Text) Then
            MessageBox.Show("The type of expense should not be numerical only! Please describe it using words and press the button again!")
        Else
            ExpName = Convert.ToString(txtExpenseName.Text)
        End If

        Dim RowIndex As Integer
        RowIndex = DtExpenses.Rows.Add()
        DtExpenses.Rows(RowIndex).Cells(0).Value = ExpName
        DtExpenses.Rows(RowIndex).Cells(1).Value = ExpAmount

        txtTotal.Text = (From row As DataGridViewRow In DtExpenses.Rows
                         Where row.Cells(1).FormattedValue.ToString() <> String.Empty
                         Select Convert.ToDouble(row.Cells(1).FormattedValue)).Sum().ToString()

    End Sub

    Private Sub DtExpenses_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtExpenses.CellContentClick
        Dim P As String = DtExpenses.Rows(e.RowIndex).Cells(1).Value
        Dim Percent As Double
        Dim Total As Double = Convert.ToDouble(txtTotal.Text)
        Percent = FormatNumber((P / Total) * 100, 2)
        DtExpenses.Rows(e.RowIndex).Cells(2).Value = Percent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Double = Convert.ToDouble(txtTotal.Text)
        Dim Savings As Double
        Dim Income As Double = Convert.ToDouble(txtNetIncome.Text)

        Savings = Income - total
        txtSavings.Text = Savings
    End Sub
End Class