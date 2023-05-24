Imports Stripe

Public Class StripePaymentProcessor
    Private ReadOnly stripeApiKey As String = "sk_test_51KNBEbGa2z685qyKm9ieOvexY37LeNIPdu1SgeGmL0nB9RLwbgXH8kJRw1nWEY3MzSOA2aBBvRxILNsFFEFkM0jZ00IZNrPosl"

    Public Sub ProcessPayment(ByVal cardNumber As String, ByVal expiryMonth As Integer, ByVal expiryYear As Integer, ByVal amount As Decimal)
        ' Set your Stripe API key
        StripeConfiguration.ApiKey = stripeApiKey

        ' Create a payment method using the card details
        Dim paymentMethodOptions As New PaymentMethodCreateOptions
        paymentMethodOptions.Type = "card"
        paymentMethodOptions.Card = New PaymentMethodCardOptions With {
            .Number = cardNumber,
            .ExpMonth = expiryMonth,
            .ExpYear = expiryYear
        }

        Dim paymentMethodService As New PaymentMethodService
        Dim paymentMethod As PaymentMethod = paymentMethodService.Create(paymentMethodOptions)

        ' Create a payment intent
        Dim paymentIntentOptions As New PaymentIntentCreateOptions
        paymentIntentOptions.Amount = CInt(amount * 100) ' Amount in cents
        paymentIntentOptions.Currency = "myr" ' Currency code
        paymentIntentOptions.PaymentMethodTypes = New List(Of String) From {"card"}

        ' Attach the payment method to the payment intent
        paymentIntentOptions.PaymentMethod = paymentMethod.Id

        ' Create the payment intent
        Dim service As New PaymentIntentService
        Dim paymentIntent As PaymentIntent = service.Create(paymentIntentOptions)

        ' Check the status of the payment intent
        If paymentIntent.Status = "requires_confirmation" Then
            ' Confirm the payment intent
            Dim confirmOptions As New PaymentIntentConfirmOptions()
            confirmOptions.PaymentMethod = paymentIntent.PaymentMethodId
            Dim confirmedIntent As PaymentIntent = service.Confirm(paymentIntent.Id, confirmOptions)

            ' Check the status of the confirmed payment intent
            If confirmedIntent.Status = "succeeded" Then
                ' Payment successful
                MsgBox("Payment successful!")
            Else
                ' Payment failed
                MsgBox("Payment failed!")
            End If
        ElseIf paymentIntent.Status = "succeeded" Then
            ' Payment successful
            MsgBox("Payment successful!")
        Else
            ' Payment failed or in another state
            MsgBox("Payment failed!")
        End If
    End Sub
End Class
