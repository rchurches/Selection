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
        Me.btnTimesTable = New System.Windows.Forms.Button()
        Me.txtTimesTable = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnTimesTable
        '
        Me.btnTimesTable.Location = New System.Drawing.Point(726, 425)
        Me.btnTimesTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTimesTable.Name = "btnTimesTable"
        Me.btnTimesTable.Size = New System.Drawing.Size(210, 152)
        Me.btnTimesTable.TabIndex = 0
        Me.btnTimesTable.Text = "TimesTable"
        Me.btnTimesTable.UseVisualStyleBackColor = True
        '
        'txtTimesTable
        '
        Me.txtTimesTable.Location = New System.Drawing.Point(90, 134)
        Me.txtTimesTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTimesTable.Multiline = True
        Me.txtTimesTable.Name = "txtTimesTable"
        Me.txtTimesTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTimesTable.Size = New System.Drawing.Size(348, 752)
        Me.txtTimesTable.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1539, 942)
        Me.Controls.Add(Me.txtTimesTable)
        Me.Controls.Add(Me.btnTimesTable)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTimesTable As Button
    Friend WithEvents txtTimesTable As TextBox
End Class
