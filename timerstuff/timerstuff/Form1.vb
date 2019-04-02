Public Class Form1
    Public countdown As Byte = 10
    Public aianswer As String
    Public useranswer As String
    Public speaker
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speaker = CreateObject("SAPI.spvoice")
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        countdown = 10
        tmStart.Enabled = True
    End Sub

    Private Sub tmStart_Tick(sender As Object, e As EventArgs) Handles tmStart.Tick
        countdown -= 1
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        lblCountdown.Text = countdown
        If countdown <= 5 Then
            lblCountdown.ForeColor = Color.DarkRed
            lblCountdown.Font = New Font("Comic Sans MS", 12, FontStyle.Bold Or FontStyle.Underline)
            speaker.Speak(countdown)
        End If

        If countdown = 0 Then
            tmStart.Enabled = False
            My.Computer.Audio.Play(My.Resources.Bomb_Exploding_Sound_Explorer_68256487, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub ai()
        Dim randnum As Byte
        randnum = Int(Rnd() * 5) + 1

        Select Case randnum
            Case 1
                aianswer = "Andrews"
            Case 2
                aianswer = "Camden"
            Case 3
                aianswer = "Dohler"
            Case 4
                aianswer = "Kavel"
            Case 5
                aianswer = "Lohe"
        End Select
    End Sub
End Class
