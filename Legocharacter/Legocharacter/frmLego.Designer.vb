<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLego
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
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Red
        Me.btnCheck.Location = New System.Drawing.Point(526, 752)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(157, 125)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'frmLego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 988)
        Me.Controls.Add(Me.btnCheck)
        Me.Name = "frmLego"
        Me.Text = "frmLego"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCheck As Button
End Class
