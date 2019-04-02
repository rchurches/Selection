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
        Me.btnScore = New System.Windows.Forms.Button()
        Me.txtScoreboard = New System.Windows.Forms.TextBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.btnCheckHole = New System.Windows.Forms.Button()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnScore
        '
        Me.btnScore.Location = New System.Drawing.Point(407, 590)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(286, 162)
        Me.btnScore.TabIndex = 0
        Me.btnScore.Text = "Score"
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'txtScoreboard
        '
        Me.txtScoreboard.Location = New System.Drawing.Point(231, 30)
        Me.txtScoreboard.Multiline = True
        Me.txtScoreboard.Name = "txtScoreboard"
        Me.txtScoreboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScoreboard.Size = New System.Drawing.Size(624, 382)
        Me.txtScoreboard.TabIndex = 1
        '
        'picPlayer
        '
        Me.picPlayer.Location = New System.Drawing.Point(947, 30)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(310, 390)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 2
        Me.picPlayer.TabStop = False
        '
        'btnCheckHole
        '
        Me.btnCheckHole.Location = New System.Drawing.Point(805, 590)
        Me.btnCheckHole.Name = "btnCheckHole"
        Me.btnCheckHole.Size = New System.Drawing.Size(286, 162)
        Me.btnCheckHole.TabIndex = 3
        Me.btnCheckHole.Text = "Hole Check"
        Me.btnCheckHole.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 830)
        Me.Controls.Add(Me.btnCheckHole)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.txtScoreboard)
        Me.Controls.Add(Me.btnScore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnScore As Button
    Friend WithEvents txtScoreboard As TextBox
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents btnCheckHole As Button
End Class
