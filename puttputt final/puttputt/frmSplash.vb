Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playername = InputBox("What is your name")
        MsgBox(playername & ", choose your avatar")
    End Sub

    Private Sub picBeatnikBob_Click(sender As Object, e As EventArgs) Handles picBeatnikBob.Click
        Form1.picPlayer.Image = (My.Resources.BeatnikBob)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub picErszebet_Click(sender As Object, e As EventArgs) Handles picErszebet.Click
        Form1.picPlayer.Image = (My.Resources.Erszebet)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub picKelsey_Click(sender As Object, e As EventArgs) Handles picKelsey.Click
        Form1.picPlayer.Image = (My.Resources.Kelsey)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub picRobbieMark_Click(sender As Object, e As EventArgs) Handles picRobbieMark.Click
        Form1.picPlayer.Image = (My.Resources.RobbieMark)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub picSly_Click(sender As Object, e As EventArgs) Handles picSly.Click
        Form1.picPlayer.Image = (My.Resources.Sly)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub picTeeTee_Click(sender As Object, e As EventArgs) Handles picTeeTee.Click
        Form1.picPlayer.Image = (My.Resources.TeeTee)
        Me.Hide()
        Form1.Show()
    End Sub
End Class