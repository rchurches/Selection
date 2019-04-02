<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.picTeeTee = New System.Windows.Forms.PictureBox()
        Me.picSly = New System.Windows.Forms.PictureBox()
        Me.picRobbieMark = New System.Windows.Forms.PictureBox()
        Me.picErszebet = New System.Windows.Forms.PictureBox()
        Me.picKelsey = New System.Windows.Forms.PictureBox()
        Me.picBeatnikBob = New System.Windows.Forms.PictureBox()
        CType(Me.picTeeTee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRobbieMark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErszebet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKelsey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBeatnikBob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTeeTee
        '
        Me.picTeeTee.Image = Global.puttputt.My.Resources.Resources.TeeTee
        Me.picTeeTee.Location = New System.Drawing.Point(729, 451)
        Me.picTeeTee.Name = "picTeeTee"
        Me.picTeeTee.Size = New System.Drawing.Size(310, 390)
        Me.picTeeTee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeeTee.TabIndex = 5
        Me.picTeeTee.TabStop = False
        '
        'picSly
        '
        Me.picSly.Image = Global.puttputt.My.Resources.Resources.Sly
        Me.picSly.Location = New System.Drawing.Point(379, 451)
        Me.picSly.Name = "picSly"
        Me.picSly.Size = New System.Drawing.Size(310, 390)
        Me.picSly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSly.TabIndex = 4
        Me.picSly.TabStop = False
        '
        'picRobbieMark
        '
        Me.picRobbieMark.Image = Global.puttputt.My.Resources.Resources.RobbieMark
        Me.picRobbieMark.Location = New System.Drawing.Point(35, 451)
        Me.picRobbieMark.Name = "picRobbieMark"
        Me.picRobbieMark.Size = New System.Drawing.Size(310, 390)
        Me.picRobbieMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRobbieMark.TabIndex = 3
        Me.picRobbieMark.TabStop = False
        '
        'picErszebet
        '
        Me.picErszebet.Image = Global.puttputt.My.Resources.Resources.Erszebet
        Me.picErszebet.Location = New System.Drawing.Point(379, 38)
        Me.picErszebet.Name = "picErszebet"
        Me.picErszebet.Size = New System.Drawing.Size(310, 390)
        Me.picErszebet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picErszebet.TabIndex = 2
        Me.picErszebet.TabStop = False
        '
        'picKelsey
        '
        Me.picKelsey.Image = Global.puttputt.My.Resources.Resources.Kelsey
        Me.picKelsey.Location = New System.Drawing.Point(729, 38)
        Me.picKelsey.Name = "picKelsey"
        Me.picKelsey.Size = New System.Drawing.Size(310, 390)
        Me.picKelsey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKelsey.TabIndex = 1
        Me.picKelsey.TabStop = False
        '
        'picBeatnikBob
        '
        Me.picBeatnikBob.Image = Global.puttputt.My.Resources.Resources.BeatnikBob
        Me.picBeatnikBob.Location = New System.Drawing.Point(35, 38)
        Me.picBeatnikBob.Name = "picBeatnikBob"
        Me.picBeatnikBob.Size = New System.Drawing.Size(310, 390)
        Me.picBeatnikBob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBeatnikBob.TabIndex = 0
        Me.picBeatnikBob.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 944)
        Me.Controls.Add(Me.picTeeTee)
        Me.Controls.Add(Me.picSly)
        Me.Controls.Add(Me.picRobbieMark)
        Me.Controls.Add(Me.picErszebet)
        Me.Controls.Add(Me.picKelsey)
        Me.Controls.Add(Me.picBeatnikBob)
        Me.Name = "frmSplash"
        Me.Text = "frmSplash"
        CType(Me.picTeeTee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRobbieMark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErszebet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKelsey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBeatnikBob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBeatnikBob As PictureBox
    Friend WithEvents picKelsey As PictureBox
    Friend WithEvents picErszebet As PictureBox
    Friend WithEvents picRobbieMark As PictureBox
    Friend WithEvents picSly As PictureBox
    Friend WithEvents picTeeTee As PictureBox
End Class
