Public Class Form1
    Dim playernumber(2) As Integer
    Dim gtotal, hole(9), holes As Integer
    Dim result(9) As String

    Private Sub Initialise()
        For index = 1 To 9
            hole(index) = 0
            result(index) = ""
        Next
        gtotal = 0
    End Sub
    Private Sub Processscores()
        Dim score As Integer
        For count = 1 To 9
            result(count) = InputBox("score: Eagle, Birdie, Par, Bogie or Double Bogie for hole " & count, "Score Card", "Par").ToLower
            If result(count) = "eagle" Then score = 3
            If result(count) = "bogie" Then score = -1
            If result(count) = "birdie" Then score = 2
            If result(count) = "par" Then score = 1
            If result(count) = "double bogie" Or result(count) = "" Then score = -2
            hole(count) = score
            gtotal = gtotal + score
            txtScoreboard.Text += "Hole " & count & ", " & result(count) & " score= " & hole(count) & vbCrLf
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCheckHole_Click(sender As Object, e As EventArgs) Handles btnCheckHole.Click
        Dim holecheck As Byte
        holecheck = InputBox("Which hole do you want to check?")
        MsgBox(playername & " got a " & result(holecheck) & ", scoring " & hole(holecheck) & " points!")
    End Sub

    Private Sub Display()
        txtScoreboard.Text += "Total " & gtotal
    End Sub

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        Initialise()
        Processscores()
        Display()

    End Sub
End Class
