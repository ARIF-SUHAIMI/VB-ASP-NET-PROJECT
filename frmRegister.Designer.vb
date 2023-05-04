<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.gbRegister = New System.Windows.Forms.GroupBox()
        Me.tlpRegister = New System.Windows.Forms.TableLayoutPanel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPass1 = New System.Windows.Forms.Label()
        Me.lblPass2 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.gbRegister.SuspendLayout()
        Me.tlpRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRegister
        '
        Me.gbRegister.Controls.Add(Me.tlpRegister)
        Me.gbRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbRegister.Location = New System.Drawing.Point(0, 0)
        Me.gbRegister.Name = "gbRegister"
        Me.gbRegister.Size = New System.Drawing.Size(494, 230)
        Me.gbRegister.TabIndex = 0
        Me.gbRegister.TabStop = False
        Me.gbRegister.Text = "Register New Account"
        '
        'tlpRegister
        '
        Me.tlpRegister.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpRegister.ColumnCount = 2
        Me.tlpRegister.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRegister.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRegister.Controls.Add(Me.lblName, 0, 0)
        Me.tlpRegister.Controls.Add(Me.lblEmail, 0, 1)
        Me.tlpRegister.Controls.Add(Me.lblPass1, 0, 2)
        Me.tlpRegister.Controls.Add(Me.lblPass2, 0, 3)
        Me.tlpRegister.Controls.Add(Me.btnRegister, 0, 4)
        Me.tlpRegister.Controls.Add(Me.txtName, 1, 0)
        Me.tlpRegister.Controls.Add(Me.txtEmail, 1, 1)
        Me.tlpRegister.Controls.Add(Me.txtPass2, 1, 3)
        Me.tlpRegister.Controls.Add(Me.txtPass1, 1, 2)
        Me.tlpRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRegister.Location = New System.Drawing.Point(3, 18)
        Me.tlpRegister.Name = "tlpRegister"
        Me.tlpRegister.RowCount = 5
        Me.tlpRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.311!))
        Me.tlpRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.8756!))
        Me.tlpRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.311!))
        Me.tlpRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35407!))
        Me.tlpRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.66986!))
        Me.tlpRegister.Size = New System.Drawing.Size(488, 209)
        Me.tlpRegister.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Location = New System.Drawing.Point(4, 1)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(236, 31)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Username"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmail.Location = New System.Drawing.Point(4, 33)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(236, 28)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email Address"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPass1
        '
        Me.lblPass1.AutoSize = True
        Me.lblPass1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPass1.Location = New System.Drawing.Point(4, 62)
        Me.lblPass1.Name = "lblPass1"
        Me.lblPass1.Size = New System.Drawing.Size(236, 31)
        Me.lblPass1.TabIndex = 2
        Me.lblPass1.Text = "Password"
        Me.lblPass1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPass2
        '
        Me.lblPass2.AutoSize = True
        Me.lblPass2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPass2.Location = New System.Drawing.Point(4, 94)
        Me.lblPass2.Name = "lblPass2"
        Me.lblPass2.Size = New System.Drawing.Size(236, 29)
        Me.lblPass2.TabIndex = 3
        Me.lblPass2.Text = "Confirm Password"
        Me.lblPass2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tlpRegister.SetColumnSpan(Me.btnRegister, 2)
        Me.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRegister.Location = New System.Drawing.Point(1, 124)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(486, 84)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Location = New System.Drawing.Point(247, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(237, 22)
        Me.txtName.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Location = New System.Drawing.Point(247, 36)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(237, 22)
        Me.txtEmail.TabIndex = 6
        '
        'txtPass2
        '
        Me.txtPass2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPass2.Location = New System.Drawing.Point(247, 97)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(237, 22)
        Me.txtPass2.TabIndex = 7
        '
        'txtPass1
        '
        Me.txtPass1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPass1.Location = New System.Drawing.Point(247, 65)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(237, 22)
        Me.txtPass1.TabIndex = 8
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 230)
        Me.Controls.Add(Me.gbRegister)
        Me.Name = "frmRegister"
        Me.Text = "Register Account"
        Me.gbRegister.ResumeLayout(False)
        Me.tlpRegister.ResumeLayout(False)
        Me.tlpRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbRegister As GroupBox
    Friend WithEvents tlpRegister As TableLayoutPanel
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPass1 As Label
    Friend WithEvents lblPass2 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents txtPass1 As TextBox
End Class
