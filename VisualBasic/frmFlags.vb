' This program will display a user chosen flag, along with its country name 
' Programmer:       Tristan Rogers
' Date:             02/02/2021
Public Class frmFlags
    Private Sub rbtnAlgeria_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAlgeria.CheckedChanged
        ' Displays the Algeria flag in the picture box when selected by user
        ' Sets the information label to show the current country

        picFlags.Image = My.Resources.Flag_Algeria
        lblInformation.Text = "Algeria"

    End Sub

    Private Sub rbtnCanada_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCanada.CheckedChanged
        ' Displays the Canada flag in the picture box when selected by user
        ' Sets the information label to show the current country

        picFlags.Image = My.Resources.canada_flag
        lblInformation.Text = "Canada"

    End Sub

    Private Sub rbtnJamaica_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnJamaica.CheckedChanged
        ' Displays the Jamaica flag in the picture box when selected by user
        ' Sets the information label to show the current country

        picFlags.Image = My.Resources.Jamaica
        lblInformation.Text = "Jamaica"

    End Sub

    Private Sub rbtnMexico_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMexico.CheckedChanged
        ' Displays the Mexico flag in the picture box when selected by user
        ' Sets the information label to show the current country

        picFlags.Image = My.Resources.mexico_flag
        lblInformation.Text = "Mexico"

    End Sub

    Private Sub rbtnPanama_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPanama.CheckedChanged
        ' Displays the Panama flag in the picture box when selected by user
        ' Sets the information label to show the current country

        picFlags.Image = My.Resources._1280px_Flag_of_Panama_svg
        lblInformation.Text = "Panama"

    End Sub

    Private Sub rbtnUSA_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnUSA.CheckedChanged
        ' Displays the United States flag in the picture box when selected by user
        ' Sets the information label to show the current country

        picFlags.Image = My.Resources.US_flag
        lblInformation.Text = "United States of America"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes and terminates the form

        Close()

    End Sub

    Private Sub chkTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkTitle.CheckedChanged
        ' Shows and hides the Title label based on whether the box is checked or not
        If (chkTitle.Checked = True) Then
            lblHeading.Show()
        Else
            lblHeading.Hide()
        End If
    End Sub

    Private Sub chkCountry_CheckedChanged(sender As Object, e As EventArgs) Handles chkCountry.CheckedChanged
        ' Shows and hides the Country Information label based on whether the box is checked or not
        If (chkCountry.Checked = True) Then
            lblInformation.Show()
        Else
            lblInformation.Hide()
        End If
    End Sub

    Private Sub chkProgrammer_CheckedChanged(sender As Object, e As EventArgs) Handles chkProgrammer.CheckedChanged
        ' Shows and hides the Programmer label based on whether the box is checked or not
        If (chkProgrammer.Checked = True) Then
            lblProgrammer.Show()
        Else
            lblProgrammer.Hide()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Resets all options to their default values.

        chkCountry.Checked = True
        chkProgrammer.Checked = True
        chkTitle.Checked = True
        rbtnAlgeria.Checked = False
        rbtnCanada.Checked = False
        rbtnJamaica.Checked = False
        rbtnMexico.Checked = False
        rbtnPanama.Checked = False
        rbtnUSA.Checked = False
        lblInformation.ResetText()
        picFlags.Image = Nothing
    End Sub
End Class
