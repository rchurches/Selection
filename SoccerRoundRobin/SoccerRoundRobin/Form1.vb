Public Class Form1
    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        Dim opposition As String
        Dim yellowcards, gameyellows, redcards, goals, round As Byte
        Dim averageyellows, averagereds, averagegoals As Single
        opposition = InputBox("Who are we playing")
        Do While opposition <> "abc"
            round += 1
            goals += InputBox("how many goals")
            gameyellows = InputBox("how many Yellows")
            yellowcards += gameyellows
            redcards += InputBox("how many Reds")
            If gameyellows > 3 Then
                txtResults.Text += opposition & " Round " & round & ", " & gameyellows & " yellow cards" & vbCrLf
            End If
            opposition = InputBox("Who are we playing")
        Loop
        averageyellows = yellowcards / round
        averagereds = redcards / round
        averagegoals = goals / round
        txtResults.Text += "The doves played " & round & " Games" & vbCrLf
        txtResults.Text += "Average Goals per Game:  " & averagegoals & vbCrLf
        txtResults.Text += "Average Yellows per Game:  " & averageyellows & vbCrLf
        txtResults.Text += "Average Reds per Game:  " & averagereds & vbCrLf

    End Sub
End Class
