Public Class Form1
    Public username(5), nickname(5) As String
    'declares an array of 5 for variables username and their Nick names
    'These are global to the form
    'An array of five has indexes of 0 to 4 NOT 1 to 5

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        For count = 0 To 4
            txtUser.Text += username(count) & "'s Nick name is " & nickname(count) & vbCrLf
        Next

    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim userquery, nicker As String
        userquery = InputBox("What name?")
        Dim indx As Integer
        indx = Array.IndexOf(username, userquery)
        nicker = nickname(indx)
        MsgBox(userquery & "'s nickname is " & nicker)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        For i = 0 To 4
            username(i) = InputBox("What is your Name?", "UserName")
            nickname(i) = InputBox(username(i) & ", What is your Nickname?", "NickName")
        Next

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
