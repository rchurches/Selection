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
        Me.btnClass = New System.Windows.Forms.Button()
        Me.txtClass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClass
        '
        Me.btnClass.Location = New System.Drawing.Point(1119, 734)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(149, 107)
        Me.btnClass.TabIndex = 0
        Me.btnClass.Text = "Click for Class"
        Me.btnClass.UseVisualStyleBackColor = True
        '
        'txtClass
        '
        Me.txtClass.Location = New System.Drawing.Point(305, 116)
        Me.txtClass.Multiline = True
        Me.txtClass.Name = "txtClass"
        Me.txtClass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtClass.Size = New System.Drawing.Size(670, 699)
        Me.txtClass.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 949)
        Me.Controls.Add(Me.txtClass)
        Me.Controls.Add(Me.btnClass)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClass As Button
    Friend WithEvents txtClass As TextBox
End Class
