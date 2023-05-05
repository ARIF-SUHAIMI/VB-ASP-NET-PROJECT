Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Server

Public Class frmLogin
    'Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-T09JSJUJ\SQLEXPRESS;Initial Catalog=SecureProg;Integrated Security=True")
    Dim clsda As New DataAccess()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strName As String = txtUserName.Text.Trim
        Dim strPass1 As String = txtPassword.Text.Trim
        Dim formTemp As New frmMainMenu()
        Dim strSqlSalt As String = ""
        Dim strSalt As String = ""
        Dim temp = GetHash(strPass1)

        strSqlSalt = "SELECT * FROM User_tb where UserName = '" & strName.Trim.Replace("'", "''") & "'"
        Dim dtSalt = clsda.GetDataAsDataTable(strSqlSalt)
        If dtSalt.Rows.Count = 1 Then
            strSalt = dtSalt.Rows(0).Item("salt")
        End If

        strPass1 = strPass1 & strSalt
        Dim strHash As String = GetHash(strPass1)

        Dim strSql As String = "SELECT * from User_tb WHERE UserName = '" & txtUserName.Text.Trim.Replace("'", "''") & "' AND Password = '" & strHash.Trim.Replace("'", "''") & "'"
        Dim dtTemp = clsda.GetDataAsDataTable(strSql)

        If (dtTemp.Rows.Count <> 0) Then
            Me.Hide()
            formTemp.ShowDialog()
            Me.Close()
        Else
            MsgBox("Wrong Username / Password")
        End If
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
