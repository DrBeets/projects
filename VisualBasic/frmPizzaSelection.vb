' Program Name: Pizza Selection
' Developer:    Tristan Rogers
' Date:         02/03/2021
' Purpose:      This program allows you to choose and select a pizza type, accompanied by a picture of each.
Public Class frmPizzaSelection
    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        ' This code shows the deep dish picture when the user clicks deep dish button
        ' Hides the thin crust picture, and enables the select button

        picDeepDish.Visible = True
        picThinCrust.Visible = False
        btnSelectPizza.Enabled = True

    End Sub

    Private Sub btnSelectPizza_Click(sender As Object, e As EventArgs) Handles btnSelectPizza.Click
        ' This code selects the currently selected pizza, and disables both the deep dish and thin crust buttons.
        ' Hides the instructions label, shows the confirmation label, and enables the exit button.

        btnDeepDish.Enabled = False
        btnThinCrust.Enabled = False
        btnSelectPizza.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True

    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        ' This code shows the Thin crust picture when the user clicks thin crustbutton
        ' Hides the deep dish picture, and enables the select button

        picDeepDish.Visible = False
        picThinCrust.Visible = True
        btnSelectPizza.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This button provides a clean exit on clicking the exit button.
        ' Closes the window and terminates the program.
        Close()
    End Sub
End Class
