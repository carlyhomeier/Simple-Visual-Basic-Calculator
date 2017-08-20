<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LabelTop = New System.Windows.Forms.Label()
        Me.firstbox = New System.Windows.Forms.TextBox()
        Me.LabelMiddle = New System.Windows.Forms.Label()
        Me.secondbox = New System.Windows.Forms.TextBox()
        Me.LabelBottom = New System.Windows.Forms.Label()
        Me.answerbox = New System.Windows.Forms.TextBox()
        Me.ButtonPlus = New System.Windows.Forms.Button()
        Me.ButtonMinus = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.ButtonTax = New System.Windows.Forms.Button()
        Me.ButtonTemperatureFC = New System.Windows.Forms.Button()
        Me.ButtonTemperatureCF = New System.Windows.Forms.Button()
        Me.ButtonPower = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelTop
        '
        Me.LabelTop.AutoSize = True
        Me.LabelTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTop.ForeColor = System.Drawing.Color.White
        Me.LabelTop.Location = New System.Drawing.Point(13, 13)
        Me.LabelTop.Name = "LabelTop"
        Me.LabelTop.Size = New System.Drawing.Size(78, 15)
        Me.LabelTop.TabIndex = 0
        Me.LabelTop.Text = "First Number"
        '
        'firstbox
        '
        Me.firstbox.Location = New System.Drawing.Point(13, 31)
        Me.firstbox.Name = "firstbox"
        Me.firstbox.Size = New System.Drawing.Size(156, 20)
        Me.firstbox.TabIndex = 1
        '
        'LabelMiddle
        '
        Me.LabelMiddle.AutoSize = True
        Me.LabelMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMiddle.ForeColor = System.Drawing.Color.White
        Me.LabelMiddle.Location = New System.Drawing.Point(13, 54)
        Me.LabelMiddle.Name = "LabelMiddle"
        Me.LabelMiddle.Size = New System.Drawing.Size(97, 15)
        Me.LabelMiddle.TabIndex = 2
        Me.LabelMiddle.Text = "Second Number"
        '
        'secondbox
        '
        Me.secondbox.Location = New System.Drawing.Point(12, 72)
        Me.secondbox.Name = "secondbox"
        Me.secondbox.Size = New System.Drawing.Size(157, 20)
        Me.secondbox.TabIndex = 3
        '
        'LabelBottom
        '
        Me.LabelBottom.AutoSize = True
        Me.LabelBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBottom.ForeColor = System.Drawing.Color.White
        Me.LabelBottom.Location = New System.Drawing.Point(13, 95)
        Me.LabelBottom.Name = "LabelBottom"
        Me.LabelBottom.Size = New System.Drawing.Size(47, 15)
        Me.LabelBottom.TabIndex = 4
        Me.LabelBottom.Text = "Answer"
        '
        'answerbox
        '
        Me.answerbox.Location = New System.Drawing.Point(12, 113)
        Me.answerbox.Name = "answerbox"
        Me.answerbox.ReadOnly = True
        Me.answerbox.Size = New System.Drawing.Size(157, 20)
        Me.answerbox.TabIndex = 5
        '
        'ButtonPlus
        '
        Me.ButtonPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlus.Location = New System.Drawing.Point(13, 139)
        Me.ButtonPlus.Name = "ButtonPlus"
        Me.ButtonPlus.Size = New System.Drawing.Size(75, 25)
        Me.ButtonPlus.TabIndex = 6
        Me.ButtonPlus.Text = "Plus"
        Me.ButtonPlus.UseVisualStyleBackColor = True
        '
        'ButtonMinus
        '
        Me.ButtonMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMinus.Location = New System.Drawing.Point(13, 170)
        Me.ButtonMinus.Name = "ButtonMinus"
        Me.ButtonMinus.Size = New System.Drawing.Size(75, 25)
        Me.ButtonMinus.TabIndex = 8
        Me.ButtonMinus.Text = "Minus"
        Me.ButtonMinus.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiply.Location = New System.Drawing.Point(13, 201)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(75, 25)
        Me.ButtonMultiply.TabIndex = 10
        Me.ButtonMultiply.Text = "Multiply"
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivide.Location = New System.Drawing.Point(94, 140)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(75, 25)
        Me.ButtonDivide.TabIndex = 12
        Me.ButtonDivide.Text = "Divide"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'ButtonTax
        '
        Me.ButtonTax.Location = New System.Drawing.Point(13, 232)
        Me.ButtonTax.Name = "ButtonTax"
        Me.ButtonTax.Size = New System.Drawing.Size(75, 25)
        Me.ButtonTax.TabIndex = 14
        Me.ButtonTax.Text = "Tax"
        Me.ButtonTax.UseVisualStyleBackColor = True
        '
        'ButtonTemperatureFC
        '
        Me.ButtonTemperatureFC.Location = New System.Drawing.Point(94, 171)
        Me.ButtonTemperatureFC.Name = "ButtonTemperatureFC"
        Me.ButtonTemperatureFC.Size = New System.Drawing.Size(75, 25)
        Me.ButtonTemperatureFC.TabIndex = 16
        Me.ButtonTemperatureFC.Text = " °F to °C "
        Me.ButtonTemperatureFC.UseVisualStyleBackColor = True
        '
        'ButtonTemperatureCF
        '
        Me.ButtonTemperatureCF.Location = New System.Drawing.Point(94, 202)
        Me.ButtonTemperatureCF.Name = "ButtonTemperatureCF"
        Me.ButtonTemperatureCF.Size = New System.Drawing.Size(75, 25)
        Me.ButtonTemperatureCF.TabIndex = 18
        Me.ButtonTemperatureCF.Text = "°C to °F"
        Me.ButtonTemperatureCF.UseVisualStyleBackColor = True
        '
        'ButtonPower
        '
        Me.ButtonPower.Location = New System.Drawing.Point(94, 233)
        Me.ButtonPower.Name = "ButtonPower"
        Me.ButtonPower.Size = New System.Drawing.Size(75, 25)
        Me.ButtonPower.TabIndex = 20
        Me.ButtonPower.Text = "Power"
        Me.ButtonPower.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(184, 268)
        Me.Controls.Add(Me.ButtonPower)
        Me.Controls.Add(Me.ButtonTemperatureCF)
        Me.Controls.Add(Me.ButtonTemperatureFC)
        Me.Controls.Add(Me.ButtonTax)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonMinus)
        Me.Controls.Add(Me.ButtonPlus)
        Me.Controls.Add(Me.answerbox)
        Me.Controls.Add(Me.LabelBottom)
        Me.Controls.Add(Me.secondbox)
        Me.Controls.Add(Me.LabelMiddle)
        Me.Controls.Add(Me.firstbox)
        Me.Controls.Add(Me.LabelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTop As Label
    Friend WithEvents firstbox As TextBox
    Friend WithEvents LabelMiddle As Label
    Friend WithEvents secondbox As TextBox
    Friend WithEvents LabelBottom As Label
    Friend WithEvents answerbox As TextBox
    Friend WithEvents ButtonPlus As Button
    Friend WithEvents ButtonMinus As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents ButtonTax As Button
    Friend WithEvents ButtonTemperatureFC As Button
    Friend WithEvents ButtonTemperatureCF As Button
    Friend WithEvents ButtonPower As Button
End Class
