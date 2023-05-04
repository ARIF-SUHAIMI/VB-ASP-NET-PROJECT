Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Server

Public Class frmLogin
    'Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-T09JSJUJ\SQLEXPRESS;Initial Catalog=SecureProg;Integrated Security=True")
    Dim clsda As New DataAccess()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim formTemp As New frmMainMenu()
        Dim strSql As String = "SELECT * from User_tb WHERE UserName = '" & txtUserName.Text.Trim.Replace("'", "''") & "' AND Password = '" & txtPassword.Text.Trim.Replace("'", "''") & "'"
        Dim dtTemp = clsda.GetDataAsDataTable(strSql)
        'Dim strHash As String = GetHash(dtTemp.Rows(0).Item("UserName"))

        If (dtTemp.Rows.Count <> 0) Then
            For i = 0 To dtTemp.Rows.Count - 1
                If (txtUserName.Text.Trim() = dtTemp.Rows(i).Item("UserName")) Then
                    MsgBox("Correct Username")
                Else
                    MsgBox("Wrong Username")
                End If
            Next
        Else
            MsgBox("Wrong Username / Password")
        End If
        'formTemp.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click
        Me.Hide()

        Dim frmRecover As New frmRecoverPass()

        frmRecover.ShowDialog()

        Me.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.ShowDialog()
    End Sub
End Class
