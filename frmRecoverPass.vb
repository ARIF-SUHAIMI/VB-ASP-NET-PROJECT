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

        If Not CheckDB() Then
            MsgBox("Email was not registered")
            Exit Sub
        End If

        intRandom = GenerateRandomNumber()
        If (sendEmail(intRandom)) Then
            Me.Hide()
            frmValidate.intRandom = intRandom
            frmValidate.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Function sendEmail(ByVal intRandom As Integer) As Boolean
        Dim strEmail = txtEmail.Text
        Dim strError As String = ""
        Dim blnState As Boolean = False

        Try

            ' Set up the email message
            Dim fromAddress As New MailAddress("testingaustralia4@gmail.com", "Developer")
            Dim toAddress As New MailAddress(strEmail.Trim, "Recipient")
            Dim subject As String = "Passcode for changing password"
            Dim body As String = "Recover Password was request by this email, This is the Passcode " & intRandom & " Please ignore this email if you did not request any passcode"
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
            blnState = False
        Finally
            If strError.Trim = "" Then
                ' Display a message to the user indicating that the email has been sent
                MessageBox.Show("Email sent successfully.")
                blnState = True
            Else
                MsgBox(strError)
            End If
        End Try

        Return blnState
    End Function

    Private Function GenerateRandomNumber() As Integer
        Dim rnd As New Random()
        Dim randomNumber As Integer = rnd.Next(1000, 9999)
        Return randomNumber
    End Function

    Private Function CheckDB() As Boolean
        Dim strEmail As String = txtEmail.Text
        Dim strSql As String = ""
        Dim dtData As DataTable

        strSql = "SELECT * FROM User_tb WHERE Email ='" & strEmail.Trim.Replace("'", "''") & "'"
        dtData = clsda.GetDataAsDataTable(strSql)

        If dtData.Rows.Count = 0 Then
            Return False
        Else
            frmNewPass.intRowId = dtData.Rows(0).Item("ID")
            Return True
        End If
    End Function
End Class