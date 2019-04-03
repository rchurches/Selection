Public Class Form1
    Private Sub btnAnimalGuess_Click(sender As Object, e As EventArgs) Handles btnAnimalGuess.Click
        Randomize() 'Ensures a random number generator is as random as can be
        Dim randnum, guesses As Byte ' Declare a variable to generate random animals later
        randnum = Int(Rnd() * 5) + 1 'Generate random number between 1 and 5
        Dim userguess, animal As String
        'The code below shows the animal based on the random number generated

        If randnum = 1 Then
            picAnimal.Image = My.Resources.aardwolf
            animal = "Aardwolf"
        End If
        If randnum = 2 Then
            picAnimal.Image = My.Resources.Ermine
            animal = "Ermine"
        End If
        If randnum = 3 Then
            picAnimal.Image = My.Resources.impala
            animal = "Tame Impala"
        End If
        If randnum = 4 Then
            picAnimal.Image = My.Resources.ocelot
            animal = "Ocelot"
        End If
        If randnum = 5 Then
            picAnimal.Image = My.Resources.urial
            animal = "Urial"
        End If
        userguess = InputBox("What animal am I")
        guesses = 1
        Do While userguess <> animal
            userguess = InputBox("Sorry, What animal am I")
            guesses += 1
        Loop
        MsgBox("Yes, you took " & guesses & " guesses")

    End Sub
End Class
