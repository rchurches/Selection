Public Class Form1
    Dim element(10) As String
    Dim elementSymb(10) As String
    Dim count As Byte
    Dim score As Integer
    Dim elementnum As Integer
    Dim elementguess As String

       
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrCoundown.Enabled = True

        ElementGame()

    End Sub

    Sub ElementGame()
restart:
                Randomize()
        elementnum = Int(Rnd() * 10) + 1
        elementguess = InputBox("What is the symbol for " & element(elementnum) & " ?")
        If elementguess = elementSymb(elementnum) Then
            MsgBox("That's right " & elementSymb(elementnum) & " is the symbol for element number " & elementnum & " which is " & element(elementnum))
            count = 10
            score = score + 1
            lblScore.Text = score


            GoTo restart
        Else
            'tmrCoundown.Enabled = False
            MsgBox("Sorry! The symbol for element number " & elementnum & " " & element(elementnum) & " is " & elementSymb(elementnum))
            score = score - 1
            lblScore.Text = score
            GoTo restart
        End If
       
    End Sub
    Sub Initialise()
        element(1) = "Hydrogen"
        element(2) = "Helium"
        element(3) = "Lithium"
        element(4) = "Beryllium"
        element(5) = "Boron"
        element(6) = "Carbon"
        element(7) = "Nitrogen"
        element(8) = "Oxygen"
        element(9) = "Fluorine"
        element(10) = "Neon"
        elementSymb(1) = "H"
        elementSymb(2) = "He"
        elementSymb(3) = "Li"
        elementSymb(4) = "Be"
        elementSymb(5) = "B"
        elementSymb(6) = "C"
        elementSymb(7) = "N"
        elementSymb(8) = "O"
        elementSymb(9) = "Fl"
        elementSymb(10) = "Ne"
        count = 10
        score = 0
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialise()

    End Sub

    Private Sub tmrCoundown_Tick(sender As Object, e As EventArgs) Handles tmrCoundown.Tick
      
      
        If count = 0 Then
            tmrCoundown.Enabled = False
            MsgBox("You run out of time.The symbol for element number " & elementnum & " " & element(elementnum) & " is " & elementSymb(elementnum))
            score = score - 1
            lblScore.Text = score
        Else

            count = count - 1
            lblCountdown.Text = count
        End If

    End Sub
End Class
