Public Class frmMainMenu

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim processor As New StripePaymentProcessor()
        Dim cardNumber As String = "4242424242424242" ' Replace with the actual card number
        Dim expiryMonth As Integer = 12 ' Replace with the actual expiry month
        Dim expiryYear As Integer = 2023 ' Replace with the actual expiry year
        Dim amount As Decimal = 100.0 ' Replace with the actual payment amount

        processor.ProcessPayment(cardNumber, expiryMonth, expiryYear, amount)

    End Sub
End Class