Imports System.Net
Imports System.Net.Mail

Public Class frmNewPass
    Dim clsda As New DataAccess
    Public intRowId As Integer = 0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not checkError() Then
            Exit Sub
        End If

        If updateTable() Then
            sendEmail()
        Else
            Exit Sub
        End If

        Me.Hide()
        frmLogin.ShowDialog()
        Me.Close()
    End Sub

    Private Function checkError() As Boolean
        Dim strPass1 As String = txtPass1.Text
        Dim strPass2 As String = txtPass2.Text

        If strPass1.Trim <> strPass2.Trim Then
            MsgBox("Password does not match")
            Return False
        Else
            Return True
        End If
    End Function

    Private Function updateTable()
        Dim strPass1 As String = txtPass1.Text
        Dim strHash As String = GetHash(strPass1)
        Dim strError As String = ""

        Dim strSql As String = "UPDATE User_tb SET Password = '" & strHash & "' WHERE ID = " & intRowId & ""
        strError = clsda.ExecuteNonQuery(strSql)

        If strError.Trim <> "" Then
            MsgBox(strError)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub sendEmail()
        Dim strEmail As String = ""
        Dim strError As String = ""

        Dim strSql As String = "SELECT * FROM User_tb WHERE ID = " & intRowId
        Dim dtData As DataTable = clsda.GetDataAsDataTable(strSql)
        If dtData.Rows.Count <> 0 Then
            Try
                strEmail = dtData.Rows(0).Item("Email")

                ' Set up the email message
                Dim fromAddress As New MailAddress("testingaustralia4@gmail.com", "Developer")
                Dim toAddress As New MailAddress(strEmail.Trim, "Recipient")
                Dim subject As String = "New password set successfully"
                Dim body As String = "A new password was change succesfully. If this was an error, please reached out to our admin at test@gmail.com"
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
        End If
    End Sub
End Class