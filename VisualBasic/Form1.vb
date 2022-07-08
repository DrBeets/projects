' This program will calculate the average price of usage in a recording studio
' It will prompt the user for the group name and the number of miinutes used
' It will then calculate the price based on set prices, and display to the user.
' Written by Tristan Rogers 2021


Public Class FrmRecordingStudio



    ' Declaring variables and constants
    Private TotalGroupsInteger As Integer = 0
    Private TotalChargesDecimal As Decimal = 0
    Const HOURLY_RATE_Decimal As Decimal = 200
    Const TOTAL_HOURS As Integer = 60
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Define the variables used to calculate the charges
        Dim RentalChargeDecimal, RentalRatePerMinDecimal, AverageChargeDecimal As Decimal
        Dim MinUsedInteger As Integer

        ' This line calculates the per minute charge
        RentalRatePerMinDecimal = HOURLY_RATE_Decimal / TOTAL_HOURS

        'Checks for empty group name 
        If textBoxName.Text IsNot "" Then

            'Checks for empty session time
            If textBoxSession.Text IsNot "" Then


                Try
                    If textBoxSession.Text < 5 Then
                        MessageBox.Show("Time must be whole number greater than Five.", "Data Entry Error1",
                                  MessageBoxButtons.OK, MessageBoxIcon.Stop)

                        'Send focus back to session time box 
                        With textBoxSession
                            .Focus()
                            .SelectAll()
                        End With
                    Else
                        'Convert time input into numeric value for calculation
                        MinUsedInteger = Integer.Parse(textBoxSession.Text)
                        TotalGroupsInteger += 1
                        RentalChargeDecimal = MinUsedInteger * RentalRatePerMinDecimal
                        TotalChargesDecimal += RentalChargeDecimal
                        AverageChargeDecimal = TotalChargesDecimal / TotalGroupsInteger

                        'Display values
                        textBoxRental.Text = RentalChargeDecimal.ToString("C")
                        textBoxTotalCharge.Text = TotalChargesDecimal.ToString("C")
                        textBoxNumofGroups.Text = TotalGroupsInteger.ToString("N0")
                        textBoxAvgCharge.Text = AverageChargeDecimal.ToString("C")
                    End If

                Catch ex As Exception
                    'Handle time entry exception
                    MessageBox.Show("Time must be numeric whole number.", "Data Entry Error2",
                             MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    'Send focus back to minutes entry for correct data. 
                    With textBoxSession
                        .Focus()
                        .SelectAll()
                    End With
                End Try
            Else
                MessageBox.Show("Time input cannot be Empty", "Data Entry Error4",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop)
                With textBoxSession
                    .Focus()
                    .SelectAll()
                End With
            End If
        Else
            MessageBox.Show("Must enter GROUP name.", "Data Entry Error3",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop)
            'Send focus back to minutes entry for correct data. 
            With textBoxName
                .Focus()
                .SelectAll()
            End With
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clears the input and rental charges
        textBoxSession.Clear()
        textBoxRental.Clear()
        With textBoxName
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        ' Clears all of the text boxes on the form
        textBoxAvgCharge.Clear()
        textBoxNumofGroups.Clear()
        textBoxTotalCharge.Clear()
        btnReset_Click(sender, e)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class