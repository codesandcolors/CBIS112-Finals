<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bBlendLabel = New System.Windows.Forms.Label()
        Me.chamomileLabel = New System.Windows.Forms.Label()
        Me.citrusGreenLabel = New System.Windows.Forms.Label()
        Me.earlGrayLabel = New System.Windows.Forms.Label()
        Me.spicedChaiLabel = New System.Windows.Forms.Label()
        Me.BBTextBox = New System.Windows.Forms.TextBox()
        Me.ChTextBox = New System.Windows.Forms.TextBox()
        Me.CGTextBox = New System.Windows.Forms.TextBox()
        Me.EGTextBox = New System.Windows.Forms.TextBox()
        Me.SCTextBox = New System.Windows.Forms.TextBox()
        Me.totalBoxesLabel = New System.Windows.Forms.Label()
        Me.salesTaxLabel = New System.Windows.Forms.Label()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.totalBoxesDisplay = New System.Windows.Forms.Label()
        Me.salesTaxDisplay = New System.Windows.Forms.Label()
        Me.totalPriceDisplay = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clrButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'bBlendLabel
        '
        Me.bBlendLabel.AutoSize = True
        Me.bBlendLabel.Location = New System.Drawing.Point(215, 42)
        Me.bBlendLabel.Name = "bBlendLabel"
        Me.bBlendLabel.Size = New System.Drawing.Size(154, 28)
        Me.bBlendLabel.TabIndex = 1
        Me.bBlendLabel.Text = "Breakfast Blend: "
        '
        'chamomileLabel
        '
        Me.chamomileLabel.AutoSize = True
        Me.chamomileLabel.Location = New System.Drawing.Point(215, 94)
        Me.chamomileLabel.Name = "chamomileLabel"
        Me.chamomileLabel.Size = New System.Drawing.Size(115, 28)
        Me.chamomileLabel.TabIndex = 2
        Me.chamomileLabel.Text = "Chamomile:"
        '
        'citrusGreenLabel
        '
        Me.citrusGreenLabel.AutoSize = True
        Me.citrusGreenLabel.Location = New System.Drawing.Point(215, 150)
        Me.citrusGreenLabel.Name = "citrusGreenLabel"
        Me.citrusGreenLabel.Size = New System.Drawing.Size(128, 28)
        Me.citrusGreenLabel.TabIndex = 3
        Me.citrusGreenLabel.Text = "Citrus Green: "
        '
        'earlGrayLabel
        '
        Me.earlGrayLabel.AutoSize = True
        Me.earlGrayLabel.Location = New System.Drawing.Point(215, 206)
        Me.earlGrayLabel.Name = "earlGrayLabel"
        Me.earlGrayLabel.Size = New System.Drawing.Size(94, 28)
        Me.earlGrayLabel.TabIndex = 4
        Me.earlGrayLabel.Text = "Earl Gray:"
        '
        'spicedChaiLabel
        '
        Me.spicedChaiLabel.AutoSize = True
        Me.spicedChaiLabel.Location = New System.Drawing.Point(215, 262)
        Me.spicedChaiLabel.Name = "spicedChaiLabel"
        Me.spicedChaiLabel.Size = New System.Drawing.Size(118, 28)
        Me.spicedChaiLabel.TabIndex = 5
        Me.spicedChaiLabel.Text = "Spiced Chai:"
        '
        'BBTextBox
        '
        Me.BBTextBox.Location = New System.Drawing.Point(375, 39)
        Me.BBTextBox.Name = "BBTextBox"
        Me.BBTextBox.Size = New System.Drawing.Size(52, 34)
        Me.BBTextBox.TabIndex = 6
        '
        'ChTextBox
        '
        Me.ChTextBox.Location = New System.Drawing.Point(375, 95)
        Me.ChTextBox.Name = "ChTextBox"
        Me.ChTextBox.Size = New System.Drawing.Size(52, 34)
        Me.ChTextBox.TabIndex = 7
        '
        'CGTextBox
        '
        Me.CGTextBox.Location = New System.Drawing.Point(375, 151)
        Me.CGTextBox.Name = "CGTextBox"
        Me.CGTextBox.Size = New System.Drawing.Size(52, 34)
        Me.CGTextBox.TabIndex = 8
        '
        'EGTextBox
        '
        Me.EGTextBox.Location = New System.Drawing.Point(375, 207)
        Me.EGTextBox.Name = "EGTextBox"
        Me.EGTextBox.Size = New System.Drawing.Size(52, 34)
        Me.EGTextBox.TabIndex = 9
        '
        'SCTextBox
        '
        Me.SCTextBox.Location = New System.Drawing.Point(375, 262)
        Me.SCTextBox.Name = "SCTextBox"
        Me.SCTextBox.Size = New System.Drawing.Size(52, 34)
        Me.SCTextBox.TabIndex = 10
        '
        'totalBoxesLabel
        '
        Me.totalBoxesLabel.AutoSize = True
        Me.totalBoxesLabel.Location = New System.Drawing.Point(463, 38)
        Me.totalBoxesLabel.Name = "totalBoxesLabel"
        Me.totalBoxesLabel.Size = New System.Drawing.Size(119, 28)
        Me.totalBoxesLabel.TabIndex = 11
        Me.totalBoxesLabel.Text = "Total boxes: "
        '
        'salesTaxLabel
        '
        Me.salesTaxLabel.AutoSize = True
        Me.salesTaxLabel.Location = New System.Drawing.Point(463, 101)
        Me.salesTaxLabel.Name = "salesTaxLabel"
        Me.salesTaxLabel.Size = New System.Drawing.Size(96, 28)
        Me.salesTaxLabel.TabIndex = 12
        Me.salesTaxLabel.Text = "Sales tax: "
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.AutoSize = True
        Me.totalPriceLabel.Location = New System.Drawing.Point(463, 162)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(111, 28)
        Me.totalPriceLabel.TabIndex = 13
        Me.totalPriceLabel.Text = "Total price: "
        '
        'totalBoxesDisplay
        '
        Me.totalBoxesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalBoxesDisplay.Location = New System.Drawing.Point(588, 38)
        Me.totalBoxesDisplay.Name = "totalBoxesDisplay"
        Me.totalBoxesDisplay.Size = New System.Drawing.Size(89, 35)
        Me.totalBoxesDisplay.TabIndex = 14
        Me.totalBoxesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesTaxDisplay
        '
        Me.salesTaxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salesTaxDisplay.Location = New System.Drawing.Point(588, 99)
        Me.salesTaxDisplay.Name = "salesTaxDisplay"
        Me.salesTaxDisplay.Size = New System.Drawing.Size(89, 35)
        Me.salesTaxDisplay.TabIndex = 15
        Me.salesTaxDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalPriceDisplay
        '
        Me.totalPriceDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalPriceDisplay.Location = New System.Drawing.Point(588, 162)
        Me.totalPriceDisplay.Name = "totalPriceDisplay"
        Me.totalPriceDisplay.Size = New System.Drawing.Size(89, 35)
        Me.totalPriceDisplay.TabIndex = 16
        Me.totalPriceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(717, 36)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(145, 39)
        Me.calcButton.TabIndex = 17
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(717, 151)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(145, 39)
        Me.exitButton.TabIndex = 18
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clrButton
        '
        Me.clrButton.Location = New System.Drawing.Point(717, 95)
        Me.clrButton.Name = "clrButton"
        Me.clrButton.Size = New System.Drawing.Size(145, 39)
        Me.clrButton.TabIndex = 19
        Me.clrButton.Text = "C&lear"
        Me.clrButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 329)
        Me.Controls.Add(Me.clrButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalPriceDisplay)
        Me.Controls.Add(Me.salesTaxDisplay)
        Me.Controls.Add(Me.totalBoxesDisplay)
        Me.Controls.Add(Me.totalPriceLabel)
        Me.Controls.Add(Me.salesTaxLabel)
        Me.Controls.Add(Me.totalBoxesLabel)
        Me.Controls.Add(Me.SCTextBox)
        Me.Controls.Add(Me.EGTextBox)
        Me.Controls.Add(Me.CGTextBox)
        Me.Controls.Add(Me.ChTextBox)
        Me.Controls.Add(Me.BBTextBox)
        Me.Controls.Add(Me.spicedChaiLabel)
        Me.Controls.Add(Me.earlGrayLabel)
        Me.Controls.Add(Me.citrusGreenLabel)
        Me.Controls.Add(Me.chamomileLabel)
        Me.Controls.Add(Me.bBlendLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "Campbell Tea Shoppe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bBlendLabel As Label
    Friend WithEvents chamomileLabel As Label
    Friend WithEvents citrusGreenLabel As Label
    Friend WithEvents earlGrayLabel As Label
    Friend WithEvents spicedChaiLabel As Label
    Friend WithEvents BBTextBox As TextBox
    Friend WithEvents ChTextBox As TextBox
    Friend WithEvents CGTextBox As TextBox
    Friend WithEvents EGTextBox As TextBox
    Friend WithEvents SCTextBox As TextBox
    Friend WithEvents totalBoxesLabel As Label
    Friend WithEvents salesTaxLabel As Label
    Friend WithEvents totalPriceLabel As Label
    Friend WithEvents totalBoxesDisplay As Label
    Friend WithEvents salesTaxDisplay As Label
    Friend WithEvents totalPriceDisplay As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents clrButton As Button
End Class
