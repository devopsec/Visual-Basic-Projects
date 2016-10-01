Public Class Form1
    'Declare constant rates & class fields
    Const SAVINGS_RATE As Double = 0.0006
    Const STOCK_RATE As Double = 0.0075
    Dim total As Double = 0.00
    Dim savingsInterest As Double = 0.00
    Dim stockInterest As Double = 0.00

    'Main method for savings
    Private Sub SavingsMain()

        'try parsing Savings inputs
        Try
            Dim savingsYears As Integer = CInt(tbxSavingsYears.Text)
            Dim savingsInvestment As Double = CDbl(tbxSavingsInvestment.Text)

            'conditionally run calculations
            If savingsYears > 100 Or savingsYears <= 0 Then
                MessageBox.Show("Error SAVINGS inputs are not valid")
            ElseIf savingsInvestment <= 0.00 Or savingsInvestment > 1.79E+100 Then
                MessageBox.Show("Error SAVINGS inputs are not valid")
            Else
                If cbxSavingsInterest.Checked = False Then
                    lblPayPeriod.Text = "YEAR"
                    lblDataOutput.Text = "BALANCE"
                    'loop to compund investment earnings yearly
                    For index0 As Integer = 1 To savingsYears
                        total = (savingsInvestment * SAVINGS_RATE) + savingsInvestment
                        savingsInvestment = total
                        lbxDataOutput.Items.Add(Format(total.ToString, "Currency"))
                        lbxPayPeriod.Items.Add(index0)
                    Next
                Else
                    lblPayPeriod.Text = "YEAR"
                    lblDataOutput.Text = "INTEREST"
                    'loop to compound interest yearly
                    For index1 As Integer = 1 To savingsYears
                        savingsInterest = (savingsInvestment * SAVINGS_RATE)
                        savingsInvestment = savingsInterest + savingsInvestment
                        total += savingsInterest
                        lbxDataOutput.Items.Add(Format(savingsInterest.ToString, "Currency"))
                        lbxPayPeriod.Items.Add(index1)
                    Next
                End If
            End If

        Catch
            MessageBox.Show("Error SAVINGS inputs are not valid")
        End Try

    End Sub

    'Main method for stock
    Private Sub StockMain()

        'try parsing Stock inputs
        Try
            Dim stockYears As Integer = CInt(tbxStockYears.Text)
            Dim stockInvestment As Double = CDbl(tbxStockInvestment.Text)
            Dim stockCounter As Integer = 1

            'conditionally run calculations
            If stockYears > 100 Or stockYears <= 0 Then
                MessageBox.Show("Error STOCK inputs are not valid")
            ElseIf stockInvestment <= 0.00 Or stockInvestment > 1.79E+100 Then
                MessageBox.Show("Error STOCK inputs are not valid")
            Else
                If cbxStockInterest.Checked = False Then
                    lblPayPeriod.Text = "QUARTER"
                    lblDataOutput.Text = "BALANCE"
                    'loop to compund investment quarterly
                    For index0 As Single = 0.25F To stockYears Step 0.25F
                        total = (stockInvestment * STOCK_RATE) + stockInvestment
                        stockInvestment = total
                        lbxDataOutput.Items.Add(Format(total.ToString, "Currency"))
                        lbxPayPeriod.Items.Add(stockCounter)
                        stockCounter += 1
                    Next
                Else
                    lblPayPeriod.Text = "QUARTER"
                    lblDataOutput.Text = "INTEREST"
                    'loop to compound interest quarterly
                    For index1 As Single = 0.25F To stockYears Step 0.25F
                        stockInterest = (stockInvestment * STOCK_RATE)
                        stockInvestment = stockInterest + stockInvestment
                        total += stockInterest
                        lbxDataOutput.Items.Add(Format(stockInterest.ToString, "Currency"))
                        lbxPayPeriod.Items.Add(stockCounter)
                        stockCounter += 1
                    Next
                End If
            End If
        Catch
            MessageBox.Show("Error STOCK inputs are not valid")
        End Try

    End Sub

    Private Sub btnSavingsCalculate_Click(sender As Object, e As EventArgs) Handles btnSavingsCalculate.Click
        'clear listboxes and set scrollbar
        lbxDataOutput.Items.Clear()
        lbxPayPeriod.Items.Clear()

        'run main method
        SavingsMain()

        'show calculated value if no errors
        If total <> 0.00 Then
            lblTotal.Visible = True
            If cbxSavingsInterest.Checked = False Then
                lblTotal.Text = Format(total.ToString, "Currency")
            Else
                lblTotal.Text = Format(total.ToString, "Currency")
            End If
        End If

        'reset savingsInterest & total 
        savingsInterest = 0.00
        total = 0.00

        'set scrollbar range
        vsbScrollData.Maximum = lbxPayPeriod.Items.Count + 2
    End Sub

    Private Sub btnStockCalculate_Click(sender As Object, e As EventArgs) Handles btnStockCalculate.Click
        'clear listboxes and set scrollbar
        lbxDataOutput.Items.Clear()
        lbxPayPeriod.Items.Clear()

        'run main method
        StockMain()

        'show calculated value if no errors
        If total <> 0.00 Then
            lblTotal.Visible = True
            If cbxStockInterest.Checked = False Then
                lblTotal.Text = Format(total.ToString, "Currency")
            Else
                lblTotal.Text = Format(total.ToString, "Currency")
            End If
        End If

        'reset stockInterest & total
        stockInterest = 0.00
        total = 0.00

        'set scrollbar range
        vsbScrollData.Maximum = lbxPayPeriod.Items.Count + 2

    End Sub

    Private Sub tbxSavingsInvestment_TextChanged(sender As Object, e As EventArgs) Handles tbxSavingsInvestment.MouseClick

        'clear text when user clicks in text box
        tbxSavingsInvestment.Clear()

    End Sub

    Private Sub tbxSavingsYears_TextChanged(sender As Object, e As EventArgs) Handles tbxSavingsYears.MouseClick

        'clear text when user clicks in text box
        tbxSavingsYears.Clear()

    End Sub

    Private Sub tbxStockInvestment_TextChanged(sender As Object, e As EventArgs) Handles tbxStockInvestment.MouseClick

        'clear text when user clicks in text box
        tbxStockInvestment.Clear()

    End Sub

    Private Sub tbxStockYears_TextChanged(sender As Object, e As EventArgs) Handles tbxStockYears.MouseClick

        'clear text when user clicks in text box
        tbxStockYears.Clear()

    End Sub

    'sync both list boxes to scrollbar
    Private Sub vsbScrollData_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbScrollData.Scroll

        If lbxPayPeriod.Items.Count > 0 And lbxDataOutput.Items.Count > 0 Then
            lbxDataOutput.SelectedIndex = vsbScrollData.Value
            lbxPayPeriod.SelectedIndex = vsbScrollData.Value
        End If

    End Sub

    'sync selected index for both listboxes
    Private Sub lbxDataOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxDataOutput.SelectedIndexChanged
        lbxPayPeriod.SelectedIndex = lbxDataOutput.SelectedIndex
    End Sub
    Private Sub lbxPayPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPayPeriod.SelectedIndexChanged
        lbxDataOutput.SelectedIndex = lbxPayPeriod.SelectedIndex
    End Sub

End Class
