Public Class Form1
    'Rob Churches
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playername = InputBox("Howdy lego Pardner, what is your name?", "Player's Name")
    End Sub

    Private Sub picSpongeBob_Click(sender As Object, e As EventArgs) Handles picSpongeBob.Click
        'sponge bob is chosen as character and gives message and loads lego form
        legocharacter = "Sponge Bob"
        MsgBox(playername & ", you have chosen " & legocharacter)
        Me.Hide()
        frmLego.Show()

    End Sub

    Private Sub picBatman_Click(sender As Object, e As EventArgs) Handles picBatman.Click
        'sponge bob is chosen as character and gives message and loads lego form
        legocharacter = "Batman"

        MsgBox(playername & ", you have chosen " & legocharacter)
        Me.Hide()
        frmLego.Show()
    End Sub

    Private Sub picRobin_Click(sender As Object, e As EventArgs) Handles picRobin.Click
        legocharacter = "Robin"
        MsgBox(playername & ", you have chosen " & legocharacter)
        Me.Hide()
        frmLego.Show()
    End Sub

    Private Sub picIronMan_Click(sender As Object, e As EventArgs) Handles picIronMan.Click
        legocharacter = "Iron Man"
        MsgBox(playername & ", you have chosen " & legocharacter)
        Me.Hide()
        frmLego.Show()
    End Sub

    Private Sub picBuzz_Click(sender As Object, e As EventArgs) Handles picBuzz.Click
        legocharacter = "Buzz"
        MsgBox(playername & ", you have chosen " & legocharacter)
        Me.Hide()
        frmLego.Show()
    End Sub
End Class
