﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.grpOrientation = New System.Windows.Forms.GroupBox()
        Me.btnEitherHand = New System.Windows.Forms.RadioButton()
        Me.btnRightHand = New System.Windows.Forms.RadioButton()
        Me.btnLeftHand = New System.Windows.Forms.RadioButton()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.grpOrientation.SuspendLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Playbill", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(51, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(530, 98)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Wally's Widget World"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Playbill", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblSubTitle.Location = New System.Drawing.Point(186, 120)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(249, 29)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "The Best Widgets in the Mid-West"
        '
        'grpOrientation
        '
        Me.grpOrientation.Controls.Add(Me.btnEitherHand)
        Me.grpOrientation.Controls.Add(Me.btnRightHand)
        Me.grpOrientation.Controls.Add(Me.btnLeftHand)
        Me.grpOrientation.Location = New System.Drawing.Point(12, 187)
        Me.grpOrientation.Name = "grpOrientation"
        Me.grpOrientation.Size = New System.Drawing.Size(146, 163)
        Me.grpOrientation.TabIndex = 2
        Me.grpOrientation.TabStop = False
        Me.grpOrientation.Text = "Orientation"
        '
        'btnEitherHand
        '
        Me.btnEitherHand.AutoSize = True
        Me.btnEitherHand.Location = New System.Drawing.Point(6, 125)
        Me.btnEitherHand.Name = "btnEitherHand"
        Me.btnEitherHand.Size = New System.Drawing.Size(94, 17)
        Me.btnEitherHand.TabIndex = 2
        Me.btnEitherHand.TabStop = True
        Me.btnEitherHand.Text = "Ambidexterous"
        Me.btnEitherHand.UseVisualStyleBackColor = True
        '
        'btnRightHand
        '
        Me.btnRightHand.AutoSize = True
        Me.btnRightHand.Location = New System.Drawing.Point(6, 78)
        Me.btnRightHand.Name = "btnRightHand"
        Me.btnRightHand.Size = New System.Drawing.Size(91, 17)
        Me.btnRightHand.TabIndex = 1
        Me.btnRightHand.TabStop = True
        Me.btnRightHand.Text = "Right Handed"
        Me.btnRightHand.UseVisualStyleBackColor = True
        '
        'btnLeftHand
        '
        Me.btnLeftHand.AutoSize = True
        Me.btnLeftHand.Location = New System.Drawing.Point(6, 36)
        Me.btnLeftHand.Name = "btnLeftHand"
        Me.btnLeftHand.Size = New System.Drawing.Size(84, 17)
        Me.btnLeftHand.TabIndex = 0
        Me.btnLeftHand.TabStop = True
        Me.btnLeftHand.Text = "Left Handed"
        Me.btnLeftHand.UseVisualStyleBackColor = True
        '
        'cmbColor
        '
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Items.AddRange(New Object() {"Red", "Blue", "Green", "Yellow", "Orange", "Mauve", "Camoflage", "Transparent"})
        Me.cmbColor.Location = New System.Drawing.Point(167, 222)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(121, 21)
        Me.cmbColor.TabIndex = 3
        Me.cmbColor.Tag = ""
        Me.cmbColor.Text = "Red"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(164, 187)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 4
        Me.lblColor.Text = "Color"
        '
        'numQty
        '
        Me.numQty.Location = New System.Drawing.Point(294, 220)
        Me.numQty.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(120, 20)
        Me.numQty.TabIndex = 5
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(291, 187)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(46, 13)
        Me.lblQty.TabIndex = 6
        Me.lblQty.Text = "Quantity"
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Location = New System.Drawing.Point(425, 187)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(53, 13)
        Me.lblUnitPrice.TabIndex = 7
        Me.lblUnitPrice.Text = "Unit Price"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(420, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(69, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(498, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Extended Price"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(495, 219)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Order Summary"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(167, 289)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(421, 61)
        Me.TextBox3.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(520, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Order Total = "
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(495, 382)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 16
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(635, 479)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblUnitPrice)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.numQty)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.grpOrientation)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "OrderForm"
        Me.Text = "Wally's Widget World"
        Me.grpOrientation.ResumeLayout(False)
        Me.grpOrientation.PerformLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents grpOrientation As System.Windows.Forms.GroupBox
    Friend WithEvents btnEitherHand As System.Windows.Forms.RadioButton
    Friend WithEvents btnRightHand As System.Windows.Forms.RadioButton
    Friend WithEvents btnLeftHand As System.Windows.Forms.RadioButton
    Friend WithEvents cmbColor As System.Windows.Forms.ComboBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblUnitPrice As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox

End Class
