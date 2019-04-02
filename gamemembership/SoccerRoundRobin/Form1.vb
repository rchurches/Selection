Public Class Form1
    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        Dim total, totalpts, score, difficulty As Integer
        Dim member, game As String

        total = 0
        totalpts = 0
        member = InputBox("Enter Members name")
        Do While member <> “nomember”
            For gamenums = 1 To 3
                game = InputBox("Enter game ")
                For rounds = 1 To 2
                    score = InputBox("Enter score for  " & game)
                    total += score
                Next rounds
                If game = “fortnite” Then
                    difficulty = 5
                End If
                If game = “overwatch” Then
                    difficulty = 3
                End If
                If game = “donkeykong” Then
                    difficulty = 1
                End If
                totalpts += total * difficulty
                txtResults.Text += member & “ “ & game & “ “ & total * difficulty & “ points” & vbCrLf
                total = 0
            Next gamenums
            member = InputBox("Enter Members name")
        Loop

    End Sub
End Class
