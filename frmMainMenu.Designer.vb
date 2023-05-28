<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.lblPizza = New System.Windows.Forms.Label()
        Me.lblSelectPizza = New System.Windows.Forms.Label()
        Me.lplSize = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.cbPizza = New System.Windows.Forms.ComboBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbSize, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPizza, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSelectPizza, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lplSize, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblQuantity, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cbPizza, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudQuantity, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOrder, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTotal, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPrice, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cbSize
        '
        Me.cbSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"Personal", "Regular", "Large"})
        Me.cbSize.Location = New System.Drawing.Point(403, 175)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(394, 24)
        Me.cbSize.TabIndex = 7
        '
        'lblPizza
        '
        Me.lblPizza.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblPizza, 2)
        Me.lblPizza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPizza.Location = New System.Drawing.Point(3, 0)
        Me.lblPizza.Name = "lblPizza"
        Me.lblPizza.Size = New System.Drawing.Size(794, 75)
        Me.lblPizza.TabIndex = 0
        Me.lblPizza.Text = "PLEASE CHOOSE YOUR PIZZA"
        Me.lblPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelectPizza
        '
        Me.lblSelectPizza.AutoSize = True
        Me.lblSelectPizza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSelectPizza.Location = New System.Drawing.Point(3, 75)
        Me.lblSelectPizza.Name = "lblSelectPizza"
        Me.lblSelectPizza.Size = New System.Drawing.Size(394, 75)
        Me.lblSelectPizza.TabIndex = 1
        Me.lblSelectPizza.Text = "PIZZA CHOICE"
        Me.lblSelectPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lplSize
        '
        Me.lplSize.AutoSize = True
        Me.lplSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lplSize.Location = New System.Drawing.Point(3, 150)
        Me.lplSize.Name = "lplSize"
        Me.lplSize.Size = New System.Drawing.Size(394, 75)
        Me.lplSize.TabIndex = 2
        Me.lplSize.Text = "PIZZA SIZE"
        Me.lplSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQuantity.Location = New System.Drawing.Point(3, 225)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(394, 75)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "ORDER QUANTITY"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbPizza
        '
        Me.cbPizza.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPizza.FormattingEnabled = True
        Me.cbPizza.Location = New System.Drawing.Point(403, 100)
        Me.cbPizza.Name = "cbPizza"
        Me.cbPizza.Size = New System.Drawing.Size(394, 24)
        Me.cbPizza.TabIndex = 6
        '
        'nudQuantity
        '
        Me.nudQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudQuantity.Location = New System.Drawing.Point(403, 251)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(394, 22)
        Me.nudQuantity.TabIndex = 8
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnOrder, 2)
        Me.btnOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOrder.Location = New System.Drawing.Point(3, 378)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(794, 69)
        Me.btnOrder.TabIndex = 9
        Me.btnOrder.Text = "Place Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(3, 300)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(394, 75)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total Price :"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPrice.Location = New System.Drawing.Point(403, 300)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(394, 75)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmMainMenu"
        Me.Text = "MainMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblPizza As Label
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents lblSelectPizza As Label
    Friend WithEvents lplSize As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents cbPizza As ComboBox
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents btnOrder As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPrice As Label
End Class
