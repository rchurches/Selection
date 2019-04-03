Public Class Form1
    'Declare global variable arrays such that they can change
    Public player(numplayers) As String
    Public age(numplayers), playernum As Byte
    'Declare global numplayers so that array can be changed on form load
    Public numplayers As Byte

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        ' assign values to each array index by user input need to use 0 because arrays start at 0
        For playernumber = 0 To numplayers - 1
            playernum = playernumber
            player(playernumber) = InputBox("What is the name of the player " & playernumber + 1)
            age(playernum) = InputBox("Enter age for player " & playernumber + 1)
            'show then player name and his/her age
            txtPlayer.Text += player(playernum) & " age is " & age(playernum) & vbCrLf
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ask user for how many players to be added
        numplayers = InputBox("How many players")
        'resize the arrays...Rdim is the way to change size of arrays at run time
        Do While (numplayers > 0 And numplayers <= 10) = False ' ensure age threshold is between 1 and 10 inclusive
            numplayers = InputBox("How many players")
        Loop
        ReDim player(numplayers)
        ReDim age(numplayers)
    End Sub
    Private Sub displayages()
        'declare local variables
        Dim playeraverage As Single
        Dim playertotal As Integer
        'calculate the total age using age array and a fixed loop remembering arrays start at 0
        For i = 0 To numplayers - 1
            playertotal += age(i)
        Next
        'Create a space in the text box and give a label t the ordered daa
        txtPlayer.Text += vbCrLf & "Below is  the order from oldest to youngest" & vbCrLf
        'Show the players' names and their ages which will now be in descending order 
        'remembering arrays start at 0
        ' Note += means to add to the object
        For playernumber = 0 To numplayers - 1
            playernum = playernumber
            txtPlayer.Text += vbCrLf & player(playernum) & " age is " & age(playernum)
        Next
        'Show a stats summary of the data entered
        txtPlayer.Text += vbCrLf & "player total is " & playertotal
        txtPlayer.Text += vbCrLf & "number players  is " & numplayers
        'calculate and display the average of all players
        playeraverage = Math.Round(playertotal / numplayers, 1)
        txtPlayer.Text += vbCrLf & "The average age is " & playeraverage & " years old"
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        'Sort ages with age as the key field
        Array.Sort(age, player)
        'reverse to show ages in descending order
        Array.Reverse(age)
        Array.Reverse(player)
        displayages()



    End Sub
End Class
