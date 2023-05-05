<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tlpNewPass = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.lblPass1 = New System.Windows.Forms.Label()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.lblPass2 = New System.Windows.Forms.Label()
        Me.tlpNewPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Location = New System.Drawing.Point(3, 126)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(416, 106)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tlpNewPass
        '
        Me.tlpNewPass.ColumnCount = 1
        Me.tlpNewPass.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNewPass.Controls.Add(Me.txtPass2, 0, 3)
        Me.tlpNewPass.Controls.Add(Me.lblPass1, 0, 0)
        Me.tlpNewPass.Controls.Add(Me.txtPass1, 0, 1)
        Me.tlpNewPass.Controls.Add(Me.btnSave, 0, 4)
        Me.tlpNewPass.Controls.Add(Me.lblPass2, 0, 2)
        Me.tlpNewPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNewPass.Location = New System.Drawing.Point(0, 0)
        Me.tlpNewPass.Name = "tlpNewPass"
        Me.tlpNewPass.RowCount = 5
        Me.tlpNewPass.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33059!))
        Me.tlpNewPass.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.9402!))
        Me.tlpNewPass.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.61794!))
        Me.tlpNewPass.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.634551!))
        Me.tlpNewPass.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5083!))
        Me.tlpNewPass.Size = New System.Drawing.Size(422, 235)
        Me.tlpNewPass.TabIndex = 1
        '
        'txtPass2
        '
        Me.txtPass2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPass2.Location = New System.Drawing.Point(3, 104)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(416, 22)
        Me.txtPass2.TabIndex = 3
        '
        'lblPass1
        '
        Me.lblPass1.AutoSize = True
        Me.lblPass1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPass1.Location = New System.Drawing.Point(3, 0)
        Me.lblPass1.Name = "lblPass1"
        Me.lblPass1.Size = New System.Drawing.Size(416, 26)
        Me.lblPass1.TabIndex = 0
        Me.lblPass1.Text = "Please Enter New Password"
        Me.lblPass1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPass1
        '
        Me.txtPass1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPass1.Location = New System.Drawing.Point(3, 29)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(416, 22)
        Me.txtPass1.TabIndex = 1
        '
        'lblPass2
        '
        Me.lblPass2.AutoSize = True
        Me.lblPass2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPass2.Location = New System.Drawing.Point(3, 67)
        Me.lblPass2.Name = "lblPass2"
        Me.lblPass2.Size = New System.Drawing.Size(416, 34)
        Me.lblPass2.TabIndex = 4
        Me.lblPass2.Text = "Retype New Password"
        Me.lblPass2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmNewPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 235)
        Me.Controls.Add(Me.tlpNewPass)
        Me.Name = "frmNewPass"
        Me.Text = "Create New Password"
        Me.tlpNewPass.ResumeLayout(False)
        Me.tlpNewPass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents tlpNewPass As TableLayoutPanel
    Friend WithEvents lblPass1 As Label
    Friend WithEvents txtPass1 As TextBox
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents lblPass2 As Label
End Class
