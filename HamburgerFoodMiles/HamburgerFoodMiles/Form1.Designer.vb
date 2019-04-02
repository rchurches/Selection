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
        Me.cboBun = New System.Windows.Forms.ComboBox()
        Me.lblBunMiles = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSauceMiles = New System.Windows.Forms.Label()
        Me.cboSauce = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPattyMiles = New System.Windows.Forms.Label()
        Me.cboPatty = New System.Windows.Forms.ComboBox()
        Me.lblTotalMiles = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picLettuce = New System.Windows.Forms.PictureBox()
        Me.picCheese = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.picTomato = New System.Windows.Forms.PictureBox()
        Me.picOnion = New System.Windows.Forms.PictureBox()
        Me.picCucumber = New System.Windows.Forms.PictureBox()
        CType(Me.picLettuce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTomato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOnion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCucumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboBun
        '
        Me.cboBun.FormattingEnabled = True
        Me.cboBun.Items.AddRange(New Object() {"", "White", "Wholemeal", "Grain"})
        Me.cboBun.Location = New System.Drawing.Point(142, 57)
        Me.cboBun.Name = "cboBun"
        Me.cboBun.Size = New System.Drawing.Size(125, 21)
        Me.cboBun.TabIndex = 0
        '
        'lblBunMiles
        '
        Me.lblBunMiles.AutoSize = True
        Me.lblBunMiles.Location = New System.Drawing.Point(302, 57)
        Me.lblBunMiles.Name = "lblBunMiles"
        Me.lblBunMiles.Size = New System.Drawing.Size(13, 13)
        Me.lblBunMiles.TabIndex = 1
        Me.lblBunMiles.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Food Miles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sauce"
        '
        'lblSauceMiles
        '
        Me.lblSauceMiles.AutoSize = True
        Me.lblSauceMiles.Location = New System.Drawing.Point(302, 145)
        Me.lblSauceMiles.Name = "lblSauceMiles"
        Me.lblSauceMiles.Size = New System.Drawing.Size(13, 13)
        Me.lblSauceMiles.TabIndex = 5
        Me.lblSauceMiles.Text = "0"
        '
        'cboSauce
        '
        Me.cboSauce.FormattingEnabled = True
        Me.cboSauce.Items.AddRange(New Object() {"", "Tomato Sauce", "BBQ Sauce", "Mayo"})
        Me.cboSauce.Location = New System.Drawing.Point(142, 145)
        Me.cboSauce.Name = "cboSauce"
        Me.cboSauce.Size = New System.Drawing.Size(125, 21)
        Me.cboSauce.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Patty"
        '
        'lblPattyMiles
        '
        Me.lblPattyMiles.AutoSize = True
        Me.lblPattyMiles.Location = New System.Drawing.Point(302, 101)
        Me.lblPattyMiles.Name = "lblPattyMiles"
        Me.lblPattyMiles.Size = New System.Drawing.Size(13, 13)
        Me.lblPattyMiles.TabIndex = 8
        Me.lblPattyMiles.Text = "0"
        '
        'cboPatty
        '
        Me.cboPatty.FormattingEnabled = True
        Me.cboPatty.Items.AddRange(New Object() {"", "Beef", "Chicken", "Falafel"})
        Me.cboPatty.Location = New System.Drawing.Point(142, 101)
        Me.cboPatty.Name = "cboPatty"
        Me.cboPatty.Size = New System.Drawing.Size(125, 21)
        Me.cboPatty.TabIndex = 7
        '
        'lblTotalMiles
        '
        Me.lblTotalMiles.AutoSize = True
        Me.lblTotalMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMiles.Location = New System.Drawing.Point(474, 414)
        Me.lblTotalMiles.Name = "lblTotalMiles"
        Me.lblTotalMiles.Size = New System.Drawing.Size(25, 25)
        Me.lblTotalMiles.TabIndex = 10
        Me.lblTotalMiles.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total Food Miles"
        '
        'picLettuce
        '
        Me.picLettuce.Image = Global.HamburgerFoodMiles.My.Resources.Resources.lettuce
        Me.picLettuce.Location = New System.Drawing.Point(38, 224)
        Me.picLettuce.Name = "picLettuce"
        Me.picLettuce.Size = New System.Drawing.Size(59, 66)
        Me.picLettuce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLettuce.TabIndex = 12
        Me.picLettuce.TabStop = False
        '
        'picCheese
        '
        Me.picCheese.Image = Global.HamburgerFoodMiles.My.Resources.Resources.cheese
        Me.picCheese.Location = New System.Drawing.Point(491, 224)
        Me.picCheese.Name = "picCheese"
        Me.picCheese.Size = New System.Drawing.Size(59, 66)
        Me.picCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheese.TabIndex = 13
        Me.picCheese.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.HamburgerFoodMiles.My.Resources.Resources.lettuce
        Me.PictureBox3.Location = New System.Drawing.Point(556, 224)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 66)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'picTomato
        '
        Me.picTomato.Image = Global.HamburgerFoodMiles.My.Resources.Resources.tomato
        Me.picTomato.Location = New System.Drawing.Point(233, 224)
        Me.picTomato.Name = "picTomato"
        Me.picTomato.Size = New System.Drawing.Size(59, 66)
        Me.picTomato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTomato.TabIndex = 15
        Me.picTomato.TabStop = False
        '
        'picOnion
        '
        Me.picOnion.Image = Global.HamburgerFoodMiles.My.Resources.Resources.onion
        Me.picOnion.Location = New System.Drawing.Point(168, 224)
        Me.picOnion.Name = "picOnion"
        Me.picOnion.Size = New System.Drawing.Size(59, 66)
        Me.picOnion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOnion.TabIndex = 16
        Me.picOnion.TabStop = False
        '
        'picCucumber
        '
        Me.picCucumber.Image = Global.HamburgerFoodMiles.My.Resources.Resources.cucumber
        Me.picCucumber.Location = New System.Drawing.Point(103, 224)
        Me.picCucumber.Name = "picCucumber"
        Me.picCucumber.Size = New System.Drawing.Size(59, 66)
        Me.picCucumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCucumber.TabIndex = 17
        Me.picCucumber.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 448)
        Me.Controls.Add(Me.picCucumber)
        Me.Controls.Add(Me.picOnion)
        Me.Controls.Add(Me.picTomato)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.picCheese)
        Me.Controls.Add(Me.picLettuce)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotalMiles)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPattyMiles)
        Me.Controls.Add(Me.cboPatty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSauceMiles)
        Me.Controls.Add(Me.cboSauce)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBunMiles)
        Me.Controls.Add(Me.cboBun)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picLettuce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTomato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOnion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCucumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboBun As ComboBox
    Friend WithEvents lblBunMiles As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSauceMiles As Label
    Friend WithEvents cboSauce As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPattyMiles As Label
    Friend WithEvents cboPatty As ComboBox
    Friend WithEvents lblTotalMiles As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents picLettuce As PictureBox
    Friend WithEvents picCheese As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents picTomato As PictureBox
    Friend WithEvents picOnion As PictureBox
    Friend WithEvents picCucumber As PictureBox
End Class
