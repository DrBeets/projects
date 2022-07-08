' Piecework C. This program expands on the previous piecework assignments by developing a multiform project
' Written by Tristan Rogers


Public Class frmPiecework

    Friend TotPieces As Integer = 0
    Friend AvgPay As Decimal = 0.0
    Friend TotPay As Decimal = 0.0
    Friend TotWorkers As Integer = 0
    Dim confirm As DialogResult


    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        ' Opens the About form on Menu item click
        frmAbout.Show()
        frmAbout.BringToFront()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .Font = lblEarned.Font
            .ShowDialog()
            lblEarned.Font = .Font
        End With
    End Sub

    Private Sub SloganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SloganToolStripMenuItem.Click
        'Toggles the slogan when the menu item is clicked

        If SloganToolStripMenuItem.Checked = True Then
            lblSlogan.Visible = True
        Else
            lblSlogan.Visible = False
        End If

    End Sub

    Private Sub frmPiecework_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SloganToolStripMenuItem.Checked = True
        LogoToolStripMenuItem.Checked = True
        lblEarned.Text = ""
    End Sub

    Private Sub LogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoToolStripMenuItem.Click
        ' Toggles the logo when the menu item is clicked

        If LogoToolStripMenuItem.Checked = True Then
            picIcon.Visible = True
        Else
            picIcon.Visible = False
        End If
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        ' Calcualtes information when the button is clicked. 
        ' Displays errors when invalid information is entered.

        Dim Pieces As Integer
        Dim AmountEarned As Decimal

        ' First error case for blank name box
        If txtName.Text = "" Then
            MessageBox.Show("You must enter a name.")
            txtName.Focus()
        Else
            Try
                Pieces = Integer.Parse(txtPieces.Text)

                ' Error to catch negative numbers and zero values
                If Pieces <= 0 Then
                    MessageBox.Show("Invalid entry. Number must be greater than zero.")
                    txtPieces.Focus()
                Else
                    AmountEarned = Total(Pieces)
                    'Enable summary button
                    SummaryToolStripMenuItem.Enabled = True
                End If

                lblEarned.Text = AmountEarned.ToString("C")
                'Data values for the summary 
                TotPieces += Pieces
                TotPay += AmountEarned
                TotWorkers += 1
                AvgPay = TotPay / TotWorkers

            Catch ex As Exception
                MessageBox.Show("Invalid Entry. Please enter a numeric value.")
                With txtPieces
                    .Focus()
                    .Clear()
                End With
            End Try
        End If
    End Sub

    Private Function Total(ByVal Pieces As Integer) As Decimal
        Const rate1 As Decimal = 0.5
        Const rate2 As Decimal = 0.55
        Const rate3 As Decimal = 0.6
        Const rate4 As Decimal = 0.65

        ' If statement to calculate the piece rate
        If Pieces < 200 Then
            Return Pieces * rate1
        ElseIf Pieces < 400 Then
            Return Pieces * rate2
        ElseIf Pieces < 600 Then
            Return Pieces * rate3
        Else : Return Pieces * rate4
        End If
    End Function

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Computes the summary if there have been values entered.
        ' Opens the summary form.

        frmSummary.ShowDialog()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Resets the user input part of the form, and returns focus to the name input box
        txtName.Clear()
        txtPieces.Clear()
        lblEarned.ResetText()
        txtName.Focus()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        confirm = MessageBox.Show("Are you sure you would like to clear all data? ", "Clear All",
        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If confirm = DialogResult.Yes Then
            AvgPay = 0.0
            TotPay = 0.0
            TotPieces = 0
            TotWorkers = 0
            ClearToolStripMenuItem_Click(sender, e)
            SummaryToolStripMenuItem.Enabled = False
            txtName.Focus()

        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = lblEarned.ForeColor
            .ShowDialog()
            lblEarned.ForeColor = .Color
        End With
    End Sub
End Class
