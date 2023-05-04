<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRecoverPass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpRecover = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.tlpConfirm = New System.Windows.Forms.TableLayoutPanel()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.tlpRecover.SuspendLayout()
        Me.tlpConfirm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpRecover
        '
        Me.tlpRecover.ColumnCount = 1
        Me.tlpRecover.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRecover.Controls.Add(Me.lblEmail, 0, 0)
        Me.tlpRecover.Controls.Add(Me.txtEmail, 0, 1)
        Me.tlpRecover.Controls.Add(Me.btnEmail, 0, 2)
        Me.tlpRecover.Controls.Add(Me.tlpConfirm, 0, 3)
        Me.tlpRecover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRecover.Location = New System.Drawing.Point(0, 0)
        Me.tlpRecover.Name = "tlpRecover"
        Me.tlpRecover.RowCount = 4
        Me.tlpRecover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.29947!))
        Me.tlpRecover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.tlpRecover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.7861!))
        Me.tlpRecover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353!))
        Me.tlpRecover.Size = New System.Drawing.Size(384, 374)
        Me.tlpRecover.TabIndex = 0
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmail.Location = New System.Drawing.Point(3, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(378, 46)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Please Enter Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Location = New System.Drawing.Point(3, 49)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(378, 22)
        Me.txtEmail.TabIndex = 1
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.IndianRed
        Me.btnEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEmail.Location = New System.Drawing.Point(3, 83)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(378, 68)
        Me.btnEmail.TabIndex = 2
        Me.btnEmail.Text = "Send Confirmation Code"
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'tlpConfirm
        '
        Me.tlpConfirm.ColumnCount = 1
        Me.tlpConfirm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpConfirm.Controls.Add(Me.txtConfirm, 0, 1)
        Me.tlpConfirm.Controls.Add(Me.btnConfirm, 0, 2)
        Me.tlpConfirm.Controls.Add(Me.lblConfirm, 0, 0)
        Me.tlpConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpConfirm.Location = New System.Drawing.Point(3, 157)
        Me.tlpConfirm.Name = "tlpConfirm"
        Me.tlpConfirm.RowCount = 3
        Me.tlpConfirm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpConfirm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.9601!))
        Me.tlpConfirm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70657!))
        Me.tlpConfirm.Size = New System.Drawing.Size(378, 214)
        Me.tlpConfirm.TabIndex = 3
        '
        'txtConfirm
        '
        Me.txtConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConfirm.Location = New System.Drawing.Point(3, 74)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(372, 22)
        Me.txtConfirm.TabIndex = 0
        '
        'btnConfirm
        '
        Me.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirm.Location = New System.Drawing.Point(3, 108)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(372, 103)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Validate"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConfirm.Location = New System.Drawing.Point(3, 0)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(372, 71)
        Me.lblConfirm.TabIndex = 2
        Me.lblConfirm.Text = "Please Enter Passcode that was sent  to your email"
        Me.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRecoverPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 374)
        Me.Controls.Add(Me.tlpRecover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRecoverPass"
        Me.Text = "Recover Password"
        Me.tlpRecover.ResumeLayout(False)
        Me.tlpRecover.PerformLayout()
        Me.tlpConfirm.ResumeLayout(False)
        Me.tlpConfirm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpRecover As TableLayoutPanel
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnEmail As Button
    Friend WithEvents tlpConfirm As TableLayoutPanel
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblConfirm As Label
End Class
