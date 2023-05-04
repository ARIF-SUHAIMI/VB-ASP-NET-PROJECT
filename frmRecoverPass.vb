Imports System.Net
Imports System.Net.Mail

Public Class frmRecoverPass

    Dim clsda As New DataAccess
    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        Dim strEmail = txtEmail.Text
        Dim strError As String = ""
        Dim intRandom As Integer = 0

        If strEmail.Trim = "" Then
            MsgBox("Please Enter Email Address")
            Exit Sub
        End If

        intRandom = GenerateRandomNumber()
        sendEmail(intRandom)

    End Sub

    Private Sub sendEmail(ByVal intRandom As Integer)
        Dim strEmail = txtEmail.Text
        Dim strError As String = ""
        Try

            ' Set up the email message
            Dim fromAddress As New MailAddress("testingaustralia4@gmail.com", "Developer")
            Dim toAddress As New MailAddress(strEmail.Trim, "Recipient")
            Dim subject As String = "New user registered"
            Dim body As String = "A new user has registered on our website."
            Dim message As New MailMessage(fromAddress, toAddress)
            message.Subject = subject
            message.Body = body

            ' Set up the Gmail SMTP client
            Dim smtpClient As New SmtpClient("smtp.gmail.com", 587)
            smtpClient.EnableSsl = True
            smtpClient.Credentials = New NetworkCredential("testingaustralia4@gmail.com", "agwvimydczrjqist")

            ' Send the email
            smtpClient.Send(message)
        Catch ex As Exception
            strError = ex.Message
        Finally
            If strError.Trim = "" Then
                ' Display a message to the user indicating that the email has been sent
                MessageBox.Show("Email sent successfully.")
            Else
                MsgBox(strError)
            End If
        End Try


    End Sub

    Private Function GenerateRandomNumber() As Integer
        Dim rnd As New Random()
        Dim randomNumber As Integer = rnd.Next(1000, 9999)
        Return randomNumber
    End Function

    Private Sub hideElements(ByVal blnState As Boolean)
        lblEmail.Visible = blnState
        txtEmail.Visible = blnState
        btnEmail.Visible = blnState

        tlpConfirm.Visible = False
        tlpRecover.RowStyles(3).Height = 0
    End Sub

    Private Sub frmRecoverPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideElements(True)
    End Sub
End Class