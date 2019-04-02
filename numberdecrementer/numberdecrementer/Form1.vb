Public Class Form1
    'Rob Churches
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim counter, number, numb As Byte 'Declare local variables
        number = 250
        numb = number
        'take 25 away 4 times from number
        For counter = 1 To 4
            number = number - 25
        Next
        MsgBox("It's been changed by " & numb - number) 'output result

    End Sub
End Class
