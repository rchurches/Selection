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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.btnSortAsc = New System.Windows.Forms.Button()
        Me.btnSortDesc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(732, 625)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(6)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(150, 44)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(346, 625)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(208, 44)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check Number"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 25
        Me.lstResult.Location = New System.Drawing.Point(413, 120)
        Me.lstResult.Margin = New System.Windows.Forms.Padding(2)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(469, 329)
        Me.lstResult.TabIndex = 2
        '
        'btnSortAsc
        '
        Me.btnSortAsc.Location = New System.Drawing.Point(1167, 543)
        Me.btnSortAsc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSortAsc.Name = "btnSortAsc"
        Me.btnSortAsc.Size = New System.Drawing.Size(157, 98)
        Me.btnSortAsc.TabIndex = 3
        Me.btnSortAsc.Text = "Sort in Ascending Order"
        Me.btnSortAsc.UseVisualStyleBackColor = True
        '
        'btnSortDesc
        '
        Me.btnSortDesc.Location = New System.Drawing.Point(1167, 671)
        Me.btnSortDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSortDesc.Name = "btnSortDesc"
        Me.btnSortDesc.Size = New System.Drawing.Size(157, 98)
        Me.btnSortDesc.TabIndex = 4
        Me.btnSortDesc.Text = "Sort in Descending Order"
        Me.btnSortDesc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.btnSortDesc)
        Me.Controls.Add(Me.btnSortAsc)
        Me.Controls.Add(Me.lstResult)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnStart)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Array Tutorial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents lstResult As ListBox
    Friend WithEvents btnSortAsc As Button
    Friend WithEvents btnSortDesc As Button
End Class
