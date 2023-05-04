Public Class frmValidate
    Public intRandom As Integer = 0

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Not checkPasscode() Then
            Exit Sub
        End If

        Me.Hide()
        frmNewPass.ShowDialog()
        Me.Close()
    End Sub

    Private Function checkPasscode() As Boolean
        If intRandom <> Int(txtConfirm.Text) Then
            MsgBox("Passcode does not match. Please check again!")
            Return False
        Else
            Return True
        End If
    End Function
End Class