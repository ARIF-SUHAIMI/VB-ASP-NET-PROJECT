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
        Me.tlpRecover.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpRecover
        '
        Me.tlpRecover.ColumnCount = 1
        Me.tlpRecover.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRecover.Controls.Add(Me.lblEmail, 0, 0)
        Me.tlpRecover.Controls.Add(Me.txtEmail, 0, 1)
        Me.tlpRecover.Controls.Add(Me.btnEmail, 0, 2)
        Me.tlpRecover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRecover.Location = New System.Drawing.Point(0, 0)
        Me.tlpRecover.Name = "tlpRecover"
        Me.tlpRecover.RowCount = 3
        Me.tlpRecover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.87014!))
        Me.tlpRecover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.07792!))
        Me.tlpRecover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.05194!))
        Me.tlpRecover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpRecover.Size = New System.Drawing.Size(384, 374)
        Me.tlpRecover.TabIndex = 0
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmail.Location = New System.Drawing.Point(3, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(378, 111)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Please Enter Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Location = New System.Drawing.Point(3, 114)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(378, 22)
        Me.txtEmail.TabIndex = 1
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.IndianRed
        Me.btnEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEmail.Location = New System.Drawing.Point(3, 196)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(378, 175)
        Me.btnEmail.TabIndex = 2
        Me.btnEmail.Text = "Send Confirmation Code"
        Me.btnEmail.UseVisualStyleBackColor = False
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpRecover As TableLayoutPanel
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnEmail As Button
End Class
