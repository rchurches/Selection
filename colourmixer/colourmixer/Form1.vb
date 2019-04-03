Public Class Form1
    Public randred, randgreen, randblue, redguess, greenguess, blueguess As Byte

    Private Sub hsbRed_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbRed.Scroll
        lblRed.Text = hsbRed.Value
        picColour.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value)
    End Sub

    Private Sub hsbGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbGreen.Scroll
        lblGreen.Text = hsbGreen.Value
        picColour.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value)
    End Sub

    Private Sub hsbBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbBlue.Scroll
        lblBlue.Text = hsbBlue.Value
        picColour.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value)
    End Sub

    Private Sub btnColourGuesser_Click(sender As Object, e As EventArgs) Handles btnColourGuesser.Click
        Dim correct As Byte
        correct = 0
        Randomize()

        randred = Int(Rnd() * 256)
        randgreen = Int(Rnd() * 256)
        randblue = Int(Rnd() * 256)
        picColour.BackColor = Color.FromArgb(randred, randgreen, randblue)
        MsgBox(randred & ", " & randgreen & ", " & randblue)
        redguess = CInt(InputBox("What shade red am I?"))
        greenguess = CInt(InputBox("What shade green am I?"))
        blueguess = CInt(InputBox("What shade blue am I?"))
        If randred < (redguess + 20) And randred > (redguess - 20) Then
            MsgBox("well done for red")
            correct += 1
        Else
            MsgBox("not close enough for the red")

        End If
        If randgreen < (greenguess + 20) And randgreen > (greenguess - 20) Then
            MsgBox("well done for green")
            correct += 1
        Else
            MsgBox("not close enough for the green")

        End If
        If randblue < (blueguess + 20) And randblue > (blueguess - 20) Then
            MsgBox("well done for blue")
            correct += 1
        Else
            MsgBox("not close enough for the blue")

        End If
        lblBlue.Text = randblue
        lblGreen.Text = randgreen
        lblRed.Text = randred
        If correct = 3 Then
            MsgBox("Wow, you are a Colour Champion!!!")
        Else
            If correct = 2 Then
                MsgBox(" You are pretty good at guessing a colour")
            Else
                If correct = 1 Then
                    MsgBox("At least you got one correct")
                Else
                    MsgBox("You didn't even get one colour correct!!!")
                End If
            End If
        End If
    End Sub
End Class
