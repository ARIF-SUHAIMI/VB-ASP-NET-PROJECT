<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.tblPayment = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtExpiry = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.tblPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblPayment
        '
        Me.tblPayment.ColumnCount = 2
        Me.tblPayment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPayment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPayment.Controls.Add(Me.lblCredit, 0, 0)
        Me.tblPayment.Controls.Add(Me.txtCredit, 1, 0)
        Me.tblPayment.Controls.Add(Me.Label1, 0, 1)
        Me.tblPayment.Controls.Add(Me.Label2, 0, 2)
        Me.tblPayment.Controls.Add(Me.Label3, 0, 3)
        Me.tblPayment.Controls.Add(Me.txtMonth, 1, 1)
        Me.tblPayment.Controls.Add(Me.txtExpiry, 1, 2)
        Me.tblPayment.Controls.Add(Me.txtAmount, 1, 3)
        Me.tblPayment.Controls.Add(Me.btnProceed, 0, 4)
        Me.tblPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPayment.Location = New System.Drawing.Point(0, 0)
        Me.tblPayment.Name = "tblPayment"
        Me.tblPayment.RowCount = 5
        Me.tblPayment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblPayment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblPayment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblPayment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblPayment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblPayment.Size = New System.Drawing.Size(800, 450)
        Me.tblPayment.TabIndex = 0
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCredit.Location = New System.Drawing.Point(3, 0)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(394, 90)
        Me.lblCredit.TabIndex = 0
        Me.lblCredit.Text = "Credit Card Number"
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCredit
        '
        Me.txtCredit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCredit.Location = New System.Drawing.Point(403, 34)
        Me.txtCredit.MaxLength = 16
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(394, 22)
        Me.txtCredit.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 90)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Expiry Month"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 90)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Expiry Year"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(394, 90)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMonth
        '
        Me.txtMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonth.Location = New System.Drawing.Point(403, 124)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(394, 22)
        Me.txtMonth.TabIndex = 5
        '
        'txtExpiry
        '
        Me.txtExpiry.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpiry.Location = New System.Drawing.Point(403, 214)
        Me.txtExpiry.Name = "txtExpiry"
        Me.txtExpiry.Size = New System.Drawing.Size(394, 22)
        Me.txtExpiry.TabIndex = 6
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmount.Location = New System.Drawing.Point(403, 304)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(394, 22)
        Me.txtAmount.TabIndex = 7
        '
        'btnProceed
        '
        Me.tblPayment.SetColumnSpan(Me.btnProceed, 2)
        Me.btnProceed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProceed.Location = New System.Drawing.Point(3, 363)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(794, 84)
        Me.btnProceed.TabIndex = 8
        Me.btnProceed.Text = "Proceed Payment"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tblPayment)
        Me.Name = "frmPayment"
        Me.Text = "Payment Window"
        Me.tblPayment.ResumeLayout(False)
        Me.tblPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblPayment As TableLayoutPanel
    Friend WithEvents lblCredit As Label
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtExpiry As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnProceed As Button
End Class
