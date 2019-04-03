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
        Me.btnData = New System.Windows.Forms.Button()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnData
        '
        Me.btnData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnData.Location = New System.Drawing.Point(169, 303)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(138, 89)
        Me.btnData.TabIndex = 0
        Me.btnData.Text = "Data Entry"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'txtPlayer
        '
        Me.txtPlayer.Location = New System.Drawing.Point(169, 59)
        Me.txtPlayer.Multiline = True
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(354, 220)
        Me.txtPlayer.TabIndex = 1
        '
        'btnSort
        '
        Me.btnSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.Location = New System.Drawing.Point(385, 303)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(138, 89)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "Sort Ages"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 504)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.txtPlayer)
        Me.Controls.Add(Me.btnData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnData As System.Windows.Forms.Button
    Friend WithEvents txtPlayer As System.Windows.Forms.TextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button

End Class
