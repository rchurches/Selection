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
        Me.picBuzz = New System.Windows.Forms.PictureBox()
        Me.picIronMan = New System.Windows.Forms.PictureBox()
        Me.picBatman = New System.Windows.Forms.PictureBox()
        Me.picSpongeBob = New System.Windows.Forms.PictureBox()
        Me.picRobin = New System.Windows.Forms.PictureBox()
        CType(Me.picBuzz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIronMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBatman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpongeBob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRobin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBuzz
        '
        Me.picBuzz.Image = Global.Legocharacter.My.Resources.Resources.Unknown
        Me.picBuzz.Location = New System.Drawing.Point(502, 528)
        Me.picBuzz.Name = "picBuzz"
        Me.picBuzz.Size = New System.Drawing.Size(170, 200)
        Me.picBuzz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuzz.TabIndex = 0
        Me.picBuzz.TabStop = False
        '
        'picIronMan
        '
        Me.picIronMan.Image = Global.Legocharacter.My.Resources.Resources.Unknown__2_
        Me.picIronMan.Location = New System.Drawing.Point(180, 518)
        Me.picIronMan.Name = "picIronMan"
        Me.picIronMan.Size = New System.Drawing.Size(170, 200)
        Me.picIronMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIronMan.TabIndex = 1
        Me.picIronMan.TabStop = False
        '
        'picBatman
        '
        Me.picBatman.Image = Global.Legocharacter.My.Resources.Resources.images_2
        Me.picBatman.Location = New System.Drawing.Point(350, 254)
        Me.picBatman.Name = "picBatman"
        Me.picBatman.Size = New System.Drawing.Size(170, 200)
        Me.picBatman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBatman.TabIndex = 2
        Me.picBatman.TabStop = False
        '
        'picSpongeBob
        '
        Me.picSpongeBob.Image = Global.Legocharacter.My.Resources.Resources.images
        Me.picSpongeBob.Location = New System.Drawing.Point(72, 254)
        Me.picSpongeBob.Name = "picSpongeBob"
        Me.picSpongeBob.Size = New System.Drawing.Size(170, 200)
        Me.picSpongeBob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpongeBob.TabIndex = 3
        Me.picSpongeBob.TabStop = False
        '
        'picRobin
        '
        Me.picRobin.Image = Global.Legocharacter.My.Resources.Resources.Unknown_3
        Me.picRobin.Location = New System.Drawing.Point(652, 254)
        Me.picRobin.Name = "picRobin"
        Me.picRobin.Size = New System.Drawing.Size(170, 200)
        Me.picRobin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRobin.TabIndex = 4
        Me.picRobin.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 1086)
        Me.Controls.Add(Me.picRobin)
        Me.Controls.Add(Me.picSpongeBob)
        Me.Controls.Add(Me.picBatman)
        Me.Controls.Add(Me.picIronMan)
        Me.Controls.Add(Me.picBuzz)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBuzz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIronMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBatman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpongeBob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRobin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBuzz As PictureBox
    Friend WithEvents picIronMan As PictureBox
    Friend WithEvents picBatman As PictureBox
    Friend WithEvents picSpongeBob As PictureBox
    Friend WithEvents picRobin As PictureBox
End Class
