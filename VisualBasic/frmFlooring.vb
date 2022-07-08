' Program name: Flooring Cost Calculator Application
' Author:       Tristan Rogers
' Purpose:      This Windows application computes the estimated cost
'               of flooring based on the number of square feet and the
'               following cost per square foot: Tile - $4.49 per square foot;
'               Carpet - $4.99 per square foot; Hardwood - $7.49 per square foot.


Public Class frmFlooring
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The btnCalculate event handler calculates the estimated cost of 
        ' flooring based on the square footage and the flooring type.

        ' Declaration Section
        Dim decFootage As Decimal
        Dim decCostPerSquareFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decTileCost As Decimal = 4.49D
        Dim decCarpetCost As Decimal = 4.99D
        Dim decHardwoodCost As Decimal = 7.49D

        ' Did user enter a numeric value?
        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)

            ' Is Square Footage greater than zero
            If decFootage > 0 Then
                ' Determine cost per square foot
                If radTile.Checked Then
                    decCostPerSquareFoot = decTileCost
                ElseIf radCarpet.Checked Then
                    decCostPerSquareFoot = decCarpetCost
                ElseIf radHardwood.Checked Then
                    decCostPerSquareFoot = decHardwoodCost
                End If

                ' Calculate and display the cost estimate
                decCostEstimate = decFootage * decCostPerSquareFoot
                lblCostEstimate.Text = decCostEstimate.ToString("C")
            Else
                ' Display error message if the user entered a negative value
                MsgBox("You entered" & decFootage.ToString() & ". Enter a Positive Number", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter the Square Footage of Flooring", , "Input Error")
            txtFootage.Text = ""
            txtFootage.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user taps or clicks the Clear button. It
        ' clears the square Footage text box and the cost estimate label, resets the radio 
        ' buttons with Tile selected, and sets the focus to the square footage text box.

        txtFootage.Clear()
        lblCostEstimate.Text = ""
        radTile.Checked = True
        radCarpet.Checked = False
        radHardwood.Checked = False
        txtFootage.Focus()
    End Sub

    Private Sub frmFlooring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of
        ' the program. It sets the focus to the square footager text box and
        ' Clears the cost estimate label.

        txtFootage.Focus()
        lblCostEstimate.Text = ""
    End Sub
End Class
