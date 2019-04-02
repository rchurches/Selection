Public Class Form1
    Public gamername As String
    Public randnum As Byte
    Public i As Byte
    Private Sub namecheck()
        Select Case randnum
            Case 1
                gamername = "Aden Klitscher"

            Case 2
                gamername = "Frozzle19 - Alex McRostie"
            Case 3
                gamername = "binetts02 - Anthony Binetti"
            Case 4
                gamername = "Byron"

            Case 5
                gamername = "JESUS - Harrison Goldsmith"
            Case 6
                gamername = "Krizzard - Hayden"
            Case 7
                gamername = "JackScholten1331"
            Case 8
                gamername = "Chimu8106 - Julian Lovell"
            Case 9
                gamername = "StevieG2038 - Mos Tsokkos"
            Case 10
                gamername = "Nid Kid - Nidula M"
            Case 11
                gamername = "smgersch1 - Sam Gersch"
            Case 12
                gamername = "Snowy Mountain - Sam Good"
            Case 13
                gamername = "TheDarkTurnip - Tom Materne"
            Case 14
                gamername = "Blaze_wreckt - Zac Cole"

        End Select
        txtNumber.Text += "Placing " & i & " " & gamername & vbCrLf & vbCrLf
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNumber.Clear()

        For i = 1 To 14
            Randomize()
            randnum = Int(Rnd() * 14) + 1
            gamername = randnum
            namecheck()

        Next

    End Sub
End Class
