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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblSide1 = New System.Windows.Forms.Label()
        Me.lblSide2 = New System.Windows.Forms.Label()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.txtSide1 = New System.Windows.Forms.TextBox()
        Me.txtSide2 = New System.Windows.Forms.TextBox()
        Me.txtAngle = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(290, 234)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblSide1
        '
        Me.lblSide1.AutoSize = True
        Me.lblSide1.Location = New System.Drawing.Point(120, 64)
        Me.lblSide1.Name = "lblSide1"
        Me.lblSide1.Size = New System.Drawing.Size(34, 13)
        Me.lblSide1.TabIndex = 1
        Me.lblSide1.Text = "Side1"
        '
        'lblSide2
        '
        Me.lblSide2.AutoSize = True
        Me.lblSide2.Location = New System.Drawing.Point(316, 64)
        Me.lblSide2.Name = "lblSide2"
        Me.lblSide2.Size = New System.Drawing.Size(34, 13)
        Me.lblSide2.TabIndex = 1
        Me.lblSide2.Text = "Side2"
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Location = New System.Drawing.Point(539, 67)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(34, 13)
        Me.lblAngle.TabIndex = 1
        Me.lblAngle.Text = "Angle"
        '
        'txtSide1
        '
        Me.txtSide1.Location = New System.Drawing.Point(165, 64)
        Me.txtSide1.Name = "txtSide1"
        Me.txtSide1.Size = New System.Drawing.Size(100, 20)
        Me.txtSide1.TabIndex = 2
        '
        'txtSide2
        '
        Me.txtSide2.Location = New System.Drawing.Point(361, 64)
        Me.txtSide2.Name = "txtSide2"
        Me.txtSide2.Size = New System.Drawing.Size(100, 20)
        Me.txtSide2.TabIndex = 2
        '
        'txtAngle
        '
        Me.txtAngle.Location = New System.Drawing.Point(584, 64)
        Me.txtAngle.Name = "txtAngle"
        Me.txtAngle.Size = New System.Drawing.Size(100, 20)
        Me.txtAngle.TabIndex = 2
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(278, 147)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(72, 24)
        Me.lblDisplay.TabIndex = 1
        Me.lblDisplay.Text = "Label1"
        Me.lblDisplay.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(440, 234)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 380)
        Me.Controls.Add(Me.txtAngle)
        Me.Controls.Add(Me.txtSide2)
        Me.Controls.Add(Me.txtSide1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblAngle)
        Me.Controls.Add(Me.lblSide2)
        Me.Controls.Add(Me.lblSide1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblSide1 As Label
    Friend WithEvents lblSide2 As Label
    Friend WithEvents lblAngle As Label
    Friend WithEvents txtSide1 As TextBox
    Friend WithEvents txtSide2 As TextBox
    Friend WithEvents txtAngle As TextBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnClose As Button
End Class
