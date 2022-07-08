Public Class frmReservations
    Dim ResFile As String = "C:\VB2021\YachtsA\Resources\ReservationFile.txt"
    Dim strMessageBoxTitle As String = "Error"
    Private Sub frmReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader

        If IO.File.Exists(ResFile) Then
            objReader = IO.File.OpenText(ResFile)
            rtxtRes.Text = IO.File.ReadAllText(ResFile)
        Else
            MsgBox("The file does not exist.", strMessageBoxTitle)
        End If


    End Sub
End Class