Public Class frmLego
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        MsgBox("Guess who " & playername & " is?")
        MsgBox(playername & " is " & legocharacter)
    End Sub
End Class