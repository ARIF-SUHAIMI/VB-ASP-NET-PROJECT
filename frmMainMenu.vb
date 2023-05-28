Public Class frmMainMenu

    Dim blnLooad As Boolean = False

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim processor As New StripePaymentProcessor()
        'Dim cardNumber As String = "4242 4242 4242 4242" ' Replace with the actual card number
        'Dim expiryMonth As Integer = 12 ' Replace with the actual expiry month
        'Dim expiryYear As Integer = 2023 ' Replace with the actual expiry year
        'Dim amount As Decimal = 100.0 ' Replace with the actual payment amount

        'processor.ProcessPayment(cardNumber, expiryMonth, expiryYear, amount)

        'MsgBox(EncodeHtml("<script>alert('XSS!');</script>"))

        setDataSourcce()
    End Sub

    Private Sub setDataSourcce()
        blnLooad = False
        Dim dtData As New DataTable()
        dtData.Columns.Add("ID", GetType(Integer))
        dtData.Columns.Add("pizzaName", GetType(String))
        dtData.Columns.Add("price", GetType(Double))

        dtData.Rows.Add(1, "Margherita", 12.7)
        dtData.Rows.Add(1, "Pepperoni Deluxe", 13)
        dtData.Rows.Add(1, "Veggie Supreme", 24)
        dtData.Rows.Add(1, "BBQ Chicken", 7)
        dtData.Rows.Add(1, "Hawaiian Paradise", 8)
        dtData.Rows.Add(1, "Four Cheese Delight", 27)
        dtData.Rows.Add(1, "Meat Lover's", 16)
        dtData.Rows.Add(1, "Mediterranean Delight", 18)
        dtData.Rows.Add(1, "Spicy Sausage", 29)
        dtData.Rows.Add(1, "Buffalo Chicken", 10)

        cbPizza.DataSource = dtData
        cbPizza.DisplayMember = "pizzaName"
        cbPizza.ValueMember = "price"
        nudQuantity.Value = 0
        blnLooad = True
    End Sub

    Private Sub cbPizza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPizza.SelectedIndexChanged, nudQuantity.ValueChanged, cbSize.SelectedIndexChanged

        If Not blnLooad Then
            Exit Sub
        End If

        Dim dblPrice As Double
        Dim dblSizePrice As Double
        Dim dblPizza As Double = cbPizza.SelectedValue

        If cbSize.SelectedIndex = 0 Then
            dblSizePrice = 2.0
        ElseIf cbSize.SelectedIndex = 1 Then
            dblSizePrice = 4.0
        Else
            dblSizePrice = 6.0
        End If

        dblPrice = (dblPizza + dblSizePrice) * nudQuantity.Value
        lblPrice.Text = dblPrice.ToString()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim frmPay As New frmPayment()
        frmPay.dblPrice = Double.Parse(lblPrice.Text)
        Me.Hide()
        frmPay.ShowDialog()
        Me.Close()
    End Sub
End Class