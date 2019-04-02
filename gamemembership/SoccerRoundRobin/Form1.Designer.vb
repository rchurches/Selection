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
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(666, 224)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(652, 605)
        Me.txtResults.TabIndex = 0
        '
        'btnScores
        '
        Me.btnScores.Location = New System.Drawing.Point(229, 592)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(195, 123)
        Me.btnScores.TabIndex = 1
        Me.btnScores.Text = "Enter Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1406, 921)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.txtResults)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResults As TextBox
    Friend WithEvents btnScores As Button
End Class
