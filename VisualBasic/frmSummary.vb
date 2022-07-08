Public Class frmSummary
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAmountTotPieces.Text = frmPiecework.TotPieces.ToString()
        lblAmtAvgPay.Text = frmPiecework.AvgPay.ToString("C")
        lblAmtTotPay.Text = frmPiecework.TotPay.ToString("C")
        lblAmtTotWorkers.Text = frmPiecework.TotWorkers.ToString()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Close()
    End Sub
End Class