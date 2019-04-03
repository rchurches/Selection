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
        Me.picColour = New System.Windows.Forms.PictureBox()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.hsbRed = New System.Windows.Forms.HScrollBar()
        Me.hsbBlue = New System.Windows.Forms.HScrollBar()
        Me.hsbGreen = New System.Windows.Forms.HScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnColourGuesser = New System.Windows.Forms.Button()
        CType(Me.picColour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picColour
        '
        Me.picColour.Location = New System.Drawing.Point(376, 105)
        Me.picColour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picColour.Name = "picColour"
        Me.picColour.Size = New System.Drawing.Size(285, 211)
        Me.picColour.TabIndex = 0
        Me.picColour.TabStop = False
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.ForeColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(793, 42)
        Me.lblRed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(24, 25)
        Me.lblRed.TabIndex = 1
        Me.lblRed.Text = "0"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGreen.Location = New System.Drawing.Point(793, 105)
        Me.lblGreen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(24, 25)
        Me.lblGreen.TabIndex = 2
        Me.lblGreen.Text = "0"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.ForeColor = System.Drawing.Color.Blue
        Me.lblBlue.Location = New System.Drawing.Point(793, 165)
        Me.lblBlue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(24, 25)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "0"
        '
        'hsbRed
        '
        Me.hsbRed.Location = New System.Drawing.Point(317, 365)
        Me.hsbRed.Maximum = 264
        Me.hsbRed.Name = "hsbRed"
        Me.hsbRed.Size = New System.Drawing.Size(505, 26)
        Me.hsbRed.TabIndex = 4
        '
        'hsbBlue
        '
        Me.hsbBlue.Location = New System.Drawing.Point(317, 496)
        Me.hsbBlue.Maximum = 264
        Me.hsbBlue.Name = "hsbBlue"
        Me.hsbBlue.Size = New System.Drawing.Size(505, 26)
        Me.hsbBlue.TabIndex = 5
        '
        'hsbGreen
        '
        Me.hsbGreen.Location = New System.Drawing.Point(317, 439)
        Me.hsbGreen.Maximum = 264
        Me.hsbGreen.Name = "hsbGreen"
        Me.hsbGreen.Size = New System.Drawing.Size(505, 26)
        Me.hsbGreen.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(709, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Blue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(709, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Green"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(709, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Red"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(224, 372)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Red"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(224, 435)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Green"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(224, 495)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Blue"
        '
        'btnColourGuesser
        '
        Me.btnColourGuesser.Location = New System.Drawing.Point(860, 229)
        Me.btnColourGuesser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnColourGuesser.Name = "btnColourGuesser"
        Me.btnColourGuesser.Size = New System.Drawing.Size(177, 88)
        Me.btnColourGuesser.TabIndex = 14
        Me.btnColourGuesser.Text = "Random Colour Guesser"
        Me.btnColourGuesser.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 626)
        Me.Controls.Add(Me.btnColourGuesser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hsbGreen)
        Me.Controls.Add(Me.hsbBlue)
        Me.Controls.Add(Me.hsbRed)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.picColour)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picColour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picColour As PictureBox
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents hsbRed As HScrollBar
    Friend WithEvents hsbBlue As HScrollBar
    Friend WithEvents hsbGreen As HScrollBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnColourGuesser As Button
End Class
