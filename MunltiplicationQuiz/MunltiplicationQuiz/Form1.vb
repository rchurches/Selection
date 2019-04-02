Public Class Form1
    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        Dim playername As String
        playername = InputBox("What is your name?")
        Dim num1, num2, product, usernum1, usernum2, useranswer, guesses As Integer
        'PictureBox1.Image = My.Resources.images
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\rchurches.IC\Source\Repos\MunltiplicationQuiz\MunltiplicationQuiz\Resources\PlayerResults.txt", True)
        file.WriteLine(playername)

        file.Close()


        Randomize()
        num1 = Int(Rnd() * 1) + 1
        num2 = Int(Rnd() * 1) + 1
        product = num1 * num2
        usernum1 = InputBox("Number 1 = ?")
        usernum2 = InputBox("Number 2 = ?")
        useranswer = usernum1 * usernum2
        guesses += 1
        Do While useranswer <> product
            If useranswer > product Then
                MsgBox("The answer is wrong!!!, The answer is lower")
            Else
                MsgBox("The answer is wrong!!!, The answer is higher")
            End If
            usernum1 = InputBox("Number 1 = ?")
            usernum2 = InputBox("Number 2 = ?")
            useranswer = usernum1 * usernum2
            guesses += 1
        Loop

        Do While num1 <> usernum1 And num2 <> usernum2
            usernum1 = InputBox("The product is " & product & " Number 1 = ")
            usernum2 = InputBox("The product is " & product & " Number 2 = ")
            useranswer = usernum1 * usernum2
            guesses += 1
        Loop
        MsgBox("Congratulations , You've got it. You took " & guesses & " Guesses, the question was " & num1 & " X " & num2)

    End Sub
End Class
