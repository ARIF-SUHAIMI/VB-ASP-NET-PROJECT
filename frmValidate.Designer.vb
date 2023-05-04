<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidate
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
        Me.tlpConfirm = New System.Windows.Forms.TableLayoutPanel()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.tlpConfirm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpConfirm
        '
        Me.tlpConfirm.ColumnCount = 1
        Me.tlpConfirm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpConfirm.Controls.Add(Me.txtConfirm, 0, 1)
        Me.tlpConfirm.Controls.Add(Me.btnConfirm, 0, 2)
        Me.tlpConfirm.Controls.Add(Me.lblConfirm, 0, 0)
        Me.tlpConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpConfirm.Location = New System.Drawing.Point(0, 0)
        Me.tlpConfirm.Name = "tlpConfirm"
        Me.tlpConfirm.RowCount = 3
        Me.tlpConfirm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpConfirm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.9601!))
        Me.tlpConfirm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70657!))
        Me.tlpConfirm.Size = New System.Drawing.Size(284, 354)
        Me.tlpConfirm.TabIndex = 4
        '
        'txtConfirm
        '
        Me.txtConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConfirm.Location = New System.Drawing.Point(3, 120)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(278, 22)
        Me.txtConfirm.TabIndex = 0
        '
        'btnConfirm
        '
        Me.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirm.Location = New System.Drawing.Point(3, 176)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(278, 175)
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
        Me.lblConfirm.Size = New System.Drawing.Size(278, 117)
        Me.lblConfirm.TabIndex = 2
        Me.lblConfirm.Text = "Please Enter Passcode that was sent  to your email"
        Me.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmValidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 354)
        Me.Controls.Add(Me.tlpConfirm)
        Me.Name = "frmValidate"
        Me.Text = "frmValidate"
        Me.tlpConfirm.ResumeLayout(False)
        Me.tlpConfirm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpConfirm As TableLayoutPanel
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblConfirm As Label
End Class
