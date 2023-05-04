Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Server

Public Class frmLogin
    'Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-T09JSJUJ\SQLEXPRESS;Initial Catalog=SecureProg;Integrated Security=True")
    Dim clsda As New DataAccess()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strName As String = txtUserName.Text.Trim
        Dim strPass1 As String = txtPassword.Text.Trim
        Dim strHash As String = GetHash(strPass1)
        Dim formTemp As New frmMainMenu()
        Dim strSql As String = "SELECT * from User_tb WHERE UserName = '" & txtUserName.Text.Trim.Replace("'", "''") & "' AND Password = '" & strHash.Trim.Replace("'", "''") & "'"
        Dim dtTemp = clsda.GetDataAsDataTable(strSql)
        'Dim strHash As String = GetHash(dtTemp.Rows(0).Item("UserName"))

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
