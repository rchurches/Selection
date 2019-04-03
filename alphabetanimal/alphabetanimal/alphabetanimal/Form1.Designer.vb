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
        Me.btnAnimalGuess = New System.Windows.Forms.Button()
        Me.picAnimal = New System.Windows.Forms.PictureBox()
        CType(Me.picAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnimalGuess
        '
        Me.btnAnimalGuess.Location = New System.Drawing.Point(12, 409)
        Me.btnAnimalGuess.Name = "btnAnimalGuess"
        Me.btnAnimalGuess.Size = New System.Drawing.Size(156, 86)
        Me.btnAnimalGuess.TabIndex = 0
        Me.btnAnimalGuess.Text = "Click to guess"
        Me.btnAnimalGuess.UseVisualStyleBackColor = True
        '
        'picAnimal
        '
        Me.picAnimal.Image = Global.alphabetanimal.My.Resources.Resources.questionmark
        Me.picAnimal.Location = New System.Drawing.Point(291, 12)
        Me.picAnimal.Name = "picAnimal"
        Me.picAnimal.Size = New System.Drawing.Size(824, 497)
        Me.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAnimal.TabIndex = 1
        Me.picAnimal.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 522)
        Me.Controls.Add(Me.picAnimal)
        Me.Controls.Add(Me.btnAnimalGuess)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAnimalGuess As Button
    Friend WithEvents picAnimal As PictureBox
End Class
