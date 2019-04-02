Public Class Form1
    Dim playernumber(2) As Integer
    Dim gtotal, hole(9), holes As Integer
    Dim playername(2) As String
    Private Sub Initialise()
        'For index = 1 To 9
        '    hole(index) = 0
        'Next
        'gtotal = 0 
        For index = 1 To 2
            playernumber(index) = 0
            playername(index) = ""
        Next
        gtotal = 0
    End Sub
    Private Sub Processscores()
        Dim score, player As Integer
        Dim result As String
        playername(1) = InputBox("What is the name of Player 1?")
        playername(2) = InputBox("What is the name of Player 2?")
        player = InputBox("Enter player number 1 or 2")
        Do While player <> 0
            result = InputBox("score: Eagle, Birdie, Par, Bogie or Double Bogie", "Score Card", "Par").ToLower
            If result = "eagle" Then score = 3
            If result = "bogie" Then score = -1
            If result = "birdie" Then score = 2
            If result = "par" Then score = 1
            If result = "double bogie" Or result = "" Then score = -2
            playernumber(player) = playernumber(player) + score
            gtotal = gtotal + score
            player = InputBox("enter player")
            holes += 1
        Loop
        'For count = 1 To 9

        '    result = InputBox("score: Eagle, Birdie, Par, Bogie or Double Bogie for hole " & count, "Score Card", "Par").ToLower
        '    If result = "eagle" Then score = 3
        '    If result = "bogie" Then score = -1
        '    If result = "birdie" Then score = 2
        '    If result = "par" Then score = 1
        '    If result = "double bogie" Or result = "" Then score = -2
        '    hole(count) = score
        '    playernumber(player) = playernumber(player) + score
        '    gtotal = gtotal + score
        '    player = InputBox("enter player")
        'Next
    End Sub
    Private Sub Display()
        For counter = 1 To 2
            txtScoreboard.Text += "Player " & counter & ", " & playername(counter) & " scored " & playernumber(counter) & vbCrLf
        Next
        txtScoreboard.Text += "Total " & gtotal & " After " & holes & " Holes!"
    End Sub

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        Initialise()
        Processscores()
        Display()

    End Sub
End Class
