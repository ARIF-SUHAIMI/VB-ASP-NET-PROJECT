Public Class frmPayment
    Public dblPrice As Double = 0.0

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmount.Text = "RM " & dblPrice.ToString()
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim processor As New StripePaymentProcessor()
        Dim cardnumber As String = txtCredit.Text ' replace with the actual card number
        Dim expirymonth As Integer = Integer.Parse(txtMonth.Text) ' replace with the actual expiry month
        Dim expiryyear As Integer = Integer.Parse(txtExpiry.Text) ' replace with the actual expiry year
        Dim amount As Double = dblPrice ' replace with the actual payment amount

        processor.ProcessPayment(cardnumber, expirymonth, expiryyear, amount)
        Me.Close()
    End Sub
End Class