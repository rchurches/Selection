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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 826)
        Me.Controls.Add(Me.txtScoreboard)
        Me.Controls.Add(Me.btnScore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnScore As Button
    Friend WithEvents txtScoreboard As TextBox
End Class
